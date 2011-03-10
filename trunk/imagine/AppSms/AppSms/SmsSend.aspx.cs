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
using System.Collections.Generic;
using System.ComponentModel;
using MSRI.SmsService;
using MSRI.HelperClasses;


namespace AppSms
{
    public partial class SmsSend : System.Web.UI.Page
    {
        public SmsServiceClass SmsService = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            //checkService(SmsService);
        }

        void SmsService_OnDeliveryReportReceived(DeliveryReportClass DeliveryReport)
        {
            if (DeliveryReport.Status == DeliveryStatusEnum.Sent)
            {
                //  int a = 2;
            } 
            else
            {
                //int b = 3;
            }
        }

        public void checkService(SmsServiceClass SmsService)
        {
          //  ScriptManager.RegisterStartupScript(Page, Page.GetType(), "Success", "alert('sv:  " + SmsService.ToString() + "')", true);
            if (SmsService == null)
            {
            SmsService = new SmsServiceClass("SMS in WEB");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            string a = txtNoiDung.Text;
            string b = txtTo1.Text;
           // ScriptManager.RegisterStartupScript(Page, Page.GetType(), "Success", "alert('Ban vua nhap "+a+"va "+b+"')", true);
            try
            {
                    SmsClass Message = new SmsClass();
                    Message.Number = a;
                    Message.Body = b;
                    SmsService.SendSms(Message);
                    SmsService = null; 
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterStartupScript(Page, Page.GetType(), "Success", "alert('Loi " +ex.ToString()+ "')", true);
            }
        
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
