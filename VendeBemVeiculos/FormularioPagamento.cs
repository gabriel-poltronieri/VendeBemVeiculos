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
        private Cliente cliente;
        private Veiculo veiculo;
        private string senha;
        private string forma;

        public FormularioPagamento(FormularioVenda formVenda, string pagamento)
        {
            this.formVenda = formVenda;
            this.vendedor = formVenda.Vendedor;
            this.cliente = formVenda.Cliente;
            this.veiculo = formVenda.Veiculo;
            this.forma = pagamento;

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        private void FormularioPagamento_Load(object sender, EventArgs e)
        {
            valorCliente.Text = this.cliente.Nome;
            valorVendedor.Text = this.vendedor.Nome;
            valorVeiculo.Text = this.veiculo.Marca + " " + this.veiculo.Modelo + " " + this.veiculo.Ano;
            valorPagamento.Text = this.forma;
            valorPreco.Text = "R$" + this.veiculo.Preco;
            
        }

        private void botaoEfetiva_Click(object sender, EventArgs e)
        {
            this.senha = textoSenha.Text;
            if (senha == vendedor.Senha)
            {
                this.vendedor.Vende(this.veiculo, this.cliente);
                MessageBox.Show("Compra Efetuada com Sucesso");
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha Incorreta");
            }
        }

       
    }
}
