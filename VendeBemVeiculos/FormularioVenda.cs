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
    public partial class FormularioVenda : Form
    {
        public Cliente ClienteSelecionado { get; private set; }
        public Veiculo veiculoSelecionado;
        public Vendedor vendedor;
        RegistroDePessoas<Vendedor> nossosVendedores = new RegistroDePessoas<Vendedor>();
        RegistroDeVeiculos nossoEstoque = new RegistroDeVeiculos();

        public FormularioVenda()
        {
            InitializeComponent();
        }

        private void FormularioVenda_Load(object sender, EventArgs e)
        {
            CarregaComboDeVendedores();
        }

        private void botaoBuscaCliente_Click(object sender, EventArgs e)
        {
            FormularioCliente formularioComClientes = new FormularioCliente(this);
            formularioComClientes.Show();
        }
        public void SelecionarCliente(Cliente cliente)
        {
            this.ClienteSelecionado = cliente;
            textoCliente.Text = this.ClienteSelecionado.ToString();
        }        
                
        private void CarregaComboDeVendedores()
        {
            foreach(Vendedor v in this.nossosVendedores.ConjuntoDeDados)
            {
                this.comboVendedor.Items.Add(v);
            }
        }

        private void botaoVeiculo_Click(object sender, EventArgs e)
        {
            FormularioEstoque formularioComVeiculos = new FormularioEstoque(this);
            formularioComVeiculos.Show();
        }

        internal void SelecionarVeiculo(Veiculo veiculoSelecionado)
        {
            this.veiculoSelecionado = veiculoSelecionado;
            textoVeiculo.Text = this.veiculoSelecionado.ToString();
        }

        private void botaoPagamento_Click(object sender, EventArgs e)
        {
            if (TodosOsDadosSelecionados())
            {
                FormularioPagamento formularioDePagamento = new FormularioPagamento(this);
                formularioDePagamento.Show();
            }
        }

        private bool TodosOsDadosSelecionados()
        {
            return (this.ClienteSelecionado != null) && (this.vendedor != null) && (this.veiculoSelecionado != null);
        }

        private void comboVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.vendedor = (Vendedor)comboVendedor.SelectedItem;
        }
    }
}
