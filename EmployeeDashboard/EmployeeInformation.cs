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
            
            
            EmployeeDetails e1 = new EmployeeDetails();
            EmployeeDetails e2 = new EmployeeDetails();
            EmployeeDetails e3 = new EmployeeDetails();

            String companyName = EmployeeDetails.companyName = "Thomson Reuters";
            e1.EmployeeID = -100;
            e1.empName = "John";
            e1.empSalary = 1000;
            e1.EmployeePerformance = 'A';


            e2.EmployeeID = -101;
            e2.empName = "JIll";
            e2.empSalary = 2000;
            e2.EmployeePerformance = 'B';

            e3.EmployeeID = 102;
            e3.empName = "Navya";
            e3.empSalary = 3000;
            e3.EmployeePerformance = 'M';

           
           e1.display();
            e2.display();
            e3.display();


            e1.AllocateBonus();
            e2.AllocateBonus();
            e3.AllocateBonus();


            e1.display();
            e2.display();
            e3.display();









        }
    }
}
