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
        private Cliente novoCliente;
        private FormularioCliente formularioCliente;

        public FormularioNovoCliente(FormularioCliente formularioCliente)
        {
            InitializeComponent();
            this.todosOsClientes = new RegistroDePessoas<Cliente>("Cliente.txt");
            this.formularioCliente = formularioCliente;
            this.textoCpf.MaxLength = 11;
        }

        private void BotaoCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BotaoCadastra_Click(object sender, EventArgs e)
        {
            this.novoCliente = new Cliente(textoPrimeiroNome.Text, textoUltimoNome.Text, textoCpf.Text);
            this.todosOsClientes.AdicionaItemNoRegistro(novoCliente);
            this.formularioCliente.AtualizaTodosOsClientes();
            this.Close();

        }
    }
}