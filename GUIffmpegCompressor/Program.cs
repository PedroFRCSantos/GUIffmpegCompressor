using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace GUIffmpeg
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            if (!File.Exists("ffmpeg.exe"))
            {
                MessageBox.Show("ffmpeg does not exits!!!\nPlease download ffmpeg.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Process.Start("http://ffmpeg.org");
                return;
            }

            MainGui frm = new MainGui();
            frm.ShowDialog();
        }
    }
}
