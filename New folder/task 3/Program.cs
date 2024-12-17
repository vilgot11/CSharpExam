using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //arrays
            string[] name = {"Bob","Steve","Nina" };
            int[] num = { 5, 57, 87, 1, 150, 32, 14 };

            //prints first array and adds Goodbye before every word
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($" Goodbye {name[i]}");
            }

            // puts array in order and delets last number before print second array
            Array.Sort(num);
            num = num.Take(num.Length -1).ToArray();
            Console.WriteLine(string.Join(",", num));

            

            Console.ReadLine();
        }
    }
}
