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
    public partial class NewVehicleForm : Form
    {
        private VehicleForm vehicleForm;
        private Vehicle newVehicle;
        private VehicleRegister<Vehicle> registeredVehicles;

        public NewVehicleForm(VehicleForm vehicleForm)
        {
            InitializeComponent();
            this.vehicleForm = vehicleForm;
            this.LoadComboBox();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (AllFieldsComplete())
            {
                this.AddNewVehicleToRegister();            
                this.vehicleForm.LoadRegisteredVehiclesOnList();
                this.Close();
            }
            else
            {
                MessageBox.Show("Complete os dados");
            }

        }
        private bool AllFieldsComplete()
        {
            return (this.textBrand.Text != "") && (this.textName.Text != "") && (this.textYear.Text != "") && (this.textPrice.Text != "");
        }
        private void AddNewVehicleToRegister()
        {
            string file = $"{this.comboVehicle.SelectedItem}.txt";
            this.newVehicle = new Vehicle(textBrand.Text, textName.Text, textYear.Text, Convert.ToDouble(textPrice.Text));
            this.registeredVehicles = new VehicleRegister<Vehicle>(file);
            this.registeredVehicles.AddItemToRegister(newVehicle);
        }

        private void LoadComboBox()
        {
            this.comboVehicle.Items.Add("Carro");
            this.comboVehicle.Items.Add("Moto");
            this.comboVehicle.SelectedItem = "Carro";
        }
    }
}