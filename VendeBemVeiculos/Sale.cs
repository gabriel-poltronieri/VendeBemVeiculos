using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class Sale
    {
        public Sale(Client client, Vehicle vehicle, Salesman salesman)
        {
            this.Client = client;
            this.Salesman = salesman;
            this.Vehicle = vehicle;
            this.Date = DateTime.Now;
        }
        public Sale(Client client, Vehicle vehicle, Salesman salesman, string date)
        {
            this.Client = client;
            this.Salesman = salesman;
            this.Vehicle = vehicle;
            this.Date = DateTime.ParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }

        public Client Client { get; private set; }
        public Salesman Salesman { get; private set; }
        public Vehicle Vehicle { get; private set; }
        public DateTime Date { get; private set; }

        public override string ToString()
        {
            return $@"{this.Date.ToString("dd/MM/yyyy")}     Cliente: {this.Client}     Veiculo: {this.Vehicle}";
        }
    }
}
