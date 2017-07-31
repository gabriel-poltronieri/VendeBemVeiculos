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
        private PersonRegister<Salesman> ourSalesMen;        
        public Vehicle vehicle;
        private string boughtVehicleFile;

        public SaleForm()
        {
            InitializeComponent();
            LoadComboSalesMan();
        }

        public Salesman Salesman { get; private set; }
        public Client Client { get; private set; }

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
            if (AllSelected())
            {
                var paymentForm = new PaymentForm(this, this.boughtVehicleFile);
                paymentForm.Show();
            }
            else
            {
                MessageBox.Show("Selecione todos os Dados");
            }
        }
        private bool AllSelected()
        {
            return (this.Salesman != null) && (this.Client != null) && (this.vehicle != null);
        }

        private void LoadComboSalesMan()
        {
            this.ourSalesMen = new PersonRegister<Salesman>("Vendedor.txt");
            this.comboSalesMan.Items.AddRange(ourSalesMen.Items.ToArray());
        }

        public void DefineClient(Client client)
        {
            this.Client = client;
            this.textClient.Text = this.Client.ToString();
        }
        public void DefineVehicle(Vehicle vehicle, string vehicleFile)
        {
            this.vehicle = vehicle;
            this.textVehicle.Text = this.vehicle.ToString();
            this.boughtVehicleFile = vehicleFile;
        }
        public void DefineSalesman(Salesman salesman)
        {
            this.Salesman = salesman;
            this.comboSalesMan.SelectedItem = this.Salesman;
        }
    }
}