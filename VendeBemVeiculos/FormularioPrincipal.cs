﻿using System;
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
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void BotaoVenda_Click(object sender, EventArgs e)
        {
            FormularioVenda formularioDeVendas = new FormularioVenda();
            formularioDeVendas.Show();
        }
    }
}
