using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    public abstract class RegistroDeDados<T> 
    {
        public string ArquivoTXT { get; protected set; }
        public SortedSet<T> ConjuntoDeDados { get; protected set; }
        protected string todosOsDadosRegistrados;

        public void CarregaDadosDoArquivo(string nomeDoArquivo)
        {
            this.ArquivoTXT = nomeDoArquivo;
            if (ArquivoExiste(ArquivoTXT))
            {
                Stream streamDeDados = File.Open(this.ArquivoTXT, FileMode.Open);
                StreamReader leitorDeDados = new StreamReader(streamDeDados);
                AdicionaOsObjetosAoConjuntoComAjudaDoStreamReader(leitorDeDados);
                streamDeDados.Close();
                leitorDeDados.Close();
            }
        }
        public void AdicionaItemNoRegistro(T item)
        {
            this.ConjuntoDeDados.Add(item);
            AtualizaTXT();
        }
        public void ExcluiItemDoRegistro(T item)
        {
            this.ConjuntoDeDados.Remove(item);
            AtualizaTXT();
        }
        public void AtualizaTXT()
        {
            VerificaSeArquivoExiste();
            Stream streamDasPessoas = File.Open(this.ArquivoTXT, FileMode.Create);
            StreamWriter escritorDasPessoas = new StreamWriter(streamDasPessoas);
            ColocaItensNaString();
            escritorDasPessoas.Write(todosOsDadosRegistrados);
            streamDasPessoas.Close();
            escritorDasPessoas.Close();
            ApagaConteudoDaString();
        }

        private bool ArquivoExiste(string arquivo)
        {
            return File.Exists(arquivo);
        }
        private void ApagaConteudoDaString()
        {
            this.todosOsDadosRegistrados = "";
        }
        private void VerificaSeArquivoExiste()
        {
            if(ArquivoTXT == null || ArquivoTXT == "")
            {
                NomearArquivo();
            }
        }
        private void NomearArquivo()
        {
            string titulo = typeof(T).Name;
            this.ArquivoTXT = titulo + ".txt";
        }

        public abstract void AdicionaOsObjetosAoConjuntoComAjudaDoStreamReader(StreamReader leitor);
        public abstract void ColocaItensNaString();
    }
}