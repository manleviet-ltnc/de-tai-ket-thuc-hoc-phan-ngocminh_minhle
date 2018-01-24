namespace WindowsFormsApplication1
{
    partial class Record
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Record));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.sttStrip = new System.Windows.Forms.StatusStrip();
            this.sttRecord = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgbRecord = new System.Windows.Forms.ToolStripProgressBar();
            this.sttTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttTime2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttTime3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnPauseMusic = new System.Windows.Forms.Button();
            this.btnCloseMusic = new System.Windows.Forms.Button();
            this.btnResumeMusic = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.sttStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(12, 12);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(24, 29);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(72, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(22, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnRecord.Image")));
            this.btnRecord.Location = new System.Drawing.Point(42, 12);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(24, 29);
            this.btnRecord.TabIndex = 5;
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // sttStrip
            // 
            this.sttStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttRecord,
            this.pgbRecord,
            this.sttTime,
            this.sttTime2,
            this.sttTime3});
            this.sttStrip.Location = new System.Drawing.Point(0, 351);
            this.sttStrip.Name = "sttStrip";
            this.sttStrip.Size = new System.Drawing.Size(364, 22);
            this.sttStrip.TabIndex = 9;
            // 
            // sttRecord
            // 
            this.sttRecord.Name = "sttRecord";
            this.sttRecord.Size = new System.Drawing.Size(0, 17);
            // 
            // pgbRecord
            // 
            this.pgbRecord.Name = "pgbRecord";
            this.pgbRecord.Size = new System.Drawing.Size(100, 16);
            // 
            // sttTime
            // 
            this.sttTime.Name = "sttTime";
            this.sttTime.Size = new System.Drawing.Size(19, 17);
            this.sttTime.Text = "00";
            // 
            // sttTime2
            // 
            this.sttTime2.Name = "sttTime2";
            this.sttTime2.Size = new System.Drawing.Size(10, 17);
            this.sttTime2.Text = ":";
            // 
            // sttTime3
            // 
            this.sttTime3.Name = "sttTime3";
            this.sttTime3.Size = new System.Drawing.Size(19, 17);
            this.sttTime3.Text = "00";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnPauseMusic
            // 
            this.btnPauseMusic.Image = ((System.Drawing.Image)(resources.GetObject("btnPauseMusic.Image")));
            this.btnPauseMusic.Location = new System.Drawing.Point(269, 12);
            this.btnPauseMusic.Name = "btnPauseMusic";
            this.btnPauseMusic.Size = new System.Drawing.Size(24, 29);
            this.btnPauseMusic.TabIndex = 11;
            this.btnPauseMusic.UseVisualStyleBackColor = true;
            this.btnPauseMusic.Visible = false;
            this.btnPauseMusic.Click += new System.EventHandler(this.btnPauseMusic_Click);
            // 
            // btnCloseMusic
            // 
            this.btnCloseMusic.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseMusic.Image")));
            this.btnCloseMusic.Location = new System.Drawing.Point(299, 12);
            this.btnCloseMusic.Name = "btnCloseMusic";
            this.btnCloseMusic.Size = new System.Drawing.Size(25, 29);
            this.btnCloseMusic.TabIndex = 12;
            this.btnCloseMusic.UseVisualStyleBackColor = true;
            this.btnCloseMusic.Visible = false;
            this.btnCloseMusic.Click += new System.EventHandler(this.btnCloseMusic_Click);
            // 
            // btnResumeMusic
            // 
            this.btnResumeMusic.Image = ((System.Drawing.Image)(resources.GetObject("btnResumeMusic.Image")));
            this.btnResumeMusic.Location = new System.Drawing.Point(330, 12);
            this.btnResumeMusic.Name = "btnResumeMusic";
            this.btnResumeMusic.Size = new System.Drawing.Size(22, 29);
            this.btnResumeMusic.TabIndex = 15;
            this.btnResumeMusic.UseVisualStyleBackColor = true;
            this.btnResumeMusic.Visible = false;
            this.btnResumeMusic.Click += new System.EventHandler(this.btnResumeMusic_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(340, 251);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(309, 318);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(43, 29);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 373);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnResumeMusic);
            this.Controls.Add(this.btnCloseMusic);
            this.Controls.Add(this.btnPauseMusic);
            this.Controls.Add(this.sttStrip);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Record";
            this.Text = "Record 1.0";
            this.Load += new System.EventHandler(this.Record_Load);
            this.Click += new System.EventHandler(this.Record_Click);
            this.sttStrip.ResumeLayout(false);
            this.sttStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.StatusStrip sttStrip;
        private System.Windows.Forms.ToolStripStatusLabel sttRecord;
        private System.Windows.Forms.ToolStripProgressBar pgbRecord;
        private System.Windows.Forms.ToolStripStatusLabel sttTime;
        private System.Windows.Forms.ToolStripStatusLabel sttTime2;
        private System.Windows.Forms.ToolStripStatusLabel sttTime3;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnPauseMusic;
        private System.Windows.Forms.Button btnCloseMusic;
        private System.Windows.Forms.Button btnResumeMusic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
    }
}

