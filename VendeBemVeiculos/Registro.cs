using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public abstract class Registro<T> 
    {
        public string NomeDoArquivo { get; protected set; }
        public T[] Itens { get { return this.ConjuntoDeDados.ToArray(); } }
        protected abstract ICollection<T> ConjuntoDeDados { get; }
        protected string todosOsDados;

        public Registro(string nomeDoArquivo)
        {
            this.NomeDoArquivo = nomeDoArquivo;
            if (File.Exists(NomeDoArquivo))
            {
                CarregaDados();
            }
            else
            {
                File.Create(this.NomeDoArquivo);
            }
        }
        
        public void AdicionaItemNoRegistro(T item)
        {
            this.ConjuntoDeDados.Add(item);
            AtualizaArquivo();
        }
        public void ExcluiItemDoRegistro(T item)
        {
            this.ConjuntoDeDados.Remove(item);
            AtualizaArquivo();
        }
        public void AtualizaArquivo()
        {
            using (Stream streamDeDados = File.Open(this.NomeDoArquivo, FileMode.Create))
            using (StreamWriter escritorDeDados = new StreamWriter(streamDeDados))
            {
                ColocaItensNaString();
                escritorDeDados.Write(todosOsDados);
            }
            ApagaConteudoDaString();
        }

        private void ApagaConteudoDaString()
        {
            this.todosOsDados = "";
        }
        
        protected abstract void CarregaDados();
        protected abstract void ColocaItensNaString();
    }
}