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
    public partial class Search : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        public void LoadData()
        {
            try
            {
                var db = new AppSmsBusiness.DBManager();
                GridView2.DataSource = db.getTeacher();
                GridView2.DataBind();
            }
            catch (DataException de)
            {
                lablMessSearch.Text = de.Message;
                lablMessSearch.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                lablMessSearch.Text = "Data Shown Sucessfully";
                lablMessSearch.ForeColor = System.Drawing.Color.Green;
            }
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string nameTK = txtName.Text;
            try
            {
                var db = new AppSmsBusiness.DBManager();
                GridView2.DataSource = db.searchTeacherbyName(nameTK);
                GridView2.DataBind();
            }
            catch (DataException de)
            {
                lablMessSearch.Text = de.Message;
                lablMessSearch.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                lablMessSearch.Text = "Data Shown Sucessfully";
                lablMessSearch.ForeColor = System.Drawing.Color.Blue;
            }
        }

        protected void GridView2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case ("ibtnEdit"):
                    int IDrow=15;
                    //get ID row
                    int index = Convert.ToInt32(e.CommandArgument);
                    //GridViewRow row = GridView2.Rows[index];
                    IDrow = int.Parse(GridView2.DataKeys[index].Value.ToString());
                    ScriptManager.RegisterStartupScript(Page, Page.GetType(), "Success", "floatingWindows('EditInfor.aspx?IDTeacher=" + IDrow + "')", true);
                    break;
                case ("ibtnDelete"):
                    break;
            }
        }
    }
}
