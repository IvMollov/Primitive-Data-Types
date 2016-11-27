using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._4a_integer_variables
{
    class Program
    {
        static void Main(string[] args)
        {      
            int a = 5;
            int b = 10;
            int c;
            Console.WriteLine("\"a\" and \"b\" before the exchange:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            c = a;
            a = b;
            b = c;
            Console.WriteLine("\"a\" and \"b\" after the exchange:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
