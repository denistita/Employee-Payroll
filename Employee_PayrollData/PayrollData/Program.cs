using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollData
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        ///         // Create an instance of the new employee data class
        public static EmpData emps;

        [STAThread]
        static void Main()
        {
            emps = new EmpData();
            // Path is a string that points to the file that contains the employee data.
            // string path = "C:\\Users\\dftita\\Documents\\Virtual Studio 2019\\Projects\\ReadFile\\ReadFile\\bin\\data.txt";
            string path = "..\\data.txt";

            // Read this file to populate the emps member data.
            if (emps.Readfile(path))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
            else
            {
                System.Threading.Thread.Sleep(4000);
            }
            

        }
    }
}
