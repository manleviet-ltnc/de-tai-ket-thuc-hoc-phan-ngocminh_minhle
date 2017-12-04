using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Runtime.InteropServices;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        [DllImport("winmm.dll")]
        private static extern int mciSendString(string MciComando, string MciRetorno, int MciRetornoLeng, int CallBack);
        string music = "";
        private int quick = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnRecord_Click(object sender, EventArgs e)
        {
            timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
            mciSendString("Open new type waveaudio alias Sound", null, 0, 0);
            mciSendString("record Sound", null, 0, 0);
            btnPlay.Enabled = true;
            btnClose.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            mciSendString("pause Sound", null, 0, 0);
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Wave|*.wav";
            save.ShowDialog();
            mciSendString("save Sound " + save.FileName, null, 0, 0);
            mciSendString("close Sound", null, 0, 0);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (music == "")
            {
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Wave|*.wav";
                if (open.ShowDialog() == DialogResult.OK)
                    music = open.FileName;
            }
            mciSendString("play " + music, null, 0, 0);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            quick++;
            lblTime.Text = quick / 60 + ":" + ((quick % 60) >= 10 ? (quick % 60).ToString() : "0" + (quick % 60));
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                lstList.Items.Clear();
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                string[] dirs = Directory.GetDirectories(fbd.SelectedPath);
                foreach (string file in files)
                {
                    lstList.Items.Add(file);
                }
                foreach (string dir in dirs)
                {
                    lstList.Items.Add(dir);
                }
            }
        }

        private void lstList_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}