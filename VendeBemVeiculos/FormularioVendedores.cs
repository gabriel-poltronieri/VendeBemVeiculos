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
    public partial class FormularioVendedores : Form
    {
        public FormularioVendedores()
        {
            InitializeComponent();
        }

        private void FormularioVendedores_Load(object sender, EventArgs e)
        {
            Atualiza();
        }

        private void botaoBusca_Click(object sender, EventArgs e)
        {
            int registro = 0;
            //Pega o cpf digitado na busca
            if (textoRegistro.Text == "")
            {
                Atualiza();
            }
            else
            {
                try
                {
                    registro = Convert.ToInt32(textoRegistro.Text);
                    //Caso o cpf tenha o tamanho certo, deve-se colocar um filtro para encontrar o cliente
                    var filtro = FormularioPrincipal.Vendedores.Where(c => c.Registro == registro);
                    try
                    {
                        //Só existe um Registro para cada vendedor. Se ele existir, ele será o elemento zero do filtro
                        Vendedor selecionado = (Vendedor)filtro.ElementAt(0);
                        //limpa a lista e mostra apenas o selecionado
                        this.listaVendedores.Items.Clear();
                        listaVendedores.Items.Add(selecionado);
                    }
                    catch
                    {
                        //Se o vendedor não for encontrado, não terá nenhum objeto em lista e um ArgumentOutOfRangeException será lançado
                        MessageBox.Show("Nenhum vendedor com o Registro buscado");
                    }
                }
                catch
                {
                    MessageBox.Show("Entre com um valor numérico");
                }
            }
        }

        private void botaoNovo_Click(object sender, EventArgs e)
        {
            FormularioNovoVendedor formNovoVendedor = new FormularioNovoVendedor(this);
            formNovoVendedor.Show();
        }

        public void Atualiza()
        {
            listaVendedores.Items.Clear();
            foreach (Vendedor v in FormularioPrincipal.Vendedores)
            {
                listaVendedores.Items.Add(v);
            }
        }
    }
}
