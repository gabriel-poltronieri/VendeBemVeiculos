﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class Car : Vehicle
    {
        public Car(string brand, string name, string year, double price)
            : base(brand, name, year, price) { }
    }
}