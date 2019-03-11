using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace server
{
    public partial class serverForm : Form
    {

        int port = 27015;
        int ch1 = 0, ch2 = 0;
        int nWin = 0, nLose = 0;
        TcpListener server;
        TcpClient client;
        NetworkStream stream;

        public serverForm()
        {
            InitializeComponent();

            label1.Text = "Server: offline";
            label1.ForeColor = System.Drawing.Color.Red;
            label2.Text = "Opponent: offline";
            label2.ForeColor = System.Drawing.Color.Red;
            panel1.Visible = false;
            nWin = nLose = 0;
            label6.Text = nWin.ToString() + " win / " + nLose.ToString() + " lose";
        }

        void startServer()
        {
            server = new TcpListener(IPAddress.Any, port);
            server.Start();

            label1.Text = "Server: online";
            label1.ForeColor = System.Drawing.Color.Green;

            Thread n = new Thread(acceptClient);
            n.IsBackground = true;
            n.Start();
        }

        void acceptClient()
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                label2.Text = "Opponent: waiting...";
                label2.ForeColor = System.Drawing.Color.Orange;
                panel1.Visible = false;
            }));

            client = server.AcceptTcpClient();
            stream = client.GetStream();

            this.Invoke(new MethodInvoker(delegate ()
            {
                label2.Text = "Opponent: online";
                label2.ForeColor = System.Drawing.Color.Green;
                panel1.Visible = true;
                restartGame();
                nWin = nLose = 0;
                label6.Text = nWin.ToString() + " win / " + nLose.ToString() + " lose";
            }));


            Thread rec = new Thread(receiveMessage);
            rec.IsBackground = true;
            rec.Start();

            Thread handle = new Thread(handleGame);
            handle.IsBackground = true;
            handle.Start();
        }

        void receiveMessage()
        {
            byte[] bytes = new byte[1024];
            string data;

            try
            {
                while (true)
                {
                    stream.Read(bytes, 0, bytes.Length);
                    data = System.Text.Encoding.ASCII.GetString(bytes, 0, bytes.Length);

                    if (data.StartsWith("1"))
                        ch2 = 1;
                    if (data.StartsWith("2"))
                        ch2 = 2;
                    if (data.StartsWith("3"))
                        ch2 = 3;

                    this.Invoke(new MethodInvoker(delegate ()
                    {

                    }));

                    Thread.Sleep(10);
                }
            }
            catch
            {
                client.Close();
                stream = null;
                nWin = nLose = 0;
                acceptClient();
            }
        }

        void stopServer()
        {
            client.Close();
            server.Stop();
        }

        void sendMessage(string data)
        {
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(data);
            stream.Write(bytes, 0, bytes.Length);
        }

        private void startServerBtn_Click(object sender, EventArgs e)
        {
            startServer();
        }

        private void choosePiatra_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile("piatra.png");
            chooseYou.Image = image;
            sendMessage("1");
            ch1 = 1;
        }

        private void chooseFoarfeca_Click(object sender, EventArgs e)
        {
            Image image = Image.FromFile("foarfeca.png");
            chooseYou.Image = image;
            sendMessage("2");
            ch1 = 2;
        }

        private void chooseHartie_Click(object sender, EventArgs e)
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
