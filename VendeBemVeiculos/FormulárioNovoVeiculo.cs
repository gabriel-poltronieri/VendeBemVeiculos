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
            this.comboVeiculo.Items.Add("Carro");
            this.comboVeiculo.Items.Add("Moto");
        }

        private void BotaoAdicionar_Click(object sender, EventArgs e)
        {
            AdicionaONovoVeiculoNoRegistro();            
            this.formularioEstoque.AtualizaTodosOsVeiculos();
            this.Close();
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdicionaONovoVeiculoNoRegistro()
        {
            string arquivo = $"{this.comboVeiculo.SelectedItem}.txt";
            this.novoVeiculo = new Veiculo(textoMarca.Text, textoModelo.Text, textoAno.Text, Convert.ToDouble(textoPreco.Text));
            this.todosOsVeiculos = new RegistroDeVeiculos<Veiculo>(arquivo);
            this.todosOsVeiculos.AdicionaItemNoRegistro(novoVeiculo);
        }

        
    }
}
