using Client.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client.DAL
{
    public class DAL
    {
        public static ConfsContext db = new ConfsContext();

        public void SaveChanges()
        {
            db.SaveChanges();
        }

        #region Conference

        public List<Conference> getList()
        {
            return db.Conferences.ToList();
        }

        public Conference findById(string id)
        {
            return db.Conferences.Find(id);
        }



        #endregion


        #region News


        #endregion

        #region User

        #endregion


    }
}