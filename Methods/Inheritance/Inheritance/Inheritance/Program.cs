using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> names = new Employee<string>();
            names.things = new List<string>() { "Ryu", "Ken", "Chun Li" };

            Employee<int> ranks = new Employee<int>();
            ranks.things = new List<int>() { 1, 2, 3 };

            foreach (string name in names.things)
            {
                Console.WriteLine(name);
            }
            foreach (int rank in ranks.things)
            {
                Console.WriteLine(rank.ToString());
            }
            Console.ReadLine();
            //Employee employee = new Employee()
            //{
            //    FirstName = "Sample",
            //    LastName = "Student"
            //};

            //employee.SayName();
            //Console.ReadLine();

            //IQuittable newEmployee = new Employee();
            //newEmployee.Quit();
        }
    }
}
