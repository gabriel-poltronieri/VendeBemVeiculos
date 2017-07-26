using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class Veiculo
    { 
        string Marca { get; set; }
        string Modelo { get; set; }
        string Ano { get; set; }
        double Preco { get; set; }

        public Veiculo(string marca, string modelo, string ano)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
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
        public override int GetHashCode()
        {
            return (int)((Marca.Length * Modelo.Length) + Preco / Convert.ToInt16(Ano));
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