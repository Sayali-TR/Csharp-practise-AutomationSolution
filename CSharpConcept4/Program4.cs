using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept4
{
    public class Program4
    {
        public static int aS = 10; // static variables creation
        public static int bS = 20;

        public int cS = 30;// non static variables creation
        public int dS = 40;

          
            static void Main(string[] args)
        {
            Program4.aS = 500; // static variable call
            Console.WriteLine("aS "+aS);
            Console.WriteLine("bs "+bS);

            Program4 obj = new Program4(); // non static variable call
            Program4 obj2 = new Program4();

            obj.cS = 566;
            Console.WriteLine("cS "+obj.cS);
            Console.WriteLine("dS "+obj.dS);

            obj2.cS = 999;
            obj2.dS = 888;
            Console.WriteLine("object 2 cS " + obj2.cS);
            Console.WriteLine("oject 2 dS " +obj2.dS);





        }
    }
}
