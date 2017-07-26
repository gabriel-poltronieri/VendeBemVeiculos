using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    interface IManipulaTXT<T>
    {
        void AdicionaItemNoRegistro(T item);
        void ExcluiItemDoRegistro(T item);
        void AtualizaTXT();
    }
}