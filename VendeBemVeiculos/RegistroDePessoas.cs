using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendeBemVeiculos
{
    class RegistroDePessoas<T> : RegistroDeDados<T> where T : PessoaGenerica
    {   
        public RegistroDePessoas()
        {
            CarregaDadosDoArquivo(typeof(T).Name);
        }

        public override void AdicionaOsObjetosAoConjuntoComAjudaDoStreamReader(StreamReader leitor)
        {
            string linhaLida = leitor.ReadLine();
            while (LinhaContemDados(linhaLida))
            {
                string[] dados = SeparaCadaDado(linhaLida);
                string primeiroNome = PegaPrimeiroNome(dados);
                string ultimoNome = PegaUltimoNome(dados);
                string cpf = PegaCPF(dados);
                var pessoaInstanciada = (T)Activator.CreateInstance(typeof(T), primeiroNome, ultimoNome, cpf);
                this.ConjuntoDeDados.Add(pessoaInstanciada);
                linhaLida = leitor.ReadLine();
            }
        }
        public override void ColocaItensNaString()
        {
            foreach (T v in this.ConjuntoDeDados)
            {
                todosOsDadosRegistrados += $"{v.PrimeiroNome}%{v.UltimoNome}%{v.CPF}\r\n";
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
        private string PegaPrimeiroNome(string[] dados)
        {
            return dados[0];
        }
        private string PegaUltimoNome(string[] dados)
        {
            return dados[1];
        }
        private string PegaCPF(string[] dados)
        {
            return dados[2];
        }
    }
}