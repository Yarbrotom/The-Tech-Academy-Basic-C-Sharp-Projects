using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("Please enter a whole number:");
            int number = Convert.ToInt32(Console.ReadLine());

            DateTime futureTime = now.AddHours(number);
            Console.WriteLine("In " + number + " hours the time will be " + futureTime);
            Console.ReadLine();

        }
    }
}
