
namespace SplitPlaylist
{
    partial class SplitPlaylist
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.eTracks = new System.Windows.Forms.TextBox();
            this.eURL = new System.Windows.Forms.TextBox();
            this.bGo = new System.Windows.Forms.Button();
            this.ePattern = new System.Windows.Forms.TextBox();
            this.lURL = new System.Windows.Forms.Label();
            this.lPattern = new System.Windows.Forms.Label();
            this.lArtist = new System.Windows.Forms.Label();
            this.eArtist = new System.Windows.Forms.TextBox();
            this.lExtension = new System.Windows.Forms.Label();
            this.cbExtension = new System.Windows.Forms.ComboBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.rbURL = new System.Windows.Forms.RadioButton();
            this.rbFile = new System.Windows.Forms.RadioButton();
            this.pSourceType = new System.Windows.Forms.Panel();
            this.bOpenFile = new System.Windows.Forms.Button();
            this.bOpenVideoFile = new System.Windows.Forms.Button();
            this.cDeleteExisting = new System.Windows.Forms.CheckBox();
            this.cUseTimeOrdering = new System.Windows.Forms.CheckBox();
            this.statusBar.SuspendLayout();
            this.pSourceType.SuspendLayout();
            this.SuspendLayout();
            // 
            // eTracks
            // 
            this.eTracks.Location = new System.Drawing.Point(9, 244);
            this.eTracks.Multiline = true;
            this.eTracks.Name = "eTracks";
            this.eTracks.Size = new System.Drawing.Size(577, 265);
            this.eTracks.TabIndex = 0;
            // 
            // eURL
            // 
            this.eURL.Location = new System.Drawing.Point(181, 82);
            this.eURL.Name = "eURL";
            this.eURL.Size = new System.Drawing.Size(243, 23);
            this.eURL.TabIndex = 1;
            // 
            // bGo
            // 
            this.bGo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bGo.Location = new System.Drawing.Point(308, 515);
            this.bGo.Name = "bGo";
            this.bGo.Size = new System.Drawing.Size(91, 47);
            this.bGo.TabIndex = 2;
            this.bGo.Text = "GO";
            this.bGo.UseVisualStyleBackColor = true;
            this.bGo.Click += new System.EventHandler(this.bGo_Click);
            // 
            // ePattern
            // 
            this.ePattern.Location = new System.Drawing.Point(181, 111);
            this.ePattern.Name = "ePattern";
            this.ePattern.Size = new System.Drawing.Size(243, 23);
            this.ePattern.TabIndex = 3;
            // 
            // lURL
            // 
            this.lURL.AutoSize = true;
            this.lURL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lURL.Location = new System.Drawing.Point(147, 85);
            this.lURL.Name = "lURL";
            this.lURL.Size = new System.Drawing.Size(28, 15);
            this.lURL.TabIndex = 4;
            this.lURL.Text = "URL";
            // 
            // lPattern
            // 
            this.lPattern.AutoSize = true;
            this.lPattern.Location = new System.Drawing.Point(130, 114);
            this.lPattern.Name = "lPattern";
            this.lPattern.Size = new System.Drawing.Size(45, 15);
            this.lPattern.TabIndex = 5;
            this.lPattern.Text = "Pattern";
            // 
            // lArtist
            // 
            this.lArtist.AutoSize = true;
            this.lArtist.Location = new System.Drawing.Point(130, 143);
            this.lArtist.Name = "lArtist";
            this.lArtist.Size = new System.Drawing.Size(35, 15);
            this.lArtist.TabIndex = 7;
            this.lArtist.Text = "Artist";
            // 
            // eArtist
            // 
            this.eArtist.Location = new System.Drawing.Point(181, 140);
            this.eArtist.Name = "eArtist";
            this.eArtist.Size = new System.Drawing.Size(243, 23);
            this.eArtist.TabIndex = 6;
            // 
            // lExtension
            // 
            this.lExtension.AutoSize = true;
            this.lExtension.Location = new System.Drawing.Point(117, 172);
            this.lExtension.Name = "lExtension";
            this.lExtension.Size = new System.Drawing.Size(58, 15);
            this.lExtension.TabIndex = 9;
            this.lExtension.Text = "Extension";
            // 
            // cbExtension
            // 
            this.cbExtension.FormattingEnabled = true;
            this.cbExtension.Location = new System.Drawing.Point(181, 169);
            this.cbExtension.Name = "cbExtension";
            this.cbExtension.Size = new System.Drawing.Size(121, 23);
            this.cbExtension.TabIndex = 10;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressbar});
            this.statusBar.Location = new System.Drawing.Point(0, 568);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(593, 22);
            this.statusBar.TabIndex = 11;
            // 
            // progressbar
            // 
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(100, 16);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(216, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 37);
            this.label1.TabIndex = 12;
            this.label1.Text = "Split Playlist";
            // 
            // rbURL
            // 
            this.rbURL.AutoSize = true;
            this.rbURL.Checked = true;
            this.rbURL.Location = new System.Drawing.Point(8, 2);
            this.rbURL.Name = "rbURL";
            this.rbURL.Size = new System.Drawing.Size(46, 19);
            this.rbURL.TabIndex = 13;
            this.rbURL.TabStop = true;
            this.rbURL.Text = "URL";
            this.rbURL.UseVisualStyleBackColor = true;
            this.rbURL.CheckedChanged += new System.EventHandler(this.rbURL_CheckedChanged);
            // 
            // rbFile
            // 
            this.rbFile.AutoSize = true;
            this.rbFile.Location = new System.Drawing.Point(65, 2);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(43, 19);
            this.rbFile.TabIndex = 14;
            this.rbFile.Text = "File";
            this.rbFile.UseVisualStyleBackColor = true;
            // 
            // pSourceType
            // 
            this.pSourceType.Controls.Add(this.rbFile);
            this.pSourceType.Controls.Add(this.rbURL);
            this.pSourceType.Location = new System.Drawing.Point(308, 169);
            this.pSourceType.Name = "pSourceType";
            this.pSourceType.Size = new System.Drawing.Size(116, 23);
            this.pSourceType.TabIndex = 15;
            // 
            // bOpenFile
            // 
            this.bOpenFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOpenFile.Location = new System.Drawing.Point(196, 515);
            this.bOpenFile.Name = "bOpenFile";
            this.bOpenFile.Size = new System.Drawing.Size(106, 47);
            this.bOpenFile.TabIndex = 15;
            this.bOpenFile.Text = "Load Tracks";
            this.bOpenFile.UseVisualStyleBackColor = true;
            this.bOpenFile.Click += new System.EventHandler(this.bOpenFile_Click);
            // 
            // bOpenVideoFile
            // 
            this.bOpenVideoFile.Location = new System.Drawing.Point(430, 82);
            this.bOpenVideoFile.Name = "bOpenVideoFile";
            this.bOpenVideoFile.Size = new System.Drawing.Size(31, 23);
            this.bOpenVideoFile.TabIndex = 16;
            this.bOpenVideoFile.Text = "...";
            this.bOpenVideoFile.UseVisualStyleBackColor = true;
            this.bOpenVideoFile.Visible = false;
            this.bOpenVideoFile.Click += new System.EventHandler(this.bOpenVideoFile_Click);
            // 
            // cDeleteExisting
            // 
            this.cDeleteExisting.AutoSize = true;
            this.cDeleteExisting.Location = new System.Drawing.Point(431, 171);
            this.cDeleteExisting.Name = "cDeleteExisting";
            this.cDeleteExisting.Size = new System.Drawing.Size(138, 19);
            this.cDeleteExisting.TabIndex = 18;
            this.cDeleteExisting.Text = "Delete Existing Tracks";
            this.cDeleteExisting.UseVisualStyleBackColor = true;
            // 
            // cUseTimeOrdering
            // 
            this.cUseTimeOrdering.AutoSize = true;
            this.cUseTimeOrdering.Checked = true;
            this.cUseTimeOrdering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cUseTimeOrdering.Location = new System.Drawing.Point(181, 198);
            this.cUseTimeOrdering.Name = "cUseTimeOrdering";
            this.cUseTimeOrdering.Size = new System.Drawing.Size(124, 19);
            this.cUseTimeOrdering.TabIndex = 19;
            this.cUseTimeOrdering.Text = "Use Time Ordering";
            this.cUseTimeOrdering.UseVisualStyleBackColor = true;
            // 
            // SplitPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 590);
            this.Controls.Add(this.cUseTimeOrdering);
            this.Controls.Add(this.cDeleteExisting);
            this.Controls.Add(this.bOpenVideoFile);
            this.Controls.Add(this.bOpenFile);
            this.Controls.Add(this.pSourceType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.cbExtension);
            this.Controls.Add(this.lExtension);
            this.Controls.Add(this.lArtist);
            this.Controls.Add(this.eArtist);
            this.Controls.Add(this.lPattern);
            this.Controls.Add(this.lURL);
            this.Controls.Add(this.ePattern);
            this.Controls.Add(this.bGo);
            this.Controls.Add(this.eURL);
            this.Controls.Add(this.eTracks);
            this.Name = "SplitPlaylist";
            this.Text = "Split Playlist";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.pSourceType.ResumeLayout(false);
            this.pSourceType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eTracks;
        private System.Windows.Forms.TextBox eURL;
        private System.Windows.Forms.Button bGo;
        private System.Windows.Forms.TextBox ePattern;
        private System.Windows.Forms.Label lURL;
        private System.Windows.Forms.Label lPattern;
        private System.Windows.Forms.Label lArtist;
        private System.Windows.Forms.TextBox eArtist;
        private System.Windows.Forms.Label lExtension;
        private System.Windows.Forms.ComboBox cbExtension;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripProgressBar progressbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbURL;
        private System.Windows.Forms.RadioButton rbFile;
        private System.Windows.Forms.Panel pSourceType;
        private System.Windows.Forms.Button bOpenFile;
        private System.Windows.Forms.Button bOpenVideoFile;
        private System.Windows.Forms.CheckBox cDeleteExisting;
        private System.Windows.Forms.CheckBox cUseTimeOrdering;
    }
}

