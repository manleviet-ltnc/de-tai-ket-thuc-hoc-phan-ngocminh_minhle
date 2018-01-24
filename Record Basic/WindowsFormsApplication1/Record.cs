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
    public partial class Record : Form
    {
        [DllImport("winmm.dll")]
        private static extern int mciSendString(string MciComando, string MciRetorno, int MciRetornoLeng, int CallBack);
        string music = "";
        public Record()
        {
            InitializeComponent();
        }
        private void btnRecord_Click(object sender, EventArgs e)
        {
            timer.Start();
            mciSendString("Open new type waveaudio alias Sound", null, 0, 0);
            mciSendString("record Sound", null, 0, 0);
            sttRecord.Text = "Recording";
            btnPauseMusic.Visible = false;
            btnResumeMusic.Visible = false;
            btnCloseMusic.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            timer.Stop();
            mciSendString("pause Sound", null, 0, 0);
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Wave|*.wav";
            save.ShowDialog();
            mciSendString("save Sound " + save.FileName, null, 0, 0);
            mciSendString("close Sound", null, 0, 0);
            sttRecord.Text = null;
            sttTime3.Text = "00";
            sttTime.Text = "00";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPauseMusic.Visible = true;
            btnResumeMusic.Visible = true;
            btnCloseMusic.Visible = true;
            sttTime3.Text = "00";
            sttTime.Text = "00";
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Wave|*.wav";
            if (open.ShowDialog() == DialogResult.OK)
            {
                music = open.FileName;
                mciSendString("play " + music, null, 0, 0);
                sttStrip.Text = "Playing...";
            }
        }
        private void btnPauseMusic_Click(object sender, EventArgs e)
        {
            mciSendString("pause " + music, null, 0, 0);
            sttStrip.Text = "Paused...";
        }

        private void btnCloseMusic_Click(object sender, EventArgs e)
        {
            mciSendString("stop " + music, null, 0, 0);
            sttStrip.Text = "Stopped";
            music = "";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int a = Int32.Parse(sttTime3.Text);
            int b = Int32.Parse(sttTime.Text);
            a++;
            if (a > 59)
            {
                a = 0;
                b++;
            }
            if (a < 10)
                sttTime3.Text = "0" + a;
            else
                sttTime3.Text = a + "";
            if (b < 10)
                sttTime.Text = "0" + b;
            else
                sttTime.Text = b + "";
        }

        private void Record_Load(object sender, EventArgs e)
        {
            String[] files = Directory.GetFiles(@"C:\Users\DELL\Desktop\SaveRecord");
            DataTable table = new DataTable();
            table.Columns.Add("Ghi âm");
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo file = new FileInfo(files[i]);
                table.Rows.Add(file);
            }
            dataGridView1.DataSource = table;
        }

        private void btnResumeMusic_Click(object sender, EventArgs e)
        {
            mciSendString("resume " + music, null, 0, 0);
            sttStrip.Text = "Playing...";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = true;
        }

        private void Record_Click(object sender, EventArgs e)
        {
            btnDelete.Visible = false;
        }  
    }
}