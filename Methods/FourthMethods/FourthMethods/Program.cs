using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourthMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            MathFunctions mathFunctions = new MathFunctions();
            mathFunctions.AddTwo(4, y: 5);
            Console.ReadLine();
        }
    }
}
