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
    public partial class VehicleForm : Form
    {
        private SaleForm saleForm;        
        private Vehicle[] filtered;

        public VehicleForm(SaleForm saleForm)
        {
            this.saleForm = saleForm;
            InitializeComponent();
            this.radioCar.Checked = true;
            this.WishedFile = "Carro.txt";
            this.AllVehicles = new VehicleRegister<Vehicle>(this.WishedFile);
            LoadOnList(this.AllVehicles.Items);        
        }

        public VehicleRegister<Vehicle> AllVehicles { get; private set; }
        public Vehicle SelectedVehicle { get; private set; }
        public string WishedFile { get; private set; }

        private void ListVeiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listVehicles.SelectedItem != null)
            {
                this.SelectedVehicle = (Vehicle)this.listVehicles.SelectedItem;
                this.labelPriceValue.Text = $"RS{string.Format("{0:0.00}", this.SelectedVehicle.Price)}";
                this.labelQuantityValue.Text = Convert.ToString(this.AllVehicles.Items.Count(v => v.Equals(SelectedVehicle)));
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ButtonNew_Click(object sender, EventArgs e)
        {
            var newClientForm = new NewVehicleForm(this);
            newClientForm.Show();
        }
        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            if (this.SelectedVehicle != null)
            {
                this.saleForm.DefineVehicle(this.SelectedVehicle, this.WishedFile);
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um Veículo");
            }
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            LoadOnList(this.filtered);
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (this.SelectedVehicle != null)
            {
                this.AllVehicles.DeleteItemFromRegister(this.SelectedVehicle);
                UpdateAllVehicles();
            }
            else
            {
                MessageBox.Show("Selecione um Veículo");
            }
        }

        private void RadioCar_CheckedChanged(object sender, EventArgs e)
        {
            this.WishedFile = "Carro.txt";
            UpdateAllVehicles();
        }
        private void RadioMotorcycle_CheckedChanged(object sender, EventArgs e)
        {
            this.WishedFile = "Moto.txt";
            UpdateAllVehicles();
        }
                
        private void ComboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filtered = this.AllVehicles.FilterByBrand(this.comboBrand.SelectedItem.ToString());
            CleanComboName();
            CleanComboYear();
            LoadComboName();
        }
        private void ComboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filtered = this.AllVehicles.FilterByBrand(this.comboBrand.SelectedItem.ToString());
            this.filtered = this.AllVehicles.FilterByName(this.comboName.SelectedItem.ToString());
            CleanComboYear();
            LoadComboYear();
        }
        private void ComboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filtered = this.AllVehicles.FilterByBrand(this.comboBrand.SelectedItem.ToString());
            this.filtered = this.AllVehicles.FilterByName(this.comboName.SelectedItem.ToString());
            this.filtered = this.AllVehicles.FilterByYear(this.comboYear.SelectedItem.ToString());
        }

        private void LoadOnList(Vehicle[] vehicleList)
        {
            vehicleList = vehicleList.Distinct().ToArray();
            this.listVehicles.Items.Clear();
            this.listVehicles.Items.AddRange(vehicleList);
        }
        public void UpdateAllVehicles()
        {
            this.AllVehicles = new VehicleRegister<Vehicle>(this.WishedFile);
            this.filtered = this.AllVehicles.Items;
            LoadOnList(this.AllVehicles.Items);
            CleanComboBrand();
            CleanComboName();
            CleanComboYear();
            LoadComboBrand();
        }

        private void CleanComboBrand()
        {
            this.comboBrand.Items.Clear();
            this.comboBrand.Text = "";
        }
        private void CleanComboName()
        {
            this.comboName.Items.Clear();
            this.comboName.Text = "";
        }
        private void CleanComboYear()
        {
            this.comboYear.Items.Clear();
            this.comboYear.Text = "";
        }

        private void LoadComboBrand()
        {
            var brands = this.AllVehicles.Items.Select(veiculo => veiculo.Brand).Distinct().ToArray();
            this.comboBrand.Items.AddRange(brands);
        }
        private void LoadComboName()
        {
            var names = this.filtered.Select(veiculo => veiculo.Name).Distinct().ToArray();
            this.comboName.Items.AddRange(names);
        }
        private void LoadComboYear()
        {
            var years = this.filtered.Select(v => v.Year).Distinct().ToArray();
            this.comboYear.Items.AddRange(years);
        }        
    }
}