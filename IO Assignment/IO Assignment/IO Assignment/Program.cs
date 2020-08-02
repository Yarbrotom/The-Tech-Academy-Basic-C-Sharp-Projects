using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a whole number:");
            string number = Console.ReadLine();
            File.WriteAllText(@"C:\Logs\IOlog.txt", number);
            string logNumber = File.ReadAllText(@"C:\Logs\IOlog.txt");
            Console.WriteLine("The number you entered is " + logNumber);
            Console.ReadLine();
        }
    }
}
