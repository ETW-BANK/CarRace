namespace CarRace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
        {
            new Car("Ferrari", 120),
            new Car("BMW", 120)
            // Add more cars here
        };

            List<Thread> threads = new List<Thread>();

            foreach (var car in cars)
            {
                Thread t = new Thread(car.Move);
                threads.Add(t);
                t.Start();
            }

            foreach (var thread in threads)
            {
                thread.Join(); 
            }

            Console.WriteLine("Race finished for all cars!");
        }
    }
}
