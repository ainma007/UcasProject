using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UcasProWindowsForm.Forms.MainForm;
using UcasProWindowsForm.Forms.ProjectProfileForm;
using UcasProWindowsForm.Forms.UserSystemForm;

namespace UcasProWindowsForm
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
            Application.Run(new FrmLogin ());
           // Application.Run(new FrmAdmin());
        }
    }
}
