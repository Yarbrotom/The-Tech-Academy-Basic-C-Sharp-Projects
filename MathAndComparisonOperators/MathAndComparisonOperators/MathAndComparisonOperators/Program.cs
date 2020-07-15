using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine("Five plus Ten = " + total.ToString());
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus Five = " + difference.ToString());
            //Console.ReadLine();

            //int product = 10 * 5;
            //Console.WriteLine(product);
            //Console.ReadLine();

            //double quotient = 100 / 5;
            //Console.WriteLine(quotient);
            //Console.ReadLine();

            //bool trueOrFalse = 12 < 5;
            //Console.WriteLine(trueOrFalse.ToString());
            //Console.ReadLine();

            //int roomTemp = 70;
            //int currentTemp = 72;

            //bool isWarm = currentTemp > roomTemp;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            Console.WriteLine("Please enter a whole number between 1 and 10,000,00.");
            string input = Console.ReadLine();
            double number = Int32.Parse(input);
            Console.WriteLine(number * 50);
            Console.WriteLine(number + 25);
            Console.WriteLine(number / 12.5);
            Console.WriteLine(number > 50);
            Console.WriteLine(number % 7);
            Console.ReadLine();
            
        }
    }
}
