using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollData
{
   public class Developer1099 : Employee
    {
       
      public   Developer1099(string devName, string addr, string devAge, double monGross, string deptId, string devType, string taxType, double annualGross, double net) : base(devName, addr, devAge, monGross, deptId, devType, taxType, annualGross, net)
        {
          
        }


        public override string tostring()
        {
            string result = "";
            result += "Employee Type:  1099" + "\r\n";
            result += base.tostring();     
            result += "Net pay is  : " + netPay.ToString("C", CultureInfo.CurrentCulture) + "\r\n";
            return result;
        }
    }
}
