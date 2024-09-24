using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

using ThomsonReuters.Formulae;

namespace CSharpConcept3
{
    public class Program3
    {

        //Here, all static Methods are  called
        
        public static void Main(String[] args)
        {
            double areaOfCircle = Area.AreaOfCircle(3);
            Console.WriteLine("Area of Cicle " + areaOfCircle);


            //Create object to allocate memory for non static fields

            Area obj=new Area();

            //call the non static menthod with the help of object
            double areaOfRectange = obj.AreaOfRectangle(5, 4);
            Console.WriteLine("Area of rectangle " +areaOfRectange);


            areaOfRectange  = obj.AreaOfRectangle(5, 5);
            Console.WriteLine("Area of rectangle " + areaOfRectange);

            double areaOfTriangle = Area.AreaOfTriangle(3, 25);
            Console.WriteLine("Area of triangle "+areaOfTriangle);

            Console.WriteLine((double)25/2); // explicit conversion

            string s = Area.AuthorName("Sayali");
            Console.WriteLine(s);

            obj.empty();


            

        }
    }
}

