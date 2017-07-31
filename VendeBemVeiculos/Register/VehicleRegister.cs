using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class VehicleRegister<T> : Register<T> where T : Vehicle
    {
        private const int BRAND = 0;
        private const int NAME = 1;
        private const int YEAR = 2;
        private const int PRICE = 3;

        public VehicleRegister(string fileName)
            : base(fileName) { }

        protected override ICollection<T> DataGroup { get; } =  new List<T>();

        protected override void LoadData()
        {
            if (File.Exists(this.FileName))
            {
                using (var vehicleStream = File.Open(this.FileName, FileMode.Open))
                using (var reader = new StreamReader(vehicleStream))
                {
                    string line = reader.ReadLine();
                    while (string.IsNullOrEmpty(line) == false)
                    {
                        Load(line);                        
                        line = reader.ReadLine();
                    }
                }
            }
        }
        private void Load(string line)
        {
            string[] data = line.Split('%');
            var brand = data[BRAND];
            var name = data[NAME];
            var year = data[YEAR];
            var price = data[PRICE];
            var activatedVehicle = (T)Activator.CreateInstance(typeof(T), brand, name, year, Convert.ToDouble(price));
            this.DataGroup.Add(activatedVehicle);
        }

        protected override void LoadItemsString()
        {
            foreach (T v in this.DataGroup)
            {
                CreateStringLine(v);
            }
        }
        private void CreateStringLine(T vehicle)
        {
            if (vehicle != null)
            {
                this.allData += $"{vehicle.Brand}%{vehicle.Name}%{vehicle.Year}%{vehicle.Price}\r\n";
            }
        }

        public T[] FilterByBrand(string selectedBrand)
        {            
            return this.Items.Where(v => v.Brand == selectedBrand).ToArray();
        }
        public T[] FilterByName(string selectedName)
        {
            return this.Items.Where(v => v.Name == selectedName).ToArray();
        }
        public T[] FilterByYear(string selectedYear)
        {
            return this.Items.Where(v => v.Year == selectedYear).ToArray();
        }
    }
}
