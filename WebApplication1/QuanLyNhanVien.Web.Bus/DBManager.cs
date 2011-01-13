using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Text;
using QuanLyNhanVien.Web.Data;

namespace QuanLyNhanVien.Web.Bus
{
    public class DBManager
    {
        public List<QuanLyNhanVien.Web.Data.NhanVien> getNV()
        {
            NVDatabaseDataContext db = new NVDatabaseDataContext();
            var qry = from p in db.NhanViens
                      select p;
            return qry.ToList();
        }

        public List<QuanLyNhanVien.Web.Data.NhanVien> filterNV(DateTime fromdate,DateTime todate,string gr,string acc,string name)
        {
            NVDatabaseDataContext db = new NVDatabaseDataContext();
            var qry = from p in db.NhanViens
                      where p.FullName.StartsWith(name) 
                            && p.Group.CompareTo(gr)==0
                            && p.Account.Contains(acc)
                            && p.startDate >= fromdate
                            && p.startDate <= todate
                      select p;
            return qry.ToList();
        }

        public NhanVien getNhanVienByID(int idNhanvien)
        {
            NVDatabaseDataContext db = new NVDatabaseDataContext();
            var mem = db.NhanViens.First(m => m.ID == idNhanvien);
            return mem;
        }

        public bool addNhanVien(string startDate, string birthDate, string gr, string acc, string name)
        {
            try
            {
                NVDatabaseDataContext db = new NVDatabaseDataContext();
                NhanVien nv = new NhanVien
                {
                    startDate = Convert.ToDateTime(startDate),
                    BirthDate = birthDate,
                    FullName = name,
                    Group = gr,
                    Account = acc
                };
                db.NhanViens.InsertOnSubmit(nv);
                db.SubmitChanges();
                return true;
            }
            catch (Exception e) { return false; }
        }

        public bool updateNhanVien(NhanVien nv)
        {
            try
            {
                NVDatabaseDataContext db = new NVDatabaseDataContext();
                db.NhanViens.Attach(nv, true);
                db.SubmitChanges();
                return true;
            }
            catch (Exception e) { return false; }
        }
        public bool deleteNhanVien(int id)
        {
            try
            {
                NVDatabaseDataContext db = new NVDatabaseDataContext();
                var qry = from p in db.NhanViens
                         where p.ID == id
                         select p;
                db.NhanViens.DeleteAllOnSubmit(qry);
                db.SubmitChanges();
                return true;
            }
            catch (Exception e) { return false; }
            
        }
    }
}
