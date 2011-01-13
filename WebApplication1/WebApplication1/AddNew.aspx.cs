using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyNhanVien.Web.Bus;

namespace ExampLINQ
{
    public partial class AddNew : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DBManager db = new DBManager();
            bool a = db.addNhanVien(txtStartDate.Text,txtBirthDate.Text,txtGroup.Text,txtAccount.Text,txtFullName.Text);
            if (a == true)
            {
                Label1.Text = "Thêm Thành công !";
            }
            else Label1.Text = "Thêm Không Thành công !";
        }
    }
}
