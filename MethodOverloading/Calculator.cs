using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Calculator
    {
        //Method overloading 
        // change in return is not method overloading
        public void Calc(int a,int b)
        {
            Console.WriteLine(a + b);
        }

        public void Calc(int a,double b)
        {
            Console.WriteLine(a + b);

        }
    }
}
