namespace Ardupilot_Log_Privacy
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.ofdLog = new System.Windows.Forms.OpenFileDialog();
            this.tbxOffset = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.lblOffset = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.tbxLog = new System.Windows.Forms.TextBox();
            this.cbxLog = new System.Windows.Forms.CheckBox();
            this.btnCreateParam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "open log";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // ofdLog
            // 
            this.ofdLog.FileName = "openFileDialog1";
            // 
            // tbxOffset
            // 
            this.tbxOffset.Location = new System.Drawing.Point(53, 41);
            this.tbxOffset.Name = "tbxOffset";
            this.tbxOffset.Size = new System.Drawing.Size(34, 20);
            this.tbxOffset.TabIndex = 2;
            this.tbxOffset.TextChanged += new System.EventHandler(this.tbxOffset_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 67);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Location = new System.Drawing.Point(9, 44);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(38, 13);
            this.lblOffset.TabIndex = 4;
            this.lblOffset.Text = "Offset:";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(93, 17);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 13);
            this.lblPath.TabIndex = 5;
            // 
            // tbxLog
            // 
            this.tbxLog.Location = new System.Drawing.Point(12, 96);
            this.tbxLog.Multiline = true;
            this.tbxLog.Name = "tbxLog";
            this.tbxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxLog.Size = new System.Drawing.Size(896, 566);
            this.tbxLog.TabIndex = 6;
            // 
            // cbxLog
            // 
            this.cbxLog.AutoSize = true;
            this.cbxLog.Location = new System.Drawing.Point(96, 71);
            this.cbxLog.Name = "cbxLog";
            this.cbxLog.Size = new System.Drawing.Size(76, 17);
            this.cbxLog.TabIndex = 8;
            this.cbxLog.Text = "changelog";
            this.cbxLog.UseVisualStyleBackColor = true;
            // 
            // btnCreateParam
            // 
            this.btnCreateParam.Location = new System.Drawing.Point(178, 67);
            this.btnCreateParam.Name = "btnCreateParam";
            this.btnCreateParam.Size = new System.Drawing.Size(75, 23);
            this.btnCreateParam.TabIndex = 9;
            this.btnCreateParam.Text = ".param";
            this.btnCreateParam.UseVisualStyleBackColor = true;
            this.btnCreateParam.Click += new System.EventHandler(this.btnCreateParam_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 674);
            this.Controls.Add(this.btnCreateParam);
            this.Controls.Add(this.cbxLog);
            this.Controls.Add(this.tbxLog);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblOffset);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.tbxOffset);
            this.Controls.Add(this.btnOpenFile);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Ardupilot Logfile Privacy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog ofdLog;
        private System.Windows.Forms.TextBox tbxOffset;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.TextBox tbxLog;
        private System.Windows.Forms.CheckBox cbxLog;
        private System.Windows.Forms.Button btnCreateParam;
    }
}

