using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace SplitPlaylist
{
    public partial class SplitPlaylist : Form
    {
        public SplitPlaylist() {
            InitializeComponent();
            InitExtensionsCombo(cbSpExtension);
            InitExtensionsCombo(cbDExtension);
            progressbar.Visible = false;
            progressbar.Minimum = 0;
            MinimumSize = Size;
            MaximumSize = Size;
        }
        private void InitExtensionsCombo(ComboBox cb, List<string>? ex = null, string def = "mp3") {
            if (ex == null) {
                ex = new List<string>();
                string[] e = { "aac", "flac", "mp3", "m4a", "opus", "vorbis", "wav" };
                ex.AddRange(e);
            }
            cb.Items.Clear();
            ex.Sort();
            cb.Items.AddRange(ex.ToArray());
            cb.SelectedItem = def;
        }
        private string GetSavePath() {
            var saveDialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                Title = "Select where to save to"
            };
            if (saveDialog.ShowDialog() != CommonFileDialogResult.Ok) return "";
            return saveDialog.FileName;
        }
        private string[] GetLines(TextBox e) {
            var ret = e.Lines;
            if (!ret.Any()) {
                ret = OpenFile();
            }
            return ret;
        }
        private void bGo_Click(object sender, EventArgs e)
        {
            try {
                string ytCom = eYTCom.Text;
                string ffCom = eFFCom.Text;
                if (ytCom == "") {
                    ytCom = "yt-dlp";
                }
                if (ffCom == "") {
                    ffCom = "ffmpeg";
                }
                Splitter splitter = new()
                {
                    URL = eSpURL.Text,
                    Artist = eArtist.Text,
                    Pattern = ePattern.Text,
                    Extension = cbSpExtension.Text,
                    IsURL = rbURL.Checked,
                    DeleteExisting = cDeleteExisting.Checked,
                    TimeOrdering = cUseTimeOrdering.Checked,
                    YTCommand = ytCom,
                    FFCommand = ffCom
                };
                
                //Prompt for file names
                splitter.Tracks = GetLines(eTracks);
                if (!splitter.Tracks.Any()) return;
                splitter.PathToSaveTo = GetSavePath();
                if (String.IsNullOrWhiteSpace(splitter.PathToSaveTo)) return;
               
                //Main playlist processing
                Cursor = Cursors.WaitCursor;
                List<Process> processes = new();
                try {
                    processes = splitter.ProcessTracks();
                    progressbar.Maximum = processes.Count;
                    progressbar.Visible = true;
                    progressbar.Visible = true;
                    List<Process> finished = new();
                    while (processes.Count > 0) {
                        foreach (var process in processes) {
                            try {
                                var code = process.ExitCode;
                            }
                            catch {
                                continue;
                            }
                            processes.Remove(process);
                            finished.Add(process);
                            progressbar.Value = finished.Count;
                            break;
                        }
                    }
                }
                finally {
                    try {
                        Cursor = Cursors.Default;
                        splitter.Cleanup(processes);
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
                progressbar.Value = progressbar.Minimum;
                progressbar.Visible = false;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void rbURL_CheckedChanged(object sender, EventArgs e) {
            lSpURL.Text = rbURL.Checked ? "URL" : "File";
            bOpenVideoFile.Visible = !rbURL.Checked;
        }

        private void OpenLines(TextBox e) {
            var lines = OpenFile();
            if (lines.Any())
                e.Lines = lines;
        }

        private void bOpenFile_Click(object sender, EventArgs e) {
            OpenLines(eTracks);
        }
        private static string[] OpenFile() {
            string[] ret = Array.Empty<string>();
            var fileDialog = new OpenFileDialog
            {
                Title = "Select a list of tracks"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
                ret = File.ReadAllLines(fileDialog.FileName);
            return ret;
        }

        private void bOpenVideoFile_Click(object sender, EventArgs e) {
            var fileDialog = new OpenFileDialog
            {
                Title = "Select a list of tracks"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
                eSpURL.Text = fileDialog.FileName;
        }

        private void rbVideo_CheckedChanged(object sender, EventArgs e) {
            if (rbVideo.Checked) {
                var ex = new List<string>();
                string[] eArr = { "mp4", "m4a", "webm", "mkv", "gif" };
                ex.AddRange(eArr);
                InitExtensionsCombo(cbDExtension, ex, "mp4");
            }
            else {
                InitExtensionsCombo(cbDExtension);
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            OpenLines(eUrlList);
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                var downloader = new Downloader
                {
                    IsAudio = rbAudio.Checked,
                    IsPlaylist = cPlaylist.Checked,
                    Extension = cbDExtension.Text,
                    URLs = eUrlList.Lines,
                    YTCommand = "yt-dlp"
                };
                downloader.URLs = GetLines(eUrlList);
                if (!downloader.URLs.Any()) return;
                downloader.PathToSaveTo = GetSavePath();
                if (String.IsNullOrWhiteSpace(downloader.PathToSaveTo)) return;
                try {
                    Cursor = Cursors.WaitCursor;
                    downloader.Download();
                }
                finally {
                    Cursor = Cursors.Default;
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
