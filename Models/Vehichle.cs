using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncasting.Models
{
    internal abstract class Vehichle
    {
        public double Price { get; set; }
        public abstract void Drive();
        public Vehichle(double price)
        {
            Price = price;
        }
    }
}
