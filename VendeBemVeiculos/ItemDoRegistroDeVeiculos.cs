using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    class ItemDoRegistroDeVeiculos : IComparable
    {
        public Veiculo veiculoDaLista;
        private int quantidade;

        public ItemDoRegistroDeVeiculos(Veiculo veiculoDaLista, int quantidade)
        {
            this.veiculoDaLista = veiculoDaLista;
            this.quantidade = quantidade;
        }
        public int VerificarQuantidade()
        {
            return this.quantidade;
        }
        public string VerificarTipoDeVeiculo()
        {
            return typeof(Veiculo).Name;
        }
        public string VerificarMarcaDoVeiculo()
        {
            return veiculoDaLista.Marca;
        }
        public string VerificarModeloDoVeiculo()
        {
            return veiculoDaLista.Modelo;
        }
        public string VerificarAnoDoVeiculo()
        {
            return veiculoDaLista.Ano;
        }
        public double VerificaPrecoDoVeiculo()
        {
            return veiculoDaLista.Preco;
        }

        public int CompareTo(object obj)
        {
            ItemDoRegistroDeVeiculos i = (ItemDoRegistroDeVeiculos)obj;
            return String.Compare(this.veiculoDaLista.Marca, i.veiculoDaLista.Marca);
        }
    }
}