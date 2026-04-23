using System;
using System.Windows.Forms;

namespace Escasinas_BSIT_WM_202_Lesson5Activity
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
