﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodThree
{
    class Program
    {
        static void Main(string[] args)
        {
            MathFunctions mathFunctions = new MathFunctions();
            Console.WriteLine("Please enter a whole number:");
            int first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Optional: Please enter another whole number:");

            string second = Console.ReadLine();


            if(second != "")
            {
                Console.WriteLine(mathFunctions.AddTwo(first, Convert.ToInt32(second)).ToString());
            }
            else
            {
                Console.WriteLine(mathFunctions.AddTwo(first).ToString());
            }
            Console.ReadLine();
        }
    }
}
