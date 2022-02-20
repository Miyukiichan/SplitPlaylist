namespace SplitPlaylist.forms {
    partial class Settings {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.eYTCom = new System.Windows.Forms.TextBox();
            this.eFFCom = new System.Windows.Forms.TextBox();
            this.lYTCom = new System.Windows.Forms.Label();
            this.lFFCom = new System.Windows.Forms.Label();
            this.cUseTimeOrdering = new System.Windows.Forms.CheckBox();
            this.cDeleteExisting = new System.Windows.Forms.CheckBox();
            this.cbAudioFormat = new System.Windows.Forms.ComboBox();
            this.lAudioFormat = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bOK = new System.Windows.Forms.Button();
            this.tooltip = new System.Windows.Forms.ToolTip(this.components);
            this.cbVideoFormat = new System.Windows.Forms.ComboBox();
            this.lVideoFormat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eYTCom
            // 
            this.eYTCom.Location = new System.Drawing.Point(167, 86);
            this.eYTCom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eYTCom.Name = "eYTCom";
            this.eYTCom.Size = new System.Drawing.Size(335, 27);
            this.eYTCom.TabIndex = 28;
            // 
            // eFFCom
            // 
            this.eFFCom.Location = new System.Drawing.Point(167, 121);
            this.eFFCom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.eFFCom.Name = "eFFCom";
            this.eFFCom.Size = new System.Drawing.Size(335, 27);
            this.eFFCom.TabIndex = 29;
            // 
            // lYTCom
            // 
            this.lYTCom.AutoSize = true;
            this.lYTCom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lYTCom.Location = new System.Drawing.Point(40, 89);
            this.lYTCom.Name = "lYTCom";
            this.lYTCom.Size = new System.Drawing.Size(120, 20);
            this.lYTCom.TabIndex = 30;
            this.lYTCom.Text = "yt-dlp command";
            // 
            // lFFCom
            // 
            this.lFFCom.AutoSize = true;
            this.lFFCom.Location = new System.Drawing.Point(32, 124);
            this.lFFCom.Name = "lFFCom";
            this.lFFCom.Size = new System.Drawing.Size(129, 20);
            this.lFFCom.TabIndex = 31;
            this.lFFCom.Text = "ffmpeg command";
            // 
            // cUseTimeOrdering
            // 
            this.cUseTimeOrdering.AutoSize = true;
            this.cUseTimeOrdering.Checked = true;
            this.cUseTimeOrdering.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cUseTimeOrdering.Location = new System.Drawing.Point(167, 156);
            this.cUseTimeOrdering.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cUseTimeOrdering.Name = "cUseTimeOrdering";
            this.cUseTimeOrdering.Size = new System.Drawing.Size(155, 24);
            this.cUseTimeOrdering.TabIndex = 27;
            this.cUseTimeOrdering.Text = "Use Time Ordering";
            this.cUseTimeOrdering.UseVisualStyleBackColor = true;
            // 
            // cDeleteExisting
            // 
            this.cDeleteExisting.AutoSize = true;
            this.cDeleteExisting.Location = new System.Drawing.Point(328, 156);
            this.cDeleteExisting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cDeleteExisting.Name = "cDeleteExisting";
            this.cDeleteExisting.Size = new System.Drawing.Size(174, 24);
            this.cDeleteExisting.TabIndex = 26;
            this.cDeleteExisting.Text = "Delete Existing Tracks";
            this.cDeleteExisting.UseVisualStyleBackColor = true;
            // 
            // cbAudioFormat
            // 
            this.cbAudioFormat.FormattingEnabled = true;
            this.cbAudioFormat.Location = new System.Drawing.Point(167, 13);
            this.cbAudioFormat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAudioFormat.Name = "cbAudioFormat";
            this.cbAudioFormat.Size = new System.Drawing.Size(138, 28);
            this.cbAudioFormat.TabIndex = 25;
            // 
            // lAudioFormat
            // 
            this.lAudioFormat.AutoSize = true;
            this.lAudioFormat.Location = new System.Drawing.Point(61, 17);
            this.lAudioFormat.Name = "lAudioFormat";
            this.lAudioFormat.Size = new System.Drawing.Size(100, 20);
            this.lAudioFormat.TabIndex = 24;
            this.lAudioFormat.Text = "Audio Format";
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(310, 210);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(94, 29);
            this.bCancel.TabIndex = 32;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // bOK
            // 
            this.bOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bOK.Location = new System.Drawing.Point(410, 210);
            this.bOK.Name = "bOK";
            this.bOK.Size = new System.Drawing.Size(94, 29);
            this.bOK.TabIndex = 33;
            this.bOK.Text = "OK";
            this.bOK.UseVisualStyleBackColor = true;
            this.bOK.Click += new System.EventHandler(this.bOK_Click);
            // 
            // cbVideoFormat
            // 
            this.cbVideoFormat.FormattingEnabled = true;
            this.cbVideoFormat.Location = new System.Drawing.Point(167, 49);
            this.cbVideoFormat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbVideoFormat.Name = "cbVideoFormat";
            this.cbVideoFormat.Size = new System.Drawing.Size(138, 28);
            this.cbVideoFormat.TabIndex = 35;
            // 
            // lVideoFormat
            // 
            this.lVideoFormat.AutoSize = true;
            this.lVideoFormat.Location = new System.Drawing.Point(61, 53);
            this.lVideoFormat.Name = "lVideoFormat";
            this.lVideoFormat.Size = new System.Drawing.Size(99, 20);
            this.lVideoFormat.TabIndex = 34;
            this.lVideoFormat.Text = "Video Format";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 251);
            this.Controls.Add(this.cbVideoFormat);
            this.Controls.Add(this.lVideoFormat);
            this.Controls.Add(this.bOK);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.eYTCom);
            this.Controls.Add(this.eFFCom);
            this.Controls.Add(this.lYTCom);
            this.Controls.Add(this.lFFCom);
            this.Controls.Add(this.cUseTimeOrdering);
            this.Controls.Add(this.cDeleteExisting);
            this.Controls.Add(this.cbAudioFormat);
            this.Controls.Add(this.lAudioFormat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox eYTCom;
        private System.Windows.Forms.TextBox eFFCom;
        private System.Windows.Forms.Label lYTCom;
        private System.Windows.Forms.Label lFFCom;
        private System.Windows.Forms.CheckBox cUseTimeOrdering;
        private System.Windows.Forms.CheckBox cDeleteExisting;
        private System.Windows.Forms.ComboBox cbAudioFormat;
        private System.Windows.Forms.Label lAudioFormat;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bOK;
        private System.Windows.Forms.ToolTip tooltip;
        private System.Windows.Forms.ComboBox cbVideoFormat;
        private System.Windows.Forms.Label lVideoFormat;
    }
}