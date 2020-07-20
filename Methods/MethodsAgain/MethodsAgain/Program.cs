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
            Addition addition = new Addition();
            int answer = addition.Adding(5);
            Console.WriteLine(addition.Adding(5).ToString());

            int answerTwo = addition.Adding(5.5m);
            Console.WriteLine(answerTwo.ToString());

            int answerThree = addition.Adding("5");
            Console.WriteLine(answerThree.ToString());
            Console.ReadLine();
        }

    }
}
