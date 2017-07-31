namespace VendeBemVeiculos
{
    partial class NewSalesmanForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.textLastName = new System.Windows.Forms.TextBox();
            this.textFirstName = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textCpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(272, 183);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(125, 35);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(70, 180);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(125, 35);
            this.buttonRegister.TabIndex = 14;
            this.buttonRegister.Text = "Cadastrar";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.ButtonRegister_Click);
            // 
            // textLastName
            // 
            this.textLastName.Location = new System.Drawing.Point(150, 97);
            this.textLastName.Margin = new System.Windows.Forms.Padding(5);
            this.textLastName.Name = "textLastName";
            this.textLastName.Size = new System.Drawing.Size(299, 23);
            this.textLastName.TabIndex = 13;
            // 
            // textFirstName
            // 
            this.textFirstName.Location = new System.Drawing.Point(150, 57);
            this.textFirstName.Margin = new System.Windows.Forms.Padding(5);
            this.textFirstName.Name = "textFirstName";
            this.textFirstName.Size = new System.Drawing.Size(299, 23);
            this.textFirstName.TabIndex = 12;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(81, 135);
            this.labelCPF.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(38, 17);
            this.labelCPF.TabIndex = 11;
            this.labelCPF.Text = "CPF:";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(14, 60);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(105, 17);
            this.labelFirstName.TabIndex = 10;
            this.labelFirstName.Text = "Primeiro Nome:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(29, 98);
            this.labelLastName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(92, 17);
            this.labelLastName.TabIndex = 16;
            this.labelLastName.Text = "Último Nome:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(188, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(132, 20);
            this.labelTitle.TabIndex = 18;
            this.labelTitle.Text = "Novo Vendedor";
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(150, 132);
            this.textCpf.Mask = "000,000,000-00";
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(126, 23);
            this.textCpf.TabIndex = 19;
            // 
            // FormularioNovoVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 242);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.textLastName);
            this.Controls.Add(this.textFirstName);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.labelFirstName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormularioNovoVendedor";
            this.Text = "Vende Bem Veículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox textLastName;
        private System.Windows.Forms.TextBox textFirstName;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.MaskedTextBox textCpf;
    }
}