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
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void botaoVenda_Click(object sender, EventArgs e)
        {
            FormularioVenda formVenda = new FormularioVenda(this);
            formVenda.Show();
        }
    }
}
