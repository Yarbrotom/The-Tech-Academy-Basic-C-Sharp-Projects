using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            string[] teamRocket = new string[] { "Jesse", "James", "Meowth", "Wobbuffet" };
            Console.WriteLine("Please select a number 0-3, to find out which member of Team Rocket you have selected.");
            int answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have chosen " + teamRocket[answer] + "!!!");
            Console.ReadLine();


            int[] numbers = new int[] {2, 4, 6, 8, 10, 12};
            Console.WriteLine("Please enter a number 0-5, this number will select the index from an array of numbers and display the number stored in the array at that index.");
            int response = Convert.ToInt32(Console.ReadLine());
            if (response > 5 || response < 0)
            {
                Console.WriteLine("You have entered a number that is out of range for the index.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The number at that index in the array is " + numbers[response] + "!");
            }

            List<string> pokemon = new List<string>();

            pokemon.Add("Bulbasaur");
            pokemon.Add("Charmander");
            pokemon.Add("Squirtle");


            Console.WriteLine("Please enter a number 0-2 to pick a starter Pokemon.");
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(pokemon[choice] + "!! I choose you!!!");
            Console.ReadLine();
        }
    }
}
