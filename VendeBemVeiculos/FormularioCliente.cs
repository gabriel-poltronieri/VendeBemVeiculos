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
        private FormularioVenda formVenda;
        private Cliente cliente;
        public FormularioCliente(FormularioVenda formVenda) 
        {
            this.formVenda = formVenda;
            InitializeComponent();
        }

        private void FormularioCliente_Load(object sender, EventArgs e)
        {
            AtualizaLista();
        }

        public void AtualizaLista()
        {
            listaClientes.Items.Clear();
            foreach (Cliente c in FormularioPrincipal.Clientes)
            {
                listaClientes.Items.Add(c);
            }
        }

        private void listaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cliente = (Cliente)listaClientes.SelectedItem;
        }

        private void botaoSeleciona_Click(object sender, EventArgs e)
        {
            if (this.cliente != null)
            {
                this.formVenda.SelecionaCliente(this.cliente);
                this.Close();
            }
        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            string cpf = textoCpf.Text;
            if (cpf.Length != 11)
            {
                MessageBox.Show("O CPF deve conter 11 dígitos");
            }
            else
            {
                var filtro = FormularioPrincipal.Clientes.Where(c => c.Cpf == cpf);
                try
                    {                        
                    Cliente selecionado = (Cliente)filtro.ElementAt(0);
                    this.listaClientes.Items.Clear();
                    listaClientes.Items.Add(selecionado);
                    }
                catch (ArgumentOutOfRangeException ex)
                    {
                        MessageBox.Show("Nenhum cliente com o CPF buscado");
                    }
                
            }
        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            FormularioNovoCliente formNovoCliente = new FormularioNovoCliente(this);
            formNovoCliente.Show();
        }
    }
}
