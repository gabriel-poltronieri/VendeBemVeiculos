namespace VendeBemVeiculos
{
    partial class FormularioNovoVendedor
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
            this.botaoCancela = new System.Windows.Forms.Button();
            this.botaoCadastra = new System.Windows.Forms.Button();
            this.textoUltimoNome = new System.Windows.Forms.TextBox();
            this.textoPrimeiroNome = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelPrimeiroNome = new System.Windows.Forms.Label();
            this.labelUltimoNome = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textoCpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // botaoCancela
            // 
            this.botaoCancela.Location = new System.Drawing.Point(272, 183);
            this.botaoCancela.Margin = new System.Windows.Forms.Padding(5);
            this.botaoCancela.Name = "botaoCancela";
            this.botaoCancela.Size = new System.Drawing.Size(125, 35);
            this.botaoCancela.TabIndex = 15;
            this.botaoCancela.Text = "Cancelar";
            this.botaoCancela.UseVisualStyleBackColor = true;
            this.botaoCancela.Click += new System.EventHandler(this.BotaoCancela_Click);
            // 
            // botaoCadastra
            // 
            this.botaoCadastra.Location = new System.Drawing.Point(70, 180);
            this.botaoCadastra.Margin = new System.Windows.Forms.Padding(5);
            this.botaoCadastra.Name = "botaoCadastra";
            this.botaoCadastra.Size = new System.Drawing.Size(125, 35);
            this.botaoCadastra.TabIndex = 14;
            this.botaoCadastra.Text = "Cadastrar";
            this.botaoCadastra.UseVisualStyleBackColor = true;
            this.botaoCadastra.Click += new System.EventHandler(this.BotaoCadastra_Click);
            // 
            // textoUltimoNome
            // 
            this.textoUltimoNome.Location = new System.Drawing.Point(150, 97);
            this.textoUltimoNome.Margin = new System.Windows.Forms.Padding(5);
            this.textoUltimoNome.Name = "textoUltimoNome";
            this.textoUltimoNome.Size = new System.Drawing.Size(299, 26);
            this.textoUltimoNome.TabIndex = 13;
            // 
            // textoPrimeiroNome
            // 
            this.textoPrimeiroNome.Location = new System.Drawing.Point(150, 57);
            this.textoPrimeiroNome.Margin = new System.Windows.Forms.Padding(5);
            this.textoPrimeiroNome.Name = "textoPrimeiroNome";
            this.textoPrimeiroNome.Size = new System.Drawing.Size(299, 26);
            this.textoPrimeiroNome.TabIndex = 12;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(93, 135);
            this.labelCPF.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(47, 20);
            this.labelCPF.TabIndex = 11;
            this.labelCPF.Text = "CPF:";
            // 
            // labelPrimeiroNome
            // 
            this.labelPrimeiroNome.AutoSize = true;
            this.labelPrimeiroNome.Location = new System.Drawing.Point(14, 60);
            this.labelPrimeiroNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPrimeiroNome.Name = "labelPrimeiroNome";
            this.labelPrimeiroNome.Size = new System.Drawing.Size(126, 20);
            this.labelPrimeiroNome.TabIndex = 10;
            this.labelPrimeiroNome.Text = "Primeiro Nome:";
            // 
            // labelUltimoNome
            // 
            this.labelUltimoNome.AutoSize = true;
            this.labelUltimoNome.Location = new System.Drawing.Point(29, 98);
            this.labelUltimoNome.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelUltimoNome.Name = "labelUltimoNome";
            this.labelUltimoNome.Size = new System.Drawing.Size(111, 20);
            this.labelUltimoNome.TabIndex = 16;
            this.labelUltimoNome.Text = "Último Nome:";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(188, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(162, 25);
            this.labelTitulo.TabIndex = 18;
            this.labelTitulo.Text = "Novo Vendedor";
            // 
            // textoCpf
            // 
            this.textoCpf.Location = new System.Drawing.Point(150, 132);
            this.textoCpf.Mask = "000,000,000-00";
            this.textoCpf.Name = "textoCpf";
            this.textoCpf.Size = new System.Drawing.Size(126, 26);
            this.textoCpf.TabIndex = 19;
            // 
            // FormularioNovoVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 242);
            this.Controls.Add(this.textoCpf);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.labelUltimoNome);
            this.Controls.Add(this.botaoCancela);
            this.Controls.Add(this.botaoCadastra);
            this.Controls.Add(this.textoUltimoNome);
            this.Controls.Add(this.textoPrimeiroNome);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.labelPrimeiroNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormularioNovoVendedor";
            this.Text = "Vende Bem Veículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoCancela;
        private System.Windows.Forms.Button botaoCadastra;
        private System.Windows.Forms.TextBox textoUltimoNome;
        private System.Windows.Forms.TextBox textoPrimeiroNome;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelPrimeiroNome;
        private System.Windows.Forms.Label labelUltimoNome;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.MaskedTextBox textoCpf;
    }
}