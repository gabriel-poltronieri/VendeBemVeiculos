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
    public partial class FormularioDetalhesDaVenda : Form
    {
        private Venda venda;

        public FormularioDetalhesDaVenda(Venda venda)
        {
            InitializeComponent();
            this.venda = venda;
            CarregarValores();
        }

        private void CarregarValores()
        {
            this.labelValorCliente.Text = this.venda.Cliente.ToString();
            this.labelValorData.Text = this.venda.Data;
            this.labelValorVeiculo.Text = this.venda.Veiculo.ToString();
            this.labelValorVendedor.Text = this.venda.Vendedor.ToString();
            this.LbelValorPreco.Text = $"RS{string.Format("{0:0.00}", this.venda.Veiculo.Preco)}";
        }
    }
}