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
        private RegistroDePessoas<Vendedor> nossosVendedores;        
        public Veiculo veiculo;
        private string arquivoDoVeiculoDaCompra;

        public FormularioVenda()
        {
            InitializeComponent();
            CarregarComboVendedores();
        }

        public Vendedor Vendedor { get; private set; }
        public Cliente Cliente { get; private set; }

        private void ComboVendedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Vendedor = (Vendedor)comboVendedor.SelectedItem;
        }

        private void BotaoBuscaCliente_Click(object sender, EventArgs e)
        {
            FormularioCliente formularioCliente = new FormularioCliente(this);
            formularioCliente.Show();
        }
        private void BotaoBucaVeiculo_Click(object sender, EventArgs e)
        {
            FormularioVeiculo formularioVeiculo = new FormularioVeiculo(this);
            formularioVeiculo.Show();
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotaoPagamento_Click(object sender, EventArgs e)
        {
            if (TodosSelecionados())
            {
                FormularioPagamento formularioPagamento = new FormularioPagamento(this, this.arquivoDoVeiculoDaCompra);
                formularioPagamento.Show();
            }
            else
            {
                MessageBox.Show("Selecione todos os Dados");
            }
        }
        private bool TodosSelecionados()
        {
            return (this.Vendedor != null) && (this.Cliente != null) && (this.veiculo != null);
        }

        private void CarregarComboVendedores()
        {
            this.nossosVendedores = new RegistroDePessoas<Vendedor>("Vendedor.txt");
            this.comboVendedor.Items.AddRange(nossosVendedores.Itens.ToArray());
        }

        public void DefineCliente(Cliente cliente)
        {
            this.Cliente = cliente;
            this.textoCliente.Text = this.Cliente.ToString();
        }
        public void DefineVeiculo(Veiculo veiculo, string arquivoDeVeiculo)
        {
            this.veiculo = veiculo;
            this.textoVeiculo.Text = this.veiculo.ToString();
            this.arquivoDoVeiculoDaCompra = arquivoDeVeiculo;
        }
        public void DefineVendedor(Vendedor vendedor)
        {
            this.Vendedor = vendedor;
            this.comboVendedor.SelectedItem = this.Vendedor;
        }
    }
}