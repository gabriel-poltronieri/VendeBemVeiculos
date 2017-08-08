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
        private RegistroDePessoas<Vendedor> vendedores;
        
        public FormularioNovoVendedor()
        {
            InitializeComponent();
            this.vendedores = new RegistroDePessoas<Vendedor>("Vendedor.txt");
        }

        private void BotaoCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BotaoCadastra_Click(object sender, EventArgs e)
        {
            if (!VerificaPrimeiroEUltimoNome())
            {
                MessageBox.Show("Preencha primeiro e último nome");
            }
            else if (CpfIncompleto())
            {
                MessageBox.Show("Complete os dados do CPF");
            }
            else
            {
                AdicionaVendedor();                
            }
        }
        private bool VerificaPrimeiroEUltimoNome()
        {
            return (this.textoPrimeiroNome.Text != "") && (this.textoUltimoNome.Text != "");
        }
        private bool CpfIncompleto()
        {
            return this.textoCPF.Text.Contains(' ');
        }
        private void AdicionaVendedor()
        {
            try
            {
                var novoVendedor = new Vendedor(this.textoPrimeiroNome.Text, this.textoUltimoNome.Text, this.textoCPF.Text);
                this.vendedores.AdicionaItemNoRegistro(novoVendedor);
                this.Close();
            }
            catch (ExceptionDadoJaExistente)
            {
                MessageBox.Show("CPF já cadastrado");
            }
        }
    }
}
