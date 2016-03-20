using System;
using System.IO;
using System.Windows.Forms;

namespace GUIffmpeg
{
    public partial class MainGui
    {
        private void backgroundWorkerConverterDoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (Directory.Exists(textBoxFolderOut.Text) && textBoxFolderOut.Text != "" &&
                Directory.Exists(textBoxFolderIn.Text) && textBoxFolderIn.Text != "")
            {
                int rowCount = dataGridViewFilms.Rows.Count;

                // find all movies files
                string[] filesMP4 = Directory.GetFiles(textBoxFolderIn.Text, "*.mp4");
                string[] filesAVI = Directory.GetFiles(textBoxFolderIn.Text, "*.avi");

                string[] filesAll = new string[filesMP4.Length + filesAVI.Length];
                filesMP4.CopyTo(filesAll, 0);
                filesAVI.CopyTo(filesAll, filesMP4.Length);

                // verify if it is to convert
                for (int i = 0; i < rowCount; i++)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridViewFilms.Rows[i].Cells[0];
                    if ((bool)chk.EditedFormattedValue == true)
                    {
                        string fileName = (string)dataGridViewFilms.Rows[i].Cells[3].Value;

                        string outputName;

                        if (textBoxFolderOut.Text[textBoxFolderOut.Text.Length - 1] == '\\' ||
                            textBoxFolderOut.Text[textBoxFolderOut.Text.Length - 1] == '/')
                            outputName = textBoxFolderOut.Text + fileName;
                        else
                            outputName = textBoxFolderOut.Text + "\\" + fileName;

                        bool singleFile = true;

                        if (i + 1 < rowCount)
                        {
                            chk = (DataGridViewCheckBoxCell)dataGridViewFilms.Rows[i + 1].Cells[1];

                            if ((bool)chk.EditedFormattedValue == true)
                            {
                                singleFile = false;

                                // need to join files
                                // start to create a file with file list
                                StreamWriter file = new StreamWriter("mylist.txt");

                                file.WriteLine("file '{0}'", filesAll[i]);

                                int k = i + 1;
                                while (k < rowCount)
                                {
                                    chk = (DataGridViewCheckBoxCell)dataGridViewFilms.Rows[k].Cells[1];
                                    if ((bool)chk.EditedFormattedValue == false)
                                        break;

                                    file.WriteLine("file '{0}'", filesAll[k]);

                                    k++;
                                }

                                file.Close();

                                // call ffmpeg with multiple files
                                System.Diagnostics.Process process = new System.Diagnostics.Process();
                                System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                                startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                                startInfo.FileName = "ffmpeg.exe";
                                startInfo.Arguments = "-f concat -i mylist.txt -qscale 0 " + outputName;
                                process.StartInfo = startInfo;
                                process.Start();
                                process.WaitForExit();

                                // remove temporary file
                                //

                                i = k - 1;
                            }
                        }

                        if (singleFile)
                        {
                            // single file
                            System.Diagnostics.Process process = new System.Diagnostics.Process();
                            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                            startInfo.FileName = "ffmpeg.exe";
                            startInfo.Arguments = "-i " + filesAll[i] + " -qscale 0 " + outputName;
                            process.StartInfo = startInfo;
                            process.Start();
                            process.WaitForExit();
                        }

                        backgroundWorkerConverter.ReportProgress(Math.Min((int)((i + 1) / ((float)rowCount) * 100.0f), 100));
                    }
                }
            }
        }

        private void backgroundWorkerConverterRunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            buttonRun.Enabled = true;
            dataGridViewFilms.Enabled = true;
            buttonOpenFolderIn.Enabled = true;
            buttonFolderOut.Enabled = true;
            textBoxFolderIn.Enabled = true;
            textBoxFolderOut.Enabled = true;
            menuStripMain.Enabled = true;
        }

        private void backgroundWorkerConverterProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            Console.WriteLine("Aqui {0}!!!", e.ProgressPercentage);
            progressBarWork.Value = e.ProgressPercentage;
        }
    }
}
