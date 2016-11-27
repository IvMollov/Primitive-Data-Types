using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._8_One_hundred_50_digit_numbers
{
    class Program
    {
        static void Main(string[] args)

        {
            int sum = 0;
            int[] ab = { 3, 7, 1, 0, 7, 2, 8, 7, 5, 3, 3, 9, 0, 2, 1, 0, 2, 7, 9, 8, 7, 9, 7, 9, 9, 8, 2, 2, 0, 8, 3, 7, 5, 9, 0, 2, 4, 6, 5, 1, 0, 1, 3, 5, 7, 4, 0, 2, 5, 0 };
            for (int i = 0; i < ab.Length; i++)
            {
                if (i == 10)
                {
                    break;
                }
                sum += ab[i];
            }
            Console.WriteLine("Sum of the first ten digit of the first 50 digit number is: " + sum);
            sum = 0;
            int[] abc = { 4, 6, 3, 7, 6, 9, 3, 7, 6, 7, 7, 4, 9, 0, 0, 0, 9, 7, 1, 2, 6, 4, 8, 1, 2, 4, 8, 9, 6, 9, 7, 0, 0, 7, 8, 0, 5, 0, 4, 1, 7, 0, 1, 8, 2, 6, 0, 5, 3, 8 };
            for (int i = 0; i < ab.Length; i++)
            {
                if (i == 10)
                {
                    break;
                }
                sum += ab[i];
            }
            Console.WriteLine("Sum of the first ten digit of the second 50 digit number is: " + sum);
            sum = 0;
            int[] abcz = { 5,3,5,0,3,5,3,4,2,2,6,4,7,2,5,2,4,2,5,0,8,7,4,0,5,4,0,7,5,5,9,1,7,8,9,7,8,1,2,6,4,3,3,0,3,3,1,6,9,0 };
            for (int i = 0; i < abcz.Length; i++)
            {
                if (i == 10)
                {
                    break;
                }
                sum += ab[i];
            }
            Console.WriteLine("Sum of the first ten digit of the last 50 digit number is: " + sum);
            Console.ReadLine();
        }
    }
}
