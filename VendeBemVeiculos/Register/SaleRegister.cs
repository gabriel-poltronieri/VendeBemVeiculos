using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class SaleRegister : Register<Sale>
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

        protected override ICollection<Sale> Data { get; } = new List<Sale>();

        protected override void LoadData()
        {
            if (File.Exists(this.FileName))
            {
                using (var saleStream = File.Open(this.FileName, FileMode.Open))
                using (var reader = new StreamReader(saleStream))
                {
                    var line = reader.ReadLine();
                    while (string.IsNullOrEmpty(line) == false)
                    {
                        this.Load(line);
                        line = reader.ReadLine();
                    }
                }
            }
        }
        private void Load(string linhaLida)
        {
            string[] data = linhaLida.Split('%');
            var client = this.LoadClient(data);
            var vehicle = this.LoadVehicle(data);
            var salesman = this.LoadSalesman(data);
            var date = data[DATE];
            var sale = new Sale(client, vehicle, salesman, date);
            this.Data.Add(sale);
        }
        private Client LoadClient(string[] data)
        {
            var clientFirstName = data[CLIENT_FIRST_NAME];
            var clientLastName = data[CLIENT_LAST_NAME];
            var clientCpf = data[CLIENT_CPF];
            return new Client(clientFirstName, clientLastName, clientCpf);
        }
        private Vehicle LoadVehicle(string[] data)
        {
            var vehicleBrand = data[VEHICLE_BRAND];
            var vehicleName = data[VEHICLE_NAME];
            var vehicleYear = data[VEHICLE_YEAR];
            var vehiclePrice = data[VEHICLE_PRICE];
            return new Vehicle(vehicleBrand, vehicleName, vehicleYear, Convert.ToDouble(vehiclePrice));
        }
        private Salesman LoadSalesman(string[] data)
        {
            var salesManFirstName = data[SALESMAN_FIRST_NAME];
            var salesManLastName = data[SALESMAN_LAST_NAME];
            var salesManCpf = data[SALESMAN_CPF];
            return new Salesman(salesManFirstName, salesManLastName, salesManCpf);
        }

        protected override string GetFileContent()
        {
            var content = string.Empty;
            foreach (Sale sale in this.Data)
            {
                content += this.GetLineContent(sale);
            }
            return content;
        }
        private string GetLineContent(Sale sale)
        {
            if (sale == null)
            {
                throw new NullReferenceException();
            }
            var client = $"{sale.Client.FirstName}%{sale.Client.LastName}%{sale.Client.CPF}";
            var vehicle = $"{sale.Vehicle.Brand}%{sale.Vehicle.Name}%{sale.Vehicle.Year}%{sale.Vehicle.Price}";
            var salesMan = $"{sale.Salesman.FirstName}%{sale.Salesman.LastName}%{sale.Salesman.CPF}";
            var date = sale.Date.ToString("dd/MM/yyyy");
            return $"{client}%{vehicle}%{salesMan}%{date}\r\n";            
        }        
    }    
}