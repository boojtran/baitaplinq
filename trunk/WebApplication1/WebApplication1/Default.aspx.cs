using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QuanLyNhanVien.Web.Bus;

namespace WebApplication1
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData(){
            DBManager bus = new DBManager();
            gridNhanVien.DataSource = bus.getNV();
            gridNhanVien.DataBind();
        }

        protected void btnLoadData_Click(object sender, EventArgs e)
        {
            DBManager bus = new DBManager();
            gridNhanVien.DataSource = bus.filterNV(txtFromDate.Text,txtToDate.Text,txtGroup.Text,txtAcount.Text,txtName.Text);
            gridNhanVien.DataBind();
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            DBManager bus = new DBManager();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            DBManager bus = new DBManager();
        }

        protected void btnAddNews_Click(object sender, EventArgs e)
        {
            DBManager bus = new DBManager();
        }

        protected void btnEditItem_Click(object sender, EventArgs e)
        {
            DBManager bus = new DBManager();
        }

        protected void gridNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gridNhanVien_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }
    }
}
