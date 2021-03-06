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
    public partial class FormularioNovoVeiculo : Form
    {
        private int carroMoto = 3;  //inteiro para representar qual o tipo de veículo escolhido. Se for 3, nenhum deles foi escolhido
        private FormularioEstoque formEstoque;  //Recebe o Formulário do estoque
        //Construtor apenas recebe o formulário
        public FormularioNovoVeiculo(FormularioEstoque formEstoque)
        {
            this.formEstoque = formEstoque;
            InitializeComponent();
        }
        //Ao Carregar
        private void FormulárioNovoVeiculo_Load(object sender, EventArgs e)
        {
            //Adiciona items ao comboBox
            ComboVeiculo.Items.Add("Carro");
            ComboVeiculo.Items.Add("Moto");
            TextoAno.MaxLength = 4;
        }
        //Ao selecionar ComboBox
        private void comboVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Muda o valor do inteiro que representa a seleção
            this.carroMoto = ComboVeiculo.SelectedIndex;
        }
        //Ações dos botões
        private void botaoAdicionar_Click(object sender, EventArgs e)
        {
            //Verifica se todos os campos foram preenchidos
            if (TextoMarca.Text == "" || TextoModelo.Text == "" || TextoAno.Text == "" || TextoPreco.Text == "" || TextoQuantidade.Text == "")
            {
                MessageBox.Show("Preencha todos os dados");
            }
            //Verifica se algum tipo de veículo foi selecionado
            else if(carroMoto == 3)
            {
                MessageBox.Show("Selecione o tipo de veículo");
            }
            //Caso tudo esteja certo, recebe os valores preenchidos e instancia um carro/moto
            else
            {
                try
                {
                    double preco = Convert.ToDouble(TextoPreco.Text);
                    int quantidade = Convert.ToInt32(TextoQuantidade.Text);
                    string marca = TextoMarca.Text;
                    string modelo = TextoModelo.Text;
                    string ano = TextoAno.Text;
                    Veiculo veiculo = new Carro("", "", "", 0, 0);
                    switch (this.carroMoto)
                    {
                        case 0:
                            veiculo = new Carro(marca, modelo, ano, preco, quantidade);
                            break;
                        case 1:
                            veiculo = new Moto(marca, modelo, ano, preco, quantidade);
                            break;
                    }
                    //Passa os valores para as listas de interesse e atualiza a visualização no formulario de estoques
                    FormularioPrincipal.Veiculos.Add(veiculo);
                    FormularioPrincipal.SalvarVeiculos();
                    this.formEstoque.AdicionaItem(veiculo);
                    this.formEstoque.AtualizaLista();
                    this.Close();
            }
                catch (Exception ex)
            {
                if (ex is FormatException)
                {
                    MessageBox.Show("Insira valores numéricos para ano, preço e quantidade");
                }
            }

        }
        }
        private void botaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
