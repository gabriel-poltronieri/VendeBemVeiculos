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
    public partial class NewSalesmanForm : Form
    {
        private PersonRegister<Salesman> salesmen;
        
        public NewSalesmanForm()
        {
            InitializeComponent();
            this.salesmen = new PersonRegister<Salesman>("Vendedor.txt");
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonRegister_Click(object sender, EventArgs e)
        {
            if (FirstAndLastNameHaveData() == false)
            {
                MessageBox.Show("Preencha primeiro e último nome");
            }
            else if (CPFIsIncomplete())
            {
                MessageBox.Show("Complete os dados do CPF");
            }
            else
            {
                AddSalesman();                
            }
        }
        private bool FirstAndLastNameHaveData()
        {
            return (this.textFirstName.Text != "") && (this.textLastName.Text != "");
        }
        private bool CPFIsIncomplete()
        {
            return this.textCpf.Text.Contains(' ');
        }
        private void AddSalesman()
        {
            try
            {
                var newSalesman = new Salesman(this.textFirstName.Text, this.textLastName.Text, this.textCpf.Text);
                this.salesmen.AddItemToRegister(newSalesman);
                this.Close();
            }
            catch (AlreadyCreatedException)
            {
                MessageBox.Show("CPF já cadastrado");
            }
        }
    }
}
