using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
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
            RadMessageBox.SetThemeName("TelerikMetro");
        }
        Thread th;
        private void FrmAttachemntsShow_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

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
            var q = AttachmentsClass.GetGetAllAttachmentByproID(InformationsClass.ProjID);
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
                FrmAttachemntsShow_Load(null, null);

            }

            if (col2 == 4)
            {

                if (RadMessageBox.Show(this, OperationX.DeletedMessage, "حذف سجل", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    Operation.BeginOperation(this);
                    var obj = (Attachment)AttachemntsGridView.CurrentRow.DataBoundItem;
                    if (AttachmentsClass.DeleteAttachment(obj.IDX)) 
                    {
                        if (File.Exists(obj.FilePathX))
                        {
                            File.Delete(obj.FilePathX);
                            Application.DoEvents();
                        }
                        Operation.EndOperation(this);
                        this.FrmAttachemntsShow_Load(null, null);
                        Operation.ShowToustOk("تمت عملية الحذف", this);


                    }

                }
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
          
           
     // 
            try
            {
                //عملية الشبكة 
            //   File.Copy(p.FilePathX, sv.SelectedPath + "\\" + p.AttachmentName, true);



                ////عملية السيرفر 
                // Get the object used to communicate with the server.
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://mazoonadv.com/" + p.FilePathX);
                request.Method = WebRequestMethods.Ftp.DownloadFile;

                // This example assumes the FTP site uses anonymous logon.
                request.Credentials = new NetworkCredential("xpremax", "123456");

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();

                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);
                //File.WriteAllText(sv.SelectedPath + "\\" + p.AttachmentName, reader.ReadToEnd());
                byte[] bytes = reader.CurrentEncoding.GetBytes(reader.ReadToEnd());
                File.WriteAllBytes(sv.SelectedPath + "\\" + p.AttachmentName, bytes);
                Process.Start(sv.SelectedPath + "\\" + p.AttachmentName);

                Console.WriteLine("Download Complete, status {0}", response.StatusDescription);

                reader.Close();
                response.Close();
            }
            catch (System.UnauthorizedAccessException)
            {
                radWaitingBar1.Invoke((MethodInvoker)delegate
           {
               toolStripStatusLabel1.Text = "";
               radWaitingBar1.Visible = false;
               AttachemntsGridView.Enabled = true;
               toolStrip1.Enabled = true;
           });
                return;
            }
           

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
            FrmAttachemntsShow_Load(null, null);
   
        }

        private void FrmAttachemntsShow_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.SuppressFinalize(th);

            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            this.Dispose();
           
        }

        private void AttachemntsGridView_Click(object sender, EventArgs e)
        {

        }
    }
}
