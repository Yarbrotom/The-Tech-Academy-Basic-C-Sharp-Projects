using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Number number = new Number();
            number.Amount = 9.99m;

            Console.WriteLine(number.Amount.ToString());
            Console.ReadLine();
        }
    }
}
