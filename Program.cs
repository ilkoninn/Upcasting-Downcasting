using System.Reflection;
using System.Runtime.Versioning;
using UpcastingDowncasting.Models;

namespace UpcastingDowncasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehichle vehichle = new Car(10000);
            Vehichle vehichle1 = new Bus(20000);

            bool checkcCar = vehichle is Vehichle;
            Car bus = vehichle as Car;

            if (checkcCar)
            {
                Console.WriteLine($"Car check value is true, car price {vehichle.Price}");
                vehichle.Drive();
            }
            else
            {
                Console.WriteLine($"Car check value is false!");
            }

            Console.WriteLine("\n=== Check about bus is can do downcasting? ===");
            if (bus != null)
            {
                vehichle1.Drive();
                Console.WriteLine($"Bus can do, bus price: {bus.Price}");
            }
            else
            {
                Console.WriteLine("Bus can not do!");
            }
        }
    }
}