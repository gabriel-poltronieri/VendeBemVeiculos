namespace VendeBemVeiculos
{
    partial class NewVehicleForm
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
            this.labelVehicle = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelBrand = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.comboVehicle = new System.Windows.Forms.ComboBox();
            this.textBrand = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.textYear = new System.Windows.Forms.TextBox();
            this.textPrice = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelVehicle
            // 
            this.labelVehicle.AutoSize = true;
            this.labelVehicle.Location = new System.Drawing.Point(31, 58);
            this.labelVehicle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelVehicle.Name = "labelVehicle";
            this.labelVehicle.Size = new System.Drawing.Size(58, 17);
            this.labelVehicle.TabIndex = 0;
            this.labelVehicle.Text = "Veículo:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(35, 137);
            this.labelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(58, 17);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Modelo:";
            // 
            // labelBrand
            // 
            this.labelBrand.AutoSize = true;
            this.labelBrand.Location = new System.Drawing.Point(43, 97);
            this.labelBrand.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelBrand.Name = "labelBrand";
            this.labelBrand.Size = new System.Drawing.Size(51, 17);
            this.labelBrand.TabIndex = 2;
            this.labelBrand.Text = "Marca:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(61, 177);
            this.labelYear.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(37, 17);
            this.labelYear.TabIndex = 3;
            this.labelYear.Text = "Ano:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(46, 217);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(49, 17);
            this.labelPrice.TabIndex = 4;
            this.labelPrice.Text = "Preço:";
            // 
            // comboVehicle
            // 
            this.comboVehicle.FormattingEnabled = true;
            this.comboVehicle.Location = new System.Drawing.Point(131, 53);
            this.comboVehicle.Margin = new System.Windows.Forms.Padding(5);
            this.comboVehicle.Name = "comboVehicle";
            this.comboVehicle.Size = new System.Drawing.Size(299, 24);
            this.comboVehicle.TabIndex = 6;
            // 
            // textBrand
            // 
            this.textBrand.Location = new System.Drawing.Point(131, 92);
            this.textBrand.Margin = new System.Windows.Forms.Padding(5);
            this.textBrand.Name = "textBrand";
            this.textBrand.Size = new System.Drawing.Size(299, 23);
            this.textBrand.TabIndex = 7;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(131, 132);
            this.textName.Margin = new System.Windows.Forms.Padding(5);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(299, 23);
            this.textName.TabIndex = 8;
            // 
            // textYear
            // 
            this.textYear.Location = new System.Drawing.Point(131, 172);
            this.textYear.Margin = new System.Windows.Forms.Padding(5);
            this.textYear.Name = "textYear";
            this.textYear.Size = new System.Drawing.Size(299, 23);
            this.textYear.TabIndex = 9;
            // 
            // textPrice
            // 
            this.textPrice.Location = new System.Drawing.Point(131, 212);
            this.textPrice.Margin = new System.Windows.Forms.Padding(5);
            this.textPrice.Name = "textPrice";
            this.textPrice.Size = new System.Drawing.Size(299, 23);
            this.textPrice.TabIndex = 10;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(65, 267);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 35);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Adicionar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(291, 267);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(125, 35);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(156, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(113, 20);
            this.labelTitle.TabIndex = 14;
            this.labelTitle.Text = "Novo Veículo";
            // 
            // FormularioNovoVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 339);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textPrice);
            this.Controls.Add(this.textYear);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textBrand);
            this.Controls.Add(this.comboVehicle);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.labelBrand);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelVehicle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormularioNovoVeiculo";
            this.Text = "Vende Bem Veículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVehicle;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelBrand;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ComboBox comboVehicle;
        private System.Windows.Forms.TextBox textBrand;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textYear;
        private System.Windows.Forms.TextBox textPrice;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelTitle;
    }
}