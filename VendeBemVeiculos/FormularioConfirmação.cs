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
    public partial class FormularioConfirmação : Form
    {
        private FormularioPagamento formPagamento;
        private Vendedor vendedor;
        private string senha;

        public FormularioConfirmação(FormularioPagamento formPagamento, Vendedor vendedor)
        {
            this.formPagamento = formPagamento;
            this.vendedor = vendedor;
            InitializeComponent();
        }

        private void botaoConfirma_Click(object sender, EventArgs e)
        {
            this.senha = textoSenha.Text;
            if(senha == vendedor.Senha)
            {
                formPagamento.Close();
                this.Close();
            }
            else
            {
                MessageBox.Show("Senha Incorreta");
            }
        }

        private void botaoCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
