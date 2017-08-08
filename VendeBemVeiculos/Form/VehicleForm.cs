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
        private Vehicle[] filteredVehicles;

        public VehicleForm(SaleForm saleForm)
        {
            this.saleForm = saleForm;
            InitializeComponent();
            this.radioCar.Checked = true;
            this.VehicleFile = "Carro.txt";
            this.RegisteredVehicles = new VehicleRegister<Vehicle>(this.VehicleFile);
            this.LoadOnList(this.RegisteredVehicles.Items);        
        }

        public VehicleRegister<Vehicle> RegisteredVehicles { get; private set; }
        public Vehicle SelectedVehicle { get; private set; }
        public string VehicleFile { get; private set; }

        private void ListVehicles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listVehicles.SelectedItem != null)
            {
                this.SelectedVehicle = (Vehicle)this.listVehicles.SelectedItem;
                this.labelPriceValue.Text = $"RS{string.Format("{0:0.00}", this.SelectedVehicle.Price)}";
                this.labelQuantityValue.Text = Convert.ToString(this.RegisteredVehicles.Items.Count(v => v.Equals(SelectedVehicle)));
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
                this.saleForm.DefineVehicle(this.SelectedVehicle, this.VehicleFile);
                this.Close();
            }
            else
            {
                MessageBox.Show("Selecione um Veículo");
            }
        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            this.LoadOnList(this.filteredVehicles);
        }
        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (this.SelectedVehicle != null)
            {
                this.RegisteredVehicles.DeleteItemFromRegister(this.SelectedVehicle);
                this.LoadRegisteredVehiclesOnList();
            }
            else
            {
                MessageBox.Show("Selecione um Veículo");
            }
        }

        private void RadioCar_CheckedChanged(object sender, EventArgs e)
        {
            this.VehicleFile = "Carro.txt";
            this.LoadRegisteredVehiclesOnList();
        }
        private void RadioMotorcycle_CheckedChanged(object sender, EventArgs e)
        {
            this.VehicleFile = "Moto.txt";
            this.LoadRegisteredVehiclesOnList();
        }
                
        private void ComboBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filteredVehicles = this.RegisteredVehicles.FilterByBrand(this.comboBrand.SelectedItem.ToString());
            this.ClearComboName();
            this.ClearComboYear();
            this.LoadComboName();
        }
        private void ComboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filteredVehicles = this.RegisteredVehicles.FilterByBrand(this.comboBrand.SelectedItem.ToString());
            this.filteredVehicles = this.RegisteredVehicles.FilterByName(this.comboName.SelectedItem.ToString());
            this.ClearComboYear();
            this.LoadComboYear();
        }
        private void ComboYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.filteredVehicles = this.RegisteredVehicles.FilterByBrand(this.comboBrand.SelectedItem.ToString());
            this.filteredVehicles = this.RegisteredVehicles.FilterByName(this.comboName.SelectedItem.ToString());
            this.filteredVehicles = this.RegisteredVehicles.FilterByYear(this.comboYear.SelectedItem.ToString());
        }

        private void LoadOnList(Vehicle[] vehicleList)
        {
            vehicleList = vehicleList.Distinct().ToArray();
            this.listVehicles.Items.Clear();
            this.listVehicles.Items.AddRange(vehicleList);
        }
        public void LoadRegisteredVehiclesOnList()
        {
            this.RegisteredVehicles = new VehicleRegister<Vehicle>(this.VehicleFile);
            this.filteredVehicles = this.RegisteredVehicles.Items;
            this.LoadOnList(this.RegisteredVehicles.Items);
            this.ClearComboBrand();
            this.ClearComboName();
            this.ClearComboYear();
            this.LoadComboBrand();
        }

        private void ClearComboBrand()
        {
            this.comboBrand.Items.Clear();
            this.comboBrand.Text = "";
        }
        private void ClearComboName()
        {
            this.comboName.Items.Clear();
            this.comboName.Text = "";
        }
        private void ClearComboYear()
        {
            this.comboYear.Items.Clear();
            this.comboYear.Text = "";
        }

        private void LoadComboBrand()
        {
            var brands = this.RegisteredVehicles.Items.Select(veiculo => veiculo.Brand).Distinct().ToArray();
            this.comboBrand.Items.AddRange(brands);
        }
        private void LoadComboName()
        {
            var names = this.filteredVehicles.Select(veiculo => veiculo.Name).Distinct().ToArray();
            this.comboName.Items.AddRange(names);
        }
        private void LoadComboYear()
        {
            var years = this.filteredVehicles.Select(v => v.Year).Distinct().ToArray();
            this.comboYear.Items.AddRange(years);
        }        
    }
}