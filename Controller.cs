using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Security.Permissions;

namespace SplitPlaylist {
    public class Track {
        public string Duration() {
            if (String.IsNullOrWhiteSpace(EndTime))
                return "00:00";
            return (EndTimeTime - StartTimeTime).ToString();
        }
        protected DateTime StartTimeTime;
        protected DateTime EndTimeTime;
        public string TrackName { get; set; }
        public string Artist { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public void SetVar(string VarName, string Value) {
            switch (VarName) {
                case "$TRACK":
                    TrackName = Value;
                    break;
                case "$END":
                    EndTime = Value;
                    break;
                case "$START":
                    StartTime = Value;
                    break;
                case "$ARTIST":
                    Artist = Value;
                    break;
                default:
                    throw new Exception($"Unrecognised variable name '{VarName}'");
            }
            //Check correct time format while parsing
            DateTime dateTime = new DateTime();
            switch (VarName) {
                case "$END":
                case "$START": {
                    var format = "mm:ss";
                    if (Value.Count(c => c == ':') == 2)
                        format = "HH:mm:ss";
                    dateTime = DateTime.ParseExact(Value, format, CultureInfo.InvariantCulture);
                    break;
                }
            }
            switch (VarName) {
                case "$END":
                    EndTimeTime = dateTime;
                    break;
                case "$START":
                    StartTimeTime = dateTime;
                    break;
            }
        }
    }
    class Controller {
        readonly string[] Variables = { "$TRACK", "$END", "$START", "$ARTIST" };
        public string Artist { get; set; }
        public string Pattern { get; set; }
        public string URL { get; set; }
        public string PathToSaveTo { get; set; }
        public string SavePath { get; set; }
        public string Extension { get; set; }
        public string[] Tracks { get; set; }
        public bool IsURL { get; set; }
        public List<Process> ProcessTracks() {
            if (String.IsNullOrWhiteSpace(URL) || !Uri.IsWellFormedUriString(URL, UriKind.Absolute))
                throw new Exception("Must provide URL");
            var artists = Pattern.Contains("$ARTIST");
            var end = Pattern.Contains("$END");
            if (!(Pattern.Contains("$TRACK") && Pattern.Contains("$START")))
                throw new Exception("Must provide TRACK (track name) and START (start time) in the pattern");
            if (IsURL) {
                //Download the video as audio
                SavePath = Path.Combine(PathToSaveTo, $"{new Random().Next()}.{Extension}");
                var args = $"-x --audio-format {Extension} -o {SavePath} {URL}";
                var StartInfo = new ProcessStartInfo()
                {
                    FileName = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "youtube-dl.exe"),
                    Arguments = args
                };
                Process process = new Process();
                process.StartInfo = StartInfo;
                process.Start();
                process.WaitForExit();
                switch (process.ExitCode) {
                    case 1:
                        throw new Exception("Invalid video URL");
                    case 2:
                        throw new Exception("Something went wrong with youtube-dl");
                }
            }
            else {
                SavePath = URL;
            }
            //Parse tokens from pattern - separate variables from bits of text, variables start with '$' and end with' '
            var tokens = new List<String>();
            var variable = false;
            foreach (var c in Pattern) {
                if (c == '$' && !variable) {
                    tokens.Add("");
                    variable = true;
                }
                else if (c == ' ' && variable) {
                    tokens.Add("");
                    variable = false;
                }
                if (!tokens.Any())
                    tokens.Add("");
                tokens[^1] += c;
            }
            //Go through all the tokens and skip the bits of consistent text such as '-' chars and set track properties from the variables
            var trackList = new List<Track>();
            foreach (var t in Tracks) {
                var trackObj = new Track();
                var track = t;
                for (var i = 0; i < tokens.Count; i++) {
                    var token = tokens[i].ToUpper(); ;
                    var next = i == tokens.Count - 1 ? "" : tokens[i + 1];
                    var readTo = -1;
                    if (next == "")
                        readTo = track.Length - 1;
                    else {
                        if (token.StartsWith('$'))
                            readTo = track.IndexOf(' ') - 1;
                        else
                            readTo = token.Length - 1;
                    }
                    if (readTo < 0)
                        throw new Exception($"Error parsing line [{track}] token error");
                    var value = "";
                    if (Variables.Contains(token)) {
                        for (var j = 0; j <= readTo; j++)
                            value += track[j];
                        trackObj.SetVar(token, value);
                    }
                    track = track.Remove(0, readTo + 1);
                }
                trackList.Add(trackObj);
            }
            //The final track doesn't need an end time - will just continue to the end of the file
            if (!end) {
                for (var i = 0; i < trackList.Count; i++) {
                    if (i < trackList.Count - 1)
                        trackList[i].SetVar("$END", trackList[i + 1].StartTime);
                }
            }
            //Launch all the ffmpeg processes
            var processes = new List<Process>();
            for (var i = 0; i < trackList.Count; i++) {
                var track = trackList[i];
                var args = $"-i {SavePath} -ss {track.StartTime} -n";
                if (!String.IsNullOrWhiteSpace(track.EndTime))
                    args += $" -t {track.Duration()}";
                var filename = $"{i + 1} - {track.TrackName}.{Extension}";
                args += $" \"{Path.Combine(PathToSaveTo, filename)}\"";
                var  process = new Process()
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "ffmpeg.exe"),
                        Arguments = args,
                        CreateNoWindow = true
                    }
                };
                process.Start();
                processes.Add(process);
            }
            return processes;
        }
        public void Cleanup(List<Process> processes) {
            foreach (var process in processes) {
                try {
                    process.Kill();
                }
                catch {
                    continue;
                }
            }
            FileIOPermission file = new FileIOPermission(PermissionState.None);
            file.AllLocalFiles = FileIOPermissionAccess.AllAccess;
            file.Demand();
            File.SetAttributes(SavePath, FileAttributes.Normal);
            File.Delete(SavePath);
        }
    }
}
