using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UcasProWindowsForm.Forms;

namespace UcasProWindowsForm
{
   public class Operation
    {
       private static frmLoader load = new frmLoader();
      

        public static void ShowToustOk(string msg, Control frm)
        {
            ToastNotification.Show(frm, msg, null, 1000, eToastGlowColor.Green, eToastPosition.MiddleCenter);
        }

        public static void BeginOperation(Control frm)
        {
           // Shows(frm);
            frm.Invoke((MethodInvoker)delegate
            {

                frm.Enabled = false;
                frm.Cursor = Cursors.WaitCursor;
                

            });
        }

        private static void Shows(Control frm)
        {
            //frm.BeginInvoke((MethodInvoker)delegate {
                frm.Show();
                load.Show();
          //  });
            
          
        }

        public static void EndOperation(Control frm)
        {
          //  hider(frm);
            frm.Invoke((MethodInvoker)delegate
            {

                frm.Enabled = true;
                frm.Cursor = Cursors.Default;
                

            });
        }

        private static void hider(Control frm)
        {
            frm.BeginInvoke((MethodInvoker)delegate
            {
                frm.Hide();
                load.Hide();
            });
        }
    }
}
