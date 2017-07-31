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
    public partial class FormularioNovoVeiculo : Form
    {
        private FormularioVeiculo formularioEstoque;
        private Veiculo novoVeiculo;
        private RegistroDeVeiculos<Veiculo> todosOsVeiculos;

        public FormularioNovoVeiculo(FormularioVeiculo formularioEstoque)
        {
            InitializeComponent();
            this.formularioEstoque = formularioEstoque;
            CarregaComboBox();
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotaoAdicionar_Click(object sender, EventArgs e)
        {
            if (TodosOsCamposPreenchidos())
            {
                AdicionaONovoVeiculoNoRegistro();            
                this.formularioEstoque.AtualizaTodosOsVeiculos();
                this.Close();
            }
            else
            {
                MessageBox.Show("Complete os dados");
            }

        }
        private bool TodosOsCamposPreenchidos()
        {
            return (this.textoMarca.Text != "") && (this.textoModelo.Text != "") && (this.textoAno.Text != "") && (this.textoPreco.Text != "");
        }
        private void AdicionaONovoVeiculoNoRegistro()
        {
            string arquivo = $"{this.comboVeiculo.SelectedItem}.txt";
            this.novoVeiculo = new Veiculo(textoMarca.Text, textoModelo.Text, textoAno.Text, Convert.ToDouble(textoPreco.Text));
            this.todosOsVeiculos = new RegistroDeVeiculos<Veiculo>(arquivo);
            this.todosOsVeiculos.AdicionaItemNoRegistro(novoVeiculo);
        }

        private void CarregaComboBox()
        {
            this.comboVeiculo.Items.Add("Carro");
            this.comboVeiculo.Items.Add("Moto");
            this.comboVeiculo.SelectedItem = "Carro";
        }
    }
}