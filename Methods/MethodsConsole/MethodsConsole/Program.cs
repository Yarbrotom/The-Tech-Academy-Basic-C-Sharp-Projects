using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number for the program to do \"Quick Maths\" to:");
            int answer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The first opperation returns " + QuickMaths.AddFive(answer).ToString());
            Console.ReadLine();

            Console.WriteLine("The second opperation returns " + QuickMaths.SubFive(answer).ToString());
            Console.ReadLine();

            Console.WriteLine("The third opperation returns " + QuickMaths.AddTen(answer).ToString());
            Console.ReadLine();
        }
    }
}
