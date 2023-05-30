using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SimpleFileShredder
{
    static class Program
    {
        /// <summary>
        /// Вхідна точка додатку
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmShredder());
        }
    }
}
