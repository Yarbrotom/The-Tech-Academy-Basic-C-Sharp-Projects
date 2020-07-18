using System;
using System.Collections.Generic;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine("Please enter a number:");
            //    int numberOne = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Please enter a second number:");
            //    int numberTwo = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Dividing the two...");
            //    int numberThree = numberOne / numberTwo;
            //    Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            //    Console.ReadLine();
            //}

            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Please type a whole number");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please don't divide by zero.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Console.ReadLine();


            List<int> numbers = new List<int>() { 20, 24, 30, 8, 12 };

            try
            {
                Console.WriteLine("Please enter a whole number that will be used to divide each number of the list:");
                int divisor = Convert.ToInt32(Console.ReadLine());

                foreach (int number in numbers)
                {
                    decimal answer = number / divisor;
                    Console.WriteLine(number + " divided by " + divisor + " equals: " + answer);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            

        }
    }
}
