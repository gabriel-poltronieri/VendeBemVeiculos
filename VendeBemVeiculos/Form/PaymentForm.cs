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
    public partial class PaymentForm : Form
    {
        private string vehicleFile;
        private SaleRegister<Sale> saleRegister = new SaleRegister<Sale>("Venda.txt");
        private SaleForm saleForm;
        private Client client;
        private Salesman salesman;
        private Vehicle vehicle;
        private Sale sale;

        public PaymentForm(SaleForm saleForm, string vehicleForm)
        {
            this.saleForm = saleForm;
            InitializeComponent();
            GetSaleCharacters();
            ValuesInTextFormat();
            this.vehicleFile = vehicleForm;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            this.sale = new Sale(this.client, this.vehicle, this.salesman);
            this.saleRegister.AddItemToRegister(sale);
            VehicleRegister<Vehicle> vehicleRegister = new VehicleRegister<Vehicle>(this.vehicleFile);
            vehicleRegister.DeleteItemFromRegister(this.vehicle);
            this.Close();
        }

        private void GetSaleCharacters()
        {
            this.client = this.saleForm.Client;
            this.salesman = this.saleForm.Salesman;
            this.vehicle = this.saleForm.Vehicle;
        }
        private void ValuesInTextFormat()
        {
            this.labelClientValue.Text = this.client.ToString();
            this.labelSalesManValue.Text = this.salesman.ToString();
            this.labelVehicleValue.Text = $"{this.vehicle.Brand} {this.vehicle.Name} {this.vehicle.Year}";
            this.labelPriceValue.Text = $"R${string.Format("{0:0.00}", this.vehicle.Price)}";
        }        
    }
}
