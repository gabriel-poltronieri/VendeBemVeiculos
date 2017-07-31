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
        private SaleForm saleForm;

        public ClientForm(SaleForm saleForm)
        {
            this.saleForm = saleForm;
            InitializeComponent();
            this.AllClients = new PersonRegister<Client>("Cliente.txt");
            LoadOnList(this.AllClients.Items);
        }

        public PersonRegister<Client> AllClients { get; private set; }
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
                this.AllClients.DeleteItemFromRegister(this.SelectedClient);
                UpdateAllClients();
            }
            else
            {
                MessageBox.Show("Nenhum cliente selecionado");
            }
        }        
        private void ButtonNewClient_Click(object sender, EventArgs e)
        {
            NewClientForm newClientForm = new NewClientForm(this);
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
            if (CPFIsEmpty())
            {
                LoadOnList(this.AllClients.Items);
            }
            else
            {
                SearchClientByCPF();
            }
        }
        private bool CPFIsEmpty()
        {
            return this.textCPF.Text == "   .   .   -";
        }
        private void LoadOnList(Client[] clientsList)
        {
            this.listClients.Items.Clear();
            this.listClients.Items.AddRange(clientsList);
        }

        private void SearchClientByCPF()
        {
            Client[] searchedCPF = this.AllClients.FilterByCPF(this.textCPF.Text);
            if (searchedCPF.Length == 0)
            {
                MessageBox.Show("Nenhum Cliente com o CPF buscado");
            }
            else
            {
                LoadOnList(searchedCPF);
            }
        }

        public void UpdateAllClients()
        {
            this.AllClients = new PersonRegister<Client>("Cliente.txt");
            LoadOnList(this.AllClients.Items);
        }
    }
}