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
        RegistroDeVeiculos nossoEstoque = new RegistroDeVeiculos();
        Veiculo veiculoSelecionado;
        private FormularioVenda formularioComDadosDeVenda;


        public FormularioEstoque(FormularioVenda formulario)
        {
            this.formularioComDadosDeVenda = formulario;
            InitializeComponent();
        }
        private void FormularioEstoque_Load(object sender, EventArgs e)
        {
            AtualizaAListaDeVeiculosPeloModelo();
        }
        private void AtualizaAListaDeVeiculosPeloModelo(string modelo = null)
        {
            SortedSet<ItemDoRegistroDeVeiculos> veiculosParaLista = SelecionaVeiculosParaLista(modelo);
            CarregarElementosNaLista(veiculosParaLista);
        }
        private SortedSet<ItemDoRegistroDeVeiculos> SelecionaVeiculosParaLista(string modelo)
        {
            if (ModeloEhNuloOuVazio(modelo))
            {
                return this.nossoEstoque.ConjuntoDeDados;
            }
            FiltroDeVeiculo filtrodeVeiculo = new FiltroDeVeiculo(this.nossoEstoque);
            return filtrodeVeiculo.FiltrarPeloModelo(modelo);
        }
        private void CarregarElementosNaLista(SortedSet<ItemDoRegistroDeVeiculos> registroFiltrado)
        {
            this.listaVeiculos.Items.Clear();
            foreach (ItemDoRegistroDeVeiculos c in registroFiltrado)
            {
                this.listaVeiculos.Items.Add(c.veiculoDaLista);
            }
        }
        private bool ModeloEhNuloOuVazio(string modelo)
        {
            return (modelo == null) || (modelo == "");
        }

        private void botaoSeleciona_Click(object sender, EventArgs e)
        {
            if (ExisteUmVeiculoSelecionado())
            {
                this.formularioComDadosDeVenda.SelecionarVeiculo(this.veiculoSelecionado);
                FechaOFormulario();
            }
        }
        private bool ExisteUmVeiculoSelecionado()
        {
            return this.veiculoSelecionado != null;
        }
        private void FechaOFormulario()
        {
            this.Close();
        }

        private void listaVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.veiculoSelecionado = (Veiculo)listaVeiculos.SelectedItem;
        }
    }
}
