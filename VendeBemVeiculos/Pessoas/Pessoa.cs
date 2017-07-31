using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class Pessoa : IComparable
    {
        public Pessoa(string primeiroNome, string ultimoNome, string cpf)
        {
            this.PrimeiroNome = primeiroNome;
            this.UltimoNome = ultimoNome;
            this.CPF = cpf;
        }

        public string PrimeiroNome { get; private set; }
        public string UltimoNome { get; private set; }
        public string CPF { get; private set; }

        public override int GetHashCode()
        {
            return (int)(Convert.ToUInt64(CPF) / 20051);
        }
        public override string ToString()
        {
            return $"{this.PrimeiroNome} {this.UltimoNome}     CPF:{this.CPF}";
        }
        public int CompareTo(object obj)
        {
            var p = (Pessoa)obj;
            return string.Compare(this.CPF, p.CPF);
        }

        public override bool Equals(object obj)
        {
            if (EhPessoa(obj))
            {
                var pessoaComparada = (Pessoa)obj;
                return this.CPF == pessoaComparada.CPF;
            }
            return false;
        }
        private bool EhPessoa(object obj)
        {
            return obj is Pessoa;
        }        
    }
}