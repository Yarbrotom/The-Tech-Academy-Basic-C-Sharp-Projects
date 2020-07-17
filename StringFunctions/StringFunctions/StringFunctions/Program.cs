using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstWord = "Mount";
            string secondWord = "Hood";
            string thirdWord = "Meadows";

            string name = firstWord + " " + secondWord + " " + thirdWord;

            Console.WriteLine(name.ToUpper());


            StringBuilder sb = new StringBuilder();

            sb.Append("The Meadows Difference - ");
            sb.Append("Our Awesome Terrain");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
