using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendeBemVeiculos;

namespace ExtensionsMethods
{
    public static class ObjectExtensions
    {
        public static bool IsPerson (this object obj)
        {
            return obj is Person;
        }

        public static bool IsVehicle(this object obj)
        {
            return obj is Vehicle;
        }
    }
}
