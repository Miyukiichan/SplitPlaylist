using System.Diagnostics;

namespace SplitPlaylist {
    class Downloader {
        public bool IsPlaylist { get; set; }
        public required string Extension { get; set; }
        public bool IsAudio { get; set; } 
        public required string[] URLs { get; set; }
        public required string PathToSaveTo { get; set; }
        public string YTCommand { get; set; } = "yt-dlp";
        public List<Process> Download() {
            //AddDirectorySecurity(PathToSaveTo, "Users", FileSystemRights.FullControl, AccessControlType.Allow);
            string format = "\\%(title)s.%(ext)s";
            if (IsPlaylist) {
                format = "\\%(playlist)s\\%(playlist_index)s %(title)s.%(ext)s";
            }
            string args = $"-o \"{PathToSaveTo}{format}\"";
            if (!IsPlaylist) {
                args += " --no-playlist";
            }
            if (IsAudio) {
                args += $" -x --audio-format {Extension}";
            }
            else {
                args += $" --format {Extension}";
            }
            var processes = new List<Process>();
            foreach (var url in URLs) {
                var process = new Process()
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = YTCommand,
                        Arguments = $"{args} {url}",
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardOutput = false,
                        RedirectStandardInput = true
                    }
                };
                process.Start();
                processes.Add(process);
            }
            return processes;
        }
    }
}
