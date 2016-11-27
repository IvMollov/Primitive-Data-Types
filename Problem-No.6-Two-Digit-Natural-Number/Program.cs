using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Problem_No._6_Two_Digit_Natural_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = string.Empty;
            int count = 0;
            for (int i = 10; i < 100; i++)
            {
                a = i.ToString();
                if ((int)Char.GetNumericValue(a[0]) == 0 || (int)Char.GetNumericValue(a[1]) == 0)
                {
                    continue;
                }
                else if ( (i % (int)Char.GetNumericValue(a[0]) == 0) && (i % (int)Char.GetNumericValue(a[1]) == 0))
                {   
                    count++;
                    Console.WriteLine("Number {0,2} is {1}", count, i);
                }
            }
            Console.WriteLine("\nTotal count is: {0}", count);
            Console.ReadLine();
        }
    }
}
