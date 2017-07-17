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

        public Vendedor(string nome, string senha, int registro)
        {
            this.Nome = nome;
            CadastrarSenha(senha);
            this.Registro = registro;
            NumeroVendedores++;
        }

        public void Vende(Veiculo veiculo, Cliente cliente)
        {
            veiculo.Exclui();
        }

        public void CadastrarSenha(string senha)
        {
            this.Senha = senha;
        }

        
        public override string ToString()
        {
            return this.Nome;
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Vendedor))
            {
                return false;
            }
            Vendedor comparado = (Vendedor)obj;
            return this.Registro == comparado.Registro;
        }
    }
}
