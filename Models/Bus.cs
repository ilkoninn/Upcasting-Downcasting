using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting.Models
{
    internal class Bus:Vehichle
    {
        public override void Drive()
        {
            Console.WriteLine("Bus is driving now!");
        }
        public Bus(double price):base(price) { }
    }
}
