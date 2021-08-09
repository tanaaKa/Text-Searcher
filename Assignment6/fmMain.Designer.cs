namespace Assignment6
{
    partial class fmMain
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
            this.lbFind = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.bnFind = new System.Windows.Forms.Button();
            this.rtbPoem = new System.Windows.Forms.RichTextBox();
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.tsslStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiData = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDataFind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMain.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbFind
            // 
            this.lbFind.AutoSize = true;
            this.lbFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lbFind.Location = new System.Drawing.Point(28, 247);
            this.lbFind.Name = "lbFind";
            this.lbFind.Size = new System.Drawing.Size(84, 18);
            this.lbFind.TabIndex = 1;
            this.lbFind.Text = "Text to find:";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(31, 268);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(298, 20);
            this.tbText.TabIndex = 2;
            // 
            // bnFind
            // 
            this.bnFind.Location = new System.Drawing.Point(137, 294);
            this.bnFind.Name = "bnFind";
            this.bnFind.Size = new System.Drawing.Size(75, 23);
            this.bnFind.TabIndex = 3;
            this.bnFind.Text = "Find";
            this.bnFind.UseVisualStyleBackColor = true;
            this.bnFind.Click += new System.EventHandler(this.bnFind_Click);
            // 
            // rtbPoem
            // 
            this.rtbPoem.Location = new System.Drawing.Point(31, 39);
            this.rtbPoem.Name = "rtbPoem";
            this.rtbPoem.Size = new System.Drawing.Size(298, 196);
            this.rtbPoem.TabIndex = 4;
            this.rtbPoem.Text = "";
            // 
            // ssMain
            // 
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslStatus});
            this.ssMain.Location = new System.Drawing.Point(0, 333);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(357, 22);
            this.ssMain.TabIndex = 5;
            this.ssMain.Text = "statusStrip1";
            // 
            // tsslStatus
            // 
            this.tsslStatus.Name = "tsslStatus";
            this.tsslStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiData,
            this.tsmiHelp});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(357, 24);
            this.msMain.TabIndex = 6;
            this.msMain.Text = "menuStrip1";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFileExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(37, 20);
            this.tsmiFile.Text = "File";
            // 
            // tsmiFileExit
            // 
            this.tsmiFileExit.Name = "tsmiFileExit";
            this.tsmiFileExit.Size = new System.Drawing.Size(93, 22);
            this.tsmiFileExit.Text = "Exit";
            this.tsmiFileExit.Click += new System.EventHandler(this.tsmiFileExit_Click);
            // 
            // tsmiData
            // 
            this.tsmiData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDataFind});
            this.tsmiData.Name = "tsmiData";
            this.tsmiData.Size = new System.Drawing.Size(43, 20);
            this.tsmiData.Text = "Data";
            // 
            // tsmiDataFind
            // 
            this.tsmiDataFind.Name = "tsmiDataFind";
            this.tsmiDataFind.Size = new System.Drawing.Size(97, 22);
            this.tsmiDataFind.Text = "Find";
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiHelpAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(44, 20);
            this.tsmiHelp.Text = "Help";
            // 
            // tsmiHelpAbout
            // 
            this.tsmiHelpAbout.Name = "tsmiHelpAbout";
            this.tsmiHelpAbout.Size = new System.Drawing.Size(107, 22);
            this.tsmiHelpAbout.Text = "About";
            this.tsmiHelpAbout.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 355);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.msMain);
            this.Controls.Add(this.rtbPoem);
            this.Controls.Add(this.bnFind);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lbFind);
            this.MainMenuStrip = this.msMain;
            this.Name = "fmMain";
            this.Text = "Text Finder";
            this.Load += new System.EventHandler(this.fmMain_Load);
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFind;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button bnFind;
        private System.Windows.Forms.RichTextBox rtbPoem;
        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiFileExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiData;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiDataFind;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelpAbout;
        private System.Windows.Forms.ToolStripStatusLabel tsslStatus;
    }
}