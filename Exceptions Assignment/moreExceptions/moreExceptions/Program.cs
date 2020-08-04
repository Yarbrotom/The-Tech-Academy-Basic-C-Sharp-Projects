using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moreExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");
            try
            {
                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 0)
                {
                    Console.WriteLine("The age you entered was less than 1.");
                    Console.ReadLine();
                    return;
                }

                DateTime birthDate = DateTime.Now.AddYears(-(age));
                Console.WriteLine("You were born in " + birthDate.Year + ".");
            }
            catch (Exception)
            {
                Console.WriteLine("An error occured.");
            }
            Console.ReadLine();
        }
    }
}
