using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Prototype
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string newWindowUrl = "pmRequest.aspx";
            string javaScript =
             "<script type='text/javascript'>\n" +
             "<!--\n" +
             "var width=750;" +
             "var height=500;" +
             "var left   = (screen.width  - width)/2;" +
             "var top    = (screen.height - height)/2;" +
             "window.open('" + newWindowUrl + "','AddNew','width='+width+', height='+height+',top='+top+', left='+left+',menubar=no,toolbar=no,location=no,status=yes,scrollbars=yes,resizable=no');\n" +
             "// -->\n" +
             "</script>\n";
            Page.RegisterStartupScript("Edit", javaScript); 
        }
    }
}
