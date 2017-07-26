using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    class RegistroDeVenda<T> : RegistroDeDados<T> where T : Venda
    {

        public RegistroDeVenda()
        {
            CarregaDadosDoArquivo("Venda");
        }

        public override void AdicionaOsObjetosAoConjuntoComAjudaDoStreamReader(StreamReader leitor)
        {
            string linhaLida = leitor.ReadLine();
            while (LinhaContemDados(linhaLida))
            {
                string[] dados = SeparaCadaDado(linhaLida);
                Cliente cliente = PegarCliente(dados);
                Vendedor vendedor = PegarVendedor(dados);
                Veiculo veiculo = PegarVeiculo(dados);
                var vendaRealizada = (T)Activator.CreateInstance(typeof(T), cliente, vendedor, veiculo);
                this.ConjuntoDeDados.Add(vendaRealizada);
                linhaLida = leitor.ReadLine();
            }
        }
        public override void ColocaItensNaString()
        {
            foreach(T v in this.ConjuntoDeDados)
            {
                todosOsDadosRegistrados += $"{v.cliente}"
            }
        }

        private Veiculo PegarVeiculo(string[] dados)
        {
            return new Veiculo(dados[6], dados[7], dados[8], Convert.ToDouble(dados[9]));
        }
        private Vendedor PegarVendedor(string[] dados)
        {
            return new Vendedor(dados[3], dados[4], dados[5]);
        }
        private Cliente PegarCliente(string[] dados)
        {
            return new Cliente(dados[0], dados[1], dados[2]);
        }       
        private string[] SeparaCadaDado(string todosOsDados)
        {
            return todosOsDados.Split('%');
        }
        private bool LinhaContemDados(string linha)
        {
            return linha != null && linha != "";
        }
    }
}
