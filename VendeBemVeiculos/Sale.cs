using System;
using System.Collections.Generic;
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
            this.Date = DateTime.Now.ToString("dd/MM/yyyy");
        }
        public Sale(Client client, Vehicle vehicle, Salesman saler, string date)
        {
            this.Client = client;
            this.Salesman = saler;
            this.Vehicle = vehicle;
            this.Date = date;
        }

        public Client Client { get; private set; }
        public Salesman Salesman { get; private set; }
        public Vehicle Vehicle { get; private set; }
        public string Date { get; private set; }

        public override string ToString()
        {
            return $@"{this.Date}     Cliente: {this.Client}     Veiculo: {this.Vehicle}";
        }
    }
}
