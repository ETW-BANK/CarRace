using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CarRace
{
    internal class Race
    {
        public static void Races()
        {
            // Create a new car object with the name names and speed 120 km/h
            Car car1 = new Car("Ferrari", 120);
            Car car2 = new Car("BMW", 120);


            //Create a new thread for the Move method of car1 and car2

            Thread t = new Thread(car1.Move);
            Thread t2 = new Thread(car2.Move);

            // Start the thread for car1(t) & car2(t1)
            t.Start();
            t2.Start();

            // Wait for t & t2 thread to finish

            t.Join();
            t2.Join();

            // Check if the thread for t & t2 has stopped to check the winer basd on Thread state

            if (t2.ThreadState == ThreadState.Stopped)
            {
                Console.WriteLine($"\u001b[36m{car2.Name}\u001b[0m \u001b[34m HAR VUNNIT TÄVLINGEN\u001b[0m \n");

            }
            else if (t.ThreadState == ThreadState.Stopped)
            {
                Console.WriteLine($"\u001b[36m{car1.Name}\u001b[0m \u001b[34m HAR VUNNIT TÄVLINGEN\u001b[0m \n");

            }

            Console.WriteLine($"\u001b[32m{car1.Name} & {car2.Name} har avslutat Tävlingen!\u001b[0m");
           Car.EscapeKeyCall();
            
        }
    }
}
