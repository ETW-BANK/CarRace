namespace CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Car car1=new Car("ferrari",120);
            Car car2 = new Car("BMW", 120);

           
                Thread t = new Thread(car1.Move);
                Thread t2 = new Thread(car2.Move);
             
                t.Start();
                t2.Start();
          

                t.Join();
                t2.Join();

            Console.WriteLine($"{car1.Name} & {car2.Name} har avslutat Tävlingen!");
        }
    }
}
