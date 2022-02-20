using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Linq;
using System.IO;
using System;

namespace SplitPlaylist.forms {
    static class CommonFormProc {
        static public void InitVideoCombo(ComboBox cb, string def) {
            string[] ex = { "mp4", "m4a", "webm", "mkv", "gif" };
            var e = new List<string>();
            e.AddRange(ex);
            InitExtensionCombo(cb, e, def);
        }
        static public void InitAudioCombo(ComboBox cb, string def) {
            string[] ex = { "aac", "flac", "mp3", "m4a", "opus", "vorbis", "wav" };
            var e = new List<string>();
            e.AddRange(ex);
            InitExtensionCombo(cb, e, def);
        }
        static public void InitExtensionCombo(ComboBox cb, List<string> ex, string def) {
            cb.Items.Clear();
            ex.Sort();
            cb.Items.AddRange(ex.ToArray());
            cb.SelectedItem = def;
        }
        public static string GetSavePath() {
            var saveDialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true,
                Title = "Select where to save to"
            };
            if (saveDialog.ShowDialog() != CommonFileDialogResult.Ok) return "";
            return saveDialog.FileName;
        }
        public static string[] GetLines(TextBox e) {
            var ret = e.Lines;
            if (!ret.Any()) {
                ret = OpenFile();
            }
            return ret;
        }
        public static string[] OpenFile() {
            string[] ret = Array.Empty<string>();
            var fileDialog = new OpenFileDialog
            {
                Title = "Select a list of tracks"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
                ret = File.ReadAllLines(fileDialog.FileName);
            return ret;
        }
        public static void OpenLines(TextBox e) {
            var lines = OpenFile();
            if (lines.Any())
                e.Lines = lines;
        }
    }
}
