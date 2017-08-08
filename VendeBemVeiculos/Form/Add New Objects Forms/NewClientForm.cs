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
    public partial class NewClientForm : Form
    {
        private PersonRegister<Client> registeredClients;
        private ClientForm clientForm;

        public NewClientForm(ClientForm clientForm)
        {
            InitializeComponent();
            this.registeredClients = new PersonRegister<Client>("Cliente.txt");
            this.clientForm = clientForm;
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
                this.AddClient();
            }
        }
        private bool FirstAndLastNameHaveData()
        {
            return (this.textFirstName.Text != "") && (this.textLastName.Text != "");
        }
        private bool CPFIsIncomplete()
        {
            return this.textCPF.Text.Contains(' '); 
        }
        private void AddClient()
        {
            try
            {
                var client = new Client(this.textFirstName.Text, this.textLastName.Text, this.textCPF.Text);
                this.registeredClients.AddItemToRegister(client);
                this.clientForm.LoadRegisteredClientsOnList();
                this.Close();
            }
            catch (AlreadyCreatedException)
            {
                MessageBox.Show("CPF já cadastrado");
            }
        }
    }
}