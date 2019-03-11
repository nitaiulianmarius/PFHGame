using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace client
{
    public partial class clientForm : Form
    {

        int port = 27015;
        int ch1 = 0, ch2 = 0;
        int nWin = 0, nLose = 0;
        TcpClient client;
        NetworkStream stream;

        public clientForm()
        {
            InitializeComponent();

            label1.Text = "Status: offline";
            label1.ForeColor = System.Drawing.Color.Red;
            panel1.Visible = false;
            nWin = nLose = 0;
            label6.Text = nWin.ToString() + " win / " + nLose.ToString() + " lose";
        }

        void connect(string ip, int port)
        {
            bool connected = false;

            this.Invoke(new MethodInvoker(delegate ()
            {
                label1.Text = "Status: connecting...";
                label1.ForeColor = System.Drawing.Color.Orange;
                panel1.Visible = false;
            }));

            do
            {

                try
                {

                    client = new TcpClient(ip, port);
                    stream = client.GetStream();
                    connected = true;
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        label1.Text = "Status: connected";
                        label1.ForeColor = System.Drawing.Color.Green;
                        panel1.Visible = true;
                        restartGame();
                        nWin = nLose = 0;
                        label6.Text = nWin.ToString() + " win / " + nLose.ToString() + " lose";
                    }));
                }
                catch
                {
                    connected = false;
                }
                Thread.Sleep(10);
            } while (connected == false);


            Thread rec = new Thread(receiveMessage);
            rec.IsBackground = true;
            rec.Start();

            Thread handle = new Thread(handleGame);
            handle.IsBackground = true;
            handle.Start();
        }

        void sendMessage(string data)
        {
            byte[] bytes = new byte[1024];
            bytes = Encoding.ASCII.GetBytes(data);
            stream.Write(bytes, 0, bytes.Length);
        }

        void receiveMessage()
        {
            byte[] bytes = new byte[1024];

            try
            {
                while (true)
                {
                    int n = stream.Read(bytes, 0, bytes.Length);
                    string data = Encoding.ASCII.GetString(bytes, 0, n);

                    if (data.StartsWith("1"))
                        ch2 = 1;
                    if (data.StartsWith("2"))
                        ch2 = 2;
                    if (data.StartsWith("3"))
                        ch2 = 3;

                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        //
                    }));

                    Thread.Sleep(10);
                }
            }
            catch
            {
                disconnect();
                nWin = nLose = 0;
                label6.Text = nWin.ToString() + " win / " + nLose.ToString() + " lose";
            }
        }

        void disconnect()
        {
            stream.Close();
            client.Close();
            this.Invoke(new MethodInvoker(delegate ()
            {
                label1.Text = "Status: disconnected";
                label1.ForeColor = System.Drawing.Color.Red;
                panel1.Visible = false;
            }));
        }

        private void connectBtn_Click(object sender, System.EventArgs e)
        {
            Thread n = new Thread(() => connect(textBox1.Text, port));
            n.IsBackground = true;
            n.Start();
        }

        private void choosePiatra_Click(object sender, System.EventArgs e)
        {
            Image image = Image.FromFile("piatra.png");
            chooseYou.Image = image;
            sendMessage("1");
            ch1 = 1;
        }

        private void chooseFoarfeca_Click(object sender, System.EventArgs e)
        {
            Image image = Image.FromFile("foarfeca.png");
            chooseYou.Image = image;
            sendMessage("2");
            ch1 = 2;
        }

        private void chooseHartie_Click(object sender, System.EventArgs e)
        {
            Image image = Image.FromFile("hartie.png");
            chooseYou.Image = image;
            sendMessage("3");
            ch1 = 3;
        }

        void handleGame()
        {
            while (true)
            {
                if (ch1 != 0 && ch2 != 0)
                {
                    this.Invoke(new MethodInvoker(delegate ()
                    {
                        if (ch2 == 1)
                            chooseOpponent.Image = Image.FromFile("piatra.png");

                        if (ch2 == 2)
                            chooseOpponent.Image = Image.FromFile("foarfeca.png");

                        if (ch2 == 3)
                            chooseOpponent.Image = Image.FromFile("hartie.png");

                        if (ch1 == ch2)
                        {
                            chooseWinner.Image = Image.FromFile("intrebare.png");
                        }

                        if (ch1 == 1 && ch2 == 2)
                        {
                            chooseWinner.Image = Image.FromFile("piatra.png");
                            nWin++;
                        }

                        if (ch1 == 1 && ch2 == 3)
                        {
                            chooseWinner.Image = Image.FromFile("hartie.png");
                            nLose++;
                        }

                        if (ch1 == 2 && ch2 == 1)
                        {
                            chooseWinner.Image = Image.FromFile("piatra.png");
                            nLose++;
                        }

                        if (ch1 == 2 && ch2 == 3)
                        {
                            chooseWinner.Image = Image.FromFile("foarfeca.png");
                            nWin++;
                        }

                        if (ch1 == 3 && ch2 == 1)
                        {
                            chooseWinner.Image = Image.FromFile("hartie.png");
                            nWin++;
                        }

                        if (ch1 == 3 && ch2 == 2)
                        {
                            chooseWinner.Image = Image.FromFile("foarfeca.png");
                            nLose++;
                        }

                        chooseOpponent.Update();
                        chooseWinner.Update();
                        label6.Text = nWin.ToString() + " win / " + nLose.ToString() + " lose";
                        Thread.Sleep(2000);
                        restartGame();
                    }));
                }
                Thread.Sleep(10);
            }
        }

        void restartGame()
        {
            ch1 = 0;
            ch2 = 0;
            chooseYou.Image = null;
            chooseOpponent.Image = null;
            chooseWinner.Image = null;
        }
    }//form
}
