﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_No._4b_Only_Two_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("\"a\" and \"b\" before the exchange:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            b = a;
            a = b + a;
            Console.WriteLine("\"a\" and \"b\" after the exchange:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
