namespace VendeBemVeiculos
{
    partial class FormularioNovoCliente
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
            this.labelPrimeiroNome = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.textoPrimeiroNome = new System.Windows.Forms.TextBox();
            this.botaoCadastrar = new System.Windows.Forms.Button();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.textoUltimoNome = new System.Windows.Forms.TextBox();
            this.labelUltimoNome = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textoCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // labelPrimeiroNome
            // 
            this.labelPrimeiroNome.AutoSize = true;
            this.labelPrimeiroNome.Location = new System.Drawing.Point(14, 56);
            this.labelPrimeiroNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPrimeiroNome.Name = "labelPrimeiroNome";
            this.labelPrimeiroNome.Size = new System.Drawing.Size(126, 20);
            this.labelPrimeiroNome.TabIndex = 0;
            this.labelPrimeiroNome.Text = "Primeiro Nome:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(98, 136);
            this.labelCPF.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(47, 20);
            this.labelCPF.TabIndex = 1;
            this.labelCPF.Text = "CPF:";
            // 
            // textoPrimeiroNome
            // 
            this.textoPrimeiroNome.Location = new System.Drawing.Point(155, 53);
            this.textoPrimeiroNome.Margin = new System.Windows.Forms.Padding(5);
            this.textoPrimeiroNome.Name = "textoPrimeiroNome";
            this.textoPrimeiroNome.Size = new System.Drawing.Size(299, 26);
            this.textoPrimeiroNome.TabIndex = 6;
            // 
            // botaoCadastrar
            // 
            this.botaoCadastrar.Location = new System.Drawing.Point(78, 189);
            this.botaoCadastrar.Margin = new System.Windows.Forms.Padding(5);
            this.botaoCadastrar.Name = "botaoCadastrar";
            this.botaoCadastrar.Size = new System.Drawing.Size(125, 35);
            this.botaoCadastrar.TabIndex = 8;
            this.botaoCadastrar.Text = "Cadastrar";
            this.botaoCadastrar.UseVisualStyleBackColor = true;
            this.botaoCadastrar.Click += new System.EventHandler(this.BotaoCadastra_Click);
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Location = new System.Drawing.Point(273, 189);
            this.botaoCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(125, 35);
            this.botaoCancelar.TabIndex = 9;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            this.botaoCancelar.Click += new System.EventHandler(this.BotaoCancela_Click);
            // 
            // textoUltimoNome
            // 
            this.textoUltimoNome.Location = new System.Drawing.Point(155, 93);
            this.textoUltimoNome.Margin = new System.Windows.Forms.Padding(5);
            this.textoUltimoNome.Name = "textoUltimoNome";
            this.textoUltimoNome.Size = new System.Drawing.Size(299, 26);
            this.textoUltimoNome.TabIndex = 11;
            // 
            // labelUltimoNome
            // 
            this.labelUltimoNome.AutoSize = true;
            this.labelUltimoNome.Location = new System.Drawing.Point(30, 96);
            this.labelUltimoNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUltimoNome.Name = "labelUltimoNome";
            this.labelUltimoNome.Size = new System.Drawing.Size(111, 20);
            this.labelUltimoNome.TabIndex = 10;
            this.labelUltimoNome.Text = "Último Nome:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(192, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(136, 25);
            this.labelTitulo.TabIndex = 12;
            this.labelTitulo.Text = "Novo Cliente";
            // 
            // textoCPF
            // 
            this.textoCPF.Location = new System.Drawing.Point(155, 133);
            this.textoCPF.Mask = "000,000,000-00";
            this.textoCPF.Name = "textoCPF";
            this.textoCPF.Size = new System.Drawing.Size(124, 26);
            this.textoCPF.TabIndex = 13;
            // 
            // FormularioNovoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 243);
            this.Controls.Add(this.textoCPF);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textoUltimoNome);
            this.Controls.Add(this.labelUltimoNome);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoCadastrar);
            this.Controls.Add(this.textoPrimeiroNome);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.labelPrimeiroNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormularioNovoCliente";
            this.RightToLeftLayout = true;
            this.Text = "Vende Bem Veículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrimeiroNome;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.TextBox textoPrimeiroNome;
        private System.Windows.Forms.Button botaoCadastrar;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.TextBox textoUltimoNome;
        private System.Windows.Forms.Label labelUltimoNome;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.MaskedTextBox textoCPF;
    }
}