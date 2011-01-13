using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuanLyNhanVien.Web.Frameworks.CommonFunctions
{
    public static class DateTimeHelper
    {
        public static DateTime formatDate(string textbox)
        {
            string givendate = "01/01/2010";
            IFormatProvider iFP = new System.Globalization.CultureInfo("en-GB", true); //This does the trick FROM US to Great Britain
            DateTime startDate =  Convert.ToDateTime(givendate + " 2:00:00 PM", iFP);
            if (textbox != "__/__/____")
            {
                startDate = Convert.ToDateTime(textbox + " 2:00:00 PM", iFP);
            }
            return startDate;
        }
    }
}
