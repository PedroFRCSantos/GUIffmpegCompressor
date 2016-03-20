using System;
using System.Windows.Forms;

namespace GUIffmpeg
{
    public partial class MainGui : Form
    {
        private enum FileNameParts { Date, BaseName, UserName };

        private FileNameParts[] fileNameParts;

        private LanguageManager languageManager;

        public MainGui()
        {
            InitializeComponent();

            updateGuiLanguage();
        }

        private void button1Run(object sender, EventArgs e)
        {
            buttonRun.Enabled = false;
            dataGridViewFilms.Enabled = false;
            buttonOpenFolderIn.Enabled = false;
            buttonFolderOut.Enabled = false;
            textBoxFolderIn.Enabled = false;
            textBoxFolderOut.Enabled = false;
            menuStripMain.Enabled = false;

            progressBarWork.Maximum = 100;
            progressBarWork.Value = 0;

            backgroundWorkerConverter.ProgressChanged += backgroundWorkerConverterProgressChanged;

            backgroundWorkerConverter.RunWorkerAsync();
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

        private void openInToolStripMenuItemClick(object sender, EventArgs e)
        {
            buttonOpenFolderInClick(sender, e);
        }

        private void openOutToolStripMenuItemClick(object sender, EventArgs e)
        {
            buttonFolderOutClick(sender, e);
        }

        private void aboutToolStripMenuItemClick(object sender, EventArgs e)
        {
            // About
        }

        private void exitToolStripMenuItemClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxDateFormatSelectedIndexChanged(object sender, EventArgs e)
        {
            updateOrderOfName();
        }

        private void textBoxBaseNameTextChanged(object sender, EventArgs e)
        {
            updateOrderOfName();
        }

        private void checkBoxName1CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxName2CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxName3CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonUp1Click(object sender, EventArgs e)
        {
            FileNameParts tmp = fileNameParts[0];
            fileNameParts[0] = fileNameParts[1];
            fileNameParts[1] = fileNameParts[2];
            fileNameParts[2] = tmp;

            updateOrderOfName();
        }

        private void buttonDown1Click(object sender, EventArgs e)
        {
            FileNameParts tmp = fileNameParts[0];
            fileNameParts[0] = fileNameParts[1];
            fileNameParts[1] = tmp;

            updateOrderOfName();
        }

        private void buttonUp2Click(object sender, EventArgs e)
        {
            buttonDown1Click(null, null);
        }

        private void buttonDown2Click(object sender, EventArgs e)
        {
            FileNameParts tmp = fileNameParts[1];
            fileNameParts[1] = fileNameParts[2];
            fileNameParts[2] = tmp;

            updateOrderOfName();
        }

        private void buttonUp3Click(object sender, EventArgs e)
        {
            buttonDown2Click(null, null);
        }

        private void buttonDown3Click(object sender, EventArgs e)
        {
            FileNameParts tmp = fileNameParts[2];
            fileNameParts[2] = fileNameParts[1];
            fileNameParts[1] = fileNameParts[0];
            fileNameParts[0] = tmp;

            updateOrderOfName();
        }
    }
}
