using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDashboard
{
    public class EmployeeDetails
    {

        public static string companyName;
        private int empId;
        public string empName;
        public int empSalary;
        private char empPerformance;

        //constructor

        public EmployeeDetails()
        {
            Console.WriteLine("launch the browser");

        }

        
        //encapsulation concept
       public int EmployeeID
        {
            get
            {
                return empId;
            }
            set
            {
                if (value > 100)
                {
                    empId = value;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
            }
        }

        public char EmployeePerformance
        {
            get
            {
                return empPerformance;
            }
            set
            {
                if ((value == 'A') || (value == 'B') || (value=='C'))
                {
                    empPerformance = value;
                }
                else
                {
                    Console.WriteLine("invalid input");

                }
            }
        }
       public void display()
        {
            Console.WriteLine("Name " + empName);
            Console.WriteLine("id " +empId);
            Console.WriteLine("Salary " + empSalary);
            Console.WriteLine("performance "+empPerformance);
            Console.WriteLine("company name "+EmployeeDetails.companyName);
            Console.WriteLine("----------------------------------------------------------------- ");
            
            
        }

        public void AllocateBonus()
        {
            if(empPerformance !=null)
            {
                if (empPerformance == 'A')
                {
                    empSalary = empSalary + 1000;
                }
                else if (empPerformance == 'B')
                {
                    empSalary = empSalary + 500;
                }
                else
                {
                    empSalary = empSalary + 100;
                }
            }
           
            
        }


        

    }


}
