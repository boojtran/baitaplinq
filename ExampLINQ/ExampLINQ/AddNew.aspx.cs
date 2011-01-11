using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExampLINQ
{
    public partial class AddNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            NVDatabaseDataContext db = new NVDatabaseDataContext();
            NhanVien nv = new NhanVien
            {
                startDate = Convert.ToDateTime(txtStartDate.Text),
                BirthDate = txtBirthDate.Text,
                FullName = txtFullName.Text,
                Group = txtGroup.Text
            };
            db.NhanViens.InsertOnSubmit(nv);
            db.SubmitChanges();
            Label1.Text = "Thêm Thành công !";
        }
    }
}
