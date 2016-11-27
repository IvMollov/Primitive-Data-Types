using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._7_Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int three = 3;
            int five = 5;
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (three * i < 1000)
                {   
                    sum += (three * i);
                }
                if (five * i < 1000)
                {  
                    sum += (five * i);
                }
            }
            Console.WriteLine("Sum of all the multiples of 3 and 5 below 1000 is: {0}", sum);
            Console.ReadLine();

        }
    }
}
