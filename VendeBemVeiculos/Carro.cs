using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    class Carro : IVeiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }

        public Carro(string marca, string modelo, string ano)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Ano = ano;
        }
    }
}
