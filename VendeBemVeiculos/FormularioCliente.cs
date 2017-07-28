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
    public partial class FormularioCliente : Form
    {   
        public RegistroDePessoas<Cliente> TodosOsClientes { get; private set; }
        public Cliente ClienteSelecionado { get; private set; }

        public FormularioCliente()
        {
            InitializeComponent();
            this.TodosOsClientes = new RegistroDePessoas<Cliente>("Cliente.txt");
            CarregarNaLista(this.TodosOsClientes.Itens);
            this.textoCPF.MaxLength = 11;
        }

        public void AtualizaTodosOsClientes()
        {
            this.TodosOsClientes = new RegistroDePessoas<Cliente>("Cliente.txt");
            CarregarNaLista(this.TodosOsClientes.Itens);
        }

        private void CarregarNaLista(Cliente[] listaDeClientes)
        {
            this.listaClientes.Items.Clear();
            this.listaClientes.Items.AddRange(listaDeClientes);            
        }

        private void ListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.ClienteSelecionado = (Cliente)this.listaClientes.SelectedItem;
        }          
        private void BotaoExcluir_Click(object sender, EventArgs e)
        {
            this.TodosOsClientes.ExcluiItemDoRegistro(this.ClienteSelecionado);
            AtualizaTodosOsClientes();
        }

        private void BotaoBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textoCPF.Text))
            {
                CarregarNaLista(this.TodosOsClientes.Itens);
            }
            else
            {
                CarregarNaLista(this.TodosOsClientes.Itens.Where(c => c.CPF == textoCPF.Text).ToArray());
            }
        }
        private void BotaoNovoCliente_Click(object sender, EventArgs e)
        {
            FormularioNovoCliente formularioNovoCliente = new FormularioNovoCliente(this);
            formularioNovoCliente.Show();
        }
    }
}