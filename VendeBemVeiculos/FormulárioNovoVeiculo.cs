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
    public partial class FormulárioNovoVeiculo : Form
    {
        private int selecionado;
        private FormularioEstoque formEstoque;
        public FormulárioNovoVeiculo(FormularioEstoque formEstoque)
        {
            this.formEstoque = formEstoque;
            InitializeComponent();
        }

        private void FormulárioNovoVeiculo_Load(object sender, EventArgs e)
        {
            comboVeiculo.Items.Add("Carro");
            comboVeiculo.Items.Add("Moto");
        }

        private void comboVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.selecionado = comboVeiculo.SelectedIndex;
        }

        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            if (textoMarca.Text == "" || textoModelo.Text == "" || textoAno.Text == "" || textoPreco.Text == "" || textoQuantidade.Text == "")
            {
                MessageBox.Show("Preencha todos os dados");
            }
            else
            {
                string marca = textoMarca.Text;
                string modelo = textoModelo.Text;
                string ano = textoAno.Text;
                double preco = Convert.ToDouble(textoPreco.Text);
                int quantidade = Convert.ToInt32(textoPreco.Text);
                switch (this.selecionado)
                {
                    case 0:
                        Carro novoCarro = new Carro(marca, modelo, ano, preco, quantidade);
                        FormularioPrincipal.Veiculos.Add(novoCarro);
                        break;
                    case 1:
                        Moto novaMoto = new Moto(marca, modelo, ano, preco, quantidade);
                        FormularioPrincipal.Veiculos.Add(novaMoto);
                        break;
                }
                this.formEstoque.AtualizaLista();
                this.Close();
            }
        }

        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
