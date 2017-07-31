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
    public partial class SaleDetailForm : Form
    {
        private Sale sale;

        public SaleDetailForm(Sale sale)
        {
            InitializeComponent();
            this.sale = sale;
            LoadValues();
        }

        private void LoadValues()
        {
            this.labelClientValue.Text = this.sale.Client.ToString();
            this.labelDateValue.Text = this.sale.Date;
            this.labelVehicleValue.Text = this.sale.Vehicle.ToString();
            this.labelSalesmanValue.Text = this.sale.Salesman.ToString();
            this.LbelPriceValue.Text = $"RS{string.Format("{0:0.00}", this.sale.Vehicle.Price)}";
        }
    }
}