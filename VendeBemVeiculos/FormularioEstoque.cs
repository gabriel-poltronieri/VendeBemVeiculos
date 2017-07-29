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
    public partial class FormularioEstoque : Form
    {
        public RegistroDeVeiculos<Veiculo> TodosOsVeiculos { get; private set; }
        public Veiculo VeiculoSelecionado { get; private set; }
        public string ArquivoDesejado { get; private set; }

        public FormularioEstoque()
        {            
            InitializeComponent();
            this.radioCarro.Checked = true;
            this.ArquivoDesejado = "Carro.txt";
            this.TodosOsVeiculos = new RegistroDeVeiculos<Veiculo>(this.ArquivoDesejado);
            CarregarNaLista(this.TodosOsVeiculos.Itens);
        }

        public void AtualizaTodosOsVeiculos()
        {
            this.TodosOsVeiculos = new RegistroDeVeiculos<Veiculo>(this.ArquivoDesejado);
            CarregarNaLista(this.TodosOsVeiculos.Itens);
        }

        private void CarregarNaLista(Veiculo[] listaDeVeiculos)
        {
            this.listaVeiculos.Items.Clear();
            this.listaVeiculos.Items.AddRange(listaDeVeiculos);
        }

        private void ListaVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.VeiculoSelecionado = (Veiculo)this.listaVeiculos.SelectedItem;
        }
        private void BotaoExcluir_Click(object sender, EventArgs e)
        {
            this.TodosOsVeiculos.ExcluiItemDoRegistro(this.VeiculoSelecionado);
            AtualizaTodosOsVeiculos();
        }
        
        private void BotaoBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textoModelo.Text))
            {
                CarregarNaLista(this.TodosOsVeiculos.Itens);
            }
            else
            {
                CarregarNaLista(this.TodosOsVeiculos.Itens.Where(v => v.Modelo == textoModelo.Text).ToArray());
            }
        }

        private void RadioCarro_CheckedChanged(object sender, EventArgs e)
        {
            this.ArquivoDesejado = "Carro.txt";
            AtualizaTodosOsVeiculos();
        }
        private void RadioMotos_CheckedChanged(object sender, EventArgs e)
        {
            this.ArquivoDesejado = "Moto.txt";
            AtualizaTodosOsVeiculos();
        }

        private void BotaoNovo_Click(object sender, EventArgs e)
        {
            FormularioNovoVeiculo formularioNovoVeiculo = new FormularioNovoVeiculo(this);
            formularioNovoVeiculo.Show();
        }
        private void BotaoCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
