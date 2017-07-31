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
        private string arquivoDoVeiculo;
        private RegistroDeVenda<Venda> registroDeVenda = new RegistroDeVenda<Venda>("Venda.txt");
        private FormularioVenda formularioVenda;
        private Cliente cliente;
        private Vendedor vendedor;
        private Veiculo veiculo;
        private Venda venda;

        public FormularioPagamento(FormularioVenda formularioVenda, string arquivoDoVeiculo)
        {
            this.formularioVenda = formularioVenda;
            InitializeComponent();
            DefineEnvolvidosNaVenda();
            ApresentaValoresEmTexto();
            this.arquivoDoVeiculo = arquivoDoVeiculo;
        }
               

        private void DefineEnvolvidosNaVenda()
        {
            this.cliente = this.formularioVenda.Cliente;
            this.vendedor = this.formularioVenda.Vendedor;
            this.veiculo = this.formularioVenda.veiculo;
        }
        private void ApresentaValoresEmTexto()
        {
            this.valorCliente.Text = this.cliente.ToString();
            this.valorVendedor.Text = this.vendedor.ToString();
            this.valorVeiculo.Text = $"{this.veiculo.Marca} {this.veiculo.Modelo} {this.veiculo.Ano}";
            this.valorPreco.Text = $"R${string.Format("{0:0.00}", this.veiculo.Preco)}";
        }

        private void BotaoCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BotaoEfetiva_Click(object sender, EventArgs e)
        {
            this.venda = new Venda(this.cliente, this.veiculo, this.vendedor);
            this.registroDeVenda.AdicionaItemNoRegistro(venda);
            RegistroDeVeiculos<Veiculo> registroDeVeiculo = new RegistroDeVeiculos<Veiculo>(this.arquivoDoVeiculo);
            registroDeVeiculo.ExcluiItemDoRegistro(this.veiculo);
            this.Close();
        }
    }
}
