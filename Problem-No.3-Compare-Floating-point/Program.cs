using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._3_Compare_floating_point
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            decimal number1 = decimal.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            decimal number2 = decimal.Parse(Console.ReadLine());

            if ((number1 >= number2) && (number1 - number2 < 0.000001M) || (number1 <= number2) && (number2 - number1 < 0.000001M))
            {
                Console.WriteLine("Numbers are equal");
            }
            if ((number1 > number2) && (number1 - number2 > 0.000001M))
            {
                Console.WriteLine("{0} is greater than {1}", number1, number2);
            }
            if ((number1 < number2) && (number2 - number1 > 0.000001M))
            {
                Console.WriteLine("{1} is greater than {0}", number1, number2);
            }
            Console.WriteLine("\n*********************************\n");
            Console.WriteLine("Epsilon precision");
            Console.Write("Enter first number: ");
            decimal number3 = decimal.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            decimal number4 = decimal.Parse(Console.ReadLine());

            if ((number3 >= number4) && (number3 - number4 < (decimal)float.Epsilon) || (number3 <= number4) && (number3 - number4 < (decimal)float.Epsilon))
            {
                Console.WriteLine("Numbers are equal");
            }
            if ((number3 > number4) && (number3 - number4 > (decimal)float.Epsilon))
            {
                Console.WriteLine("{0} is greater than {1}", number3, number4);
            }
            if ((number3 < number4) && (number4 - number3 > (decimal)float.Epsilon))
            {
                Console.WriteLine("{1} is greater than {0}", number3, number4);
            }
        }
    }
}
