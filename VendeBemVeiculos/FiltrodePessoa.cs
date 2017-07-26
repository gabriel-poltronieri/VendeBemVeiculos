using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    class FiltroDePessoa<T> where T : PessoaGenerica
    {
        public RegistroDeDados<T> RegistroASerFiltrado { get; set; }

        public FiltroDePessoa(RegistroDeDados<T> registro) 
        {
            this.RegistroASerFiltrado = registro;
        }

        public SortedSet<T> FiltrarPeloDado(string cpf)
        {
            SortedSet<T> todasAsPessoas = RegistroASerFiltrado.ConjuntoDeDados;
            var filtro = todasAsPessoas.Where(p => p.CPF == cpf);
            SortedSet<T> pessoasFiltradas = new SortedSet<T>(filtro);
            return pessoasFiltradas;
        }
    }
}
