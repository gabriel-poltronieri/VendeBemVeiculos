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
    public partial class HistoryForm : Form
    {
        private SaleRegister<Sale> allSales = new SaleRegister<Sale>("Venda.txt");
        private Sale selectedSale;

        public HistoryForm()
        {
            InitializeComponent();
            LoadHistory();
        }

        private void ListHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listHistory.SelectedItem != null)
            {
                this.selectedSale = (Sale)this.listHistory.SelectedItem;
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ButtonDetails_Click(object sender, EventArgs e)
        {
            if (this.selectedSale != null)
            {
                var saleDetailForm = new SaleDetailForm(this.selectedSale);
                saleDetailForm.Show();
            }
            else
            {
                MessageBox.Show("Selecione uma venda");
            }
        }

        private void LoadHistory()
        {
            this.listHistory.Items.AddRange(allSales.Items);
        }
    }
}