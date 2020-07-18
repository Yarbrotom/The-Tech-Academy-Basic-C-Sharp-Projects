using System;
using System.Collections.Generic;

namespace Iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 89, 72, 92, 84, 56 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 80)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);

            //    }
            //}
            //Console.ReadLine();


            //string[] pokemon = { "Bulbasaur", "Charmander", "Squirtle" };

            //for (int p = 0; p < pokemon.Length; p++ )
            //{
            //    Console.WriteLine(pokemon[p] + " is a great starter Pokemon!");
            //}
            //Console.ReadLine();

            //List<int> testScores = new List<int>();

            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(70);
            //testScores.Add(92);
            //testScores.Add(79);
            //testScores.Add(85);

            //foreach (int score in testScores)
            //{
            //    if (score > 80)
            //    {
            //        Console.WriteLine(score + " is a passing grade.");
            //    }
            //}
            //Console.ReadLine();

            //List<string> pokemons = new List<string>() { "Bulbasaur", "Charmander", "Squirtle" };

            //foreach (string pokemon in pokemons)
            //{
            //    Console.WriteLine(pokemon);
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 98, 99, 89, 72, 92, 84, 56 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
                if (score > 80)
                {
                    passingScores.Add(score);
                }
            Console.WriteLine(passingScores.Count);
            Console.ReadLine();
        }
    }
}
