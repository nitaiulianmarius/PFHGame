namespace client
{
    partial class clientForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientForm));
            this.connectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chooseWinner = new System.Windows.Forms.PictureBox();
            this.chooseOpponent = new System.Windows.Forms.PictureBox();
            this.chooseYou = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chooseHartie = new System.Windows.Forms.PictureBox();
            this.chooseFoarfeca = new System.Windows.Forms.PictureBox();
            this.choosePiatra = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chooseWinner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseOpponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseYou)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseHartie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseFoarfeca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosePiatra)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // connectBtn
            // 
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBtn.Location = new System.Drawing.Point(12, 12);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Status: offline";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Winner:";
            // 
            // chooseWinner
            // 
            this.chooseWinner.Location = new System.Drawing.Point(320, 104);
            this.chooseWinner.Name = "chooseWinner";
            this.chooseWinner.Size = new System.Drawing.Size(128, 128);
            this.chooseWinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chooseWinner.TabIndex = 13;
            this.chooseWinner.TabStop = false;
            // 
            // chooseOpponent
            // 
            this.chooseOpponent.Location = new System.Drawing.Point(142, 104);
            this.chooseOpponent.Name = "chooseOpponent";
            this.chooseOpponent.Size = new System.Drawing.Size(128, 128);
            this.chooseOpponent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chooseOpponent.TabIndex = 12;
            this.chooseOpponent.TabStop = false;
            // 
            // chooseYou
            // 
            this.chooseYou.Location = new System.Drawing.Point(8, 104);
            this.chooseYou.Name = "chooseYou";
            this.chooseYou.Size = new System.Drawing.Size(128, 128);
            this.chooseYou.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chooseYou.TabIndex = 11;
            this.chooseYou.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Opponent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "You";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Scor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Choose";
            // 
            // chooseHartie
            // 
            this.chooseHartie.Image = ((System.Drawing.Image)(resources.GetObject("chooseHartie.Image")));
            this.chooseHartie.Location = new System.Drawing.Point(194, 3);
            this.chooseHartie.Name = "chooseHartie";
            this.chooseHartie.Size = new System.Drawing.Size(64, 64);
            this.chooseHartie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chooseHartie.TabIndex = 23;
            this.chooseHartie.TabStop = false;
            this.chooseHartie.Click += new System.EventHandler(this.chooseHartie_Click);
            // 
            // chooseFoarfeca
            // 
            this.chooseFoarfeca.Image = ((System.Drawing.Image)(resources.GetObject("chooseFoarfeca.Image")));
            this.chooseFoarfeca.Location = new System.Drawing.Point(124, 3);
            this.chooseFoarfeca.Name = "chooseFoarfeca";
            this.chooseFoarfeca.Size = new System.Drawing.Size(64, 64);
            this.chooseFoarfeca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.chooseFoarfeca.TabIndex = 22;
            this.chooseFoarfeca.TabStop = false;
            this.chooseFoarfeca.Click += new System.EventHandler(this.chooseFoarfeca_Click);
            // 
            // choosePiatra
            // 
            this.choosePiatra.Image = ((System.Drawing.Image)(resources.GetObject("choosePiatra.Image")));
            this.choosePiatra.Location = new System.Drawing.Point(54, 3);
            this.choosePiatra.Name = "choosePiatra";
            this.choosePiatra.Size = new System.Drawing.Size(64, 64);
            this.choosePiatra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.choosePiatra.TabIndex = 21;
            this.choosePiatra.TabStop = false;
            this.choosePiatra.Click += new System.EventHandler(this.choosePiatra_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.choosePiatra);
            this.panel1.Controls.Add(this.chooseHartie);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.chooseFoarfeca);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.chooseYou);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.chooseOpponent);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.chooseWinner);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(6, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 250);
            this.panel1.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(261, 4);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label8.Size = new System.Drawing.Size(201, 41);
            this.label8.TabIndex = 25;
            this.label8.Text = "Click connect and wait for server to play.\r\nNita Iulian Marius 2016 ©\r\nHave fun !" +
    "";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 26;
            this.textBox1.Text = "127.0.0.1";
            // 
            // clientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectBtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "clientForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Client";
            ((System.ComponentModel.ISupportInitialize)(this.chooseWinner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseOpponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseYou)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseHartie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chooseFoarfeca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.choosePiatra)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox chooseWinner;
        private System.Windows.Forms.PictureBox chooseOpponent;
        private System.Windows.Forms.PictureBox chooseYou;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox chooseHartie;
        private System.Windows.Forms.PictureBox chooseFoarfeca;
        private System.Windows.Forms.PictureBox choosePiatra;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
    }
}

