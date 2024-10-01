using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorConcepts
{
    public class Constructor
    {

        public int b;
        public Constructor()
        {
            Console.WriteLine("Constuctor without any arguments");

        }

        public Constructor(int a)
        {
            Console.WriteLine("Constructor with 1 argument");
           b= a;
        }


        public Constructor(String s, int a)
        {
            Console.WriteLine("Constructor with 2 arguments ");
        }

    }
}

