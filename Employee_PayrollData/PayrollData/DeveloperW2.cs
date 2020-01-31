using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace PayrollData
{
    public class DeveloperW2 : Employee
    {
        private double monthlyTaxes;
        private double annualTaxes;
        public DeveloperW2(string devName, string addr, string devAge, double monGross, string deptId, string devType, string taxType, double annualGross, double net, double monTax, double annualTax) : base(devName, addr, devAge, monGross, deptId, devType, taxType, annualGross, net) {
            monthlyTaxes = monTax;
            annualTaxes = annualTax;

        }

    
        public override string tostring()
        {
            string result = "";
            result += "Employee Type:  W2" + "\r\n";
            result += base.tostring();          
            result += "Monthly gross pay: " + monthlyGrossPay.ToString("C", CultureInfo.CurrentCulture) + "\r\n";
            result += "Annual gross pay: " + annualGrossPay.ToString("C", CultureInfo.CurrentCulture) + "\r\n";
            result += "Monthly taxes paid  : " + monthlyTaxes.ToString("C", CultureInfo.CurrentCulture) + "\r\n";
            result += "Annual taxes paid  : " + annualTaxes.ToString("C", CultureInfo.CurrentCulture) + "\r\n";
            result += "Net pay is  : " + netPay.ToString("C", CultureInfo.CurrentCulture) + "\r\n";
            return result;
        }
    }

}

