using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting.Models
{
    internal class Car:Vehichle
    {
        public override void Drive()
        {
            Console.WriteLine("Car is driving now!");
        }
        public Car(double price):base(price) { }
    }
}
