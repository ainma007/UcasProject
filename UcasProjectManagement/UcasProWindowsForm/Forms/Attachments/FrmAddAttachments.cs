using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;
using Ucas.Data;
using Ucas.Data.CommandClass;

namespace UcasProWindowsForm.Forms.Attachments
{
    public partial class FrmAddAttachments : Telerik.WinControls.UI.RadForm
    {
        public FrmAddAttachments()
        {
            InitializeComponent();
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        byte[] img;

        Thread th;
        OpenFileDialog op = new OpenFileDialog();
        private void radButton1_Click(object sender, EventArgs e)
        {
            op = new OpenFileDialog();
            ;
            if (op.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                radTextBox1.Text = op.FileName;
            }
            else
            {

                radTextBox1.Clear();
            }
           
           
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            th = new Thread(SaveData);
            th.Start();
         
        }

        static async Task<int> Method(SqlConnection conn, SqlCommand cmd)
        {
            await conn.OpenAsync();
            await cmd.ExecuteNonQueryAsync();
            return 1;
        }

        private void SaveData()
        {

            radWaitingBar1.Invoke((MethodInvoker)delegate
            {
                radWaitingBar1.Visible = true;
                radWaitingBar1.StartWaiting();
                label1.Visible = true;

            });
           

             string str = @"\\BLACKSWORD\UCAttachment\" + InformationsClass.ProjID + "_" + op.SafeFileName;
             File.Copy(op.FileName, str);
           

          
            Attachment tb = new Attachment
            {
                ProjectProfile_ID = InformationsClass.ProjID,
                AttachmentName = op.SafeFileName,
                CreateDate = DateTime.Now,
                FilePathX = str

            };

            AttachmentsClass.NewAttachment(tb);
            radWaitingBar1.Invoke((MethodInvoker)delegate
            {
                radWaitingBar1.Visible = false;
                label1.Visible = false;
                Operation.ShowToustOk("تمت عملية الرفع",this);
                radTextBox1.Clear();

            });
            img = null;
            tb = null;
            GC.SuppressFinalize(th);
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            th.Abort();
            
        }

        private void FrmAddAttachments_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            try
            {
                if (th.IsAlive)
                {
                    th.Abort();
                }
            }
            catch (System.NullReferenceException ex)
            {
                
                return;
            }
            
        }
          
    }
}
