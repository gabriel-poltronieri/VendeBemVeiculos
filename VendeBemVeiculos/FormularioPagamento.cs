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
        FormularioVenda formularioDeVenda;

        public FormularioPagamento(FormularioVenda formulario)
        {
            this.formularioDeVenda = formulario;
            InitializeComponent();
        }

        private void FormularioPagamento_Load(object sender, EventArgs e)
        {
            valorCliente.Text = this.formularioDeVenda.ClienteSelecionado.ToString();
            valorVendedor.Text = this.formularioDeVenda.vendedor.ToString();
            valorVeiculo.Text = this.formularioDeVenda.veiculoSelecionado.ToString();
            valorCliente.Text = this.formularioDeVenda.ClienteSelecionado.ToString();
            valorPreco.Text = Convert.ToString(this.formularioDeVenda.veiculoSelecionado.Preco);
        }

        private void butaoEfetiva_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
