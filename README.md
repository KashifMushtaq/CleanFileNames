**Cleans File Names in the Windows History Backup**

![Clean File Names](./CleanFileNames.jpg)

Tool search for all the files in the selected root directory and tries to find the start ' (' and end ')' tag in the file names. If it finds it, it removes it from the name. It is useful to clean up the Windows History (files backup) if you could not restore using windows backup (like me). If history backup has multiple files with the same name (after removing date from the name), it deletes the old file and keeps the new one.

If you need only binary, its in the “bin” folder. Otherwise, you can clone the repository. If you like please modify the code and use at your own. I take no responsibility.
