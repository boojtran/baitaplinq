using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using QuanLyNhanVien.Web.Bus;
using QuanLyNhanVien.Web.Data;


namespace ExampLINQ
{
    public partial class EditPage : System.Web.UI.Page
    {
        string a;
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            a = Request.QueryString["ID"];
            id = Convert.ToInt32(a);
            DBManager db = new DBManager();
            NhanVien nv = db.getNhanVienByID(id);

            txtAc.Text = nv.Account;
            txtBirth.Text = nv.BirthDate.ToString();
            txtFullname.Text = nv.FullName;
            txtGroup.Text = nv.Group;
            txtStartDate.Text = nv.startDate.ToString();
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            DBManager db = new DBManager();
            bool b = db.updateNhanVien(db.getNhanVienByID(id));
            if (b)
            {
                Label1.Text="Sửa Thành Công";
            }
            else Label1.Text = "Sửa Không Thành Công";
        }
    }
}
