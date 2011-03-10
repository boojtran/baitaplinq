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
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using AppSmsEntity;
using AppSmsBusiness;

namespace AppSms
{
    public partial class _Default : System.Web.UI.Page
    {
        private string strFilename;//get directory File Excel
        private string stringconnection = "Data Source=ITFRIEND\\SQLEXPRESS;Initial Catalog=SmsCoaxial;Persist Security Info=True;User ID=sa;Password=tuan;Pooling=False";

        protected void Page_Load(object sender, EventArgs e)
        {
            loadData();//load Data on first load page
        }
        protected void insertdata_Click(object sender, EventArgs e)
        {
            uploadFile();
            OleDbConnection oconn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("FileUpload\\" + strFilename + "") + ";Extended Properties='Excel 8.0;HDR=YES;IMEX=1'");
            try
            {
                OleDbCommand ocmd = new OleDbCommand("select * from [Data$7:200]", oconn);
                oconn.Open();
                OleDbDataReader odr = ocmd.ExecuteReader();
                string phone = "";
                string account = "";
                string password = "";
                string birthdate = "";
                string email = "";
                string fullname = "";
                int i = 1;
                if (odr.HasRows==true )
                {                 
                    while (odr.Read() == true )
                    {
                            fullname = valid(odr, 1);
                            birthdate = valid(odr, 2);                            
                            account = valid(odr, 3); //lay ma giang vien làm account đăng nhập
                            password = "12345678";   //pass tự sinh ra
                            email = valid(odr, 4);
                            phone = valid(odr, 5);
                            int degree = 1 ;             
                            if ("0".Equals(fullname)) break;
                            var db = new AppSmsBusiness.DBManager();
                            db.insertTeacher(phone, account, password, degree, email, fullname , DateTime.Parse(birthdate));
                    }
                   
                }
                oconn.Close();
            }
            catch (DataException ee)
            {
               
                lblmsg.Text = ee.Message;
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                loadData();
                lblmsg.Text = "Data Inserted Sucessfully";
                lblmsg.ForeColor = System.Drawing.Color.Green;
            }
        }
        protected string valid(OleDbDataReader myreader, int stval)
        //if any columns are found null then they are replaced by zero
        {
            object val = myreader[stval];
            if (val != DBNull.Value)//neu khac null thi tra ve gia tri
                return val.ToString();
            else
                return Convert.ToString(0);
        }

        /// <summary>
        /// get data from Database
        /// </summary>
        public void loadData()
        {
            try
            {
                var db = new AppSmsBusiness.DBManager();
                GridView1.DataSource = db.getTeacher();
                GridView1.DataBind();
            }
            catch (DataException de)
            {
                lblmsg.Text = de.Message;
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                lblmsg.Text = "Data Shown Sucessfully";
                lblmsg.ForeColor = System.Drawing.Color.Green;
            }
        }
        //view data action
        protected void viewdata_Click(object sender, EventArgs e)
        {
            loadData();
        }
        //--------------------------
       

        public void uploadFile()
        {
            if (filMyFile.PostedFile != null)
            {
                HttpPostedFile myFile = filMyFile.PostedFile;
                int nFileLen = myFile.ContentLength; //get length               
                byte[] myData = new byte[nFileLen];
                myFile.InputStream.Read(myData, 0, nFileLen);
                strFilename = Path.GetFileName(myFile.FileName);//get url
                string type = myFile.ContentType;  //get type
                WriteToFile(Server.MapPath(@"FileUpload/" + strFilename), ref myData);// Write data into a file
            }
        }

        // Writes file to current folder
        private void WriteToFile(string strPath, ref byte[] Buffer)
        {
            // Create a file
            FileStream newFile = new FileStream(strPath, FileMode.Create);
            // Write data to the file
            newFile.Write(Buffer, 0, Buffer.Length);
            // Close file
            newFile.Close();
        }

        protected void deletedata_Click(object sender, EventArgs e)
        {
            try
            {
                var db = new AppSmsBusiness.DBManager();
                db.deleteAllTeachers();
                loadData();
            }
            catch (DataException de1)
            {
                lblmsg.Text = de1.Message;
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
            finally
            {
                lblmsg.Text = "Data Deleted Sucessfully";
                lblmsg.ForeColor = System.Drawing.Color.Red;
            }
            loadData();
        }
    }
}
