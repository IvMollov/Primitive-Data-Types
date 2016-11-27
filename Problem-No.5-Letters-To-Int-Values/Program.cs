using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._5_letters_to_int_values
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = (int)'a'; i <= (int)'z'; i++)
            {
                Console.WriteLine("Letter \"{0}\" has integer value of {1}", (char)i, i);
            }
            Console.ReadLine();
        }
    }
}
