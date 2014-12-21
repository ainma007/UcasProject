using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ucas.Data.CommandClass
{
    public class AttachmentsClass{

        static UcasProEntities db = new UcasProEntities();
        public static bool NewAttachment(Attachment tb)
        {
            try
            {
                db = new UcasProEntities();
                //db.Configuration.ProxyCreationEnabled = false;
                // db.Configuration.LazyLoadingEnabled = false;
                db.Attachments.Add(tb);
                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public static bool EditAttachment(Attachment tb)
        {
            try
            {
                db = new UcasProEntities();
                db.Configuration.LazyLoadingEnabled = false;
                db.Configuration.ProxyCreationEnabled = false;
                var q = db.Attachments.Where(p => p.IDX == tb.IDX).SingleOrDefault();
                q.AttachmentName = tb.AttachmentName;
                q.CreateDate = tb.CreateDate;

                q.ProjectProfile_ID = tb.ProjectProfile_ID;


                db.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {


                return false;
            }
        }

        //public static bool DeleteAttachment(int ID)
        //{
        //    try
        //    {
        //        db = new UcasProEntities();
        //        db.Configuration.LazyLoadingEnabled = false;
        //        db.Configuration.ProxyCreationEnabled = false;
        //        var q = db.Attachments.Where(p => p.ID == ID).SingleOrDefault();
        //        db.Attachments.Remove(q);
        //        db.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {

        //        return false;
        //    }
        //}

        //public static List<Attachment> GetAllAttachment()
        //{
        //    db = new UcasProEntities();
        //    db.Configuration.LazyLoadingEnabled = false;
        //    db.Configuration.ProxyCreationEnabled = false;
        //    return db.Attachments.ToList();
        //}

          public static List<Attachment> GetGetAllAttachmentByproID(int ProID)
        {
            db = new UcasProEntities();
            
            var LST = (from c in db.Attachments
                       where c.ProjectProfile_ID == ProID
                       select c).ToList();
            return LST;
        }

    }
    
    }
