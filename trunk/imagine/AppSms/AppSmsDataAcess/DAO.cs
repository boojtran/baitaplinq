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
using System.Collections.Generic;
using System.Data.SqlClient;

namespace AppSmsDataAcess
{
    public class DAO
    {
        private string stringconnection = "Data Source=ITFRIEND\\SQLEXPRESS;Initial Catalog=SmsCoaxial;Persist Security Info=True;User ID=sa;Password=tuan;Pooling=False";
        
        public List<Teacher> getTeacher()
        {
            var cn = new SqlConnection(stringconnection);
            cn.Open();

            var cmd = new SqlCommand("select * from Teacher", cn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();

            var result = new List<Teacher>();

            while (reader.Read())
            {
                var entity = new Teacher();
                entity.IDTeacher = int.Parse(reader["IDTeacher"].ToString());
                entity.IDPermission = int.Parse(reader["IDPermission"].ToString());
                entity.Phone = int.Parse(reader["Phone"].ToString());
                entity.Password = reader["Password"].ToString();
                entity.Account = reader["Account"].ToString();
                entity.DegreeID = int.Parse(reader["DegreeID"].ToString());
                entity.Email = reader["Email"].ToString();
                entity.FullName = reader["FullName"].ToString();
                entity.BirthDate = DateTime.Parse(reader["BirthDate"].ToString());
                result.Add(entity);
            }
            cn.Close();

            return result;
        }

        public List<AppSmsEntity.Degree> getDegree()
        {
            var cn = new SqlConnection(stringconnection);
            cn.Open();
            var cmd = new SqlCommand("select * from Degree", cn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            var result = new List<Degree>();
            while (reader.Read())
            {
                var entity = new Degree();
                entity.ID = int.Parse(reader["ID"].ToString());
                entity.DegreeName = reader["DegreeName"].ToString();
                entity.Other = reader["Other"].ToString();
                result.Add(entity);
            }
            cn.Close();
            return result;
        }

        public List<Permission> getPermission()
        {
            var cn = new SqlConnection(stringconnection);
            cn.Open();
            var cmd = new SqlCommand("select * from Permission", cn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader = cmd.ExecuteReader();
            var result = new List<Permission>();
            while (reader.Read())
            {
                var entity = new Permission();
                entity.IDPermission = int.Parse(reader["IDPermission"].ToString());
                entity.PermissionName = reader["PermissionName"].ToString();
                entity.Details = reader["Details"].ToString();
                result.Add(entity);
            }
            cn.Close();
            return result;
        }
        //////////
        public void deleteTeachers(int id)
        {
            SqlConnection conn = new SqlConnection(stringconnection);
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from Teacher where IDTeacher=" + id, conn);
                cmd.ExecuteNonQuery();
            }
            finally
            {
                conn.Close();
            }
        }
        //////////
        public void deleteAllTeachers()
        {
            SqlConnection conn = new SqlConnection(stringconnection);
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "delete from Teacher";
                cmd.CommandType = CommandType.Text;
                conn.Open();
                cmd.ExecuteScalar();
                conn.Close();
            }
            finally
            {
                conn.Close();
            }
        }
        ///////////////////
         public void insertdataintosql(string tphone, string taccount, string tpass, int tdgree, string temail, string tfullname ,DateTime tbirthdate)
        {      
            SqlConnection conn = new SqlConnection(stringconnection);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            int idpermission = 1;
            cmd.CommandText = "insert into Teacher(IDPermission,Phone,Password,Account,DegreeID,Email,FullName,BirthDate) values(@tidpermission,@tphone,@tpassword,@taccount,@tdegree,@temail,@tfullname,@tbirthdate)";
            cmd.Parameters.Add("@tidpermission", SqlDbType.Int).Value = idpermission;
            cmd.Parameters.Add("@tphone", SqlDbType.Int).Value = Convert.ToInt32(tphone);
            cmd.Parameters.Add("@tpassword", SqlDbType.NVarChar).Value = tpass;
            cmd.Parameters.Add("@taccount", SqlDbType.NVarChar).Value = taccount;
            cmd.Parameters.Add("@tdegree", SqlDbType.Int).Value = tdgree;
            cmd.Parameters.Add("@temail", SqlDbType.NVarChar).Value = temail;
            cmd.Parameters.Add("@tfullname", SqlDbType.NVarChar).Value = tfullname;
            cmd.Parameters.Add("@tbirthdate", SqlDbType.DateTime).Value = tbirthdate;
            cmd.CommandType = CommandType.Text;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        ////////////////////////
         public List<Teacher> searchTeacherbyName(string name)
         {
             var cn = new SqlConnection(stringconnection);
             cn.Open();
             var cmd = new SqlCommand("select * from Teacher where fullname like '%" + name + "%'", cn);
             cmd.CommandType = CommandType.Text;
             SqlDataReader reader = cmd.ExecuteReader();
             var result = new List<Teacher>();
             while (reader.Read())
             {
                 var entity = new Teacher();
                 entity.IDTeacher = int.Parse(reader["IDTeacher"].ToString());
                 entity.IDPermission = int.Parse(reader["IDPermission"].ToString());
                 entity.Phone = int.Parse(reader["Phone"].ToString());
                 entity.Password = reader["Password"].ToString();
                 entity.Account = reader["Account"].ToString();
                 entity.DegreeID = int.Parse(reader["DegreeID"].ToString());
                 entity.Email = reader["Email"].ToString();
                 entity.FullName = reader["FullName"].ToString();
                 entity.BirthDate = DateTime.Parse(reader["BirthDate"].ToString());
                 result.Add(entity);
             }
             cn.Close();
             return result;
         }
        ////////////////////////////
         public Teacher getTeacherbyID(int idTeacher)
         {
             Teacher a = new Teacher();
                 var cn = new SqlConnection(stringconnection);
                 cn.Open();
                 var cmd = new SqlCommand("select * from Teacher where IDTeacher=" + idTeacher + "", cn);
                 cmd.CommandType = CommandType.Text;
                 SqlDataReader reader = cmd.ExecuteReader();
                 while (reader.Read())
                 {
                     a.Account = reader["Account"].ToString();
                     a.BirthDate= DateTime.Parse(reader["BirthDate"].ToString());
                     a.FullName = reader["FullName"].ToString();
                     a.Phone = Int32.Parse(reader["Phone"].ToString());
                     a.DegreeID = Int32.Parse(reader["DegreeID"].ToString());
                     a.Email = reader["Email"].ToString();
                     a.IDPermission = Int32.Parse(reader["IDPermission"].ToString());
                 }
                 cn.Close();
                 return a; 
         }
        //////////////////////////////
         public bool UpdateTeacher(int permission, int phone, string account, int degree, string email, string fullName, DateTime birthdate, int idTeacher)
         {
             SqlConnection conn = new SqlConnection(stringconnection);
             try
             {
                 string query = "Update Teacher set IDPermission=" + permission + ",Phone=" + phone + ",Account='" + account + "',DegreeID=" + degree + ",Email='" + email + "',FullName='" + fullName + "',BirthDate='" + birthdate + "' where idTeacher=" + idTeacher;
                 SqlCommand DataCommand = new SqlCommand(query, conn);
                 DataCommand.Connection.Open();
                 // execute the statement and return the number of affected rows
                 int i = DataCommand.ExecuteNonQuery();
                 //close the connection
                 DataCommand.Connection.Close();
                 return true;

             }
             catch (Exception e) { return false; }
             finally
             {
                 conn.Close();
             }
         }
        ///////////////////////////

    }
}
