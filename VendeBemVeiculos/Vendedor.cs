using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class Vendedor
    {
        public string Nome { get; private set; }
        public int Registro { get; }
        public static int NumeroVendedores { get; private set; }
        public string Senha { get; private set; }

        public Vendedor(string nome, string senha="123")
        {
            CadastrarSenha(senha);
            this.Nome = nome;
            NumeroVendedores++;
            this.Registro = NumeroVendedores;
        }

        public void CadastrarSenha(string senha)
        {
            this.Senha = senha;
        }

        public void AlterarNome(string nome)
        {
            this.Nome = nome;
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
