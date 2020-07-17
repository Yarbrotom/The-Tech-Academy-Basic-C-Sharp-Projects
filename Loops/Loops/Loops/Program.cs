using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endLoop = false;
            while (endLoop)
            {
                Console.WriteLine("This loop is ending.");
                Console.ReadLine();
            }

            bool endDoWhileLoop = true;

            do
            {
                Console.WriteLine(" The do while loop is ending.");
                Console.ReadLine();
            }
            while (endDoWhileLoop);
        }
    }
}
