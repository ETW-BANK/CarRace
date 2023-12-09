namespace CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;

            do {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\n\n");
                Console.WriteLine("\t\t\t\t ====================================");
             
                Console.WriteLine($"\t\t\t\t   {"1. Tryck 1 att Starata Tävlingen"}");
                Console.WriteLine($"\t\t\t\t   {"2. Tryck 2 att Avsluta"}");

                Console.WriteLine("\t\t\t\t ===================================\n\n");
                Console.WriteLine($"\t\t\t{"\u001b[32mEnter\u001b[0m. Tryck ENTER att se Bil Satatus under Tävlingen"}\n\n");

                Console.ResetColor();


                if (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 2)
                {

                    Console.WriteLine("\n\t\t\t\t \u001b[31m Ogiltigt val . Vänligen välja 1-2.\u001b[0m \n");

                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }

                switch (choice)
            {
               
                case 1:
                Race.Races();
                break;
                case 2:
                Environment.Exit(2);
                break;

                default:
                Console.WriteLine("wrong choice");
                Thread.Sleep(1000);
                Console.Clear();
                     
                break;
            }
         }while (choice != 2);
        }
    }
}
