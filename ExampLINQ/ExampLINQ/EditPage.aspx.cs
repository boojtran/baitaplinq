using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;



namespace ExampLINQ
{
    public partial class EditPage : System.Web.UI.Page
    {
        String a;
        protected void Page_Load(object sender, EventArgs e)
        {          
            NhanVien nv = getNhanVienByID();
            txtAc.Text = nv.Account;
            txtBirth.Text = nv.BirthDate.ToString();
            txtFullname.Text = nv.FullName;
            txtGroup.Text = nv.Group;
            txtStartDate.Text = nv.startDate.ToString();
        }
        public NhanVien getNhanVienByID()
        {
            a = Request.QueryString["ID"];
            int id = Convert.ToInt32(a);
            NVDatabaseDataContext db = new NVDatabaseDataContext();
            var mem = db.NhanViens.First(m => m.ID == id);
            return mem;
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien();
            nv.startDate = Convert.ToDateTime(txtStartDate.Text);
            nv.FullName = txtFullname.Text;
            nv.Group = txtGroup.Text;
            nv.BirthDate = txtBirth.Text;
            nv.Account = txtAc.Text;
            NVDatabaseDataContext db = new NVDatabaseDataContext();
            db.NhanViens.Attach(nv,true);
            db.SubmitChanges();
            Label1.Text = "Sửa Thành Công";
        }
    }
}
