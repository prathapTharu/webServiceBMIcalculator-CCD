using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace webServiceBMIcalculator
{
    /// <summary>
    /// Summary description for BMIcalculatorWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BMIcalculatorWebService : System.Web.Services.WebService
    {

        [WebMethod]
        public double BMI( double Hight, double weight )
        {
            double Result;
            Result = (weight) / (Hight * Hight);
            return Result;
           
        }
        [WebMethod]
        public double AgeCalc(DateTime Birth_date)
        {
            var today = DateTime.Today;
            var Age = today.Year - Birth_date.Year;
            if (Birth_date > today.AddYears(-Age)) Age--;
            return Age;
           
        }
       
    }
}
