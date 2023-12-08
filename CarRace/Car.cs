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

        public string Name { get; }
        public int Distance { get; private set;  }
        public int Speed { get; set; }

        public Car(string name, int speed)
        {
            Name = name;
            Distance = 0;
            Speed = speed;
        }

        public void Move()
        {
            while (Distance < 10000) 
            {
                Distance += Speed; 

                Console.WriteLine($"{Name} är på {Distance} Meter.");

                RandomEvent(); 
                Thread.Sleep(1000); 

                if (Console.KeyAvailable)
                {
                   ConsoleKey key = Console.ReadKey().Key;

                    if (key==ConsoleKey.Enter)
                    {
                        Console.WriteLine("\u001b[32m Läget i tävlingen . Vissar Tävling status...\u001b[0m");
                        DisplayRaceStatus();
                    }
                }
            }

           
            Console.WriteLine($"\u001b[34m{Name} har avslutat tävlingen!\u001b[0m");
           
        }
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
                Console.WriteLine($"\u001b[31m {Name} Behöver tvätta vindrutan, stannar 10 sekunder\u001b[0m");
                Thread.Sleep(1000); 
            }
            else if (chance <= 10) 
            {
                Console.WriteLine($"\u001b[31m {Name} Hastigheten på bilen sänks med 1km/h\u001b[0m");
                Speed--; 
            }
        }
        private void DisplayRaceStatus()
        {
            Console.WriteLine($"Tävling Status för {Name}:");
            Console.WriteLine($"Sträka: {Distance} Meters");
            Console.WriteLine($"Hastighet: {Speed} km/h");
        }
    }
  
}
