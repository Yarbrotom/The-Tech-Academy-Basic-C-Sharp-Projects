using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("How much does your package weigh in pounds:");
            double weight = Convert.ToDouble(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the package width in inches:");
                double width = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package height in inches:");
                double height = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the package length in inches:");
                double length = Convert.ToDouble(Console.ReadLine());
                if ((width + height + length) > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express");
                    Console.ReadLine();
                }
                else
                {
                    double size = width * height * length;
                    string total = size.ToString();
                    Console.WriteLine("Your estimated total for shipping this package is: $" + total);
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
            
        }
    }
}
