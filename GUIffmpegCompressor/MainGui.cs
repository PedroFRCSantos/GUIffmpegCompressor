using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUIffmpeg
{
    public partial class MainGui : Form
    {
        public MainGui()
        {
            InitializeComponent();

            /*dataGridViewFilms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFilms.CurrentCell = dataGridViewFilms.Rows[0].Cells[0];*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridViewFilms.Rows[0].Cells[0];
            if ((bool)chk.EditedFormattedValue == true)
                Console.WriteLine("Check");
        }

        private void updateFilesOfInputFolder()
        {
            // remove old values
            int rowCount = dataGridViewFilms.Rows.Count;
            for (int i = 0; i < rowCount; i++)
                dataGridViewFilms.Rows.RemoveAt(0);

            // verify if folder exits and try fround all movies inside
            if (Directory.Exists(textBoxFolderIn.Text))
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
                textBoxFolderOut.Text = folderBrowserDialogOut.SelectedPath;
        }

        private void textBoxFolderInTextChanged(object sender, EventArgs e)
        {
            updateFilesOfInputFolder();
        }

        private void textBoxFolderOutTextChanged(object sender, EventArgs e)
        {
            updateOutputFolder();
        }
    }
}
