using System;
using System.Windows.Forms;

namespace SplitPlaylist.forms {
    public partial class Settings : Form {
        public string AudioFormat { get => Properties.Settings.Default.AudioFormat; }
        public string VideoFormat { get => Properties.Settings.Default.VideoFormat; }
        public string YTCommand { 
            get {
                string ret = Properties.Settings.Default.YTCommand;
                if (String.IsNullOrWhiteSpace(ret))
                    ret = "yt-dlp";
                return ret;
            } 
        }
        public string FFCommand {
            get {
                string ret = Properties.Settings.Default.FFCommand;
                if (String.IsNullOrWhiteSpace(ret))
                    ret = "ffmpeg";
                return ret;
            }
        }
        public bool TimeOrdering { get => Properties.Settings.Default.TimeOrdering; }
        public bool DeleteExistingTracks { get => Properties.Settings.Default.DeleteExistingTracks; }
        public bool IncludeMetadata { get => Properties.Settings.Default.IncludeMetadata; }
        public bool IndexFileNames { get => Properties.Settings.Default.IndexFileNames; }
        public Settings() {
            InitializeComponent();
            MinimumSize = Size;
            CommonFormProc.InitAudioCombo(cbAudioFormat, AudioFormat);
            CommonFormProc.InitVideoCombo(cbVideoFormat, VideoFormat);
            eYTCom.Text = YTCommand;
            eFFCom.Text = FFCommand;
            cUseTimeOrdering.Checked = TimeOrdering;
            cDeleteExisting.Checked = DeleteExistingTracks;
            cMetadata.Checked = IncludeMetadata;
            cIndexFiles.Checked = IndexFileNames;
            tooltip.SetToolTip(cbAudioFormat, "Sets the default audio file extesion - can be changed during operation");
            tooltip.SetToolTip(cbVideoFormat, "Sets the default video file extesion - can be changed during operation");
            tooltip.SetToolTip(cDeleteExisting, "If any files generated from splitting are already present, ticking this will replace the old files with the newly generated files");
            tooltip.SetToolTip(cUseTimeOrdering, "If the tracks are not orderd in the list by time (unlikely), ticking this will sort the list by the start time of each track (highly recommended)");
            tooltip.SetToolTip(eYTCom, "Defaults to the system path command \"yt_dlp\". Please ensure this is not blocked on your antivirus");
            tooltip.SetToolTip(eFFCom, "Defaults to the system path command \"ffmpeg\". Please ensure this is not blocked on your antivirus");
        }
        private void bOK_Click(object sender, EventArgs e) {
            Properties.Settings.Default.AudioFormat = cbAudioFormat.Text;
            Properties.Settings.Default.VideoFormat = cbVideoFormat.Text;
            Properties.Settings.Default.YTCommand = eYTCom.Text;
            Properties.Settings.Default.FFCommand = eFFCom.Text;
            Properties.Settings.Default.TimeOrdering = cUseTimeOrdering.Checked;
            Properties.Settings.Default.DeleteExistingTracks = cDeleteExisting.Checked;
            Properties.Settings.Default.IncludeMetadata = cMetadata.Checked;
            Properties.Settings.Default.IndexFileNames = cIndexFiles.Checked;
            Properties.Settings.Default.Save();
        }
    }
}
