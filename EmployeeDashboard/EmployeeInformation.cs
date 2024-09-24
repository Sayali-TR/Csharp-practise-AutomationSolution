using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeDashboard;

namespace EmployeeManagement
{
    public class EmployeeInformation
    {

       static void Main(string[] args)
        {
            String companyName = EmployeeDetails.companyName = "Thomson Reuters";
            Console.WriteLine(companyName);

            EmployeeDetails e1 = new EmployeeDetails();
            EmployeeDetails e2 = new EmployeeDetails();
            EmployeeDetails e3 = new EmployeeDetails();

            e1.empId = 100;
            e1.empName = "John";
            e1.empSalary = 78000;
            e1.empPerformance = 'A';


            e2.empId = 101;
            e2.empName = "JIll";
            e2.empSalary = 92222;
            e2.empPerformance = 'B';

            e3.empId = 102;
            e3.empName = "Navya";
            e3.empSalary = 178000;
            e3.empPerformance = 'C';




        }
    }
}
