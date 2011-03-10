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

namespace AppSmsEntity
{
    public class Teacher
    {
        public int IDTeacher { get; set; }
        public int IDPermission { get; set; }
        public int Phone { get; set; }
        public string Password { get; set; }
        public string Account { get; set; }
        public int DegreeID { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Code { get; set; }
        public DateTime BirthDate { get; set; }
        
    }
    public class Permission
    {
        public int IDPermission { get; set; }
        public string PermissionName { get; set; }
        public string Details { get; set; }
    }
    public class Degree
    {
        public int ID { get; set; }
        public string DegreeName { get; set; }
        public string Other { get; set; }
    }
}
