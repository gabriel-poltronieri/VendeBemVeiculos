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
        //Consstrutor para quando cria um novo Vendedor
        public Vendedor(string nome)
        {
            this.Nome = nome;
            NumeroVendedores++;
            this.Registro = NumeroVendedores;
        }
        //Construtor para quando carrega um vendedor do arquivo txt
        public Vendedor(string nome, int registro)
        {
            this.Nome = nome;
            this.Registro = registro;
            NumeroVendedores++;
        }

        public void Vende(Veiculo veiculo, Cliente cliente)
        {
            veiculo.Exclui();
        }       

        //Devolve o registro mais o nome do vendedor
        public override string ToString()
        {
            return this.Registro + "     " + this.Nome;
        }
        //Vendedores são iguais se tiverem o mesmo registro
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
