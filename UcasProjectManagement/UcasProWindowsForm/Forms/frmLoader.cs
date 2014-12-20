using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Ucas.Data;
using UcasProWindowsForm.Forms.MainForm;

namespace UcasProWindowsForm.Forms
{
    public partial class frmLoader : Form
    {
        public frmLoader()
        {
            InitializeComponent();
        }

        Thread th;
       
        ReportDataSource rpt = new ReportDataSource();
        private void frmLoader_Load(object sender, EventArgs e)
        {
            
            Application.DoEvents();
            th = new Thread(Loader);
            th.Start();

        }

        private  void Loader()
        {
            radWaitingBar1.Invoke((MethodInvoker)delegate
            {

                radWaitingBar1.StartWaiting();
            });

            rpt = new ReportDataSource();
           
            UcasProEntities db = new UcasProEntities();
            db.Database.Connection.Open();
            db.Database.Connection.Close();
            var q = (from i in db.ProjectProfiles select i);
            var q1 = (from i in db.ProjectActivities select i);
            var q2 = (from i in db.ProjectSubActivities select i);
            var q3 = (from i in db.Contracts select i);
            var q4 = (from i in db.Employees select i);
            var q5 = (from i in db.TheDonors select i);
            var q6 = (from i in db.Suppliers select i);
            var q7 = (from i in db.ProjectSubActivities select i);
            var q8 = (from i in db.ProjectExpenses select i);
            var q9 = (from i in db.Monthlysalaries select i);
            var q10 = (from i in db.TheDonorsProjects select i);
            var q11= (from i in db.AmountsReceiveds select i);
            var q12 = (from i in db.UserTbs select i);
           
            radWaitingBar1.Invoke((MethodInvoker)delegate
            {
                FrmLogin frmx = new FrmLogin();
                frmx.Show();
                GC.SuppressFinalize(th);
                GC.Collect();
                GC.WaitForFullGCComplete();
                GC.WaitForPendingFinalizers();
                this.Hide();
               
                
               
               
            });

            th.Abort();

        }
    }
}
