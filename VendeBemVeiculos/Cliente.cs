using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class Cliente : PessoaGenerica
    {
        public Cliente(string primeiroNome, string ultimoNome, string cpf)
            : base(primeiroNome, ultimoNome, cpf) { }
    }
}
