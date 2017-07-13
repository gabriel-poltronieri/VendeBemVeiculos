using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public int Compras { get; set; }

        public Cliente(string nome, string cpf, string telefone, string endereco)
        {
            this.Nome = nome;
            this.Cpf = cpf;
            this.Telefone = telefone;
            this.Endereco = endereco;
        }

        
        public override bool Equals(object obj)
        {
            if(!(obj is Cliente))
            {
                return false;
            }
            Cliente compara = (Cliente)obj;
            return this.Cpf == compara.Cpf;
        }

        public override string ToString()
        {
            string dados = this.Nome + "    CPF: " + this.Cpf;
            return dados;
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
