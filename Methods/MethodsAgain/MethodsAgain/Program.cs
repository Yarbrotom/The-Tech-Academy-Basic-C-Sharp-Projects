using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer = Addition.Adding(5);
            Console.WriteLine(answer.ToString());

            int answerTwo = Addition.Adding(5.5m);
            Console.WriteLine(answerTwo.ToString());

            int answerThree = Addition.Adding("5");
            Console.WriteLine(answerThree.ToString());
            Console.ReadLine();
        }

    }
}
