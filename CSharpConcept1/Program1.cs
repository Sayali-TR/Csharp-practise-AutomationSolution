using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept1
{
    public class Program1
    {
        static void Main(String[]args)
        {
            Console.WriteLine("Sayali ");
            sbyte a = 127; // -127 to 127 1 byte
            byte b = 255; // 0 to 255 1 byte
            short c = 32767; //  -32767  to 32767    2 byte
            int d = 800000; // 4 bytes
            long l = 1234567899874563210L;  // 8 bytes
            float f = 1.2F;
            double db = 1.2; // 8 bytes
            char k= 'A';

            int[] numberArray = new int[2];// 4*32 bits
            numberArray[0] = 1000;
            numberArray[1] = 2000;

            String[] Colors = new string[3]; 
            Colors[0] = "Red";
            Colors[1] = "Green";
                Colors[2] = "Yellow";

            Console.WriteLine(Colors[0]); //3*16 bits
            Console.WriteLine(Colors[1]); // 5*16 bits
            Console.WriteLine(Colors[2]); // 6*16 bits

            String[] Colors2 = { "Black", "White", "Orange" };
            Console.WriteLine(Colors2[0]);
            Console.WriteLine(Colors2[1]);
            Console.WriteLine(Colors2[2]);



            String s = "TR"; // 2*16 bits
            Console.WriteLine(a);
            Console.WriteLine(b);   
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(l);
            Console.WriteLine(f);
            Console.WriteLine(db);
            Console.WriteLine(s);
            Console.WriteLine(s[0]);
            Console.WriteLine(s[1]);
            Console.WriteLine(k);




        }
    }
}
