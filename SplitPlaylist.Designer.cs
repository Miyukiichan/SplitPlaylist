
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
            this.eSpURL = new System.Windows.Forms.TextBox();
            this.bGo = new System.Windows.Forms.Button();
            this.ePattern = new System.Windows.Forms.TextBox();
            this.lSpURL = new System.Windows.Forms.Label();
            this.lPattern = new System.Windows.Forms.Label();
            this.lArtist = new System.Windows.Forms.Label();
            this.eArtist = new System.Windows.Forms.TextBox();
            this.lSpExtension = new System.Windows.Forms.Label();
            this.cbSpExtension = new System.Windows.Forms.ComboBox();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.lSplitPlaylist = new System.Windows.Forms.Label();
            this.rbURL = new System.Windows.Forms.RadioButton();
            this.rbFile = new System.Windows.Forms.RadioButton();
            this.pSourceType = new System.Windows.Forms.Panel();
            this.bOpenFile = new System.Windows.Forms.Button();
            this.bOpenVideoFile = new System.Windows.Forms.Button();
            this.cDeleteExisting = new System.Windows.Forms.CheckBox();
            this.cUseTimeOrdering = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tSplitPlaylist = new System.Windows.Forms.TabPage();
            this.eYTCom = new System.Windows.Forms.TextBox();
            this.eFFCom = new System.Windows.Forms.TextBox();
            this.lYTCom = new System.Windows.Forms.Label();
            this.lFFCom = new System.Windows.Forms.Label();
            this.tDownload = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cPlaylist = new System.Windows.Forms.CheckBox();
            this.eUrlList = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbAudio = new System.Windows.Forms.RadioButton();
            this.rbVideo = new System.Windows.Forms.RadioButton();
            this.lDownload = new System.Windows.Forms.Label();
            this.cbDExtension = new System.Windows.Forms.ComboBox();
            this.lDExtension = new System.Windows.Forms.Label();
            this.statusBar.SuspendLayout();
            this.pSourceType.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tSplitPlaylist.SuspendLayout();
            this.tDownload.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eTracks
            // 
            this.eTracks.Location = new System.Drawing.Point(40, 271);
            this.eTracks.Multiline = true;
            this.eTracks.Name = "eTracks";
            this.eTracks.Size = new System.Drawing.Size(577, 221);
            this.eTracks.TabIndex = 0;
            // 
            // eSpURL
            // 
            this.eSpURL.Location = new System.Drawing.Point(212, 65);
            this.eSpURL.Name = "eSpURL";
            this.eSpURL.Size = new System.Drawing.Size(243, 23);
            this.eSpURL.TabIndex = 1;
            // 
            // bGo
            // 
            this.bGo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bGo.Location = new System.Drawing.Point(339, 498);
            this.bGo.Name = "bGo";
            this.bGo.Size = new System.Drawing.Size(91, 47);
            this.bGo.TabIndex = 2;
            this.bGo.Text = "GO";
            this.bGo.UseVisualStyleBackColor = true;
            this.bGo.Click += new System.EventHandler(this.bGo_Click);
            // 
            // ePattern
            // 
            this.ePattern.Location = new System.Drawing.Point(212, 94);
            this.ePattern.Name = "ePattern";
            this.ePattern.Size = new System.Drawing.Size(243, 23);
            this.ePattern.TabIndex = 3;
            // 
            // lSpURL
            // 
            this.lSpURL.AutoSize = true;
            this.lSpURL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lSpURL.Location = new System.Drawing.Point(178, 68);
            this.lSpURL.Name = "lSpURL";
            this.lSpURL.Size = new System.Drawing.Size(28, 15);
            this.lSpURL.TabIndex = 4;
            this.lSpURL.Text = "URL";
            // 
            // lPattern
            // 
            this.lPattern.AutoSize = true;
            this.lPattern.Location = new System.Drawing.Point(161, 97);
            this.lPattern.Name = "lPattern";
            this.lPattern.Size = new System.Drawing.Size(45, 15);
            this.lPattern.TabIndex = 5;
            this.lPattern.Text = "Pattern";
            // 
            // lArtist
            // 
            this.lArtist.AutoSize = true;
            this.lArtist.Location = new System.Drawing.Point(161, 126);
            this.lArtist.Name = "lArtist";
            this.lArtist.Size = new System.Drawing.Size(35, 15);
            this.lArtist.TabIndex = 7;
            this.lArtist.Text = "Artist";
            // 
            // eArtist
            // 
            this.eArtist.Location = new System.Drawing.Point(212, 123);
            this.eArtist.Name = "eArtist";
            this.eArtist.Size = new System.Drawing.Size(243, 23);
            this.eArtist.TabIndex = 6;
            // 
            // lSpExtension
            // 
            this.lSpExtension.AutoSize = true;
            this.lSpExtension.Location = new System.Drawing.Point(148, 155);
            this.lSpExtension.Name = "lSpExtension";
            this.lSpExtension.Size = new System.Drawing.Size(58, 15);
            this.lSpExtension.TabIndex = 9;
            this.lSpExtension.Text = "Extension";
            // 
            // cbSpExtension
            // 
            this.cbSpExtension.FormattingEnabled = true;
            this.cbSpExtension.Location = new System.Drawing.Point(212, 152);
            this.cbSpExtension.Name = "cbSpExtension";
            this.cbSpExtension.Size = new System.Drawing.Size(121, 23);
            this.cbSpExtension.TabIndex = 10;
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressbar});
            this.statusBar.Location = new System.Drawing.Point(0, 591);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(656, 22);
            this.statusBar.TabIndex = 11;
            // 
            // progressbar
            // 
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(100, 16);
            // 
            // lSplitPlaylist
            // 
            this.lSplitPlaylist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lSplitPlaylist.AutoSize = true;
            this.lSplitPlaylist.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lSplitPlaylist.Location = new System.Drawing.Point(256, 16);
            this.lSplitPlaylist.Name = "lSplitPlaylist";
            this.lSplitPlaylist.Size = new System.Drawing.Size(160, 37);
            this.lSplitPlaylist.TabIndex = 12;
            this.lSplitPlaylist.Text = "Split Playlist";
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
            this.pSourceType.Location = new System.Drawing.Point(339, 152);
            this.pSourceType.Name = "pSourceType";
            this.pSourceType.Size = new System.Drawing.Size(116, 23);
            this.pSourceType.TabIndex = 15;
            // 
            // bOpenFile
            // 
            this.bOpenFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOpenFile.Location = new System.Drawing.Point(227, 498);
            this.bOpenFile.Name = "bOpenFile";
            this.bOpenFile.Size = new System.Drawing.Size(106, 47);
            this.bOpenFile.TabIndex = 15;
            this.bOpenFile.Text = "Load Tracks";
            this.bOpenFile.UseVisualStyleBackColor = true;
            this.bOpenFile.Click += new System.EventHandler(this.bOpenFile_Click);
            // 
            // bOpenVideoFile
            // 
            this.bOpenVideoFile.Location = new System.Drawing.Point(461, 65);
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
            this.cDeleteExisting.Location = new System.Drawing.Point(462, 154);
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
            this.cUseTimeOrdering.Location = new System.Drawing.Point(212, 181);
            this.cUseTimeOrdering.Name = "cUseTimeOrdering";
            this.cUseTimeOrdering.Size = new System.Drawing.Size(124, 19);
            this.cUseTimeOrdering.TabIndex = 19;
            this.cUseTimeOrdering.Text = "Use Time Ordering";
            this.cUseTimeOrdering.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tSplitPlaylist);
            this.tabControl.Controls.Add(this.tDownload);
            this.tabControl.Location = new System.Drawing.Point(0, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(656, 595);
            this.tabControl.TabIndex = 20;
            // 
            // tSplitPlaylist
            // 
            this.tSplitPlaylist.Controls.Add(this.eYTCom);
            this.tSplitPlaylist.Controls.Add(this.eFFCom);
            this.tSplitPlaylist.Controls.Add(this.lYTCom);
            this.tSplitPlaylist.Controls.Add(this.lFFCom);
            this.tSplitPlaylist.Controls.Add(this.lSplitPlaylist);
            this.tSplitPlaylist.Controls.Add(this.cUseTimeOrdering);
            this.tSplitPlaylist.Controls.Add(this.eTracks);
            this.tSplitPlaylist.Controls.Add(this.cDeleteExisting);
            this.tSplitPlaylist.Controls.Add(this.eSpURL);
            this.tSplitPlaylist.Controls.Add(this.bOpenVideoFile);
            this.tSplitPlaylist.Controls.Add(this.bGo);
            this.tSplitPlaylist.Controls.Add(this.bOpenFile);
            this.tSplitPlaylist.Controls.Add(this.ePattern);
            this.tSplitPlaylist.Controls.Add(this.pSourceType);
            this.tSplitPlaylist.Controls.Add(this.lSpURL);
            this.tSplitPlaylist.Controls.Add(this.lPattern);
            this.tSplitPlaylist.Controls.Add(this.eArtist);
            this.tSplitPlaylist.Controls.Add(this.cbSpExtension);
            this.tSplitPlaylist.Controls.Add(this.lArtist);
            this.tSplitPlaylist.Controls.Add(this.lSpExtension);
            this.tSplitPlaylist.Location = new System.Drawing.Point(4, 24);
            this.tSplitPlaylist.Name = "tSplitPlaylist";
            this.tSplitPlaylist.Padding = new System.Windows.Forms.Padding(3);
            this.tSplitPlaylist.Size = new System.Drawing.Size(648, 567);
            this.tSplitPlaylist.TabIndex = 0;
            this.tSplitPlaylist.Text = "Split Playlist";
            this.tSplitPlaylist.UseVisualStyleBackColor = true;
            // 
            // eYTCom
            // 
            this.eYTCom.Location = new System.Drawing.Point(212, 206);
            this.eYTCom.Name = "eYTCom";
            this.eYTCom.Size = new System.Drawing.Size(243, 23);
            this.eYTCom.TabIndex = 20;
            // 
            // eFFCom
            // 
            this.eFFCom.Location = new System.Drawing.Point(212, 235);
            this.eFFCom.Name = "eFFCom";
            this.eFFCom.Size = new System.Drawing.Size(243, 23);
            this.eFFCom.TabIndex = 21;
            // 
            // lYTCom
            // 
            this.lYTCom.AutoSize = true;
            this.lYTCom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lYTCom.Location = new System.Drawing.Point(109, 209);
            this.lYTCom.Name = "lYTCom";
            this.lYTCom.Size = new System.Drawing.Size(97, 15);
            this.lYTCom.TabIndex = 22;
            this.lYTCom.Text = "yt-dlp command";
            // 
            // lFFCom
            // 
            this.lFFCom.AutoSize = true;
            this.lFFCom.Location = new System.Drawing.Point(102, 238);
            this.lFFCom.Name = "lFFCom";
            this.lFFCom.Size = new System.Drawing.Size(104, 15);
            this.lFFCom.TabIndex = 23;
            this.lFFCom.Text = "ffmpeg command";
            // 
            // tDownload
            // 
            this.tDownload.Controls.Add(this.button1);
            this.tDownload.Controls.Add(this.button2);
            this.tDownload.Controls.Add(this.cPlaylist);
            this.tDownload.Controls.Add(this.eUrlList);
            this.tDownload.Controls.Add(this.panel1);
            this.tDownload.Controls.Add(this.lDownload);
            this.tDownload.Controls.Add(this.cbDExtension);
            this.tDownload.Controls.Add(this.lDExtension);
            this.tDownload.Location = new System.Drawing.Point(4, 24);
            this.tDownload.Name = "tDownload";
            this.tDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tDownload.Size = new System.Drawing.Size(648, 567);
            this.tDownload.TabIndex = 1;
            this.tDownload.Text = "Download";
            this.tDownload.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(319, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 47);
            this.button1.TabIndex = 21;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(207, 514);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 47);
            this.button2.TabIndex = 22;
            this.button2.Text = "Load URLs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cPlaylist
            // 
            this.cPlaylist.AutoSize = true;
            this.cPlaylist.Location = new System.Drawing.Point(460, 84);
            this.cPlaylist.Name = "cPlaylist";
            this.cPlaylist.Size = new System.Drawing.Size(63, 19);
            this.cPlaylist.TabIndex = 20;
            this.cPlaylist.Text = "Playlist";
            this.cPlaylist.UseVisualStyleBackColor = true;
            // 
            // eUrlList
            // 
            this.eUrlList.Location = new System.Drawing.Point(29, 110);
            this.eUrlList.Multiline = true;
            this.eUrlList.Name = "eUrlList";
            this.eUrlList.Size = new System.Drawing.Size(577, 398);
            this.eUrlList.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbAudio);
            this.panel1.Controls.Add(this.rbVideo);
            this.panel1.Location = new System.Drawing.Point(330, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(124, 23);
            this.panel1.TabIndex = 18;
            // 
            // rbAudio
            // 
            this.rbAudio.AutoSize = true;
            this.rbAudio.Checked = true;
            this.rbAudio.Location = new System.Drawing.Point(4, 2);
            this.rbAudio.Name = "rbAudio";
            this.rbAudio.Size = new System.Drawing.Size(57, 19);
            this.rbAudio.TabIndex = 14;
            this.rbAudio.TabStop = true;
            this.rbAudio.Text = "Audio";
            this.rbAudio.UseVisualStyleBackColor = true;
            // 
            // rbVideo
            // 
            this.rbVideo.AutoSize = true;
            this.rbVideo.Location = new System.Drawing.Point(66, 2);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(55, 19);
            this.rbVideo.TabIndex = 13;
            this.rbVideo.Text = "Video";
            this.rbVideo.UseVisualStyleBackColor = true;
            this.rbVideo.CheckedChanged += new System.EventHandler(this.rbVideo_CheckedChanged);
            // 
            // lDownload
            // 
            this.lDownload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lDownload.AutoSize = true;
            this.lDownload.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lDownload.Location = new System.Drawing.Point(241, 31);
            this.lDownload.Name = "lDownload";
            this.lDownload.Size = new System.Drawing.Size(140, 37);
            this.lDownload.TabIndex = 17;
            this.lDownload.Text = "Download";
            // 
            // cbDExtension
            // 
            this.cbDExtension.FormattingEnabled = true;
            this.cbDExtension.Location = new System.Drawing.Point(203, 81);
            this.cbDExtension.Name = "cbDExtension";
            this.cbDExtension.Size = new System.Drawing.Size(121, 23);
            this.cbDExtension.TabIndex = 16;
            // 
            // lDExtension
            // 
            this.lDExtension.AutoSize = true;
            this.lDExtension.Location = new System.Drawing.Point(139, 85);
            this.lDExtension.Name = "lDExtension";
            this.lDExtension.Size = new System.Drawing.Size(58, 15);
            this.lDExtension.TabIndex = 15;
            this.lDExtension.Text = "Extension";
            // 
            // SplitPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 613);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusBar);
            this.Name = "SplitPlaylist";
            this.Text = "Split Playlist";
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.pSourceType.ResumeLayout(false);
            this.pSourceType.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tSplitPlaylist.ResumeLayout(false);
            this.tSplitPlaylist.PerformLayout();
            this.tDownload.ResumeLayout(false);
            this.tDownload.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eTracks;
        private System.Windows.Forms.TextBox eSpURL;
        private System.Windows.Forms.Button bGo;
        private System.Windows.Forms.TextBox ePattern;
        private System.Windows.Forms.Label lSpURL;
        private System.Windows.Forms.Label lPattern;
        private System.Windows.Forms.Label lArtist;
        private System.Windows.Forms.TextBox eArtist;
        private System.Windows.Forms.Label lSpExtension;
        private System.Windows.Forms.ComboBox cbSpExtension;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripProgressBar progressbar;
        private System.Windows.Forms.Label lSplitPlaylist;
        private System.Windows.Forms.RadioButton rbURL;
        private System.Windows.Forms.RadioButton rbFile;
        private System.Windows.Forms.Panel pSourceType;
        private System.Windows.Forms.Button bOpenFile;
        private System.Windows.Forms.Button bOpenVideoFile;
        private System.Windows.Forms.CheckBox cDeleteExisting;
        private System.Windows.Forms.CheckBox cUseTimeOrdering;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tSplitPlaylist;
        private System.Windows.Forms.TabPage tDownload;
        private System.Windows.Forms.Label lDownload;
        private System.Windows.Forms.ComboBox cbDExtension;
        private System.Windows.Forms.Label lDExtension;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbAudio;
        private System.Windows.Forms.RadioButton rbVideo;
        private System.Windows.Forms.TextBox eUrlList;
        private System.Windows.Forms.CheckBox cPlaylist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox eYTCom;
        private System.Windows.Forms.TextBox eFFCom;
        private System.Windows.Forms.Label lYTCom;
        private System.Windows.Forms.Label lFFCom;
    }
}

