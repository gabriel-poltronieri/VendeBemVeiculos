using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class Vendedor : IPessoa
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string CPF { get; set; }

        public Vendedor(string primeiroNome, string ultimoNome, string cpf)
        {
            this.PrimeiroNome = primeiroNome;
            this.UltimoNome = ultimoNome;
            this.CPF = cpf;
        }

        public override bool Equals(object obj)
        {
            
        }

    }
}
