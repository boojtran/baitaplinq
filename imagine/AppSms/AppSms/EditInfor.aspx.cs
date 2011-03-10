using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using AppSmsEntity;
using AppSmsBusiness;

namespace AppSms
{
    public partial class EditInfor : System.Web.UI.Page
    {  
        string idTeacher;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            idTeacher = Request.QueryString["IDTeacher"];
            if (!IsPostBack) {
                loadDropDownList();
                loadDataforUpdate(Int32.Parse(idTeacher));
            }
            
        }
        /// <summary>
        /// /Update into Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSave_Click(object sender, EventArgs e)
        {
            var db = new AppSmsBusiness.DBManager();
            DateTime birthdate = DateTime.Parse(txtCalendar.Text);
            string fullName = txtFullName.Text;
            string email = txtEmail.Text;
            int phone = Int32.Parse(txtPhone.Text);
            int permission = Int32.Parse(drPermission.SelectedValue);
            int degree = Int32.Parse(drDegree.SelectedValue);
            string account = txtAccount.Text;

            if (db.UpdateTeacher(permission,phone,account,degree,email,fullName,birthdate,Int32.Parse(idTeacher)))
            {
                sqlLabelError.Text = "Update Thành Công !";
                sqlLabelError.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                sqlLabelError.Text = "Update Không Thành Công !";
                sqlLabelError.ForeColor = System.Drawing.Color.Red;
            }

        }
       

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }
        public void loadDataforUpdate(int idTeacher){
            try
            {
                var db = new AppSmsBusiness.DBManager();
                Teacher a = db.getTeacherbyID(idTeacher);
                txtAccount.Text = a.Account;
                txtCalendar.Text = a.BirthDate.ToString();
                txtFullName.Text = a.FullName;
                txtPhone.Text = a.Phone.ToString();
                drDegree.SelectedValue = a.DegreeID.ToString();
                txtEmail.Text = a.Email.ToString();
                drPermission.SelectedValue = a.IDPermission.ToString();            
            }
            catch (DataException de)
            {
            }
        }
        /// <summary>
        /// ////////////
        /// </summary>
        public void loadDropDownList()
        { 
            try
            {
                var db = new AppSmsBusiness.DBManager();
                drPermission.DataSource = db.getPermission();
                drPermission.DataBind();
                ////////////
                drDegree.DataSource = db.getDegree();
                drDegree.DataBind();
            }
            catch (DataException de)
            {       
            }
        }

        protected void imgCalendar_Click1(object sender, ImageClickEventArgs e)
        {

        }
    }
}
