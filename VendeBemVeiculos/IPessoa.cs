using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    internal interface IPessoa
    {
        string PrimeiroNome { get; set; }
        string UltimoNome { get; set; }
        string CPF { get; set; }
    }
}
