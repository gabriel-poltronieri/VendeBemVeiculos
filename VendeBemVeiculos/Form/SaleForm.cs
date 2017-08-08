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
    public partial class SaleForm : Form
    {
        private PersonRegister<Salesman> registeredSalesmen;        
        private string vehicleFile;

        public SaleForm()
        {
            InitializeComponent();
            this.LoadComboSalesMan();
        }

        public Salesman Salesman { get; private set; }
        public Client Client { get; private set; }
        public Vehicle Vehicle { get; private set; }

        private void ComboSalesman_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.Salesman = (Salesman)comboSalesMan.SelectedItem;
        }

        private void ButtonSearchClient_Click(object sender, EventArgs e)
        {
            var clientForm = new ClientForm(this);
            clientForm.Show();
        }
        private void ButtonSearchVehicle_Click(object sender, EventArgs e)
        {
            var vehicleForm = new VehicleForm(this);
            vehicleForm.Show();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonPayment_Click(object sender, EventArgs e)
        {
            if (AllItemsAreSelected())
            {
                var paymentForm = new PaymentForm(this, this.vehicleFile);
                paymentForm.Show();
            }
            else
            {
                MessageBox.Show("Selecione todos os Dados");
            }
        }
        private bool AllItemsAreSelected()
        {
            return (this.Salesman != null) && (this.Client != null) && (this.Vehicle != null);
        }

        private void LoadComboSalesMan()
        {
            this.registeredSalesmen = new PersonRegister<Salesman>("Vendedor.txt");
            this.comboSalesMan.Items.AddRange(registeredSalesmen.Items.ToArray());
        }

        public void DefineClient(Client client)
        {
            this.Client = client;
            this.textClient.Text = this.Client.ToString();
        }
        public void DefineVehicle(Vehicle vehicle, string vehicleFile)
        {
            this.Vehicle = vehicle;
            this.textVehicle.Text = this.Vehicle.ToString();
            this.vehicleFile = vehicleFile;
        }
    }
}