using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UcasProWindowsForm
{
    public class OperationX
    {

         private static string _RequiredField;

        public static string RequiredField
        {
            get {
                OperationX._RequiredField = "تأكد من الحقل الفارغ";
                return OperationX._RequiredField; 
            }
           
        }


        private static string _DeleteMessage;

        public static string DeleteMessage
        {
            get
            {
                OperationX._DeleteMessage = "هل تريد حذف سجل ؟";
                return OperationX._DeleteMessage;
            }

        }


        private static string _DeletedMessage;

        public static string DeletedMessage
        {
            get
            {
                OperationX._DeletedMessage = "تم حذف السجل";
                return OperationX._DeletedMessage;
            }

        }

        private static readonly string enterName = "من فضلك ادخل الاسم";

        public static string EnterName
        {
            get { return OperationX.enterName; }
        }

        private static readonly string saveMessage = "هل تريد حفظ التغيرات؟";

        public static string SaveMessage
        {
            get { return OperationX.saveMessage; }

        }

        private static readonly string saveMessagedone = "تمت عملية التعديل";

        public static string SaveMessagedone
        {
            get { return OperationX.saveMessagedone; }

        }

        private static readonly string addMessageDone = "تمت اضافة سجل ";

        public static string AddMessageDone
        {
            get { return OperationX.addMessageDone; }

        }


    }
}

    

