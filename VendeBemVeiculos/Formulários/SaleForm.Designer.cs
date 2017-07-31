namespace VendeBemVeiculos
{
    partial class SaleForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelSalesMan = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.groupClienteVendedor = new System.Windows.Forms.GroupBox();
            this.textVehicle = new System.Windows.Forms.TextBox();
            this.buttonSearchVehicle = new System.Windows.Forms.Button();
            this.labelVehicle = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.textClient = new System.Windows.Forms.TextBox();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.buttonSearchClient = new System.Windows.Forms.Button();
            this.comboSalesMan = new System.Windows.Forms.ComboBox();
            this.groupClienteVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(218, 9);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(175, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Vende Bem Veículos";
            // 
            // labelSalesMan
            // 
            this.labelSalesMan.AutoSize = true;
            this.labelSalesMan.Location = new System.Drawing.Point(20, 47);
            this.labelSalesMan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSalesMan.Name = "labelSalesMan";
            this.labelSalesMan.Size = new System.Drawing.Size(74, 17);
            this.labelSalesMan.TabIndex = 1;
            this.labelSalesMan.Text = "Vendedor:";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(39, 106);
            this.labelClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(55, 17);
            this.labelClient.TabIndex = 2;
            this.labelClient.Text = "Cliente:";
            // 
            // groupClienteVendedor
            // 
            this.groupClienteVendedor.Controls.Add(this.textVehicle);
            this.groupClienteVendedor.Controls.Add(this.buttonSearchVehicle);
            this.groupClienteVendedor.Controls.Add(this.labelVehicle);
            this.groupClienteVendedor.Controls.Add(this.buttonCancel);
            this.groupClienteVendedor.Controls.Add(this.textClient);
            this.groupClienteVendedor.Controls.Add(this.buttonPayment);
            this.groupClienteVendedor.Controls.Add(this.buttonSearchClient);
            this.groupClienteVendedor.Controls.Add(this.comboSalesMan);
            this.groupClienteVendedor.Controls.Add(this.labelSalesMan);
            this.groupClienteVendedor.Controls.Add(this.labelClient);
            this.groupClienteVendedor.Location = new System.Drawing.Point(25, 51);
            this.groupClienteVendedor.Margin = new System.Windows.Forms.Padding(5);
            this.groupClienteVendedor.Name = "groupClienteVendedor";
            this.groupClienteVendedor.Padding = new System.Windows.Forms.Padding(5);
            this.groupClienteVendedor.Size = new System.Drawing.Size(581, 390);
            this.groupClienteVendedor.TabIndex = 3;
            this.groupClienteVendedor.TabStop = false;
            this.groupClienteVendedor.Text = "Envolvidos";
            // 
            // textVehicle
            // 
            this.textVehicle.Location = new System.Drawing.Point(125, 221);
            this.textVehicle.Margin = new System.Windows.Forms.Padding(5);
            this.textVehicle.Name = "textVehicle";
            this.textVehicle.ReadOnly = true;
            this.textVehicle.Size = new System.Drawing.Size(413, 23);
            this.textVehicle.TabIndex = 21;
            this.textVehicle.Text = "Selecione um Veículo";
            // 
            // buttonSearchVehicle
            // 
            this.buttonSearchVehicle.Location = new System.Drawing.Point(375, 267);
            this.buttonSearchVehicle.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSearchVehicle.Name = "buttonSearchVehicle";
            this.buttonSearchVehicle.Size = new System.Drawing.Size(165, 35);
            this.buttonSearchVehicle.TabIndex = 20;
            this.buttonSearchVehicle.Text = "Buscar Veiculo";
            this.buttonSearchVehicle.UseVisualStyleBackColor = true;
            this.buttonSearchVehicle.Click += new System.EventHandler(this.ButtonSearchVehicle_Click);
            // 
            // labelVehicle
            // 
            this.labelVehicle.AutoSize = true;
            this.labelVehicle.Location = new System.Drawing.Point(36, 226);
            this.labelVehicle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelVehicle.Name = "labelVehicle";
            this.labelVehicle.Size = new System.Drawing.Size(58, 17);
            this.labelVehicle.TabIndex = 19;
            this.labelVehicle.Text = "Veiculo:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(342, 331);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(125, 35);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // textClient
            // 
            this.textClient.Location = new System.Drawing.Point(125, 104);
            this.textClient.Margin = new System.Windows.Forms.Padding(5);
            this.textClient.Name = "textClient";
            this.textClient.ReadOnly = true;
            this.textClient.Size = new System.Drawing.Size(413, 23);
            this.textClient.TabIndex = 7;
            this.textClient.Text = "Selecione um Cliente";
            // 
            // buttonPayment
            // 
            this.buttonPayment.Location = new System.Drawing.Point(100, 331);
            this.buttonPayment.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(125, 35);
            this.buttonPayment.TabIndex = 17;
            this.buttonPayment.Text = "Pagamento";
            this.buttonPayment.UseVisualStyleBackColor = true;
            this.buttonPayment.Click += new System.EventHandler(this.ButtonPayment_Click);
            // 
            // buttonSearchClient
            // 
            this.buttonSearchClient.Location = new System.Drawing.Point(375, 160);
            this.buttonSearchClient.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSearchClient.Name = "buttonSearchClient";
            this.buttonSearchClient.Size = new System.Drawing.Size(165, 35);
            this.buttonSearchClient.TabIndex = 6;
            this.buttonSearchClient.Text = "Buscar Cliente";
            this.buttonSearchClient.UseVisualStyleBackColor = true;
            this.buttonSearchClient.Click += new System.EventHandler(this.ButtonSearchClient_Click);
            // 
            // comboSalesMan
            // 
            this.comboSalesMan.FormattingEnabled = true;
            this.comboSalesMan.Location = new System.Drawing.Point(125, 44);
            this.comboSalesMan.Margin = new System.Windows.Forms.Padding(5);
            this.comboSalesMan.Name = "comboSalesMan";
            this.comboSalesMan.Size = new System.Drawing.Size(413, 24);
            this.comboSalesMan.TabIndex = 4;
            this.comboSalesMan.Text = "Escolha uma opção";
            this.comboSalesMan.SelectedIndexChanged += new System.EventHandler(this.ComboSalesman_SelectedIndexChanged);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 471);
            this.Controls.Add(this.groupClienteVendedor);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SaleForm";
            this.Text = "Vende Bem Veículos";
            this.groupClienteVendedor.ResumeLayout(false);
            this.groupClienteVendedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelSalesMan;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.GroupBox groupClienteVendedor;
        private System.Windows.Forms.ComboBox comboSalesMan;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.TextBox textClient;
        private System.Windows.Forms.Button buttonSearchClient;
        private System.Windows.Forms.TextBox textVehicle;
        private System.Windows.Forms.Button buttonSearchVehicle;
        private System.Windows.Forms.Label labelVehicle;
    }
}

