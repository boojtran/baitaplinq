using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using AppSmsEntity;
using AppSmsDataAcess;
using System.Collections.Generic;

namespace AppSmsBusiness
{
    public class DBManager
    {
        public List<Teacher> getTeacher()
        {
            var dao = new AppSmsDataAcess.DAO();
            return dao.getTeacher();
        }
        public List<Degree> getDegree()
        {
            var dao = new AppSmsDataAcess.DAO();
            return dao.getDegree();
        }

        public List<Permission> getPermission()
        {
            var dao = new AppSmsDataAcess.DAO();
            return dao.getPermission();
        }

        public List<Teacher> searchTeacherbyName(string name)
        {
            var dao = new AppSmsDataAcess.DAO();
            return dao.searchTeacherbyName(name);
        }

        public Teacher getTeacherbyID(int id)
        {
            var dao = new AppSmsDataAcess.DAO();
            return dao.getTeacherbyID(id);
        }
        public bool UpdateTeacher(int permission, int phone, string account, int degree, string email, string fullName, DateTime birthdate,int idTeacher)
        {
            var dao = new AppSmsDataAcess.DAO();
            return dao.UpdateTeacher(permission, phone, account, degree, email, fullName, birthdate, idTeacher);
        }

        public void deleteTeacher(int id)
        {
            var dao = new AppSmsDataAcess.DAO();
            dao.deleteTeachers(id);
        }

        public void deleteAllTeachers()
        {
            var dao = new AppSmsDataAcess.DAO();
            dao.deleteAllTeachers();
        }
        public void insertTeacher(string tphone, string taccount, string tpass, int tdgree, string temail, string tfullname, DateTime tbirthdate)
        {
            var dao = new AppSmsDataAcess.DAO();
            dao.insertdataintosql(tphone,taccount,tpass,tdgree,temail,tfullname,tbirthdate);
        }
    }
}
