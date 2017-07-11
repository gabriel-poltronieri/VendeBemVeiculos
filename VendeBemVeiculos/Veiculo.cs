using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    abstract class Veiculo
    {
        public string Marca { get; protected set; }
        public string Modelo { get; protected set; }
        public int Ano { get; protected set; }
        public double Preco { get; protected set; }
        public int Quantidade { get; protected set; }


        public Veiculo(string marca, string modelo, int ano, double preco, int quantidade)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Preco = preco;
            this.Quantidade = quantidade;
        }

        public override bool Equals(object outro)
        {
            if(!(outro is Veiculo))
            {
                return false;
            }
            Veiculo novoVeiculo = (Veiculo)outro;
            return (this.Marca == novoVeiculo.Marca) && (this.Modelo == novoVeiculo.Modelo) && (this.Ano == novoVeiculo.Ano);
        }

        public override int GetHashCode()
        {
            return this.Ano - this.Modelo.Length;
        }
    }
}
