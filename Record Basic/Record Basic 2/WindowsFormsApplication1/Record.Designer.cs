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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Record));
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.lstList = new System.Windows.Forms.ListBox();
            this.sttStrip = new System.Windows.Forms.StatusStrip();
            this.sttRecord = new System.Windows.Forms.ToolStripStatusLabel();
            this.pgbRecord = new System.Windows.Forms.ToolStripProgressBar();
            this.sttTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(42, 26);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(42, 37);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnClose
            // 
            this.btnClose.Enabled = false;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(160, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(42, 37);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnRecord.Image")));
            this.btnRecord.Location = new System.Drawing.Point(101, 26);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(42, 37);
            this.btnRecord.TabIndex = 5;
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // lstList
            // 
            this.lstList.FormattingEnabled = true;
            this.lstList.Location = new System.Drawing.Point(12, 79);
            this.lstList.Name = "lstList";
            this.lstList.ScrollAlwaysVisible = true;
            this.lstList.Size = new System.Drawing.Size(225, 147);
            this.lstList.TabIndex = 6;
            // 
            // sttStrip
            // 
            this.sttStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttRecord,
            this.pgbRecord,
            this.sttTime});
            this.sttStrip.Location = new System.Drawing.Point(0, 245);
            this.sttStrip.Name = "sttStrip";
            this.sttStrip.Size = new System.Drawing.Size(249, 22);
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
            this.sttTime.Size = new System.Drawing.Size(34, 17);
            this.sttTime.Text = "00:00";
            // 
            // Record
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 267);
            this.Controls.Add(this.sttStrip);
            this.Controls.Add(this.lstList);
            this.Controls.Add(this.btnRecord);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Record";
            this.Text = "Record 1.0";
            this.sttStrip.ResumeLayout(false);
            this.sttStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.ListBox lstList;
        private System.Windows.Forms.StatusStrip sttStrip;
        private System.Windows.Forms.ToolStripStatusLabel sttRecord;
        private System.Windows.Forms.ToolStripProgressBar pgbRecord;
        private System.Windows.Forms.ToolStripStatusLabel sttTime;
    }
}

