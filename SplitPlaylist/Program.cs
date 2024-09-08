using CommandLine;
using SplitPlaylist;
using ShellProgressBar;
using System.Diagnostics;

var options = Parser.Default.ParseArguments<Options>(args).Value;
if (options is null) return;
if (string.IsNullOrWhiteSpace(options.File) && string.IsNullOrWhiteSpace(options.URL))
    throw new ArgumentNullException("Please provide either a file path or a YouTube URL to process");
string[] tracks;
tracks = File.ReadAllLines(options.Path);
var isURL = true;
var url = options.URL;
if (string.IsNullOrWhiteSpace(url)) {
    url = options.File;
    isURL = false;
}
var splitter = new Splitter {
    URL = url,
    IsURL = isURL,
    PathToSaveTo = options.Output,
    Pattern = options.Pattern,
    SavePath = options.Path,
    YTCommand = options.YTPath,
    FFCommand = options.FFPath,
    Extension = options.Extension,
    DeleteExisting = options.DeleteExistingTracks,
    TimeOrdering = options.TimeOrdering,
    Tracks = tracks,
    IndexFileNames = options.IndexFilenames,
    PlaylistName = options.PlaylistName,
};
Console.WriteLine("Downloading video and spawning processes");
var processes = splitter.ProcessTracks();
var totalTicks = processes.Count;
var opts = new ProgressBarOptions
{
    ProgressCharacter = '─',
    ProgressBarOnBottom = true
};
var finished = new List<Process>();
var total = processes.Count;
using (var progress = new ProgressBar(totalTicks, $"Processing tracks {finished.Count + 1} of {total}", opts))
{
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
            // Prevents ticking to total + 1
            if (processes.Count > 0)
                progress.Tick($"Processing tracks {finished.Count + 1} of {total}");
            break;
        }
    }
}
Console.WriteLine("Cleaning up");
splitter.Cleanup(finished);
Console.WriteLine("Done!");

class Options {
    [Option('u', "url", Required = false, HelpText = "YouTube URL to download and process")]
    public string? URL { get; set; }
    [Option('f', "file", Required = false, HelpText = "File input that can be used instead of a YouTube URL")]
    public string? File { get; set; }
    [Option('o', "output", Required = true, HelpText = "Output directory to store the new playlist directory")]
    public required string Output { get; set; }
    [Option('P', "pattern", Required = true, HelpText = "Pattern to match track data")]
    public required string Pattern { get; set; }
    [Option('p', "path", Required = true, HelpText = "Path to timestamp file")]
    public required string Path { get; set; }
    [Option('y', "yt-dlp", Required = false, HelpText = "YouTube downloader executable")]
    public string YTPath { get; set; } = "yt-dlp";
    [Option('F', "ffmpeg", Required = false, HelpText = "FFMPeg executable")]
    public string FFPath { get; set; } = "ffmpeg";
    [Option('e', "extension", Required = false, HelpText = "File format of output")]
    public string Extension { get; set; } = "mp3";
    [Option('d', "delete-existing", Required = false, HelpText = "Any existing files that would be generated will be deleted and overridden")]
    public bool DeleteExistingTracks { get; set; } = true;
    [Option('t', "time-ordering", Required = false, HelpText = "Sorts the timestamp list by the start time in case the list is unordered")]
    public bool TimeOrdering { get; set; } = true;
    [Option('i', "index-filenames", Required = false, HelpText = "Prepends a padded index to the filename based on the ordering of the timestamps")]
    public bool IndexFilenames { get; set; } = true;
    [Option('n', "playlist-name", Required = true, HelpText = "Name of the playlist which is also the directory the final tracks will export to")]
    public required string PlaylistName { get; set; }
}
