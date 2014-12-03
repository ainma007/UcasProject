using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data.CommandClass;
using UcasProWindowsForm.Forms.MainForm;

namespace UcasProWindowsForm.Forms.ProjectProfileForm
{
    public partial class FrmTheDonorsAndProjectManage : Telerik.WinControls.UI.RadForm
    {
        public FrmTheDonorsAndProjectManage()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }

        private void radGridView1_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
           
        }

        private void AddDonorsBtn_Click(object sender, EventArgs e)
        {
            Operation.BeginOperation(this);
            FrmTheDonorsAndProjectAdd frm = new FrmTheDonorsAndProjectAdd();
            frm.ShowDialog();
            Operation.EndOperation(this);

        }

        private void FrmTheDonorsAndProjectManage_Load(object sender, EventArgs e)
        {
            Thread th = new Thread(FillData);
            th.Start();
            
         
        }

        private void FillData()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                StatusLabel1.Text = "جاري الانتظار.... ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();
            var q = TheDonorsProjectCmd.GetAllDonorsByproID(InformationsClass.ProjID);
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                radGridView1.DataSource = q;
                StatusLabel1.Text = "";

            });
        }

        private void radGridView1_CommandCellClick(object sender, EventArgs e)
        {
            var col = radGridView1.CurrentColumn.Index;
            if (col == 3)
            {
                Operation.BeginOperation(this);
                FrmTheDonorsAndProjectEdit frm = new FrmTheDonorsAndProjectEdit();
                Ucas.Data.TheDonorsProject db = (Ucas.Data.TheDonorsProject)radGridView1.CurrentRow.DataBoundItem;
                frm.TragetTheDonorsProject = db;
                Operation.EndOperation(this);
                frm.ShowDialog();
            }
            if (col == 4)
            {
                if (RadMessageBox.Show(this, OperationX.DeleteMessage, "Done", MessageBoxButtons.YesNo, RadMessageIcon.Info) == DialogResult.Yes)
                {
                    Operation.BeginOperation(this);
                    

                    if (TheDonorsProjectCmd.DeleteDonorsProject(int.Parse(radGridView1.CurrentRow.Cells[0].Value.ToString())))
                    {

                        Operation.ShowToustOk(OperationX.DeletedMessage, this);
                        Operation.EndOperation(this);
                        FrmTheDonorsAndProjectManage_Load(sender, e);
                    }

                    else
                    {
                        Operation.EndOperation(this);
                        RadMessageBox.Show("لا يمكن حذف السجل", "خطأ", MessageBoxButtons.OK, RadMessageIcon.Error);

                    }
                }
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            
            FrmTheDonorsAndProjectManage_Load(sender, e);
           

        }
    }
}
