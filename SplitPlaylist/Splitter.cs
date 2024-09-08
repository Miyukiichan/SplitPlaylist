using System.Diagnostics;
using System.Globalization;

namespace SplitPlaylist {
    public class Track {
        public string Duration() {
            if (String.IsNullOrWhiteSpace(EndTime))
                return "00:00";
            return (EndTimeTime - StartTimeTime).ToString();
        }
        public DateTime StartTimeTime { get; set; }
        public DateTime EndTimeTime { get; set; }
        public string? TrackName { get; set; }
        public string? StartTime { get; set; }
        public string? EndTime { get; set; }
        public string? Path { get; set; }   
        public void SetVar(string VarName, string? Value) {
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
                default:
                    throw new Exception($"Unrecognised variable name '{VarName}'");
            }
            if (string.IsNullOrWhiteSpace(Value)) return;
            //Check correct time format while parsing
            DateTime dateTime = new();
            switch (VarName) {
                case "$END":
                case "$START": {
                    var spl = Value.Split(":");
                    var format = "mm:ss";
                    if (spl.Length == 3)
                        format = "HH:mm:ss";
                    //Sometimes the starting time value (hr or min) will not have a leading 0
                    //Need to alter the format accordingly to avoid a datetime parsing error
                    var fSplit = format.Split(":");
                    for (int i = 0; i < spl.Length; i++) {
                        fSplit[i] = new String(fSplit[i][0], spl[i].Length);
                    }
                    format = String.Join(":", fSplit);
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
    class Splitter {
        readonly string[] Variables = { "$TRACK", "$END", "$START" };
        public required string Pattern { get; set; }
        public required string URL { get; set; }
        public required string PathToSaveTo { get; set; }
        public required string PlaylistName { get; set; }
        public string? SavePath { get; set; }
        public required string Extension { get; set; }
        public required string[] Tracks { get; set; }
        public required bool IsURL { get; set; } = true;
        public bool DeleteExisting { get; set; } = true;
        public bool TimeOrdering { get; set; } = true;
        public required string YTCommand { get; set; }
        public required string FFCommand { get; set; }
        public bool IndexFileNames { get; set; }
        public List<Track>? TrackList { get; set; }
        public List<Process> ProcessTracks() {
            TrackList = new List<Track>();
            if (!Directory.Exists(PathToSaveTo))
                Directory.CreateDirectory(PathToSaveTo);
            var path = Path.Combine(PathToSaveTo, PlaylistName);
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
            if (string.IsNullOrWhiteSpace(URL) || (!Uri.IsWellFormedUriString(URL, UriKind.Absolute) && IsURL))
                throw new Exception("Must provide URL");
            var end = Pattern.Contains("$END");
            if (!(Pattern.Contains("$TRACK") && Pattern.Contains("$START")))
                throw new Exception("Must provide TRACK (track name) and START (start time) in the pattern");
            //Permissions
            //AddDirectorySecurity(PathToSaveTo, "Users", FileSystemRights.FullControl, AccessControlType.Allow);        
            if (IsURL) {
                //Download the video as audio
                //TODO use temp location
                SavePath = Path.Combine(PathToSaveTo, $"{new Random().Next()}.{Extension}");
                var args = $"-x --audio-format {Extension} -o \"{SavePath}\" {URL}";
                var StartInfo = new ProcessStartInfo()
                {
                    FileName = YTCommand,
                    Arguments = args,
                    CreateNoWindow = true,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                };
                Process process = new()
                {
                    StartInfo = StartInfo
                };
                process.Start();
                process.WaitForExit();
                switch (process.ExitCode) {
                    case 1:
                        throw new Exception("Invalid video URL");
                    case 2:
                        throw new Exception("Something went wrong with YouTube download");
                }
                if (!File.Exists(SavePath))
                    throw new Exception("Something went wrong with YouTube download");
            }
            else {
                SavePath = URL;
            }
            //Parse tokens from pattern - separate variables from bits of text, variables start with '$'
            var tokens = new List<string>();
            var variable = false;
            foreach (var c in Pattern) {
                if (c == '$' && !variable) {
                    tokens.Add("");
                    variable = true;
                }
                //Check if any var look like the current var with the next char - if not then stop considering it a var and go to the next token 
                else if (variable && (!Variables.Where(t => t.Contains(tokens[^1] + c)).Any())) {
                    tokens.Add("");
                    variable = false;
                }
                if (!tokens.Any())
                    tokens.Add("");
                tokens[^1] += c;
            }
            //Go through all the tokens and skip the bits of consistent text such as '-' chars and set track properties from the variables
            TrackList = new List<Track>();
            foreach (var t in Tracks) {
                var trackObj = new Track();
                var track = t;
                for (var i = 0; i < tokens.Count; i++) {
                    var token = tokens[i].ToUpper(); 
                    var next = i == tokens.Count - 1 ? "" : tokens[i + 1];
                    var tokenEnd = 1;
                    if (next == " ") {
                        if (!track.Contains('"'))
                            throw new Exception("Track names must be enclosed in quotes");
                        //If we leave next as a space, we will only read the first word of the quote enclosed string
                        if (track[0] == '"') {
                            next = "\"";
                            track = track.Remove(0, 1);
                            tokenEnd = 2;
                        }
                    }
                    var readTo = -1;
                    if (next == "")
                        readTo = track.Length - 1;
                    else {
                        if (token.StartsWith('$'))
                            readTo = track.IndexOf(next) - 1;
                        else
                            readTo = token.Length - 1;
                    }
                    if (readTo < 0)
                        throw new Exception($"Error parsing line [{track}] token error");
                    var value = "";
                    if (Variables.Contains(token)) {
                        for (var j = 0; j <= readTo; j++) {
                            if (track[j] != '"')
                                value += track[j];
                        }
                        trackObj.SetVar(token, value.Trim());
                    }
                    track = track.Remove(0, readTo + tokenEnd);
                }
                TrackList.Add(trackObj);
            }
            //The final track doesn't need an end time - will just continue to the end of the file
            IEnumerable<Track> orderedTrackList = TrackList;
            if (TimeOrdering)
                orderedTrackList = TrackList.OrderBy(t => t.StartTimeTime);
            if (!end) {
                for (var i = 0; i < orderedTrackList.Count(); i++) {
                    if (i < orderedTrackList.Count() - 1)
                        orderedTrackList.ElementAt(i).SetVar("$END", orderedTrackList.ElementAt(i + 1).StartTime);
                }
            }
            TrackList = orderedTrackList.ToList();
            //Launch all the ffmpeg processes
            var processes = new List<Process>();
            for (var i = 0; i < orderedTrackList.Count(); i++) {
                var track = orderedTrackList.ElementAt(i);
                var args = $"-i \"{SavePath}\" -ss {track.StartTime} ";
                args += DeleteExisting ? "-y" : "-n";
                if (!string.IsNullOrWhiteSpace(track.EndTime))
                    args += $" -t {track.Duration()}";
                var filename = $"{track.TrackName}.{Extension}";
                if (IndexFileNames) {
                    var zeros = new string('0', (int)Math.Log10(orderedTrackList.Count()) - (int)Math.Log10(i + 1));
                    filename = $"{zeros}{i + 1} - {filename}";
                }
                path = Path.Combine(PathToSaveTo, PlaylistName, filename);
                args += $" \"{path}\"";
                track.Path = path;
                var process = new Process()
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = FFCommand,
                        Arguments = args,
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        RedirectStandardInput = true
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
            if (!IsURL) return;
            if (string.IsNullOrWhiteSpace(SavePath)) return;
            File.SetAttributes(SavePath, FileAttributes.Normal);
            File.Delete(SavePath);
        }
    }
}
