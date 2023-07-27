using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3_Player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Visible = false;
            axWindowsMediaPlayer1.settings.volume = 30;
            tim1.Visible = true;
          



        }

        String[] paths, files; //global

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void resumebutton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void forwardbutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex + 1;
            }

            else
            {
                listBox1.SelectedIndex = 0;
            }
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex = listBox1.SelectedIndex - 1;
            }
            else
            {
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
            }
            axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
            axWindowsMediaPlayer1.Ctlcontrols.play();
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
                axWindowsMediaPlayer1.URL = paths[listBox1.SelectedIndex];
                musicname.Text = files[listBox1.SelectedIndex];
            
                
            
        }
       
        private void selectedbutton_Click(object sender, EventArgs e) // additon controling
        {
            // ss means select songs
            OpenFileDialog ss = new OpenFileDialog();
            ss.Multiselect = true;
            if (ss.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                files = ss.SafeFileNames;
                paths = ss.FileNames;
                for (int i = 0; i < files.Length; i++)
                {
                   
                    listBox1.Items.Add(files[i]);
                }
                //axWindowsMediaPlayer1.URL = paths[0];
                //axWindowsMediaPlayer1.Ctlcontrols.play();
                

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1 != null && axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }

            try
            {
                if (axWindowsMediaPlayer1 != null)
                {
                tim1.Text = axWindowsMediaPlayer1.Ctlcontrols.currentPositionString;
                tim2.Text = axWindowsMediaPlayer1.Ctlcontrols.currentItem.durationString.ToString();
                }
            }
            catch { }

        }

        private void volumevalue_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value;
            volumevalue.Text = trackBar1.Value.ToString();
        }

        private void musicname_Click(object sender, EventArgs e)
        {
        }

        private void tim1_Click(object sender, EventArgs e)
        {

        }

        private void playbutton_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
