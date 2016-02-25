using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
