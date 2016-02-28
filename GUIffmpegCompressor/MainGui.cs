﻿using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace GUIffmpeg
{
    public partial class MainGui : Form
    {
        public MainGui()
        {
            InitializeComponent();
        }

        private void button1Run(object sender, EventArgs e)
        {
            buttonRun.Enabled = false;
            dataGridViewFilms.Enabled = false;
            buttonOpenFolderIn.Enabled = false;
            buttonFolderOut.Enabled = false;
            textBoxFolderIn.Enabled = false;
            textBoxFolderOut.Enabled = false;

            progressBarWork.Maximum = 100;
            progressBarWork.Value = 0;

            backgroundWorkerConverter.ProgressChanged += backgroundWorkerConverterProgressChanged;

            backgroundWorkerConverter.RunWorkerAsync();
        }

        private void updateFilesOfInputFolder()
        {
            // remove old values
            int rowCount = dataGridViewFilms.Rows.Count;
            for (int i = 0; i < rowCount; i++)
                dataGridViewFilms.Rows.RemoveAt(0);

            // verify if folder exits and try fround all movies inside
            if (Directory.Exists(textBoxFolderIn.Text) && textBoxFolderIn.Text != "")
            {
                textBoxFolderIn.BackColor = Color.Green;

                // find all movies files
                string[] filesMP4 = Directory.GetFiles(textBoxFolderIn.Text, "*.mp4");
                string[] filesAVI = Directory.GetFiles(textBoxFolderIn.Text, "*.avi");

                string[] filesAll = new string[filesMP4.Length + filesAVI.Length];
                filesMP4.CopyTo(filesAll, 0);
                filesAVI.CopyTo(filesAll, filesMP4.Length);

                int N = filesAll.Length;

                // add all
                for (int i = 0; i < N; i++)
                {
                    int n = dataGridViewFilms.Rows.Add();

                    dataGridViewFilms.Rows[i].Cells[0].Value = true;
                    dataGridViewFilms.Rows[i].Cells[2].Value = Path.GetFileName(filesAll[i]);

                    DateTime time = File.GetCreationTime(filesAll[i]);
                    string fileNameNoExtention = Path.GetFileNameWithoutExtension(filesAll[i]);

                    string fileNameOut = fileNameNoExtention + time.Year + "_" + time.Month + "_" + time.Day + "_" + time.Hour + "_" + time.Minute + "_" + time.Second + ".mp4";

                    dataGridViewFilms.Rows[i].Cells[3].Value = fileNameOut;
                }
            }
            else
                textBoxFolderIn.BackColor = Color.White;
        }

        private void updateOutputFolder()
        {
            if (Directory.Exists(textBoxFolderOut.Text))
                textBoxFolderOut.BackColor = Color.Green;
            else
                textBoxFolderOut.BackColor = Color.White;
        }

        private void buttonOpenFolderInClick(object sender, EventArgs e)
        {
            folderBrowserDialogIn = new FolderBrowserDialog();
            if (folderBrowserDialogIn.ShowDialog() == DialogResult.OK)
            {
                textBoxFolderIn.Text = folderBrowserDialogIn.SelectedPath;

                updateFilesOfInputFolder();
            }
        }

        private void buttonFolderOutClick(object sender, EventArgs e)
        {
            folderBrowserDialogOut = new FolderBrowserDialog();
            if (folderBrowserDialogOut.ShowDialog() == DialogResult.OK)
            {
                textBoxFolderOut.Text = folderBrowserDialogOut.SelectedPath;

                updateOutputFolder();
            }
        }

        private void textBoxFolderInTextChanged(object sender, EventArgs e)
        {
            updateFilesOfInputFolder();
        }

        private void textBoxFolderOutTextChanged(object sender, EventArgs e)
        {
            updateOutputFolder();
        }

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
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridViewFilms.Rows[0].Cells[0];
                    if ((bool)chk.EditedFormattedValue == true)
                    {
                        string fileName = (string)dataGridViewFilms.Rows[i].Cells[3].Value;

                        string outputName;

                        if (textBoxFolderOut.Text[textBoxFolderOut.Text.Length - 1] == '\\' ||
                            textBoxFolderOut.Text[textBoxFolderOut.Text.Length - 1] == '/')
                            outputName = textBoxFolderOut.Text + fileName;
                        else
                            outputName = textBoxFolderOut.Text + "\\" + fileName;

                        Thread.Sleep(1000);

                        backgroundWorkerConverter.ReportProgress((int)(i / ((float)rowCount) * 100.0f));
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
        }

        private void backgroundWorkerConverterProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            Console.WriteLine("Aqui {0}!!!", e.ProgressPercentage);
            progressBarWork.Value = e.ProgressPercentage;
        }
    }
}
