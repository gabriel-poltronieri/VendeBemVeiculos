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
    public partial class FormularioPagamento : Form
    {
        private FormularioVenda formVenda;
        private Vendedor vendedor;

        public FormularioPagamento(FormularioVenda formVenda)
        {
            this.formVenda = formVenda;
            this.vendedor = formVenda.Vendedor;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void FormularioPagamento_Load(object sender, EventArgs e)
        {
            valorVendedor.Text = this.formVenda.Vendedor.Nome;
            valorVeiculo.Text = this.formVenda.Veiculo.Marca + " " + this.formVenda.Veiculo.Modelo + " " + this.formVenda.Veiculo.Ano;
            valorPreco.Text = "R$" + this.formVenda.Veiculo.Preco;
            comboPagamento.Items.Add("Em Dinheiro");
            comboPagamento.Items.Add("Débito");
            comboPagamento.Items.Add("Crédito");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormularioConfirmação formConfirma = new FormularioConfirmação(this, this.vendedor);
            formConfirma.Show();
        }
    }
}
