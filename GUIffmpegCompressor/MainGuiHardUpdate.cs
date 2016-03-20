using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUIffmpeg
{
    public partial class MainGui
    {
        private void updateGuiLanguage()
        {
            // Order of output file names
            languageManager = new LanguageManager();

            buttonUp1.Text = languageManager.getUpName();
            buttonUp2.Text = languageManager.getUpName();
            buttonUp3.Text = languageManager.getUpName();

            buttonDown1.Text = languageManager.getDownName();
            buttonDown2.Text = languageManager.getDownName();
            buttonDown3.Text = languageManager.getDownName();

            fileNameParts = new FileNameParts[3];
            fileNameParts[0] = FileNameParts.BaseName;
            fileNameParts[1] = FileNameParts.UserName;
            fileNameParts[2] = FileNameParts.Date;

            // enable check box file parts
            checkBoxName1.CheckState = CheckState.Checked;
            checkBoxName2.CheckState = CheckState.Checked;
            checkBoxName3.CheckState = CheckState.Checked;

            labelUserName.Text = languageManager.getUserName() + ":";

            updateOrderOfName();

            // try to change gui acording to windows language
            labelFolderIn.Text = languageManager.getNameFolderIn();
            labelOutputDir.Text = languageManager.getNameFolderOut();
            buttonOpenFolderIn.Text = languageManager.getBrowse();
            buttonFolderOut.Text = languageManager.getBrowse();

            //openInToolStripOpenIn.Text = "asdjdf";

            // list o date format
            comboBoxDataFormat.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDataFormat.Items.Add(languageManager.getDateFormat1());
            comboBoxDataFormat.Items.Add(languageManager.getDateFormat2());
            comboBoxDataFormat.Items.Add(languageManager.getDateFormat3());
            comboBoxDataFormat.SelectedIndex = 0;

            buttonRun.Text = languageManager.getConvertName();
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

                    string fileNameOut = fileNameNoExtention + "_" + time.Year + "_" + time.Month + "_" + time.Day + "_" + time.Hour + "_" + time.Minute + "_" + time.Second + ".mp4";

                    dataGridViewFilms.Rows[i].Cells[3].Value = fileNameOut;
                }
            }
            else
                textBoxFolderIn.BackColor = Color.White;
        }


        private void updateOrderOfName()
        {
            // fill first option
            switch (fileNameParts[0])
            {
                case FileNameParts.BaseName:
                    if (textBoxBaseName.Text.Length == 0)
                        checkBoxName1.Text = languageManager.getBaseName();
                    else
                        checkBoxName1.Text = textBoxBaseName.Text;
                    break;
                case FileNameParts.Date:
                    checkBoxName1.Text = languageManager.getDateName();
                    break;
                case FileNameParts.UserName:
                    checkBoxName1.Text = languageManager.getUserName();
                    break;
            }

            switch (fileNameParts[1])
            {
                case FileNameParts.BaseName:
                    if (textBoxBaseName.Text.Length == 0)
                        checkBoxName2.Text = languageManager.getBaseName();
                    else
                        checkBoxName2.Text = textBoxBaseName.Text;
                    break;
                case FileNameParts.Date:
                    checkBoxName2.Text = languageManager.getDateName();
                    break;
                case FileNameParts.UserName:
                    checkBoxName2.Text = languageManager.getUserName();
                    break;
            }

            switch (fileNameParts[2])
            {
                case FileNameParts.BaseName:
                    if (textBoxBaseName.Text.Length == 0)
                        checkBoxName3.Text = languageManager.getBaseName();
                    else
                        checkBoxName3.Text = textBoxBaseName.Text;
                    break;
                case FileNameParts.Date:
                    checkBoxName3.Text = languageManager.getDateName();
                    break;
                case FileNameParts.UserName:
                    checkBoxName3.Text = languageManager.getUserName();
                    break;
            }
        }

        private string getCurrentDateString(DateTime dateFile, int optionIndex)
        {
            string outDate = dateFile.ToString();

            switch (optionIndex)
            {
                case 0:
                    outDate = "" + dateFile.Day + AuxiliaryFunctions.numberNDigits(dateFile.Month, 2) + dateFile.Year +
                              AuxiliaryFunctions.numberNDigits(dateFile.Hour, 2) +
                              AuxiliaryFunctions.numberNDigits(dateFile.Minute, 2) +
                              AuxiliaryFunctions.numberNDigits(dateFile.Second, 2);
                    break;
                case 1:
                    outDate = "" + dateFile.Year + AuxiliaryFunctions.numberNDigits(dateFile.Month, 2) +
                              AuxiliaryFunctions.numberNDigits(dateFile.Day, 2) +
                              AuxiliaryFunctions.numberNDigits(dateFile.Hour, 2) +
                              AuxiliaryFunctions.numberNDigits(dateFile.Minute, 2) +
                              AuxiliaryFunctions.numberNDigits(dateFile.Second, 2);
                    break;
                case 2:
                    outDate = "" + AuxiliaryFunctions.numberNDigits(dateFile.Day, 2) +
                              getMonthName(dateFile.Month) + dateFile.Year +
                              AuxiliaryFunctions.numberNDigits(dateFile.Hour, 2) +
                              AuxiliaryFunctions.numberNDigits(dateFile.Minute, 2) +
                              AuxiliaryFunctions.numberNDigits(dateFile.Second, 2);
                    break;
            }

            return outDate;
        }

        private string getMonthName(int monthID)
        {
            switch (monthID)
            {
                case 1:
                    languageManager.getMonthJanuary();
                    break;
                case 2:
                    languageManager.getMonthFebruary();
                    break;
                case 3:
                    languageManager.getMonthMarch();
                    break;
                case 4:
                    languageManager.getMonthAbril();
                    break;
                case 5:
                    languageManager.getMonthMay();
                    break;
                case 6:
                    languageManager.getMonthJune();
                    break;
                case 7:
                    languageManager.getMonthJuly();
                    break;
                case 8:
                    languageManager.getMonthAugust();
                    break;
                case 9:
                    languageManager.getMonthSeptember();
                    break;
                case 10:
                    languageManager.getMonthOctober();
                    break;
                case 11:
                    languageManager.getMonthNovember();
                    break;
                case 12:
                    languageManager.getMonthDecember();
                    break;
            }

            return "month";
        }

        private void updateOutputFolder()
        {
            if (Directory.Exists(textBoxFolderOut.Text))
                textBoxFolderOut.BackColor = Color.Green;
            else
                textBoxFolderOut.BackColor = Color.White;
        }
    }
}
