using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._1_Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            byte a = (byte)number;
            sbyte b = (sbyte)number;
            short c = (short)number;
            ushort d = (ushort)number;
            int e = (int)number;
            uint f = (uint)number;
            long g = (long)number;
            ulong h = (ulong)number;
            double i = (double)number;
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", a, b, c, d, e, f, g, h, i);
            //Да, конверсията може да се провали, ако въведената стойност на променливата "number" 
            //e по-голямa(съответно по-малка) от минималните или максималните допустими стойности на съответния примитивен тим данни.
        }
    }
}
