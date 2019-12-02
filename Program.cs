using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace file_organization_fth_oz
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new file_organization_algorithms());
        }
    }
}
