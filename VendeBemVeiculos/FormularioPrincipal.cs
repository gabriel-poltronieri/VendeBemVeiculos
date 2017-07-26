using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendeBemVeiculos
{
    public partial class FormularioPrincipal : Form
    {
        private void FormularioPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void botaoVenda_Click(object sender, EventArgs e)
        {
            FormularioCliente cliente = new FormularioCliente();
            cliente.Show();
        }
    }
}
