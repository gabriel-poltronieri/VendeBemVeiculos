using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class Veiculo : IComparable
    { 
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public double Preco { get; set; }

        public Veiculo(string marca, string modelo, string ano, double preco)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.Preco = preco;
        }
                
        public override int GetHashCode()
        {
            return (int)((Marca.Length * Modelo.Length) + Preco / Convert.ToInt16(Ano));
        }
        public override string ToString()
        {
            return $"{this.Marca} {this.Modelo} Ano {this.Ano} Preço: R${string.Format("{0:0.00}", this.Preco)}";
        }
        public int CompareTo(object obj)
        {
            var v = (Veiculo)obj;
            return string.Compare(this.Marca, v.Marca);
        }
        public override bool Equals(object obj)
        {
            if (EhVeiculo(obj))
            {
                var veiculoComparado = (Veiculo)obj;
                return ComparaTodosOsDados(veiculoComparado);
            }
            return false;
        }

        private bool EhVeiculo(object obj)
        {
            return obj is Veiculo;
        }
        private bool ComparaTodosOsDados(Veiculo veiculo)
        {
            return (this.Marca == veiculo.Marca) && (this.Modelo == veiculo.Modelo) && (this.Ano == veiculo.Ano) && (this.Preco == veiculo.Preco);
        }       
    }
}