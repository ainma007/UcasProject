using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
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
        }
        byte[] img;

        Thread th;
        OpenFileDialog op = new OpenFileDialog();
        private void radButton1_Click(object sender, EventArgs e)
        {
            op = new OpenFileDialog();
            op.ShowDialog();
            
           
           
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            th = new Thread(SaveData);
            th.Start();
         
        }

        private void SaveData()
        {
            radWaitingBar1.Invoke((MethodInvoker)delegate
            {
                radWaitingBar1.Visible = true;
                radWaitingBar1.StartWaiting();
                label1.Visible = true;

            });
           
            Attachment tb = new Attachment
            {
                ProjectProfile_ID = InformationsClass.ProjID,
                AttachmentName = op.SafeFileName,
                CreateDate = DateTime.Now,
                fileContent = File.ReadAllBytes(op.FileName),
               
            };

            AttachmentsClass.NewAttachment(tb);
            radWaitingBar1.Invoke((MethodInvoker)delegate
            {
                radWaitingBar1.Visible = false;
                label1.Visible = false;
                Operation.ShowToustOk("تمت عملية الرفع",this);

            });
            img = null;
            tb = null;
           // GC.SuppressFinalize(tb);
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            th.Abort();
            
        }

        private void FrmAddAttachments_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
          
    }
}
