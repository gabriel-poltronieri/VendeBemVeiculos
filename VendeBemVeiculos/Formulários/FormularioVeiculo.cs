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
    public partial class FormularioVeiculo : Form
    {
        private FormularioVenda formularioVenda;        
        private Veiculo[] filtrados;

        public FormularioVeiculo(FormularioVenda formularioVenda)
        {
            this.formularioVenda = formularioVenda;
            InitializeComponent();
            this.radioCarro.Checked = true;
            this.ArquivoDesejado = "Carro.txt";
            this.TodosOsVeiculos = new RegistroDeVeiculos<Veiculo>(this.ArquivoDesejado);
            CarregarNaLista(this.TodosOsVeiculos.Itens);        
        }

        public RegistroDeVeiculos<Veiculo> TodosOsVeiculos { get; private set; }
        public Veiculo VeiculoSelecionado { get; private set; }
        public string ArquivoDesejado { get; private set; }

        private void ListaVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listaVeiculos.SelectedItem != null)
            {
                this.VeiculoSelecionado = (Veiculo)this.listaVeiculos.SelectedItem;
                this.labelValorPreco.Text = $"RS{string.Format("{0:0.00}", this.VeiculoSelecionado.Preco)}";
                this.labelValorQuantidade.Text = Convert.ToString(this.TodosOsVeiculos.Itens.Count(v => v.Equals(VeiculoSelecionado)));
            }
        }

        private void BotaoCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BotaoNovo_Click(object sender, EventArgs e)
        {
            FormularioNovoVeiculo formularioNovoVeiculo = new FormularioNovoVeiculo(this);
            formularioNovoVeiculo.Show();
        }
        private void BotaoSeleciona_Click(object sender, EventArgs e)
        {
            if (this.VeiculoSelecionado != null)
            {
                this.formularioVenda.DefineVeiculo(this.VeiculoSelecionado, this.ArquivoDesejado);
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um Veículo");
            }
        }

        private void BotaoFiltrar_Click(object sender, EventArgs e)
        {
            CarregarNaLista(this.filtrados);
        }
        private void BotaoExcluir_Click(object sender, EventArgs e)
        {
            if (this.VeiculoSelecionado != null)
            {
                this.TodosOsVeiculos.ExcluiItemDoRegistro(this.VeiculoSelecionado);
                AtualizaTodosOsVeiculos();
            }
            else
            {
                MessageBox.Show("Selecione um Veículo");
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
                
        private void ComboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filtrados = this.TodosOsVeiculos.FiltrarPorMarca(this.comboMarca.SelectedItem.ToString());
            LimparComboModelo();
            LimparComboAno();
            CarregaOComboDeModelo();
        }
        private void ComboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filtrados = this.TodosOsVeiculos.FiltrarPorMarca(this.comboMarca.SelectedItem.ToString());
            this.filtrados = this.TodosOsVeiculos.FiltrarPorModelo(this.comboModelo.SelectedItem.ToString());
            LimparComboAno();
            CarregaOComboDeAno();
        }
        private void ComboAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filtrados = this.TodosOsVeiculos.FiltrarPorMarca(this.comboMarca.SelectedItem.ToString());
            this.filtrados = this.TodosOsVeiculos.FiltrarPorModelo(this.comboModelo.SelectedItem.ToString());
            this.filtrados = this.TodosOsVeiculos.FiltrarPorAno(this.comboAno.SelectedItem.ToString());
        }

        private void CarregarNaLista(Veiculo[] listaDeVeiculos)
        {
            listaDeVeiculos = listaDeVeiculos.Distinct().ToArray();
            this.listaVeiculos.Items.Clear();
            this.listaVeiculos.Items.AddRange(listaDeVeiculos);
        }
        public void AtualizaTodosOsVeiculos()
        {
            this.TodosOsVeiculos = new RegistroDeVeiculos<Veiculo>(this.ArquivoDesejado);
            this.filtrados = this.TodosOsVeiculos.Itens;
            CarregarNaLista(this.TodosOsVeiculos.Itens);
            LimparComboMarca();
            LimparComboModelo();
            LimparComboAno();
            CarregaOComboDeMarca();
        }
        private void LimparComboMarca()
        {
            comboMarca.Items.Clear();
            comboMarca.Text = "";
        }
        private void LimparComboModelo()
        {
            comboModelo.Items.Clear();
            comboModelo.Text = "";
        }
        private void LimparComboAno()
        {
            comboAno.Items.Clear();
            comboAno.Text = "";
        }

        private void CarregaOComboDeMarca()
        {
            var marcas = this.TodosOsVeiculos.Itens.Select(veiculo => veiculo.Marca).Distinct().ToArray();
            this.comboMarca.Items.AddRange(marcas);
        }
        private void CarregaOComboDeModelo()
        {
            var modelos = this.filtrados.Select(veiculo => veiculo.Modelo).Distinct().ToArray();
            this.comboModelo.Items.AddRange(modelos);
        }
        private void CarregaOComboDeAno()
        {
            var anos = this.filtrados.Select(v => v.Ano).Distinct().ToArray();
            this.comboAno.Items.AddRange(anos);
        }        
    }
}