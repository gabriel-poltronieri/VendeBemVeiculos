using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    class Venda
    {
        public Cliente cliente;
        public Vendedor vendedor;
        public Veiculo veiculo;

        public Venda(Cliente clienteQueComprou, Vendedor vendedorQueVendeu, Veiculo veiculoVendido)
        {
            this.cliente = clienteQueComprou;
            this.vendedor = vendedorQueVendeu;
            this.veiculo = veiculoVendido;
        }
    }
}
