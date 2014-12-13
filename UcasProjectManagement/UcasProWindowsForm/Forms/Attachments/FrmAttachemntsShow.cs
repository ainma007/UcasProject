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
    public partial class FrmAttachemntsShow : Telerik.WinControls.UI.RadForm
    {
        public FrmAttachemntsShow()
        {
            InitializeComponent();
        }
        Thread th;
        private void FrmAttachemntsShow_Load(object sender, EventArgs e)
        {
            th = new Thread(LodingData);
            th.Start();
         
           
        }

        private void LodingData()
        {
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                toolStripStatusLabel1.Text = "جاري الانتظار.... ";

            });
            Operation.BeginOperation(this);

            Application.DoEvents();
            var q = AttachmentsClass.GetAllAttachment();
            Application.DoEvents();

            Operation.EndOperation(this);
            statusStrip1.Invoke((MethodInvoker)delegate
            {

                AttachemntsGridView.DataSource = q;
                toolStripStatusLabel1.Text = "";

            });

            th.Abort();
        }

        private void MasterTemplate_Click(object sender, EventArgs e)
        {
            
        }

        private void MasterTemplate_CommandCellClick(object sender, EventArgs e)
        {

            var col2 = AttachemntsGridView.CurrentColumn.Index;

            if (col2 == 3)
            {
                th = new Thread(DownData);
                th.Start();

            }
        }

        private void DownData()
        {

            Attachment p = (Attachment)AttachemntsGridView.CurrentRow.DataBoundItem;
            FolderBrowserDialog sv = new FolderBrowserDialog();
         
            radWaitingBar1.Invoke((MethodInvoker)delegate
            {
                
                sv.ShowDialog();

                ///
                radWaitingBar1.Visible = true;
                toolStripStatusLabel1.Text = "جاري التنزيل...";
                AttachemntsGridView.Enabled = false;
                toolStrip1.Enabled = false;
                radWaitingBar1.StartWaiting();

            });
          
           
            File.WriteAllBytes(sv.SelectedPath + "\\" + p.AttachmentName, p.fileContent);
            

            radWaitingBar1.Invoke((MethodInvoker)delegate
            {
                toolStripStatusLabel1.Text = "";
                radWaitingBar1.Visible = false;
                AttachemntsGridView.Enabled = true;
                toolStrip1.Enabled = true;
                Operation.ShowToustOk("تم تحميل الملف",this);

              
            });
            th.Abort();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmAddAttachments frm = new FrmAddAttachments();
            frm.ShowDialog();
   
        }

        private void FrmAttachemntsShow_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
           
        }
    }
}
