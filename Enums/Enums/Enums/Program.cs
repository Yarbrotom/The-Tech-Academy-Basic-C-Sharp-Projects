using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Days days = new Days();
            
            Console.WriteLine("Please enter the current day of the week: ");
            try
            {
                
                string userDay = Console.ReadLine();
                DayOfWeek dayOfWeek = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), userDay);
                
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
