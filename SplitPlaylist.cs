using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            string[] Extensions = { "aac", "flac", "mp3", "m4a", "opus", "vorbis", "wav" };
            cbExtension.Items.AddRange(Extensions);
            cbExtension.SelectedItem = "mp3";
            progressbar.Visible = false;
            progressbar.Minimum = 0;
            MinimumSize = Size;
            MaximumSize = Size;
        }

        private void bGo_Click(object sender, EventArgs e)
        {
            Controller controller = new()
            {
                URL = eURL.Text,
                Artist = eArtist.Text,
                Pattern = ePattern.Text,
                Tracks = eTracks.Lines,
                Extension = cbExtension.Text,
                IsURL = rbURL.Checked
            };
            //Prompt for file names
            if (!controller.Tracks.Any()) {
                controller.Tracks = OpenFile();
                if (!controller.Tracks.Any())
                    return;
            }
            var saveDialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                Title = "Select where to save the playlist to"
            };
            if (saveDialog.ShowDialog() != CommonFileDialogResult.Ok)
                return;
            controller.PathToSaveTo = saveDialog.FileName;
            //Main playlist processing
            Cursor = Cursors.WaitCursor;
            List<Process> processes = new List<Process>();
            try {
                processes = controller.ProcessTracks();
                progressbar.Maximum = processes.Count;
                progressbar.Visible = true;
                progressbar.Visible = true;
                List<Process> finished = new List<Process>();
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
                    controller.Cleanup(processes);
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            progressbar.Value = progressbar.Minimum;
            progressbar.Visible = false;
        }

        private void rbURL_CheckedChanged(object sender, EventArgs e) {
            lURL.Text = rbURL.Checked ? "URL" : "File";
            bOpenVideoFile.Visible = !rbURL.Checked;
        }

        private void bOpenFile_Click(object sender, EventArgs e) {
            eTracks.Lines = OpenFile();
        }
        private string[] OpenFile() {
            string[] ret = { };
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
                eURL.Text = fileDialog.FileName;
        }
    }
}
