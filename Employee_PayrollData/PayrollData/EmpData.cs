using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PayrollData
{
   
    public class EmpData
    {
        // Member data
        private const double taxRate = 0.07;
        private List<Employee> list;
        // Default constructor because there are no parameters.
        public EmpData()
        {
            list = new List<Employee>();
        }
        // Read employee records from the file through the path specified in the parameter string.
        public bool Readfile(string path)
        {
            // Check to see that this path is valid.
            try
            {         
                string line;
                using (StreamReader sr = new StreamReader(path))
                {
                    // Read one line at a time.
                    while ((line = sr.ReadLine()) != null)
                    {
                        // If the line is not blank, then 
                        if (line != "")
                        {
                            //Use a split() method to split strings with comma (',') delimiter and returning the substrings as string array
                            string[] fields = line.Split(',');
                           // Use for loop to iterate through string elements.
                            for (int i = 0; i < fields.Length; i++)
                            {
                                fields[i] = fields[i].Trim();
                            }
                            // We have exactly seven fields. Report error if not 7.
                            if (!isCorrectFields(fields))
                            {
                                //Console.WriteLine("Invalid Record");
                                throw new FormatException();
                            }
                            // Since we have exactly 7 fields, we could do [0], [1], [2] with each of the fields.
                            // field[0] is the developer name, field[1] is the address, and field[2] is the age.
                            string developerName = fields[0];
                            string address = fields[1];
                            string age = fields[2];
                            string emptaxType = fields[3];
                            double monthlyGrossPay = double.Parse(fields[4]);
                            double annualGrossPay = 0;
                            double monthlyTaxes = 0;
                            double annualTaxes = 0;
                            double netPay = 0;
                          

                            string departmentID = fields[5];
                            string developerType = fields[6];
                            Employee newemp = null;
                            if (emptaxType.Equals("W2"))
                            {
                               
                                annualGrossPay = 12 * monthlyGrossPay;
                                monthlyTaxes = (monthlyGrossPay * taxRate);
                                annualTaxes = monthlyTaxes * 12;
                                netPay = monthlyGrossPay - monthlyTaxes;
                                newemp = new DeveloperW2(developerName, address, age, monthlyGrossPay, departmentID, developerType, emptaxType, annualGrossPay, netPay, monthlyTaxes, annualTaxes);
                            }
                            else
                            {
                                netPay = monthlyGrossPay;
                                 newemp = new Developer1099(developerName, address, age, monthlyGrossPay, departmentID, developerType, emptaxType, annualGrossPay, netPay);

                            }
                           


                            //Create an employee record from the line and add the employee to list.
                            list.Add(newemp);
                        }
                    }
                    // Close the StreamReader
                    sr.Close();
                }
            }
            // All errors are caught here.
            catch (Exception e)
            {
                Console.WriteLine("\n\nERROR= " + e.Message);
                Console.WriteLine("Exiting program...");
                return false;
               // System.Environment.Exit(1);
            }
            return true;
        }

        private bool isCorrectFields(string[] fields)
        {
            if (fields.Length == 7)
            {
                //check if first two fields are non-numeric
                return true;
            }
            return false;

        }
             

        //returns a string with all records
        public String tostring()
        {
            String result = "";
            // We iterate over each of the employees
            for (int i = 0; i < list.Count; i++)
            {
                // print each employee.
                Employee emp = list[i];
                result += emp.tostring();
            }
            return result;
        }

    }
}
