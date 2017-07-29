using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class Vendedor : Pessoa
    {
        public Vendedor(string primeiroNome, string ultimoNome, string cpf) 
            : base(primeiroNome, ultimoNome, cpf) { }  
        
        public void Vende(Veiculo veiculo, Cliente cliente)
        {
            var venda = new Venda(cliente, veiculo, this);
            RegistraVenda(venda);
        }

        private void RegistraVenda(Venda venda)
        {
            var novoRegistro = new RegistroDeVenda<Venda>("Vendas.txt");
            novoRegistro.AdicionaItemNoRegistro(venda);
        }
    }
}