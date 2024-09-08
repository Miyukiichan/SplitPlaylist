# SplitPlaylist

## Dependencies

Depends on yt-dlb and ffmpeg although you can use youtube-dl instead of yt-dlb by setting a custom command path. By default, the application will just use the command that is on the system path.

## TODO

- More logging using callback on client side
- Use temp file location for downloaded YT file
- Have optional limit to amount of processes at a time for batch processing rather than all at once - opens up option for sequential processing
- Capture yt-dlp stdout and display in callback
- Possibly put a sleep when checking all the processes so to not overload the CPU
