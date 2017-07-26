using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    class RegistroDeVeiculos : RegistroDeDados<ItemDoRegistroDeVeiculos> 
    {
        public RegistroDeVeiculos()
        {
            CarregaDadosDoArquivo("Veiculo");
        }

        public override void AdicionaOsObjetosAoConjuntoComAjudaDoStreamReader(StreamReader leitor)
        {
            string linhaLida = leitor.ReadLine();
            while (LinhaContemDados(linhaLida))
            {
                string[] dados = SeparaCadaDado(linhaLida);
                Veiculo novoVeiculo = InstanciaVeiculo(dados);
                int quantidade = PegarQuantidade(dados);
                ItemDoRegistroDeVeiculos itemDeRegistro = new ItemDoRegistroDeVeiculos(novoVeiculo, quantidade);
                this.ConjuntoDeDados.Add(itemDeRegistro);
                linhaLida = leitor.ReadLine();
            }
        }      

        public override void ColocaItensNaString()
        {             
            foreach(ItemDoRegistroDeVeiculos item in this.ConjuntoDeDados)
            {
                todosOsDadosRegistrados = $"{item.VerificarTipoDeVeiculo()}%{item.VerificarMarcaDoVeiculo()}%{item.VerificarModeloDoVeiculo()}%" +
                    $"{item.VerificarAnoDoVeiculo()}%{item.VerificaPrecoDoVeiculo()}%{item.VerificarQuantidade()}\n\r";
            }
        }

        private bool LinhaContemDados(string linha)
        {
            return linha != null && linha != "";
        }

        private string[] SeparaCadaDado(string todosOsDados)
        {
            return todosOsDados.Split('%');
        }

        public Veiculo InstanciaVeiculo(string[] dados)
        {
            string tipoDeVeiculo = PegarTipoDeVeiculo(dados);
            string marca = PegarMarcaDeveiculo(dados);
            string modelo = PegarModeloDeVeiculo(dados);
            string ano = PegarAnoDeVeiculo(dados);
            double preco = PegarPrecoDeVeiculo(dados);
            if (tipoDeVeiculo == "Carro") {
                return new Carro(marca, modelo, ano, preco);
            }
            else
            {
                return new Moto(marca, modelo, ano, preco);
            }
        }
        
        private string PegarTipoDeVeiculo(string[] dados)
        {
            return dados[0];
        }

        private string PegarMarcaDeveiculo(string[] dados)
        {
            return dados[1];
        }

        private string PegarModeloDeVeiculo(string[] dados)
        {
            return dados[2];
        }

        private string PegarAnoDeVeiculo(string[] dados)
        {
            return dados[3];
        }

        private double PegarPrecoDeVeiculo(string[] dados)
        {
            return Convert.ToDouble(dados[4]);
        }

        private int PegarQuantidade(string[] dados)
        {
            return Convert.ToInt16(dados[5]);
        }
    }
}
