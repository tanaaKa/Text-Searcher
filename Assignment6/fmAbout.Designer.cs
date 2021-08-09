namespace Assignment6
{
    partial class fmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAbout));
            this.bnOkay = new System.Windows.Forms.Button();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbWordsSearched = new System.Windows.Forms.Label();
            this.pbSearch = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // bnOkay
            // 
            this.bnOkay.Location = new System.Drawing.Point(96, 226);
            this.bnOkay.Name = "bnOkay";
            this.bnOkay.Size = new System.Drawing.Size(75, 23);
            this.bnOkay.TabIndex = 0;
            this.bnOkay.Text = "OK";
            this.bnOkay.UseVisualStyleBackColor = true;
            this.bnOkay.Click += new System.EventHandler(this.bnOkay_Click);
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(25, 79);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(98, 13);
            this.lbAuthor.TabIndex = 1;
            this.lbAuthor.Text = "Author: Troy Billsen";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lbTitle.Location = new System.Drawing.Point(58, 27);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(157, 20);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "TEXT SEARCHER";
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(25, 107);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(63, 13);
            this.lbVersion.TabIndex = 3;
            this.lbVersion.Text = "Version: 1.0";
            // 
            // lbWordsSearched
            // 
            this.lbWordsSearched.AutoSize = true;
            this.lbWordsSearched.Location = new System.Drawing.Point(12, 135);
            this.lbWordsSearched.Name = "lbWordsSearched";
            this.lbWordsSearched.Size = new System.Drawing.Size(113, 13);
            this.lbWordsSearched.TabIndex = 4;
            this.lbWordsSearched.Text = "Words Searched: N/A";
            // 
            // pbSearch
            // 
            this.pbSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbSearch.Image = ((System.Drawing.Image)(resources.GetObject("pbSearch.Image")));
            this.pbSearch.Location = new System.Drawing.Point(139, 64);
            this.pbSearch.Name = "pbSearch";
            this.pbSearch.Size = new System.Drawing.Size(143, 145);
            this.pbSearch.TabIndex = 5;
            this.pbSearch.TabStop = false;
            // 
            // fmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pbSearch);
            this.Controls.Add(this.lbWordsSearched);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.lbAuthor);
            this.Controls.Add(this.bnOkay);
            this.Name = "fmAbout";
            this.Text = "About Text Searcher";
            this.Load += new System.EventHandler(this.fmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnOkay;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbWordsSearched;
        private System.Windows.Forms.PictureBox pbSearch;
    }
}