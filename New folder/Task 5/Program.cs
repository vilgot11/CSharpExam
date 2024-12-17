using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> Words = new Dictionary<string, string>();
            bool b = false;

            while (!b)
            {
                //user input
                Console.WriteLine("Add a word and its defenition");
                Console.WriteLine("Remove a word");
                Console.WriteLine("Show all words and their defenitions");
                Console.WriteLine("Exit");
                Console.WriteLine("choose 1 to 4");
                string Choice = Console.ReadLine();

                switch (Choice)
                {
                    //adds word
                    case "1":
                        Console.Write("Enter a Word: ");
                        string Word = Console.ReadLine();
                        Console.Write("Enter the description: ");
                        string description = Console.ReadLine();

                        if (!Words.ContainsKey(Word))
                        {
                            Words[Word] = description;
                            Console.WriteLine($"{Word} added");
                        }
                        else
                        {
                            Console.WriteLine($"This {Word} alredy exists");
                        }
                        
                        break;

                        //delete word
                    case "2":
                        Console.Write("What word to remove: ");
                        string WordsToRemove = Console.ReadLine();

                        if (Words.Remove(WordsToRemove))
                        {
                            Console.WriteLine($"Word '{WordsToRemove}' removed.");
                        }
                        else
                        {
                            Console.WriteLine($"Word '{WordsToRemove}' not found.");
                        }
                        break;

                        //show all words
                    case "3":
                        Console.WriteLine("\nWords and defenitions:");
                        if (Words.Count > 0)
                        {
                            foreach (var item in Words)
                            {
                                Console.WriteLine($"Words: {item.Key}, Defenitions: {item.Value}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No words ore Defenitions found.");
                        }
                        break;

                        //Exit
                    case "4":
                        b = true;
                        Console.WriteLine("bye");

                        Console.ReadLine();
                        break;





                }




            }
        }
    }
}
