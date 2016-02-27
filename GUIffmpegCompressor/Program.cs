using System;

namespace GUIffmpeg
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            MainGui frm = new MainGui();
            frm.ShowDialog();
        }
    }
}
