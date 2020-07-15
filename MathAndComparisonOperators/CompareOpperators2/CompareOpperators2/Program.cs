using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareOpperators2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int rateOne = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursOne = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int rateTwo = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursTwo = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Annual salary of Person 1:");
            int salaryOne = rateOne * hoursOne * 52;
            Console.WriteLine(salaryOne);

            Console.WriteLine("Annual salary of Person 2:");
            int salaryTwo = rateTwo * hoursTwo * 52;
            Console.WriteLine(salaryTwo);

            Console.WriteLine("Does Person 1 make more money than Person2?");
            Console.WriteLine(salaryOne > salaryTwo);
            Console.ReadLine();
        }
    }
}
