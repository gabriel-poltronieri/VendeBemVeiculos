using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    class FiltroDeVeiculo 
    {
        public RegistroDeVeiculos RegistroASerFiltrado { get ; set; }

        public FiltroDeVeiculo(RegistroDeVeiculos registro)
        {
            this.RegistroASerFiltrado = registro;
        }
                
        public SortedSet<ItemDoRegistroDeVeiculos> FiltrarPelaMarca(string marca)
        {
            SortedSet<ItemDoRegistroDeVeiculos> todosOsVeiculos = RegistroASerFiltrado.ConjuntoDeDados;
            var filtro = todosOsVeiculos.Where(v => v.VerificarMarcaDoVeiculo() == marca);
            SortedSet<ItemDoRegistroDeVeiculos> veiculosFiltrados = new SortedSet<ItemDoRegistroDeVeiculos>(filtro);
            return veiculosFiltrados;
        }

        public SortedSet<ItemDoRegistroDeVeiculos> FiltrarPeloModelo(string modelo)
        {
            SortedSet<ItemDoRegistroDeVeiculos> todosOsVeiculos = RegistroASerFiltrado.ConjuntoDeDados;
            var filtro = todosOsVeiculos.Where(v => v.VerificarModeloDoVeiculo() == modelo);
            SortedSet<ItemDoRegistroDeVeiculos> veiculosFiltrados = new SortedSet<ItemDoRegistroDeVeiculos>(filtro);
            return veiculosFiltrados;
        }

        public SortedSet<ItemDoRegistroDeVeiculos> FiltrarPeloAno(string ano)
        {
            SortedSet<ItemDoRegistroDeVeiculos> todosOsVeiculos = RegistroASerFiltrado.ConjuntoDeDados;
            var filtro = todosOsVeiculos.Where(v => v.VerificarAnoDoVeiculo() == ano);
            SortedSet<ItemDoRegistroDeVeiculos> veiculosFiltrados = new SortedSet<ItemDoRegistroDeVeiculos>(filtro);
            return veiculosFiltrados;
        }
    }
}
