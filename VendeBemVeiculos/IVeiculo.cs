using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public interface IVeiculo
    { 
        string Marca { get; set; }
        string Modelo { get; set; }
        string Ano { get; set; }   
    }
}
