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
    public partial class FormularioNovoVendedor : Form
    {
        private FormularioVendedores formVendedores;
        private Vendedor novoVendedor;
        public FormularioNovoVendedor(FormularioVendedores formVendedores)
        {
            this.formVendedores = formVendedores;
            InitializeComponent();
        }

        private void BotaoCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotaoCadastra_Click(object sender, EventArgs e)
        {
            if(TextoNome.Text == "" || TextoSenha.Text == "")
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                this.novoVendedor = new Vendedor(TextoNome.Text, TextoSenha.Text);
                FormularioPrincipal.Vendedores.Add(this.novoVendedor);
                FormularioPrincipal.SalvarVendedores();
                this.formVendedores.Atualiza();
                this.Close();
            }
        }
    }
}
