using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input and makes string int
            Console.WriteLine("write a number");
            string num = Console.ReadLine();
            int num2 = int.Parse(num);

            
            // prints depending on what user wrote
            // positive if user put positive
            if (num2 > 0)
            {
                Console.WriteLine("This number is positive");
            }
            else if(num2 < 0)
                // negative if user putt negative number
            {
                Console.WriteLine("This number is negative");
            }
            // zero if user putt zero
            else if( num2 == 0) 
            {
                Console.WriteLine("This number is zero");
            }
            // if invalid input
            else if (int.TryParse(num, out int number))
            {
                Console.WriteLine("Invalid input");
            }
            
            





            Console.ReadLine();
        }
    }
}
