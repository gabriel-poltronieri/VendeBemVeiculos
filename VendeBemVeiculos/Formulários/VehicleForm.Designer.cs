namespace VendeBemVeiculos
{
    partial class VehicleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.listVehicles = new System.Windows.Forms.ListBox();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.radioCar = new System.Windows.Forms.RadioButton();
            this.radioMotorcycle = new System.Windows.Forms.RadioButton();
            this.comboBrand = new System.Windows.Forms.ComboBox();
            this.comboName = new System.Windows.Forms.ComboBox();
            this.comboYear = new System.Windows.Forms.ComboBox();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.labelQuantityValue = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelPriceValue = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelTítle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(305, 310);
            this.buttonFilter.Margin = new System.Windows.Forms.Padding(5);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(125, 35);
            this.buttonFilter.TabIndex = 11;
            this.buttonFilter.Text = "Filtrar";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.ButtonFilter_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(554, 435);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(199, 45);
            this.buttonDelete.TabIndex = 8;
            this.buttonDelete.Text = "Excluir ";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(124, 435);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(186, 45);
            this.buttonSelect.TabIndex = 7;
            this.buttonSelect.Text = "Seleciona";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // listVehicles
            // 
            this.listVehicles.FormattingEnabled = true;
            this.listVehicles.ItemHeight = 16;
            this.listVehicles.Location = new System.Drawing.Point(26, 61);
            this.listVehicles.Margin = new System.Windows.Forms.Padding(5);
            this.listVehicles.Name = "listVehicles";
            this.listVehicles.Size = new System.Drawing.Size(568, 356);
            this.listVehicles.TabIndex = 6;
            this.listVehicles.SelectedIndexChanged += new System.EventHandler(this.ListVeiculos_SelectedIndexChanged);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(334, 435);
            this.buttonNew.Margin = new System.Windows.Forms.Padding(5);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(199, 45);
            this.buttonNew.TabIndex = 12;
            this.buttonNew.Text = "Novo";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(779, 435);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(199, 45);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // radioCar
            // 
            this.radioCar.AutoSize = true;
            this.radioCar.Location = new System.Drawing.Point(80, 41);
            this.radioCar.Margin = new System.Windows.Forms.Padding(5);
            this.radioCar.Name = "radioCar";
            this.radioCar.Size = new System.Drawing.Size(68, 21);
            this.radioCar.TabIndex = 14;
            this.radioCar.Text = "Carros";
            this.radioCar.UseVisualStyleBackColor = true;
            this.radioCar.CheckedChanged += new System.EventHandler(this.RadioCar_CheckedChanged);
            // 
            // radioMotorcycle
            // 
            this.radioMotorcycle.AutoSize = true;
            this.radioMotorcycle.Location = new System.Drawing.Point(312, 41);
            this.radioMotorcycle.Margin = new System.Windows.Forms.Padding(5);
            this.radioMotorcycle.Name = "radioMotorcycle";
            this.radioMotorcycle.Size = new System.Drawing.Size(64, 21);
            this.radioMotorcycle.TabIndex = 15;
            this.radioMotorcycle.TabStop = true;
            this.radioMotorcycle.Text = "Motos";
            this.radioMotorcycle.UseVisualStyleBackColor = true;
            this.radioMotorcycle.CheckedChanged += new System.EventHandler(this.RadioMotorcycle_CheckedChanged);
            // 
            // comboBrand
            // 
            this.comboBrand.FormattingEnabled = true;
            this.comboBrand.Location = new System.Drawing.Point(135, 99);
            this.comboBrand.Margin = new System.Windows.Forms.Padding(5);
            this.comboBrand.Name = "comboBrand";
            this.comboBrand.Size = new System.Drawing.Size(294, 24);
            this.comboBrand.TabIndex = 16;
            this.comboBrand.SelectedIndexChanged += new System.EventHandler(this.ComboBrand_SelectedIndexChanged);
            // 
            // comboName
            // 
            this.comboName.FormattingEnabled = true;
            this.comboName.Location = new System.Drawing.Point(135, 155);
            this.comboName.Margin = new System.Windows.Forms.Padding(5);
            this.comboName.Name = "comboName";
            this.comboName.Size = new System.Drawing.Size(294, 24);
            this.comboName.TabIndex = 17;
            this.comboName.SelectedIndexChanged += new System.EventHandler(this.ComboName_SelectedIndexChanged);
            // 
            // comboYear
            // 
            this.comboYear.FormattingEnabled = true;
            this.comboYear.Location = new System.Drawing.Point(135, 218);
            this.comboYear.Margin = new System.Windows.Forms.Padding(5);
            this.comboYear.Name = "comboYear";
            this.comboYear.Size = new System.Drawing.Size(294, 24);
            this.comboYear.TabIndex = 18;
            this.comboYear.SelectedIndexChanged += new System.EventHandler(this.ComboYear_SelectedIndexChanged);
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(38, 104);
            this.labelBrand.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(51, 17);
            this.labelBrand.TabIndex = 19;
            this.labelBrand.Text = "Marca:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(38, 159);
            this.labelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(58, 17);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Modelo:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(52, 221);
            this.labelYear.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(37, 17);
            this.labelYear.TabIndex = 21;
            this.labelYear.Text = "Ano:";
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(271, 266);
            this.labelQuantity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(86, 17);
            this.labelQuantity.TabIndex = 22;
            this.labelQuantity.Text = "Quantidade:";
            // 
            // labelQuantityValue
            // 
            this.labelQuantityValue.AutoSize = true;
            this.labelQuantityValue.Location = new System.Drawing.Point(402, 266);
            this.labelQuantityValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelQuantityValue.Name = "labelQuantityValue";
            this.labelQuantityValue.Size = new System.Drawing.Size(18, 17);
            this.labelQuantityValue.TabIndex = 23;
            this.labelQuantityValue.Text = "--";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelPriceValue);
            this.groupBox1.Controls.Add(this.labelPrice);
            this.groupBox1.Controls.Add(this.labelBrand);
            this.groupBox1.Controls.Add(this.labelQuantityValue);
            this.groupBox1.Controls.Add(this.buttonFilter);
            this.groupBox1.Controls.Add(this.labelQuantity);
            this.groupBox1.Controls.Add(this.radioCar);
            this.groupBox1.Controls.Add(this.labelYear);
            this.groupBox1.Controls.Add(this.radioMotorcycle);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.comboBrand);
            this.groupBox1.Controls.Add(this.comboName);
            this.groupBox1.Controls.Add(this.comboYear);
            this.groupBox1.Location = new System.Drawing.Point(620, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(471, 354);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de Busca";
            // 
            // labelPriceValue
            // 
            this.labelPriceValue.AutoSize = true;
            this.labelPriceValue.Location = new System.Drawing.Point(91, 266);
            this.labelPriceValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPriceValue.Name = "labelPriceValue";
            this.labelPriceValue.Size = new System.Drawing.Size(46, 17);
            this.labelPriceValue.TabIndex = 25;
            this.labelPriceValue.Text = "R$----";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(40, 266);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(49, 17);
            this.labelPrice.TabIndex = 24;
            this.labelPrice.Text = "Preço:";
            // 
            // labelTítle
            // 
            this.labelTítle.AutoSize = true;
            this.labelTítle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTítle.Location = new System.Drawing.Point(479, 9);
            this.labelTítle.Name = "labelTítle";
            this.labelTítle.Size = new System.Drawing.Size(174, 20);
            this.labelTítle.TabIndex = 25;
            this.labelTítle.Text = "Estoque de Veículos";
            // 
            // VehicleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 501);
            this.Controls.Add(this.labelTítle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.listVehicles);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "VehicleForm";
            this.Text = "Vende Bem Veículos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.ListBox listVehicles;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton radioCar;
        private System.Windows.Forms.RadioButton radioMotorcycle;
        private System.Windows.Forms.ComboBox comboBrand;
        private System.Windows.Forms.ComboBox comboName;
        private System.Windows.Forms.ComboBox comboYear;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.Label labelQuantityValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPriceValue;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelTítle;
    }
}