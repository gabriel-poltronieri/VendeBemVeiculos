using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class RegistroDeVenda<T> : Registro<T> where T : Venda
    {
        private const int CLIENTE_PRIMEIRO_NOME = 0;
        private const int CLIENTE_ULTIMO_NOME = 1;
        private const int CLIENTE_CPF = 2;
        private const int VEICULO_MARCA = 3;
        private const int VEICULO_MODELO = 4;
        private const int VEICULO_ANO = 5;
        private const int VEICULO_PRECO = 6;
        private const int VENDEDOR_PRIMEIRO_NOME = 7;
        private const int VENDEDOR_ULTIMO_NOME = 8;
        private const int VENDEDOR_CPF = 9;
        private const int DATA = 10;

        public RegistroDeVenda(string nomeDoArquivo) 
            : base(nomeDoArquivo) { }

        protected override ICollection<T> ConjuntoDeDados => new List<T>();

        protected override void CarregaDados()
        {
            if (File.Exists(this.NomeDoArquivo))
            {
                using (Stream streamDeVendas = File.Open(this.NomeDoArquivo, FileMode.Open))
                using (StreamReader leitorDeArquivo = new StreamReader(streamDeVendas))
                {
                    string linhaLida = leitorDeArquivo.ReadLine();
                    while (!(string.IsNullOrEmpty((linhaLida))))
                    {
                        string[] dados = linhaLida.Split('%');
                        var cliente = InstanciarCliente(dados);
                        var veiculo = InstanciarVeiculo(dados);
                        var vendedor = IntanciaVendedor(dados);
                        var data = dados[DATA];
                        var venda = (T)Activator.CreateInstance(typeof(T), cliente, veiculo, vendedor, data);
                        this.ConjuntoDeDados.Add(venda);
                        linhaLida = leitorDeArquivo.ReadLine();
                    }
                }
            }
        }
        protected override void ColocaItensNaString()
        {
            foreach (T v in this.ConjuntoDeDados)
            {
                CriaLinhaDaString(v);
            }
        }

        private void CriaLinhaDaString(T venda)
        {
            if (venda != null)
            {
                this.todosOsDados += $"{venda.Cliente.PrimeiroNome}%{venda.Cliente.UltimoNome}%{venda.Cliente.CPF}%" +
                    $"{venda.Veiculo.Marca}%{venda.Veiculo.Modelo}%{venda.Veiculo.Ano}%{venda.Veiculo.Preco}%" +
                    $"{venda.Vendedor.PrimeiroNome}%{venda.Vendedor.UltimoNome}%{venda.Vendedor.CPF}%" +
                    $"{venda.Data}\r\n";
            }
        }
        private Cliente InstanciarCliente(string[] dados)
        {
            var clientePrimeiroNome = dados[CLIENTE_PRIMEIRO_NOME];
            var clienteUltimoNome = dados[CLIENTE_ULTIMO_NOME];
            var clienteCpf = dados[CLIENTE_CPF];
            return new Cliente(clientePrimeiroNome, clienteUltimoNome, clienteCpf);
        }
        private Veiculo InstanciarVeiculo(string[] dados)
        {
            var veiculoMarca = dados[VEICULO_MARCA];
            var veiculoModelo = dados[VEICULO_MODELO];
            var veiculoAno = dados[VEICULO_ANO];
            var veiculoPreco = dados[VEICULO_PRECO];
            return new Veiculo(veiculoMarca, veiculoModelo, veiculoAno, Convert.ToDouble(veiculoPreco));
        }
        private Vendedor IntanciaVendedor(string[] dados)
        {
            var vendedorPrimeiroNome = dados[VENDEDOR_PRIMEIRO_NOME];
            var vendedorUltimoNome = dados[VENDEDOR_ULTIMO_NOME];
            var vendedorCpf = dados[VENDEDOR_CPF];
            return new Vendedor(vendedorPrimeiroNome, vendedorUltimoNome, vendedorCpf);
        }

    }
}