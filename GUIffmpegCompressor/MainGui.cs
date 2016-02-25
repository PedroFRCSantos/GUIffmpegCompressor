using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIffmpeg
{
    public partial class MainGui : Form
    {
        public MainGui()
        {
            InitializeComponent();

            int n = dataGridViewFilms.Rows.Add();

            //dataGridViewFilms.Rows[n].Cells[0].Value = new DataGridViewCheckBoxCell();
            dataGridViewFilms.Rows[n].Cells[2].Value = "ahaha";

            /*dataGridViewFilms.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFilms.CurrentCell = dataGridViewFilms.Rows[0].Cells[0];*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)dataGridViewFilms.Rows[0].Cells[0];
            if ((bool)chk.EditedFormattedValue == true)
                Console.WriteLine("Check");
        }

        private void buttonOpenFolderInClick(object sender, EventArgs e)
        {
            folderBrowserDialogIn = new FolderBrowserDialog();
            if (folderBrowserDialogIn.ShowDialog() == DialogResult.OK)
                textBoxFolderIn.Text = folderBrowserDialogIn.SelectedPath;
        }

        private void buttonFolderOutClick(object sender, EventArgs e)
        {
            folderBrowserDialogOut = new FolderBrowserDialog();
            if (folderBrowserDialogOut.ShowDialog() == DialogResult.OK)
                textBoxFolderOut.Text = folderBrowserDialogOut.SelectedPath;
        }
    }
}
