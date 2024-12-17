using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // asigne value
            Game game1 = new Game();
            
            game1.Name = "Bloons 6";

            game1.Publisher = "Ninja Kiwi";

            game1.Year = "2018";

            game1.Genre = "Tower Defence";

            game1.DisplayInfo();
            game1.DisplayInfo();

            Console.ReadLine();
        }
    }
    class Game
    {
        //properties of the class
        public string Name { get; set; }
        public string Publisher {  get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }

        //Constructor to initialize name publisher year genre
        public Game(string name, string publisher, string year, string genre)
        {
            Name = name;
            Publisher = publisher;
            Year = year;
            Genre = genre;
        }

        public Game()
        {
        }

        // Method to display 
        public void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name} Publisher: {Publisher} Year: {Year} Genre{Genre}");
        }
    }
}
