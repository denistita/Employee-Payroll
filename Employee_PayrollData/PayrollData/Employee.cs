using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PayrollData
{
   public class Employee
    {
        // Member data
        private string developerName;
        private string address;
        private string age;
        private string departmentID;
        private string developerType;
        private string emptaxType;
        protected double monthlyGrossPay;
        protected double annualGrossPay;
        protected double netPay;
       

        // We made the taxRate const so no body can change it.
        private const double taxRate = 0.07;
        // Constructor constructs a record from a string (csv comma separated)
        public Employee(string devName, string addr, string devAge, double monGross, string deptId, string devType, string taxType, double annualGross, double net)
        {
            developerName = devName;
            address = addr;
            age = devAge;
            departmentID = deptId;
            developerType = devType;
            emptaxType = taxType;
            monthlyGrossPay = monGross;
            annualGrossPay = annualGross;
            netPay = net;
            

        }
       
      
        //return record in form of a string
        public virtual string tostring()
        {
            String result = "";
            result += "\r\nName: " + developerName + "\r\n";
            result += "Address: " + address + "\r\n";
            result += "Age: " + age + "\r\n";
            result += "Department ID: " + departmentID + "\r\n";
            result += "Developer Type: " + developerType + "\r\n";
            return result;
        }

    }
}
