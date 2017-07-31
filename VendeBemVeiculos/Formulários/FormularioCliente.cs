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
        private FormularioVenda formularioVenda;

        public FormularioCliente(FormularioVenda formularioVenda)
        {
            this.formularioVenda = formularioVenda;
            InitializeComponent();
            this.TodosOsClientes = new RegistroDePessoas<Cliente>("Cliente.txt");
            CarregarNaLista(this.TodosOsClientes.Itens);
        }

        public RegistroDePessoas<Cliente> TodosOsClientes { get; private set; }
        public Cliente ClienteSelecionado { get; private set; }

        private void ListaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listaClientes.SelectedItem != null)
            {
                this.ClienteSelecionado = (Cliente)this.listaClientes.SelectedItem;
            }
        }

        private void BotaoExcluir_Click(object sender, EventArgs e)
        {
            if (this.ClienteSelecionado != null)
            {
                this.TodosOsClientes.ExcluiItemDoRegistro(this.ClienteSelecionado);
                AtualizaTodosOsClientes();
            }
            else
            {
                MessageBox.Show("Nenhum cliente selecionado");
            }
        }        
        private void BotaoNovoCliente_Click(object sender, EventArgs e)
        {
            FormularioNovoCliente formularioNovoCliente = new FormularioNovoCliente(this);
            formularioNovoCliente.Show();
        }
        private void BotaoSeleciona_Click(object sender, EventArgs e)
        {
            if (this.ClienteSelecionado != null)
            {
                this.formularioVenda.DefineCliente(this.ClienteSelecionado);
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um Cliente");
            }
        }

        private void BotaoBuscar_Click(object sender, EventArgs e)
        {
            if (CpfEstaVazio())
            {
                CarregarNaLista(this.TodosOsClientes.Itens);
            }
            else
            {
                BuscarClientePorCpf();
            }
        }
        private bool CpfEstaVazio()
        {
            return this.textoCPF.Text == "   .   .   -";
        }
        private void CarregarNaLista(Cliente[] listaDeClientes)
        {
            this.listaClientes.Items.Clear();
            this.listaClientes.Items.AddRange(listaDeClientes);
        }

        private void BuscarClientePorCpf()
        {
            Cliente[] cpfBuscado = this.TodosOsClientes.FiltrarPorCpf(this.textoCPF.Text);
            if (cpfBuscado.Length == 0)
            {
                MessageBox.Show("Nenhum Cliente com o CPF buscado");
            }
            else
            {
                CarregarNaLista(cpfBuscado);
            }
        }

        public void AtualizaTodosOsClientes()
        {
            this.TodosOsClientes = new RegistroDePessoas<Cliente>("Cliente.txt");
            CarregarNaLista(this.TodosOsClientes.Itens);
        }
    }
}