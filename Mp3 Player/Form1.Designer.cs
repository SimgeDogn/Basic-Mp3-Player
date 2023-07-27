namespace Mp3_Player
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.musicname = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.label6 = new System.Windows.Forms.Label();
            this.volumevalue = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.tim2 = new System.Windows.Forms.Label();
            this.tim1 = new System.Windows.Forms.Label();
            this.playbutton = new System.Windows.Forms.PictureBox();
            this.backbutton = new System.Windows.Forms.PictureBox();
            this.forwardbutton = new System.Windows.Forms.PictureBox();
            this.resumebutton = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.selectedbutton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.close = new System.Windows.Forms.PictureBox();
            this.minimize = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardbutton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumebutton)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // musicname
            // 
            this.musicname.AutoSize = true;
            this.musicname.Font = new System.Drawing.Font("MV Boli", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.musicname.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.musicname.Location = new System.Drawing.Point(434, 228);
            this.musicname.Name = "musicname";
            this.musicname.Size = new System.Drawing.Size(103, 20);
            this.musicname.TabIndex = 16;
            this.musicname.Text = "Music Name";
            this.musicname.Click += new System.EventHandler(this.musicname_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(268, 258);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(601, 12);
            this.progressBar1.TabIndex = 15;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel2.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel2.Controls.Add(this.musicname);
            this.panel2.Controls.Add(this.progressBar1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.volumevalue);
            this.panel2.Controls.Add(this.volume);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.tim2);
            this.panel2.Controls.Add(this.tim1);
            this.panel2.Controls.Add(this.playbutton);
            this.panel2.Controls.Add(this.backbutton);
            this.panel2.Controls.Add(this.forwardbutton);
            this.panel2.Controls.Add(this.resumebutton);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(922, 431);
            this.panel2.TabIndex = 5;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(773, 31);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(96, 104);
            this.axWindowsMediaPlayer1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MV Boli", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(219, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Developed By: Simge";
            // 
            // volumevalue
            // 
            this.volumevalue.AutoSize = true;
            this.volumevalue.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumevalue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.volumevalue.Location = new System.Drawing.Point(302, 180);
            this.volumevalue.Name = "volumevalue";
            this.volumevalue.Size = new System.Drawing.Size(48, 22);
            this.volumevalue.TabIndex = 12;
            this.volumevalue.Text = "30%";
            this.volumevalue.Click += new System.EventHandler(this.volumevalue_Click);
            // 
            // volume
            // 
            this.volume.AutoSize = true;
            this.volume.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.volume.Location = new System.Drawing.Point(290, 31);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(72, 22);
            this.volume.TabIndex = 11;
            this.volume.Text = "Volume";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(306, 45);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(56, 146);
            this.trackBar1.TabIndex = 10;
            this.trackBar1.Value = 30;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // tim2
            // 
            this.tim2.AutoSize = true;
            this.tim2.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tim2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tim2.Location = new System.Drawing.Point(776, 223);
            this.tim2.Name = "tim2";
            this.tim2.Size = new System.Drawing.Size(69, 22);
            this.tim2.TabIndex = 9;
            this.tim2.Text = "00.00";
            // 
            // tim1
            // 
            this.tim1.AutoSize = true;
            this.tim1.Font = new System.Drawing.Font("MV Boli", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tim1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tim1.Location = new System.Drawing.Point(302, 223);
            this.tim1.Name = "tim1";
            this.tim1.Size = new System.Drawing.Size(69, 22);
            this.tim1.TabIndex = 8;
            this.tim1.Text = "00.00";
            this.tim1.Click += new System.EventHandler(this.tim1_Click);
            // 
            // playbutton
            // 
            this.playbutton.Image = ((System.Drawing.Image)(resources.GetObject("playbutton.Image")));
            this.playbutton.Location = new System.Drawing.Point(506, 291);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(74, 71);
            this.playbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playbutton.TabIndex = 6;
            this.playbutton.TabStop = false;
            this.playbutton.Click += new System.EventHandler(this.playbutton_Click);
            // 
            // backbutton
            // 
            this.backbutton.Image = ((System.Drawing.Image)(resources.GetObject("backbutton.Image")));
            this.backbutton.Location = new System.Drawing.Point(438, 296);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(62, 62);
            this.backbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.backbutton.TabIndex = 5;
            this.backbutton.TabStop = false;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // forwardbutton
            // 
            this.forwardbutton.Image = ((System.Drawing.Image)(resources.GetObject("forwardbutton.Image")));
            this.forwardbutton.Location = new System.Drawing.Point(681, 300);
            this.forwardbutton.Name = "forwardbutton";
            this.forwardbutton.Size = new System.Drawing.Size(59, 62);
            this.forwardbutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.forwardbutton.TabIndex = 4;
            this.forwardbutton.TabStop = false;
            this.forwardbutton.Click += new System.EventHandler(this.forwardbutton_Click);
            // 
            // resumebutton
            // 
            this.resumebutton.Image = ((System.Drawing.Image)(resources.GetObject("resumebutton.Image")));
            this.resumebutton.Location = new System.Drawing.Point(586, 296);
            this.resumebutton.Name = "resumebutton";
            this.resumebutton.Size = new System.Drawing.Size(89, 66);
            this.resumebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resumebutton.TabIndex = 3;
            this.resumebutton.TabStop = false;
            this.resumebutton.Click += new System.EventHandler(this.resumebutton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(84)))), ((int)(((byte)(53)))));
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.selectedbutton);
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Location = new System.Drawing.Point(2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(211, 430);
            this.panel3.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(40, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 37);
            this.label7.TabIndex = 12;
            this.label7.Text = "Playlist";
            // 
            // selectedbutton
            // 
            this.selectedbutton.BackColor = System.Drawing.Color.Black;
            this.selectedbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.selectedbutton.Cursor = System.Windows.Forms.Cursors.Default;
            this.selectedbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectedbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.selectedbutton.Location = new System.Drawing.Point(34, 375);
            this.selectedbutton.Name = "selectedbutton";
            this.selectedbutton.Size = new System.Drawing.Size(146, 41);
            this.selectedbutton.TabIndex = 1;
            this.selectedbutton.Text = "Selected Song";
            this.selectedbutton.UseVisualStyleBackColor = false;
            this.selectedbutton.Click += new System.EventHandler(this.selectedbutton_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(10, 48);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(187, 308);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(530, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(114, 111);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(841, 11);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(100, 50);
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // minimize
            // 
            this.minimize.Image = ((System.Drawing.Image)(resources.GetObject("minimize.Image")));
            this.minimize.Location = new System.Drawing.Point(755, -12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(80, 92);
            this.minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize.TabIndex = 1;
            this.minimize.TabStop = false;
            this.minimize.Click += new System.EventHandler(this.minimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mp3 Player App";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.minimize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(922, 71);
            this.panel1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 491);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardbutton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resumebutton)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label musicname;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label volumevalue;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label tim2;
        private System.Windows.Forms.Label tim1;
        private System.Windows.Forms.PictureBox playbutton;
        private System.Windows.Forms.PictureBox backbutton;
        private System.Windows.Forms.PictureBox forwardbutton;
        private System.Windows.Forms.PictureBox resumebutton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button selectedbutton;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox close;
        private System.Windows.Forms.PictureBox minimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

