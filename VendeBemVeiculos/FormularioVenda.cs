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
    public partial class FormularioVenda : Form
    {       

        public FormularioVenda()
        {
            InitializeComponent();
        }

        private void BotaoBuscaCliente_Click(object sender, EventArgs e)
        {
            FormularioCliente formularioCliente = new FormularioCliente();
            formularioCliente.Show();
        }

        private void BotaoVeiculo_Click(object sender, EventArgs e)
        {
            FormularioEstoque formularioVeiculo = new FormularioEstoque();
            formularioVeiculo.Show();
        }
    }
}
