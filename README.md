# SplitPlaylist

## Dependencies

Depends on yt-dlb and ffmpeg although you can use youtube-dl instead of yt-dlb by setting a custom command path. By default, the application will just use the command that is on the system path.

Make sure that your ffmpeg and yt-dlp exes are added as firewall exceptions. Otherwise they won't work consistently/effectively or at all.

## TODO

- Options menu to declutter the main pages 
  - Default command paths
  - Default video/audio formats
  - Delete existing tracks
  - Use time ordering
- Implement progress bar for regular downloads
- Add custom yt-dlp command path for regular downloads
- Improve error handling of processes
- Custom file name format
- Support outputting to subdirectories using
  - Artist
  - Album
- Support adding metadata such as album, artist, index, etc
- Make form look bootiful
- Introduce command line app version using backend code
  - Need to create separate project and split the backend into a library project
- Have optional limit to amount of processes at a time for batch processing rather than all at once - opens up option for sequential processing
- Capture yt-dlp stdout and put it in a dialog rather than launching a terminal
- Possibly put a sleep when checking all the processes so to not overload the CPU
