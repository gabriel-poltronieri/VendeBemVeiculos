using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    class RegistroDeVendedores : SortedSet<Vendedor>, IRegistro
    {
        public void Adiciona(object novoVendedor)
        {
            if (VerificaSeEhVendedor(novoVendedor))
            {
                Vendedor vendedorQueSeraAdicionado = (Vendedor)novoVendedor;
                base.Add(vendedorQueSeraAdicionado);
            }
        }
        public void Remove(object vendedor)
        {
            if (VerificaSeEhVendedor(vendedor))
            {
                Vendedor vendedorRemovido = (Vendedor)vendedor;
                base.Remove(vendedorRemovido);
            }
        }
        public bool VerificaSeContemObjeto(object vendedor)
        {
            if (VerificaSeEhVendedor(vendedor))
            {
                Vendedor vendedorProcurado = (Vendedor)vendedor;
                base.Contains(vendedorProcurado);
            }
            return false;
        }

        private bool VerificaSeEhVendedor(object item)
        {
            if(item is Vendedor)
            {
                return true;
            }
            return false;
        }
    }
}