using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class SaleRegister<T> : Register<T> where T : Sale
    {
        private const int CLIENT_FIRST_NAME = 0;
        private const int CLIENT_LAST_NAME = 1;
        private const int CLIENT_CPF = 2;
        private const int VEHICLE_BRAND = 3;
        private const int VEHICLE_NAME = 4;
        private const int VEHICLE_YEAR = 5;
        private const int VEHICLE_PRICE = 6;
        private const int SALESMAN_FIRST_NAME = 7;
        private const int SALESMAN_LAST_NAME = 8;
        private const int SALESMAN_CPF = 9;
        private const int DATE = 10;

        public SaleRegister(string fileName)
            : base(fileName) { }

        protected override ICollection<T> DataGroup { get; } = new List<T>();

        protected override void LoadData()
        {
            if (File.Exists(this.FileName))
            {
                using (var saleStream = File.Open(this.FileName, FileMode.Open))
                using (var reader = new StreamReader(saleStream))
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
        private void Load(string linhaLida)
        {
            string[] data = linhaLida.Split('%');
            var client = ActivateClient(data);
            var vehicle = ActivateVehicle(data);
            var salesMan = ActivateSalesMan(data);
            var date = data[DATE];
            var sale = (T)Activator.CreateInstance(typeof(T), client, vehicle, salesMan, data);
            this.DataGroup.Add(sale);
        }
        private Client ActivateClient(string[] data)
        {
            var clientFirstName = data[CLIENT_FIRST_NAME];
            var clientLastName = data[CLIENT_LAST_NAME];
            var clientCpf = data[CLIENT_CPF];
            return new Client(clientFirstName, clientLastName, clientCpf);
        }
        private Vehicle ActivateVehicle(string[] data)
        {
            var vehicleBrand = data[VEHICLE_BRAND];
            var vehicleName = data[VEHICLE_NAME];
            var vehicleYear = data[VEHICLE_YEAR];
            var vehiclePrice = data[VEHICLE_PRICE];
            return new Vehicle(vehicleBrand, vehicleName, vehicleYear, Convert.ToDouble(vehiclePrice));
        }
        private Salesman ActivateSalesMan(string[] data)
        {
            var salesManFirstName = data[SALESMAN_FIRST_NAME];
            var salesManLastName = data[SALESMAN_LAST_NAME];
            var salesManCpf = data[SALESMAN_CPF];
            return new Salesman(salesManFirstName, salesManLastName, salesManCpf);
        }

        protected override void LoadItemsString()
        {
            foreach (T v in this.DataGroup)
            {
                CreateStringLine(v);
            }
        }
        private void CreateStringLine(T sale)
        {
            if (sale != null)
            {
                var client = $"{sale.Client.FirstName}%{sale.Client.LastName}%{sale.Client.CPF}";
                var vehicle = $"{sale.Vehicle.Brand}%{sale.Vehicle.Name}%{sale.Vehicle.Year}%{sale.Vehicle.Price}";
                var salesMan = $"{sale.Salesman.FirstName}%{sale.Salesman.LastName}%{sale.Salesman.CPF}";
                var date = $"{sale.Date}";
                this.allData += $"{client}%{vehicle}%{salesMan}%{date}\r\n";
            }
        }        
    }    
}