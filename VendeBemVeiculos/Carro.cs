using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    class Carro : Veiculo
    {
        public Carro(string marca, string modelo, string ano, double preco)
            : base(marca, modelo, ano, preco) { }
    }
}
