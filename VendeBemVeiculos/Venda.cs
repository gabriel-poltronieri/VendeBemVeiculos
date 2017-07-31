using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class Venda
    {
        public Venda(Cliente cliente, Veiculo veiculo, Vendedor vendedor)
        {
            this.Cliente = cliente;
            this.Vendedor = vendedor;
            this.Veiculo = veiculo;
            this.Data = DateTime.Now.ToString("dd/MM/yyyy");
        }
        public Venda(Cliente cliente, Veiculo veiculo, Vendedor vendedor, string data)
        {
            this.Cliente = cliente;
            this.Vendedor = vendedor;
            this.Veiculo = veiculo;
            this.Data = data;
        }

        public Cliente Cliente { get; private set; }
        public Vendedor Vendedor { get; private set; }
        public Veiculo Veiculo { get; private set; }
        public string Data { get; private set; }

        public override string ToString()
        {
            return $@"{this.Data}     Cliente: {this.Cliente}     Veiculo: {this.Veiculo}";
        }
    }
}
