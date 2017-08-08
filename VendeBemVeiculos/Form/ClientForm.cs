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
    public partial class ClientForm : Form
    {
        private const string EMPTY_CPF = "   .   .   -";
        private SaleForm saleForm;

        public ClientForm(SaleForm saleForm)
        {
            this.saleForm = saleForm;
            InitializeComponent();
            this.RegisteredClients = new PersonRegister<Client>("Cliente.txt");
            this.LoadOnList(this.RegisteredClients.Items);
        }

        public PersonRegister<Client> RegisteredClients { get; private set; }
        public Client SelectedClient { get; private set; }

        private void ListClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listClients.SelectedItem != null)
            {
                this.SelectedClient = (Client)this.listClients.SelectedItem;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (this.SelectedClient != null)
            {
                this.RegisteredClients.DeleteItemFromRegister(this.SelectedClient);
                this.LoadRegisteredClientsOnList();
            }
            else
            {
                MessageBox.Show("Nenhum cliente selecionado");
            }
        }        
        private void ButtonNewClient_Click(object sender, EventArgs e)
        {
            var newClientForm = new NewClientForm(this);
            newClientForm.Show();
        }
        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            if (this.SelectedClient != null)
            {
                this.saleForm.DefineClient(this.SelectedClient);
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um Cliente");
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (textCPF.Text == EMPTY_CPF)
            {
                this.LoadOnList(this.RegisteredClients.Items);
            }
            else
            {
                this.SearchClientByCPF();
            }
        }
        
        private void LoadOnList(Client[] clientsList)
        {
            this.listClients.Items.Clear();
            this.listClients.Items.AddRange(clientsList);
        }
        private void SearchClientByCPF()
        {
            Client[] searchedCPF = this.RegisteredClients.FilterByCPF(this.textCPF.Text);
            if (searchedCPF.Length == 0)
            {
                MessageBox.Show("Nenhum Cliente com o CPF buscado");
            }
            else
            {
                LoadOnList(searchedCPF);
            }
        }
        public void LoadRegisteredClientsOnList()
        {
            this.RegisteredClients = new PersonRegister<Client>("Cliente.txt");
            this.LoadOnList(this.RegisteredClients.Items);
        }
    }
}