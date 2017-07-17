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
        private FormularioPrincipal formPrincipal;
        private Veiculo veiculo;
        private HashSet<Veiculo> lista = new HashSet<Veiculo>();

        public FormularioEstoque(FormularioPrincipal formPrincipal)
        {
            this.formPrincipal = formPrincipal;
            InitializeComponent();
        }

        private void FormularioEstoque_Load(object sender, EventArgs e)
        {
            radioCarro.Checked = true;
        }

        public void AtualizaLista()
        {
            listaVeiculos.Items.Clear();
            foreach (Veiculo c in this.lista)
            {
                listaVeiculos.Items.Add(c);
            }
        }

        private void listaVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.veiculo = (Veiculo)listaVeiculos.SelectedItem;
        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            List<Veiculo> filtro;
            this.listaVeiculos.Items.Clear();
            if (textoModelo.Text != "")
            {
                string modelo = textoModelo.Text;
                filtro = FormularioPrincipal.Veiculos.Where(v => v.Modelo == modelo).ToList();
            }
            else
            {
                filtro = FormularioPrincipal.Veiculos.ToList();
            }
            foreach (Veiculo v in filtro)
            {
                listaVeiculos.Items.Add(v);
            }
        }

        private void botaoCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void botaoExclui_Click(object sender, EventArgs e)
        {
            if (this.veiculo != null)
            {
                this.veiculo.Exclui();
                MessageBox.Show("Veículo excluído");
                AtualizaLista();
            }
            else
            {
                MessageBox.Show("Selecione um veículo");
            }
        }

        private void botaoSeleciona_Click(object sender, EventArgs e)
        {
            FormularioVenda formVenda = new FormularioVenda(this.formPrincipal, this.veiculo);
            formVenda.Show();
            this.formPrincipal.Hide();
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.lista.Clear();
            foreach (Veiculo v in FormularioPrincipal.Veiculos)
            {
                if (v is Carro)
                {
                    this.lista.Add(v);
                }
            }
            AtualizaLista();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.lista.Clear();
            foreach (Veiculo v in FormularioPrincipal.Veiculos)
            {
                if (v is Moto)
                {
                    this.lista.Add(v);
                }
            }
            AtualizaLista();
        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            FormularioNovoVeiculo formNovoVeiculo = new FormularioNovoVeiculo(this);
            formNovoVeiculo.Show();
        }

        public void AdicionaItem(Veiculo veiculo)
        {
            this.lista.Add(veiculo);
        }
    }
}
