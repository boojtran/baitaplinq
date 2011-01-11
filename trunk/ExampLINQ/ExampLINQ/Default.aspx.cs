using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExampLINQ
{
    public partial class _Default : System.Web.UI.Page
    {
        string IDRow;
        protected void Page_Load(object sender, EventArgs e)
        {
            gridNhanVien.DataSource = getNV();
            gridNhanVien.DataBind();
        }

        public List<NhanVien> getNV()
        {
            NVDatabaseDataContext db = new NVDatabaseDataContext();
            var qry = from p in db.NhanViens
                      select p;
            return qry.ToList();
        }

        protected void btnFilter_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtFromDate.Text = "";
            txtGroup.Text = "";
            txtToDate.Text = "";
            txtAcount.Text = "";
        }
        public List<NhanVien> FilterData(string name,string account)
        {
            NVDatabaseDataContext db = new NVDatabaseDataContext();
            var qry = from p in db.NhanViens
                      where p.FullName.StartsWith(name) && p.Account.StartsWith(account) 
                      select p;
            return qry.ToList();
        }

        protected void btnLoadData_Click(object sender, EventArgs e)
        {
            gridNhanVien.DataSource = FilterData(txtName.Text,txtAcount.Text);
            gridNhanVien.DataBind();            
        }

        protected void gridNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = gridNhanVien.SelectedRow;
            Label1.Text = "You selected " + row.Cells[2].Text + ".";
        }

        protected void gridNhanVien_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            //GridViewRow row = GridViewRow.Rows[e.NewSelectedIndex];


        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            NVDatabaseDataContext db = new NVDatabaseDataContext();
            int IDrow;
            GridViewRow row = gridNhanVien.SelectedRow;
            IDrow = int.Parse(row.Cells[1].Text);
            Label1.Text = "You selected " + IDrow + ".";
            var id = from p in db.NhanViens
                     where p.ID == IDrow
                     select p;
            db.NhanViens.DeleteAllOnSubmit(id);
            db.SubmitChanges();

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

    }
}
