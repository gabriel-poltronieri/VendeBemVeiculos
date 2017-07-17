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
        //Construtor
        public FormularioNovoVendedor(FormularioVendedores formVendedores)
        {
            this.formVendedores = formVendedores;
            InitializeComponent();
        }
        //Botões
        private void BotaoCadastra_Click(object sender, EventArgs e)
        {
            //verifica se tem texto inserido
            if (TextoNome.Text == "")
            {
                MessageBox.Show("Preencha com o nome");
            }
            else
            {
                //cria um novo vendedor, adiciona na hashset do formulario principal, salva o hashset, atualiza a lista dos vendedores e fecha
                this.novoVendedor = new Vendedor(TextoNome.Text);
                FormularioPrincipal.Vendedores.Add(this.novoVendedor);
                FormularioPrincipal.SalvarVendedores();
                this.formVendedores.Atualiza();
                this.Close();
            }
        }
        private void BotaoCancela_Click(object sender, EventArgs e)
        {
            //apenas fecha o formulário
            this.Close();
        }
    }
}
