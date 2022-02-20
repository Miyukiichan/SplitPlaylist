using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using SplitPlaylist.src;

namespace SplitPlaylist.forms
{
    public partial class SplitPlaylist : Form
    {
        Settings _settings;
        public SplitPlaylist() {
            InitializeComponent();
            _settings = new Settings();
            CommonFormProc.InitAudioCombo(cbSpExtension, _settings.AudioFormat);
            CommonFormProc.InitAudioCombo(cbDExtension, _settings.AudioFormat);
            progressbar.Visible = false;
            progressbar.Minimum = 0;
            MinimumSize = Size;
        }
        private void bGo_Click(object sender, EventArgs e)
        {
            try {
                src.Splitter splitter = new()
                {
                    URL = eSpURL.Text,
                    Artist = eArtist.Text,
                    Pattern = ePattern.Text,
                    Extension = cbSpExtension.Text,
                    IsURL = rbURL.Checked,
                    DeleteExisting = _settings.DeleteExistingTracks,
                    TimeOrdering = _settings.TimeOrdering,
                    YTCommand = _settings.YTCommand,
                    FFCommand = _settings.FFCommand
                };
                
                //Prompt for file names
                splitter.Tracks = CommonFormProc.GetLines(eTracks);
                if (!splitter.Tracks.Any()) return;
                splitter.PathToSaveTo = CommonFormProc.GetSavePath();
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

        private void bOpenFile_Click(object sender, EventArgs e) {
            CommonFormProc.OpenLines(eTracks);
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
            if (rbVideo.Checked) CommonFormProc.InitVideoCombo(cbDExtension, _settings.VideoFormat);
            else CommonFormProc.InitAudioCombo(cbDExtension, _settings.AudioFormat);
        }

        private void button2_Click(object sender, EventArgs e) {
            CommonFormProc.OpenLines(eUrlList);
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
                var downloader = new Downloader
                {
                    IsAudio = rbAudio.Checked,
                    IsPlaylist = cPlaylist.Checked,
                    Extension = cbDExtension.Text,
                    URLs = eUrlList.Lines,
                    YTCommand = _settings.YTCommand
                };
                downloader.URLs = CommonFormProc.GetLines(eUrlList);
                if (!downloader.URLs.Any()) return;
                downloader.PathToSaveTo = CommonFormProc.GetSavePath();
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

        private void bSpSettings_Click(object sender, EventArgs e) {
            _settings.ShowDialog();
        }
    }
}
