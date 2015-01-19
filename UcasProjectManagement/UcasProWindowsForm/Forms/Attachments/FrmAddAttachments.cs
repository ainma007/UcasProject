using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
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
      //  byte[] img;

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
            //string filename = "_" + DateTime.Now.ToString("dd_MM_yyyy_hh_mm_ss_tt") + InformationsClass.ProjID + "_" + op.SafeFileName;
          
            //Upload(op.FileName,filename);
            string str = @"\\HEROO\Ucas\" + InformationsClass.ProjID + "_" + op.SafeFileName;
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
          
            tb = null;
            th.Abort();

            GC.SuppressFinalize(th);
            GC.SuppressFinalize(tb);
            GC.Collect();
            GC.WaitForFullGCComplete();
            GC.WaitForPendingFinalizers();
            
        }
        private void Upload(string filename,string filn)
        {
            FileInfo fileInf = new FileInfo(filename);
            string uri = "ftp://mazoonadv.com/"+filn;
            FtpWebRequest reqFTP;

            // Create FtpWebRequest object from the Uri provided
            reqFTP = (FtpWebRequest)FtpWebRequest.Create(new Uri(uri));

            // Provide the WebPermission Credintials
            reqFTP.Credentials = new NetworkCredential("xpremax",
                                                       "xprema");

            // By default KeepAlive is true, where the control connection is 
            // not closed after a command is executed.
            reqFTP.KeepAlive = false;

            // Specify the command to be executed.
            reqFTP.Method = WebRequestMethods.Ftp.UploadFile;

            // Specify the data transfer type.
            reqFTP.UseBinary = true;

            // Notify the server about the size of the uploaded file
            reqFTP.ContentLength = fileInf.Length;

            // The buffer size is set to 2kb
            int buffLength = 2048;
            byte[] buff = new byte[buffLength];
            int contentLen;

            // Opens a file stream (System.IO.FileStream) to read 
            // the file to be uploaded
            FileStream fs = fileInf.OpenRead();

            try
            {
                // Stream to which the file to be upload is written
                Stream strm = reqFTP.GetRequestStream();

                // Read from the file stream 2kb at a time
                contentLen = fs.Read(buff, 0, buffLength);

                // Till Stream content ends
                while (contentLen != 0)
                {
                    // Write Content from the file stream to the 
                    // FTP Upload Stream
                    strm.Write(buff, 0, contentLen);
                    contentLen = fs.Read(buff, 0, buffLength);
                }

                // Close the file stream and the Request Stream
                strm.Close();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Upload Error");
            }
        }
        private void FrmAddAttachments_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
           
            try
            {
                if (th.IsAlive)
                {
                    th.Abort();
                    GC.SuppressFinalize(th);

                    GC.Collect();
                    GC.WaitForFullGCComplete();
                    GC.WaitForPendingFinalizers();
                }
            }
            catch (System.NullReferenceException ex)
            {
                
                return;
            }
            
        }

        private void FrmAddAttachments_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

        }
          
    }
}
