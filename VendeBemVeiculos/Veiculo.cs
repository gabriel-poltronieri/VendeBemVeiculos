using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public abstract class Veiculo
    {
        public string Marca { get; protected set; }
        public string Modelo { get; protected set; }
        public string Ano { get; protected set; }
        public double Preco { get; protected set; }
        public int Quantidade { get; protected set; }


        public Veiculo(string marca, string modelo, string ano, double preco, int quantidade)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public void Exclui()
        {
            //Diminui o inteiro da quantidade e, caso ela zere, elmina o objeto do hashset
            this.Quantidade--;
            if(this.Quantidade <= 0)
            {
                FormularioPrincipal.Veiculos.Remove(this);
            }
            FormularioPrincipal.SalvarVeiculos();
        }
        //Veículos serão iguais se tiverem mesma marca, modelo e ano
        public override bool Equals(object outro)
        {
            if(!(outro is Veiculo))
            {
                return false;
            }
            Veiculo novoVeiculo = (Veiculo)outro;
            return (this.Marca == novoVeiculo.Marca) && (this.Modelo == novoVeiculo.Modelo) && (this.Ano == novoVeiculo.Ano);
        }
        //Outros métodos sobrescritos
        public override int GetHashCode()
        {
            return Convert.ToInt32(this.Ano) - this.Modelo.Length;
        }
        public override string ToString()
        {
            return this.Marca + "  " + this.Modelo + "  " + this.Ano + "    R$" + this.Preco + "    Quantidade:" + this.Quantidade;
        }
    }
}
