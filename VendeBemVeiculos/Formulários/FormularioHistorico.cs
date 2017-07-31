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
    public partial class FormularioHistorico : Form
    {
        private RegistroDeVenda<Venda> todasAsVendas = new RegistroDeVenda<Venda>("Venda.txt");
        private Venda vendaSelecionada;

        public FormularioHistorico()
        {
            InitializeComponent();
            CarregarHistorico();
        }

        private void ListaHistorico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listaHistorico.SelectedItem != null)
            {
                this.vendaSelecionada = (Venda)this.listaHistorico.SelectedItem;
            }
        }

        private void BotaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BotaoDetalhes_Click(object sender, EventArgs e)
        {
            if (this.vendaSelecionada != null)
            {
                FormularioDetalhesDaVenda formularioDetalheDeVenda = new FormularioDetalhesDaVenda(this.vendaSelecionada);
                formularioDetalheDeVenda.Show();
            }
            else
            {
                MessageBox.Show("Selecione uma venda");
            }
        }

        private void CarregarHistorico()
        {
            this.listaHistorico.Items.AddRange(todasAsVendas.Itens);
        }
    }
}