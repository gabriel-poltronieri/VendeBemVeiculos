namespace VendeBemVeiculos
{
    partial class PaymentForm
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
            this.labelClient = new System.Windows.Forms.Label();
            this.labelSalesMan = new System.Windows.Forms.Label();
            this.labelVehicle = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.groupPagamento = new System.Windows.Forms.GroupBox();
            this.labelPriceValue = new System.Windows.Forms.Label();
            this.labelVehicleValue = new System.Windows.Forms.Label();
            this.labelSalesManValue = new System.Windows.Forms.Label();
            this.labelClientValue = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(29, 25);
            this.labelClient.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(55, 17);
            this.labelClient.TabIndex = 0;
            this.labelClient.Text = "Cliente:";
            // 
            // labelSalesMan
            // 
            this.labelSalesMan.AutoSize = true;
            this.labelSalesMan.Location = new System.Drawing.Point(10, 61);
            this.labelSalesMan.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSalesMan.Name = "labelSalesMan";
            this.labelSalesMan.Size = new System.Drawing.Size(74, 17);
            this.labelSalesMan.TabIndex = 1;
            this.labelSalesMan.Text = "Vendedor:";
            // 
            // labelVehicle
            // 
            this.labelVehicle.AutoSize = true;
            this.labelVehicle.Location = new System.Drawing.Point(26, 99);
            this.labelVehicle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelVehicle.Name = "labelVehicle";
            this.labelVehicle.Size = new System.Drawing.Size(58, 17);
            this.labelVehicle.TabIndex = 2;
            this.labelVehicle.Text = "Veículo:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(35, 132);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(49, 17);
            this.labelPrice.TabIndex = 3;
            this.labelPrice.Text = "Preço:";
            // 
            // groupPagamento
            // 
            this.groupPagamento.Controls.Add(this.labelPriceValue);
            this.groupPagamento.Controls.Add(this.labelVehicleValue);
            this.groupPagamento.Controls.Add(this.labelSalesManValue);
            this.groupPagamento.Controls.Add(this.labelClientValue);
            this.groupPagamento.Controls.Add(this.labelClient);
            this.groupPagamento.Controls.Add(this.labelSalesMan);
            this.groupPagamento.Controls.Add(this.labelPrice);
            this.groupPagamento.Controls.Add(this.labelVehicle);
            this.groupPagamento.Location = new System.Drawing.Point(13, 44);
            this.groupPagamento.Margin = new System.Windows.Forms.Padding(5);
            this.groupPagamento.Name = "groupPagamento";
            this.groupPagamento.Padding = new System.Windows.Forms.Padding(5);
            this.groupPagamento.Size = new System.Drawing.Size(435, 165);
            this.groupPagamento.TabIndex = 5;
            this.groupPagamento.TabStop = false;
            this.groupPagamento.Text = "Pagamento";
            // 
            // labelPriceValue
            // 
            this.labelPriceValue.AutoSize = true;
            this.labelPriceValue.Location = new System.Drawing.Point(133, 132);
            this.labelPriceValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPriceValue.Name = "labelPriceValue";
            this.labelPriceValue.Size = new System.Drawing.Size(45, 17);
            this.labelPriceValue.TabIndex = 8;
            this.labelPriceValue.Text = "Preco";
            // 
            // labelVehicleValue
            // 
            this.labelVehicleValue.AutoSize = true;
            this.labelVehicleValue.Location = new System.Drawing.Point(133, 99);
            this.labelVehicleValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelVehicleValue.Name = "labelVehicleValue";
            this.labelVehicleValue.Size = new System.Drawing.Size(54, 17);
            this.labelVehicleValue.TabIndex = 7;
            this.labelVehicleValue.Text = "Veiculo";
            // 
            // labelSalesManValue
            // 
            this.labelSalesManValue.AutoSize = true;
            this.labelSalesManValue.Location = new System.Drawing.Point(133, 61);
            this.labelSalesManValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSalesManValue.Name = "labelSalesManValue";
            this.labelSalesManValue.Size = new System.Drawing.Size(70, 17);
            this.labelSalesManValue.TabIndex = 6;
            this.labelSalesManValue.Text = "Vendedor";
            // 
            // labelClientValue
            // 
            this.labelClientValue.AutoSize = true;
            this.labelClientValue.Location = new System.Drawing.Point(133, 25);
            this.labelClientValue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelClientValue.Name = "labelClientValue";
            this.labelClientValue.Size = new System.Drawing.Size(51, 17);
            this.labelClientValue.TabIndex = 5;
            this.labelClientValue.Text = "Cliente";
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(25, 229);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(5);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(185, 35);
            this.buttonConfirm.TabIndex = 6;
            this.buttonConfirm.Text = "Confirmar Compra";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(299, 229);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(125, 35);
            this.buttonCancel.TabIndex = 7;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(98, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(202, 20);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Confirmação de Compra";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 283);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.groupPagamento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "PaymentForm";
            this.Text = "Vende Bem Veículos";
            this.groupPagamento.ResumeLayout(false);
            this.groupPagamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.Label labelSalesMan;
        private System.Windows.Forms.Label labelVehicle;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.GroupBox groupPagamento;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelPriceValue;
        private System.Windows.Forms.Label labelVehicleValue;
        private System.Windows.Forms.Label labelSalesManValue;
        private System.Windows.Forms.Label labelClientValue;
        private System.Windows.Forms.Label labelTitle;
    }
}