using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendeBemVeiculos
{
    public partial class FormularioNovoCliente : Form
    {
        private RegistroDePessoas<Cliente> todosOsClientes;
        private FormularioCliente formularioCliente;

        public FormularioNovoCliente(FormularioCliente formularioCliente)
        {
            InitializeComponent();
            this.todosOsClientes = new RegistroDePessoas<Cliente>("Cliente.txt");
            this.formularioCliente = formularioCliente;
        }

        private void BotaoCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotaoCadastra_Click(object sender, EventArgs e)
        {
            if (!VerificaPrimeiroEUltimoNome())
            {
                MessageBox.Show("Preencha primeiro e último nome");
            }
            else if (CpfIncompleto())
            {
                MessageBox.Show("Complete os dados do CPF");
            }
            else
            {
                AdicionaCliente();
            }
        }
        private bool VerificaPrimeiroEUltimoNome()
        {
            return (this.textoPrimeiroNome.Text != "") && (this.textoUltimoNome.Text != "");
        }
        private bool CpfIncompleto()
        {
            return this.textoCpf.Text.Contains(' '); // == TAMANHO_CPF;
        }
        private void AdicionaCliente()
        {
            try
            {
                var cliente = new Cliente(this.textoPrimeiroNome.Text, this.textoUltimoNome.Text, this.textoCpf.Text);
                this.todosOsClientes.AdicionaItemNoRegistro(cliente);
                this.formularioCliente.AtualizaTodosOsClientes();
                this.Close();
            }
            catch (ExceptionDadoJaExistente)
            {
                MessageBox.Show("CPF já cadastrado");
            }
        }
    }
}