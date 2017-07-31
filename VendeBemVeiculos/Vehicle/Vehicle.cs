using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class Vehicle : IComparable
    {
        public Vehicle(string brand, string name, string year, double price)
        {
            this.Brand = brand;
            this.Name = name;
            this.Year = year;
            this.Price = price;
        }

        public string Brand { get; set; }
        public string Name { get; set; }
        public string Year { get; set; }
        public double Price { get; set; }
                
        public override int GetHashCode()
        {
            return (int)((Brand.Length * Name.Length) + Price / Convert.ToInt16(Year));
        }
        public override string ToString()
        {
            return $"{this.Brand} {this.Name} Ano {this.Year}";
        }
        public int CompareTo(object obj)
        {
            var v = (Vehicle)obj;
            return string.Compare(this.Brand, v.Brand);
        }

        public override bool Equals(object obj)
        {
            if (IsVehicle(obj))
            {
                var comparedVehicle = (Vehicle)obj;
                return CompareAllData(comparedVehicle);
            }
            return false;
        }
        private bool IsVehicle(object obj)
        {
            return obj is Vehicle;
        }
        private bool CompareAllData(Vehicle vehicle)
        {
            return (this.Brand == vehicle.Brand) && (this.Name == vehicle.Name) && (this.Year == vehicle.Year) && (this.Price == vehicle.Price);
        }       
    }
}