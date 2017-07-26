using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class PessoaGenerica
    {
        public string PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string CPF { get; set; }

        public PessoaGenerica(string primeiroNome, string ultimoNome, string cpf)
        {
            this.PrimeiroNome = primeiroNome;
            this.UltimoNome = ultimoNome;
            this.CPF = cpf;
        }

        public override bool Equals(object obj)
        {
            if (EhPessoa(obj))
            {
                var pessoaComparada = (PessoaGenerica)obj;
                return this.CPF == pessoaComparada.CPF;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return (int)(Convert.ToUInt64(CPF) / 20051);
        }
        private bool EhPessoa(object obj)
        {
            return obj is PessoaGenerica;
        }
    }
}