﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using UcasProWindowsForm.Forms;
using UcasProWindowsForm.Forms.ExpensesForm;
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
        //public static Process PriorProcess()
        //// Returns a System.Diagnostics.Process pointing to
        //// a pre-existing process with the same name as the
        //// current one, if any; or null if the current process
        //// is unique.
        //{
        //    Process curr = Process.GetCurrentProcess();
        //    Process[] procs = Process.GetProcessesByName(curr.ProcessName);
        //    foreach (Process p in procs)
        //    {
        //        if ((p.Id != curr.Id) &&
        //            (p.MainModule.FileName == curr.MainModule.FileName))
        //            return p;
        //    }

        //    return null;

        //}
        static void Main()
        {
            //if (PriorProcess() != null)
            //{


            //    return;
            //}
            Application.ThreadException += Application_ThreadException;
            CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            culture.DateTimeFormat.LongTimePattern = "";
            Thread.CurrentThread.CurrentCulture = culture;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new FrmLogin ());
           // Application.Run(new FrmLogin());
           // Operation.BeginOperation(new FrmAdmin());
            

            Application.Run(new frmLoader());
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            RadMessageBox.Show("خطأ في البرنامج"+e.ToString());
           
            return;
           // Application.Restart();
        }
    }
}
