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
        private VehicleRegister<Vehicle> allVehicles;

        public NewVehicleForm(VehicleForm vehicleForm)
        {
            InitializeComponent();
            this.vehicleForm = vehicleForm;
            LoadComboBox();
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (AllFieldsComplete())
            {
                AddNewVehicleToRegister();            
                this.vehicleForm.UpdateAllVehicles();
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
            this.allVehicles = new VehicleRegister<Vehicle>(file);
            this.allVehicles.AddItemToRegister(newVehicle);
        }

        private void LoadComboBox()
        {
            this.comboVehicle.Items.Add("Carro");
            this.comboVehicle.Items.Add("Moto");
            this.comboVehicle.SelectedItem = "Carro";
        }
    }
}