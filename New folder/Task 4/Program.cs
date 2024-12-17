using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // user in put
            Console.Write("Enter the first number: ");
            string input1 = Console.ReadLine();
            

            Console.Write("Enter the second number: ");
            string input2 = Console.ReadLine();

            string sum = Add(input1, input2);
            string difference = Subtract(input1, input2);
            string product = Multiply(input1, input2);
            string quotient = Divide(input1, input2);
            // calls on calculations
            Console.WriteLine($"The sum of the numbers is: {sum}");
            Console.WriteLine($"The difference of the numbers is: {difference}");
            Console.WriteLine($"The product of the numbers is: {product}");
            Console.WriteLine($"The quotient of the numbers is: {quotient}");

            Console.ReadLine();
        }
        // Calculations
        static string Add(string input1, string input2)
        {
            return input1 + input2;
        }

        static string Subtract(string input1, string input2)
        {
            return input1 + "-" + input2;
        }


        static string Multiply(string input1, string input2)
        {
            return input1 + "*" + input2;
        }

        static string Divide(string input1, string input2)
        {
            return input1 + "/" + input2;
        }
    }
}

