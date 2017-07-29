using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class RegistroDeVeiculos<T> : Registro<T> where T : Veiculo
    {
        private const int MARCA = 0;
        private const int MODELO = 1;
        private const int ANO = 2;
        private const int PRECO = 3;

        public RegistroDeVeiculos(string nomeDoArquivo)
            : base(nomeDoArquivo) { }

        protected override ICollection<T> ConjuntoDeDados { get; } =  new List<T>();

        protected override void CarregaDados()
        {
            if (File.Exists(this.NomeDoArquivo))
            {
                using (var streamDeVeiculos = File.Open(this.NomeDoArquivo, FileMode.Open))
                using (var leitorDeArquivo = new StreamReader(streamDeVeiculos))
                {
                    string linhaLida = leitorDeArquivo.ReadLine();
                    while (!(string.IsNullOrEmpty(linhaLida)))
                    {
                        string[] dados = linhaLida.Split('%');
                        var marca = dados[MARCA];
                        var modelo = dados[MODELO];
                        var ano = dados[ANO];
                        var preco = dados[PRECO];
                        var veiculoInstanciado = (T)Activator.CreateInstance(typeof(T), marca, modelo, ano, Convert.ToDouble(preco));
                        this.ConjuntoDeDados.Add(veiculoInstanciado);
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

        private void CriaLinhaDaString(T veiculo)
        {
            if (veiculo != null)
            {
                this.todosOsDados += $"{veiculo.Marca}%{veiculo.Modelo}%{veiculo.Ano}%{veiculo.Preco}\r\n";
            }
        }
    }
}
