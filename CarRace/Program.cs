namespace CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Car car1=new Car("Ferrari",120);
            Car car2 = new Car("BMW", 120);

           
                Thread t = new Thread(car1.Move);
                Thread t2 = new Thread(car2.Move);
             
                t.Start();
                t2.Start();
          

                t.Join();
                t2.Join();

            Console.WriteLine("\n");

            if (t2.ThreadState==0)
            {
                Console.WriteLine($"\u001b[36m{car2.Name}\u001b[0m \u001b[34m HAR VUNNIT TÄVLINGEN\u001b[0m \n");
            }
            else
            {
                Console.WriteLine($"\u001b[36m{car1.Name}\u001b[0m \u001b[34m HAR VUNNIT TÄVLINGEN\u001b[0m \n");

            }

            Console.WriteLine($"\u001b[32m{car1.Name} & {car2.Name} har avslutat Tävlingen!\u001b[0m");
        }
    }
}
