using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class Venda
    {
        public Cliente Cliente { get; private set; }
        public Vendedor Vendedor { get; private set; }
        public Veiculo Veiculo { get; private set; }
        public string Data { get; private set; }


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
        public override string ToString()
        {
            return $"{this.Data}\r\n" +
                $"Cliente: {this.Cliente}\r\n" +
                $"Vendedor: {this.Vendedor}\r\n" +
                $"Veiculo: {this.Veiculo}\r\n" +
                $"Valor: R${this.Veiculo.Preco}";
        }
    }
}
