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

        public override void AdicionaItemNoRegistro(T item)
        {
            if (this.ConjuntoDeDados.Contains(item))
            {
                throw new ExceptionDadoJaExistente();
            }
            else
            {
                base.AdicionaItemNoRegistro(item);
            }
        }

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
                        Carrega(linhaLida);                        
                        linhaLida = leitorDeArquivo.ReadLine();
                    }
                }
            }
        }
        private void Carrega(string linhaLida)
        {
            string[] dados = linhaLida.Split('%');
            var primeiroNome = dados[PRIMEIRO_NOME];
            var ultimoNome = dados[ULTIMO_NOME];
            var cpf = dados[CPF];
            var pessoaInstanciada = (T)Activator.CreateInstance(typeof(T), primeiroNome, ultimoNome, cpf);
            this.ConjuntoDeDados.Add(pessoaInstanciada);
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

        public T[] FiltrarPorPrimeiroNome(string primeiroNome)
        {
            return this.Itens.Where(v => v.PrimeiroNome == primeiroNome).ToArray();
        }
        public T[] FiltrarPorUltimoNome(string ultimoNome)
        {
            return this.Itens.Where(v => v.UltimoNome == ultimoNome).ToArray();
        }
        public T[] FiltrarPorCpf(string cpf)
        {
            return this.Itens.Where(v => v.CPF == cpf).ToArray();
        }
    }
}