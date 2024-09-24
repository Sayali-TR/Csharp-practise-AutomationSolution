using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept2
{
    public class Program2
    {
        static void Main(String[] args)
        {
            //To calculate area of circle

            int radiusOfCircle = 10;
            double areaOfCicle;
            areaOfCicle = 3.14 * radiusOfCircle * radiusOfCircle;
            Console.WriteLine("Area of Circle =" + areaOfCicle);

            radiusOfCircle = 20;
            areaOfCicle = 3.14 * radiusOfCircle * radiusOfCircle;
            Console.WriteLine("Area of Circle =" + areaOfCicle);
        }

           

    }
}