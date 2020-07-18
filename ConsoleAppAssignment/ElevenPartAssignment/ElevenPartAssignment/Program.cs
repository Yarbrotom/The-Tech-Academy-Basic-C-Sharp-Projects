using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace ElevenPartAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pokemon = new string[] { "Bulbasaur", "Charmander", "Squirtle" };
            Console.WriteLine("Please type one word that describes your Pokemon:");
            string description = Console.ReadLine();
            
            for (int i = 0; i < pokemon.Length; i++)
            {
                string name = pokemon[i];
                pokemon[i] = "Your " + name + " is " + description + "!";
            }

            for (int i = 0; i < pokemon.Length; i++)
            {
                Console.WriteLine(pokemon[i]);
            }
            Console.ReadLine();

            bool fainted = true;

            while (fainted)
            {
                Console.WriteLine("Your pokemon is unable to battle.");
                Console.WriteLine("Press enter to revive your pokemon.");
                Console.ReadLine();

                fainted = false;
            }

            int counter = 0;

            while (counter <= pokemon.Length)
            {
                counter++;
            }

            Console.WriteLine("If you add a Pokemon to your Pokedex, it will be assigned the number " + counter.ToString() + ".");
            Console.ReadLine();


            List<string> eeveeEvolutions = new List<string>() { "Jolteon", "Vaporeon", "Flareon", "Leafeon", "Sylveon", "Glaceon", "Umbreon", "Espeon" };

            Console.WriteLine("Please enter your favorite Eevee evolution form to find where it is on the list: ");
            string evolution = Console.ReadLine();

            for (int m = 0; m < eeveeEvolutions.Count; m++)
            {
                if (eeveeEvolutions[m] == evolution)
                {
                    Console.WriteLine(evolution + " is in index " + m.ToString());
                    Console.ReadLine();
                    break;
                }
            }

            if (evolution != "Jolteon" &&
                evolution != "Vaporeon" &&
                evolution != "Flareon" &&
                evolution != "Leafeon" &&
                evolution != "Sylveon" &&
                evolution != "Glaceon" &&
                evolution != "Umbreon" &&
                evolution != "Espeon")
            {
                Console.WriteLine("You typed \"" + evolution + "\" that name isn't on the list.");
            }
            Console.ReadLine();

            List<string> trainers = new List<string>() { "Ash", "Misty", "Brock", "Clemont", "Ash", "Serena" };

            Console.WriteLine("Enter the name of the pokemon trainer to find out which indices they are on the list:");
            string trainer = Console.ReadLine();

            for (int i = 0; i < trainers.Count; i++)
            {
                if (trainers[i] == trainer)
                {
                    Console.WriteLine(trainer + " is in index " + i.ToString());
                }
            }
            Console.ReadLine();

            if (trainer != "Ash" &&
                trainer != "Misty" &&
                trainer != "Brock" &&
                trainer != "Clemont" &&
                trainer != "Serena")
            {
                Console.WriteLine(trainer + " could not be found on the list.");
            }
            Console.ReadLine();


            List<string> newPokemon = new List<string>() { "Bulbasaur", "Charmander", "Squirtle", "Charmander" };
            List<string> counted = new List<string>();

            foreach (string poke in newPokemon)
            {
                if (counted.Contains(poke))
                {
                    Console.WriteLine(poke + " has already been added to the Pokedex.");
                }
                else
                {
                    counted.Add(poke);
                    Console.WriteLine("You have added " + poke + " to the Pokedex!");
                }
                Console.ReadLine();
            }
        }
    }
}
