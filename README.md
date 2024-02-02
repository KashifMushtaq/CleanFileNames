<h1>Cleans File Names in the Windows History Backup</h1>
  
<p>&nbsp;</p>

![Clean File Names](./CleanFileNames.jpg)

<p>Windows backup file history at your configured location. There could be multiple version of the same file in format shown below.</p>

<p><b>(File name)(2022_05_30 19_02_35 UTC).doc</b></p>
<P>This tool goes through all the files in the selected directory and removes <b> (TimeStamp)</b> part from the file name. It just renames the file.</P>

<p>
Tool search for all the files in the selected root directory and tries to find the start <b>' ('</b> and end <b>')'</b> tags in the file names. If it finds it, it removes any text which is in between these tags including the tags from the file name. It is useful to clean up the Windows History (files backup) if you could not restore using windows backup (like me). If history backup has multiple files with the same name (after removing date from the name), it deletes the old file and keeps the new one.
</p>

<p>If you need only binary, its in the “bin” folder. Otherwise, you can clone the repository. If you like please modify the code and use at your own risk. I take no responsibility.</p>
