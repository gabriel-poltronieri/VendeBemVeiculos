﻿using System;
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
        private Vendedor vendedor;
        private Cliente cliente;
        private Veiculo veiculo;
        //Construtor precisa receber o formulario de vendas para pegar suas propriedades
        public FormularioPagamento(FormularioVenda formVenda)
        {
            this.vendedor = formVenda.Vendedor;
            this.cliente = formVenda.Cliente;
            this.veiculo = formVenda.Veiculo;

            InitializeComponent();
        }
        //Ao carregar, os dados da compra são todos apresentados ao usuário
        private void FormularioPagamento_Load(object sender, EventArgs e)
        {
            ValorCliente.Text = this.cliente.Nome;
            ValorVendedor.Text = this.vendedor.Nome;
            ValorVeiculo.Text = this.veiculo.Marca + " " + this.veiculo.Modelo + " " + this.veiculo.Ano;
            ValorPreco.Text = "R$" + this.veiculo.Preco;
        }
        //Botoes do formulario
        private void BotaoEfetiva_Click(object sender, EventArgs e)
        {
            //chama-se o método Vende da classe vendedor, registra a venda no txt, mostra uma mensagem de venda efetivada e fecha
            try
            {
                FormularioPrincipal.RegistrarVenda(this.vendedor, this.cliente, this.veiculo);
                this.vendedor.Vende(this.veiculo, this.cliente);
                MessageBox.Show("Compra Efetuada com Sucesso");
            }
            catch
            {
                MessageBox.Show("Venda cancelada. Falha ao registrar");
            }
            this.Close();

        }
        private void BotaoCancela_Click(object sender, EventArgs e)
        {
            //fecha o formulario
            this.Close();
        }
    }
}
