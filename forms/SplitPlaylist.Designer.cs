
namespace SplitPlaylist.forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplitPlaylist));
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tSplitPlaylist = new System.Windows.Forms.TabPage();
            this.lTracks = new System.Windows.Forms.Label();
            this.tDownload = new System.Windows.Forms.TabPage();
            this.lURLs = new System.Windows.Forms.Label();
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
            this.bSpSettings = new System.Windows.Forms.Button();
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
            this.eTracks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eTracks.Location = new System.Drawing.Point(46, 283);
            this.eTracks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eTracks.Multiline = true;
            this.eTracks.Name = "eTracks";
            this.eTracks.Size = new System.Drawing.Size(659, 352);
            this.eTracks.TabIndex = 0;
            // 
            // eSpURL
            // 
            this.eSpURL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.eSpURL.Location = new System.Drawing.Point(242, 87);
            this.eSpURL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eSpURL.Name = "eSpURL";
            this.eSpURL.Size = new System.Drawing.Size(277, 27);
            this.eSpURL.TabIndex = 1;
            // 
            // bGo
            // 
            this.bGo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bGo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bGo.Location = new System.Drawing.Point(387, 645);
            this.bGo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bGo.Name = "bGo";
            this.bGo.Size = new System.Drawing.Size(104, 63);
            this.bGo.TabIndex = 2;
            this.bGo.Text = "GO";
            this.bGo.UseVisualStyleBackColor = true;
            this.bGo.Click += new System.EventHandler(this.bGo_Click);
            // 
            // ePattern
            // 
            this.ePattern.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ePattern.Location = new System.Drawing.Point(242, 125);
            this.ePattern.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ePattern.Name = "ePattern";
            this.ePattern.Size = new System.Drawing.Size(277, 27);
            this.ePattern.TabIndex = 3;
            // 
            // lSpURL
            // 
            this.lSpURL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lSpURL.AutoSize = true;
            this.lSpURL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lSpURL.Location = new System.Drawing.Point(204, 92);
            this.lSpURL.Name = "lSpURL";
            this.lSpURL.Size = new System.Drawing.Size(35, 20);
            this.lSpURL.TabIndex = 4;
            this.lSpURL.Text = "URL";
            // 
            // lPattern
            // 
            this.lPattern.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lPattern.AutoSize = true;
            this.lPattern.Location = new System.Drawing.Point(184, 128);
            this.lPattern.Name = "lPattern";
            this.lPattern.Size = new System.Drawing.Size(55, 20);
            this.lPattern.TabIndex = 5;
            this.lPattern.Text = "Pattern";
            // 
            // lArtist
            // 
            this.lArtist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lArtist.AutoSize = true;
            this.lArtist.Location = new System.Drawing.Point(192, 167);
            this.lArtist.Name = "lArtist";
            this.lArtist.Size = new System.Drawing.Size(44, 20);
            this.lArtist.TabIndex = 7;
            this.lArtist.Text = "Artist";
            // 
            // eArtist
            // 
            this.eArtist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.eArtist.Location = new System.Drawing.Point(242, 164);
            this.eArtist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eArtist.Name = "eArtist";
            this.eArtist.Size = new System.Drawing.Size(277, 27);
            this.eArtist.TabIndex = 6;
            // 
            // lSpExtension
            // 
            this.lSpExtension.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lSpExtension.AutoSize = true;
            this.lSpExtension.Location = new System.Drawing.Point(167, 206);
            this.lSpExtension.Name = "lSpExtension";
            this.lSpExtension.Size = new System.Drawing.Size(72, 20);
            this.lSpExtension.TabIndex = 9;
            this.lSpExtension.Text = "Extension";
            // 
            // cbSpExtension
            // 
            this.cbSpExtension.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSpExtension.FormattingEnabled = true;
            this.cbSpExtension.Location = new System.Drawing.Point(242, 202);
            this.cbSpExtension.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSpExtension.Name = "cbSpExtension";
            this.cbSpExtension.Size = new System.Drawing.Size(138, 28);
            this.cbSpExtension.TabIndex = 10;
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressbar});
            this.statusBar.Location = new System.Drawing.Point(0, 790);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusBar.Size = new System.Drawing.Size(750, 27);
            this.statusBar.TabIndex = 11;
            // 
            // progressbar
            // 
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(114, 19);
            // 
            // lSplitPlaylist
            // 
            this.lSplitPlaylist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lSplitPlaylist.AutoSize = true;
            this.lSplitPlaylist.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lSplitPlaylist.Location = new System.Drawing.Point(274, 21);
            this.lSplitPlaylist.Name = "lSplitPlaylist";
            this.lSplitPlaylist.Size = new System.Drawing.Size(217, 46);
            this.lSplitPlaylist.TabIndex = 12;
            this.lSplitPlaylist.Text = "Split Playlist";
            // 
            // rbURL
            // 
            this.rbURL.AutoSize = true;
            this.rbURL.Checked = true;
            this.rbURL.Location = new System.Drawing.Point(9, 3);
            this.rbURL.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbURL.Name = "rbURL";
            this.rbURL.Size = new System.Drawing.Size(56, 24);
            this.rbURL.TabIndex = 13;
            this.rbURL.TabStop = true;
            this.rbURL.Text = "URL";
            this.rbURL.UseVisualStyleBackColor = true;
            this.rbURL.CheckedChanged += new System.EventHandler(this.rbURL_CheckedChanged);
            // 
            // rbFile
            // 
            this.rbFile.AutoSize = true;
            this.rbFile.Location = new System.Drawing.Point(74, 3);
            this.rbFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbFile.Name = "rbFile";
            this.rbFile.Size = new System.Drawing.Size(53, 24);
            this.rbFile.TabIndex = 14;
            this.rbFile.Text = "File";
            this.rbFile.UseVisualStyleBackColor = true;
            // 
            // pSourceType
            // 
            this.pSourceType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pSourceType.Controls.Add(this.rbFile);
            this.pSourceType.Controls.Add(this.rbURL);
            this.pSourceType.Location = new System.Drawing.Point(387, 202);
            this.pSourceType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pSourceType.Name = "pSourceType";
            this.pSourceType.Size = new System.Drawing.Size(133, 28);
            this.pSourceType.TabIndex = 15;
            // 
            // bOpenFile
            // 
            this.bOpenFile.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.bOpenFile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bOpenFile.Location = new System.Drawing.Point(259, 645);
            this.bOpenFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bOpenFile.Name = "bOpenFile";
            this.bOpenFile.Size = new System.Drawing.Size(121, 63);
            this.bOpenFile.TabIndex = 15;
            this.bOpenFile.Text = "Load Tracks";
            this.bOpenFile.UseVisualStyleBackColor = true;
            this.bOpenFile.Click += new System.EventHandler(this.bOpenFile_Click);
            // 
            // bOpenVideoFile
            // 
            this.bOpenVideoFile.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bOpenVideoFile.Location = new System.Drawing.Point(525, 87);
            this.bOpenVideoFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bOpenVideoFile.Name = "bOpenVideoFile";
            this.bOpenVideoFile.Size = new System.Drawing.Size(33, 27);
            this.bOpenVideoFile.TabIndex = 16;
            this.bOpenVideoFile.Text = "...";
            this.bOpenVideoFile.UseVisualStyleBackColor = true;
            this.bOpenVideoFile.Visible = false;
            this.bOpenVideoFile.Click += new System.EventHandler(this.bOpenVideoFile_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tSplitPlaylist);
            this.tabControl.Controls.Add(this.tDownload);
            this.tabControl.Location = new System.Drawing.Point(0, 49);
            this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(750, 745);
            this.tabControl.TabIndex = 20;
            // 
            // tSplitPlaylist
            // 
            this.tSplitPlaylist.Controls.Add(this.lTracks);
            this.tSplitPlaylist.Controls.Add(this.lSplitPlaylist);
            this.tSplitPlaylist.Controls.Add(this.eTracks);
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
            this.tSplitPlaylist.Location = new System.Drawing.Point(4, 29);
            this.tSplitPlaylist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tSplitPlaylist.Name = "tSplitPlaylist";
            this.tSplitPlaylist.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tSplitPlaylist.Size = new System.Drawing.Size(742, 712);
            this.tSplitPlaylist.TabIndex = 0;
            this.tSplitPlaylist.Text = "Split Playlist";
            this.tSplitPlaylist.UseVisualStyleBackColor = true;
            // 
            // lTracks
            // 
            this.lTracks.AutoSize = true;
            this.lTracks.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lTracks.Location = new System.Drawing.Point(46, 251);
            this.lTracks.Name = "lTracks";
            this.lTracks.Size = new System.Drawing.Size(71, 28);
            this.lTracks.TabIndex = 17;
            this.lTracks.Text = "Tracks";
            // 
            // tDownload
            // 
            this.tDownload.Controls.Add(this.lURLs);
            this.tDownload.Controls.Add(this.button1);
            this.tDownload.Controls.Add(this.button2);
            this.tDownload.Controls.Add(this.cPlaylist);
            this.tDownload.Controls.Add(this.eUrlList);
            this.tDownload.Controls.Add(this.panel1);
            this.tDownload.Controls.Add(this.lDownload);
            this.tDownload.Controls.Add(this.cbDExtension);
            this.tDownload.Controls.Add(this.lDExtension);
            this.tDownload.Location = new System.Drawing.Point(4, 29);
            this.tDownload.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tDownload.Name = "tDownload";
            this.tDownload.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tDownload.Size = new System.Drawing.Size(742, 712);
            this.tDownload.TabIndex = 1;
            this.tDownload.Text = "Download";
            this.tDownload.UseVisualStyleBackColor = true;
            // 
            // lURLs
            // 
            this.lURLs.AutoSize = true;
            this.lURLs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lURLs.Location = new System.Drawing.Point(40, 140);
            this.lURLs.Name = "lURLs";
            this.lURLs.Size = new System.Drawing.Size(58, 28);
            this.lURLs.TabIndex = 23;
            this.lURLs.Text = "URLs";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(375, 641);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 63);
            this.button1.TabIndex = 21;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(248, 641);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 63);
            this.button2.TabIndex = 22;
            this.button2.Text = "Load URLs";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cPlaylist
            // 
            this.cPlaylist.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cPlaylist.AutoSize = true;
            this.cPlaylist.Location = new System.Drawing.Point(530, 94);
            this.cPlaylist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cPlaylist.Name = "cPlaylist";
            this.cPlaylist.Size = new System.Drawing.Size(77, 24);
            this.cPlaylist.TabIndex = 20;
            this.cPlaylist.Text = "Playlist";
            this.cPlaylist.UseVisualStyleBackColor = true;
            // 
            // eUrlList
            // 
            this.eUrlList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eUrlList.Location = new System.Drawing.Point(40, 172);
            this.eUrlList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eUrlList.Multiline = true;
            this.eUrlList.Name = "eUrlList";
            this.eUrlList.Size = new System.Drawing.Size(659, 461);
            this.eUrlList.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.Controls.Add(this.rbAudio);
            this.panel1.Controls.Add(this.rbVideo);
            this.panel1.Location = new System.Drawing.Point(370, 90);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 31);
            this.panel1.TabIndex = 18;
            // 
            // rbAudio
            // 
            this.rbAudio.AutoSize = true;
            this.rbAudio.Checked = true;
            this.rbAudio.Location = new System.Drawing.Point(5, 3);
            this.rbAudio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbAudio.Name = "rbAudio";
            this.rbAudio.Size = new System.Drawing.Size(70, 24);
            this.rbAudio.TabIndex = 14;
            this.rbAudio.TabStop = true;
            this.rbAudio.Text = "Audio";
            this.rbAudio.UseVisualStyleBackColor = true;
            // 
            // rbVideo
            // 
            this.rbVideo.AutoSize = true;
            this.rbVideo.Location = new System.Drawing.Point(75, 3);
            this.rbVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbVideo.Name = "rbVideo";
            this.rbVideo.Size = new System.Drawing.Size(69, 24);
            this.rbVideo.TabIndex = 13;
            this.rbVideo.Text = "Video";
            this.rbVideo.UseVisualStyleBackColor = true;
            this.rbVideo.CheckedChanged += new System.EventHandler(this.rbVideo_CheckedChanged);
            // 
            // lDownload
            // 
            this.lDownload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lDownload.AutoSize = true;
            this.lDownload.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lDownload.Location = new System.Drawing.Point(279, 23);
            this.lDownload.Name = "lDownload";
            this.lDownload.Size = new System.Drawing.Size(184, 46);
            this.lDownload.TabIndex = 17;
            this.lDownload.Text = "Download";
            // 
            // cbDExtension
            // 
            this.cbDExtension.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbDExtension.FormattingEnabled = true;
            this.cbDExtension.Location = new System.Drawing.Point(225, 90);
            this.cbDExtension.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDExtension.Name = "cbDExtension";
            this.cbDExtension.Size = new System.Drawing.Size(138, 28);
            this.cbDExtension.TabIndex = 16;
            // 
            // lDExtension
            // 
            this.lDExtension.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lDExtension.AutoSize = true;
            this.lDExtension.Location = new System.Drawing.Point(152, 95);
            this.lDExtension.Name = "lDExtension";
            this.lDExtension.Size = new System.Drawing.Size(72, 20);
            this.lDExtension.TabIndex = 15;
            this.lDExtension.Text = "Extension";
            // 
            // bSpSettings
            // 
            this.bSpSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bSpSettings.FlatAppearance.BorderSize = 0;
            this.bSpSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSpSettings.Image = ((System.Drawing.Image)(resources.GetObject("bSpSettings.Image")));
            this.bSpSettings.Location = new System.Drawing.Point(702, 8);
            this.bSpSettings.Name = "bSpSettings";
            this.bSpSettings.Size = new System.Drawing.Size(44, 41);
            this.bSpSettings.TabIndex = 17;
            this.bSpSettings.UseVisualStyleBackColor = true;
            this.bSpSettings.Click += new System.EventHandler(this.bSpSettings_Click);
            // 
            // SplitPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 817);
            this.Controls.Add(this.bSpSettings);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusBar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private System.Windows.Forms.Button bSpSettings;
        private System.Windows.Forms.Label lTracks;
        private System.Windows.Forms.Label lURLs;
    }
}

