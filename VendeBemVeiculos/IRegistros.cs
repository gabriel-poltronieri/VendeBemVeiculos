using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    interface IRegistro
    {
        void Adiciona(Object item);
        void Remove(Object item);
        bool VerificaSeContemObjeto(Object item);
    }
}
