using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUppgift1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user input
            Console.WriteLine("Write a int: ");
            string i = Console.ReadLine();
            
            Console.WriteLine("Write a double: ");
            string d = Console.ReadLine();

            Console.WriteLine("Write a float: ");
            string f = Console.ReadLine();

            Console.WriteLine("Write a string: ");
            string s = Console.ReadLine();

            //convert and print
            Console.WriteLine(Convert.ToInt32(i));
            Console.WriteLine(Convert.ToDouble(d));
            Console.WriteLine(Convert.ToSingle(f));
            Console.WriteLine(s);

            //what are int, double, float and string
            Console.WriteLine("int is a whole number");
            Console.WriteLine("double is a decimal number up to 15 digits ");
            Console.WriteLine("float is a decimal number upp to 6 ore 7 digits ");
            Console.WriteLine("string is text");

            Console.ReadLine();




        }
    }
}
