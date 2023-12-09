using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarRace
{
    internal class Car
    {
        // Class representing a car in the race
        public string Name { get; }
        public int Distance { get; set; }
        public int Speed { get; set; }

        // Properties to get the car name, distance, and speed
        public Car(string name, int speed)
        {
            Name = name;
            Distance = 0;
            Speed = speed;
        }

        // Method to simulate the movement of the car in the race
        public void Move()
        {
            while (Distance < 10000) 
            {
                Distance = Distance+Speed;

                // Display race progress and handle random events
                Console.WriteLine($"{Name} är på {Distance} Meter.");

                RandomEvent(); 
                Thread.Sleep(1000);

                Keypress();
            }

           
            Console.WriteLine($"\u001b[34m{Name} har avslutat tävlingen!\u001b[0m");
           
        }
        // Method to introduce random events during the race
        private void RandomEvent()
        {
            Random random = new Random();
            int chance = random.Next(1, 51); 

            if (chance == 1) 
            {
                Console.WriteLine($"\u001b[31m{Name} Behöver tanka, stannar 30 sekunder\u001b[0m");
                Thread.Sleep(3000); 
            }
            else if (chance <= 2) 
            {
                Console.WriteLine($"\u001b[31m{Name} Behöver byta däck, stannar 20 sekunder\u001b[0m");
                Thread.Sleep(2000); 
            }
            else if (chance <= 5) 
            {
                Console.WriteLine($"\u001b[31m{Name} Behöver tvätta vindrutan, stannar 10 sekunder\u001b[0m");
                Thread.Sleep(1000); 
            }
            else if (chance <= 10) 
            {
                Console.WriteLine($"\u001b[31m{Name} Hastigheten på bilen sänks med 1km/h\u001b[0m");
                Speed--; 
            }
        }
        // Method to check for user input and display race status on Enter key press
        private void DisplayRaceStatus()
        {
            Console.WriteLine($"Tävling Status för {Name}:");
            Console.WriteLine($"Sträka: {Distance} Meters");
            Console.WriteLine($"Hastighet: {Speed} km/h");
        }

        private void Keypress()
        {

            if (Console.KeyAvailable)
            {
                ConsoleKey key = Console.ReadKey().Key;

                if (key == ConsoleKey.Enter)
                {
                    Console.WriteLine("\u001b[32mLäget i tävlingen . Vissar Tävling status...\u001b[0m");
                    DisplayRaceStatus();
                }
            }
        }


        // Method to provide an escape key functionality to get back to the main menu
        public static void EscapeKeyCall()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("\t\t\t\u001b[0m Tryck \u001b[34m ESC \u001b[0m att gå tillbacka till Huvud Meny");

            ConsoleKey key;
            do
            {
                key = Console.ReadKey().Key;

                if (key != ConsoleKey.Escape)
                {
                    Console.WriteLine("\n\t\t\t\u001b[31m Fel Nyckel Trycket. Tryck \u001b[34m ESC\u001b[0m \u001b[31m att gå tillbacka till Huvud Meny.\t\t\t\u001b[0m");
                }
                Console.Clear();
            } while (key != ConsoleKey.Escape);
        }

    }

}
