using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public class RegistroDePessoas<T> : Registro<T> where T : Pessoa
    {
        private const int PRIMEIRO_NOME = 0;
        private const int ULTIMO_NOME = 1;
        private const int CPF = 2;

        public RegistroDePessoas(string nomeDoArquivo) 
            : base(nomeDoArquivo) { }
        
        protected override ICollection<T> ConjuntoDeDados { get; } = new SortedSet<T>();

        protected override void CarregaDados()
        {
            if (File.Exists(this.NomeDoArquivo))
            {
                using (Stream streamDePessoas = File.Open(this.NomeDoArquivo, FileMode.Open))
                using (StreamReader leitorDeArquivo = new StreamReader(streamDePessoas))
                {
                    string linhaLida = leitorDeArquivo.ReadLine();
                    while (!(string.IsNullOrEmpty(linhaLida)))
                    {
                        string[] dados = linhaLida.Split('%');
                        var primeiroNome = dados[PRIMEIRO_NOME];
                        var ultimoNome = dados[ULTIMO_NOME];
                        var cpf = dados[CPF];
                        var pessoaInstanciada = (T)Activator.CreateInstance(typeof(T), primeiroNome, ultimoNome, cpf);
                        this.ConjuntoDeDados.Add(pessoaInstanciada);
                        linhaLida = leitorDeArquivo.ReadLine();
                    }
                }
            }
        }
        protected override void ColocaItensNaString()
        {
            foreach (T p in this.ConjuntoDeDados)
            {
                CriaLinhaDaString(p);
            }
        }                   
        
        private void CriaLinhaDaString(T pessoa)
        {
            if (pessoa != null)
            {
                this.todosOsDados += $"{pessoa.PrimeiroNome}%{pessoa.UltimoNome}%{pessoa.CPF}\r\n";
            }
        }
    }
}