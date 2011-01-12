using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using QuanLyNhanVien.Web.Data;

namespace QuanLyNhanVien.Web.Bus
{
    public class DBManager
    {
        public List<NhanVien> getNV()
        {
            NVDatabaseDataContext db = new NVDatabaseDataContext();
            var qry = from p in db.NhanViens
                      select p;
            return qry.ToList();
        }
    }
}
