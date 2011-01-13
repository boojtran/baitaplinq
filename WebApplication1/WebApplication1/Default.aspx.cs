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
            txtName.Text = "";
            txtFromDate.Text = "";
            txtGroup.Text = "";
            txtToDate.Text = "";
            txtAcount.Text = "";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int IDrow;
            GridViewRow row = gridNhanVien.SelectedRow;
            IDrow = int.Parse(row.Cells[1].Text);
            Label1.Text = "You selected " + IDrow + ".";
            DBManager db = new DBManager();
            if (db.deleteNhanVien(IDrow))
            {
                  Label1.Text = "Xoa Thanh Cong";
                  loadData();
            }
            else Label1.Text = "Xoa Bi Loi";
        }

        protected void btnAddNews_Click(object sender, EventArgs e)
        {
            string newWindowUrl = "AddNew.aspx";
            string javaScript =
             "<script type='text/javascript'>\n" +
             "<!--\n" +
             "var width=600;" +
             "var height=300;" +
             "var left   = (screen.width  - width)/2;" +
             "var top    = (screen.height - height)/2;" +
             "window.open('" + newWindowUrl + "','AddNew','width='+width+', height='+height+',top='+top+', left='+left+',menubar=no,toolbar=no,location=no,status=yes,scrollbars=yes,resizable=yes');\n" +
             "// -->\n" +
             "</script>\n";
            Page.RegisterStartupScript("Edit", javaScript); 
        }

        protected void btnEditItem_Click(object sender, EventArgs e)
        {
            int IDrow;
            GridViewRow row = gridNhanVien.SelectedRow;
            IDrow = int.Parse(row.Cells[1].Text);
            string newWindowUrl = "EditPage.aspx?ID=" + IDrow;
            string javaScript =
             "<script type='text/javascript'>\n" +
             "<!--\n" +
             "var width=600;" +
             "var height=300;" +
             "var left   = (screen.width  - width)/2;" +
             "var top    = (screen.height - height)/2;" +
             "window.open('" + newWindowUrl + "','AddNew','width='+width+', height='+height+',top='+top+', left='+left+',menubar=no,toolbar=no,location=no,status=yes,scrollbars=yes,resizable=yes');\n" +
             "// -->\n" +
             "</script>\n";
            Page.RegisterStartupScript("Edit", javaScript);
        }

        protected void gridNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gridNhanVien.SelectedRow;
            Label1.Text = "You selected " + row.Cells[2].Text + ".";
        }

        protected void gridNhanVien_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {

        }
    }
}
