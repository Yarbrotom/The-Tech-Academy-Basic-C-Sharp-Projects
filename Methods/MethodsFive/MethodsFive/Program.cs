﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsFive
{
    static class Program
    {
        static void Main(string[] args)
        {
            MathFunctions mathFunctions = new MathFunctions();
            Console.WriteLine("Please enter a number to divide by two:");
            int x = Convert.ToInt32(Console.ReadLine());
            int answer;
            mathFunctions.MathFunction(x, out answer);
            Console.WriteLine("The answer is: " + answer.ToString());

            Console.WriteLine("Please enter another number that will be multiplied by 2:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter one more number that will be multiplied by 3:");
            int y = Convert.ToInt32(Console.ReadLine());
            int answerOne;
            int answerTwo;
            mathFunctions.MathFunction(x, y, out answerOne, out answerTwo);
            Console.WriteLine("The first answer is: " + answerOne.ToString());
            Console.WriteLine("The second answer is: " + answerTwo.ToString());

            Console.ReadLine();
        }
    }
}
