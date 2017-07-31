using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle(string brand, string name, string year, double price)
            : base(brand, name, year, price) { }
    }
}
