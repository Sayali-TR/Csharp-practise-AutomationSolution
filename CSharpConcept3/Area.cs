using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThomsonReuters.Formulae
{
    public class Area
    {

        // CLASS CREATED FOR ALL THE STATIC METHODS
        public static double AreaOfCircle(int radiusOfCircle)
        {
            double areaOfCircle = 3.14 * radiusOfCircle * radiusOfCircle;
            return areaOfCircle;
        }
        //area of rectangle Non static method
        public  double AreaOfRectangle(int lenght, int breadth)
        {
            double areaOfRectangle = lenght * breadth;
            return areaOfRectangle;

        }
        // are of traingle

        public static double AreaOfTriangle(double baseOfTriangle, double heightOfTriangle)
        {
            return 0.5 * baseOfTriangle * heightOfTriangle;
        }
        public static string AuthorName(String s)
        {
            return s;
        }
        
        //Non static method
        public  void empty()
        {
            // if nothing has to return we can use it as void 
        }
    }
}
