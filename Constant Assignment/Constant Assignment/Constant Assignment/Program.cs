using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constant_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const string region = "Scotland";

            var firstScotch = new Scotch("Glenfiddich");
            Console.WriteLine("The first Scotch of the evening is distiled by {0} and aged for {1} years.", firstScotch.Distilery, firstScotch.Age);
            Console.WriteLine("Did you know that by law, a whiskey must be distiled in {0} in order for it to be called Scotch?",region);
            Console.ReadLine();
        }
    }
}
