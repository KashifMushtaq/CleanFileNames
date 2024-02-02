using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace CleanFileName
{
    public partial class frmCleanFileName : Form
    {
        public frmCleanFileName()
        {
            InitializeComponent();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Clear();

            folderBrowserDialog.Description = "Please select a root folder";
            folderBrowserDialog.ShowDialog();
            string selectedPath = folderBrowserDialog.SelectedPath;

            this.textBoxPath.Text = selectedPath;

            if (!string.IsNullOrEmpty(selectedPath))
            {

                if (MessageBox.Show("Are you shore to clean the file names?", "Start Cleaning File Names?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;

                buttonBrowse.Enabled = false;

                DirectoryInfo directoryInfo = new DirectoryInfo(selectedPath);
                
                var files = Directory.GetFiles(selectedPath, "*.*", SearchOption.AllDirectories);

                foreach (var f in files)
                {

                    FileInfo file = new FileInfo(f);
                    string fileName = file.Name;

                    try
                    {
                        richTextBoxLog.AppendText(string.Format("Found File: {0}\n", file.FullName));

                        //string @pattern = textBoxStart.Text + "\\(.*?\\)" + textBoxEnd.Text;

                        //var newFileName = Regex.Replace(fileName, pattern, "");

                        labelCFile.Text = fileName;
                        Application.DoEvents();

                        var newFileName = getCleanName(fileName);


                        if (!string.IsNullOrEmpty(newFileName) && !newFileName.Equals(fileName))
                        {
                            if (File.Exists(file.DirectoryName + @"\" + newFileName))
                            {
                                FileInfo oldFile = new FileInfo(file.DirectoryName + @"\" + newFileName);

                                if (oldFile.LastWriteTime >= file.LastWriteTime)
                                {
                                    File.Delete(file.DirectoryName + @"\" + fileName);
                                    continue;
                                }
                                else
                                {
                                    //continue;
                                    File.Delete(oldFile.FullName);
                                }
                            }

                            FileSystem.Rename(file.FullName, file.DirectoryName + @"\" + newFileName);

                            if (File.Exists(file.DirectoryName + @"\" + newFileName))
                            {
                                richTextBoxLog.AppendText(string.Format("Renamed file: {0}\n", file.DirectoryName + @"\" + newFileName));
                            }
                            else
                            {
                                richTextBoxLog.AppendText(string.Format("\n\nFailed to rename the file: {0}\n\n", file.DirectoryName + @"\" + fileName));
                            }
                        }
                        else if (newFileName.Equals(fileName))
                        {
                            richTextBoxLog.AppendText(string.Format("\n\nPattern not found in the file name: {0}\n\n", file.DirectoryName + @"\" + fileName));
                        }
                    }
                    catch (Exception ex)
                    { 

                        richTextBoxLog.AppendText(ex.Message);
                    }

                }

                richTextBoxLog.AppendText("\n\nClean operation completed\n\n");

                Thread.Sleep(2000);

                labelCFile.Text = "Clean operation completed";

                buttonBrowse.Enabled = true;

            }
            else
            {
                MessageBox.Show("Please select a root folder", "Select root folder", MessageBoxButtons.OK);
            }

        }

        private void frmCleanFileName_Load(object sender, EventArgs e)
        {
            //string fileName = "Dil Ne Ye Kaha (Fmw11.com) (2021_11_29 16_25_27 UTC).mp3";

            //string @pattern = textBoxStart.Text + "\\(.*?\\)" + textBoxEnd.Text;

            ////var newFileName = Regex.Replace(fileName, pattern, "");

            //string markS = textBoxStart.Text;
            //string markE = textBoxEnd.Text;

            //int start = fileName.LastIndexOf(markS);
            //int end = fileName.LastIndexOf(markE);

            //if (start >= 0 && end >= 0)
            //{ 
            //    int length = fileName.LastIndexOf(markE) + markE.Length - start;
            //    var textToReplace = fileName.Substring(start, length);
            //    var result = fileName.Replace(textToReplace, "");
            //}
        }

        string getCleanName(string fileName)
        {
            string markS = textBoxStart.Text;
            string markE = textBoxEnd.Text;

            int start = fileName.LastIndexOf(markS);
            int end = fileName.LastIndexOf(markE);

            if (start >= 0 && end >= 0)
            {
                int length = fileName.LastIndexOf(markE) + markE.Length - start;
                var textToReplace = fileName.Substring(start, length);
                return fileName.Replace(textToReplace, "");
            }

            return fileName;
        }
    }
}
