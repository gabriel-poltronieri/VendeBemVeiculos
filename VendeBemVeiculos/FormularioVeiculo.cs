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
        public RegistroDeVeiculos<Veiculo> TodosOsVeiculos { get; private set; }
        public Veiculo VeiculoSelecionado { get; private set; }
        public string ArquivoDesejado { get; private set; }
        private Veiculo[] filtrados;

        public FormularioVeiculo()
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
            this.filtrados = this.TodosOsVeiculos.Itens;
            CarregarNaLista(this.TodosOsVeiculos.Itens);
            LimparComboMarca();
            LimparComboModelo();
            LimparComboAno();
            CarregaOComboDeMarca();
        }        

        private void CarregarNaLista(Veiculo[] listaDeVeiculos)
        {
            listaDeVeiculos = listaDeVeiculos.Distinct().ToArray();
            this.listaVeiculos.Items.Clear();
            this.listaVeiculos.Items.AddRange(listaDeVeiculos);
        }
        
        private void BotaoExcluir_Click(object sender, EventArgs e)
        {
            this.TodosOsVeiculos.ExcluiItemDoRegistro(this.VeiculoSelecionado);
            AtualizaTodosOsVeiculos();
        }
        private void BotaoBuscar_Click(object sender, EventArgs e)
        {
            CarregarNaLista(this.filtrados);
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

        private void ListaVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.VeiculoSelecionado = (Veiculo)this.listaVeiculos.SelectedItem;
            this.labelValorQuantidade.Text =  Convert.ToString(this.TodosOsVeiculos.Itens.Count(v => v.Equals(VeiculoSelecionado)));
        }
        private void ComboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarPorMarca();
            LimparComboModelo();
            LimparComboAno();
            CarregaOComboDeModelo();
        }
        private void ComboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarPorMarca();
            FiltrarPorModelo();
            LimparComboAno();
            CarregaOComboDeAno();
        }
        private void ComboAno_SelectedIndexChanged(object sender, EventArgs e)
        {
            FiltrarPorMarca();
            FiltrarPorModelo();
            FiltrarPorAno();            
        }        

        private void FiltrarPorMarca()
        {
            var marcaSelecionada = (string)this.comboMarca.SelectedItem;
            this.filtrados = this.TodosOsVeiculos.Itens.Where(v => v.Marca == marcaSelecionada).ToArray();
        }
        private void FiltrarPorModelo()
        {
            var modeloSelecionado = (string)this.comboModelo.SelectedItem;
            this.filtrados = this.filtrados.Where(v => v.Modelo == modeloSelecionado).ToArray();
        }
        private void FiltrarPorAno()
        {
            var anoSelecionado = (string)this.comboAno.SelectedItem;
            this.filtrados = this.filtrados.Where(v => v.Ano == anoSelecionado).ToArray();
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
        
    }
}