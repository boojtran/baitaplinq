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
    }
}
