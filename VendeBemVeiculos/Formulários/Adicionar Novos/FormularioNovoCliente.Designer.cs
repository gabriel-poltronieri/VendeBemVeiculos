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
            this.labelCpf = new System.Windows.Forms.Label();
            this.textoPrimeiroNome = new System.Windows.Forms.TextBox();
            this.botaoCadastra = new System.Windows.Forms.Button();
            this.botaoCancela = new System.Windows.Forms.Button();
            this.textoUltimoNome = new System.Windows.Forms.TextBox();
            this.labelUltimoNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textoCpf = new System.Windows.Forms.MaskedTextBox();
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
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(98, 136);
            this.labelCpf.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(47, 20);
            this.labelCpf.TabIndex = 1;
            this.labelCpf.Text = "CPF:";
            // 
            // textoPrimeiroNome
            // 
            this.textoPrimeiroNome.Location = new System.Drawing.Point(155, 53);
            this.textoPrimeiroNome.Margin = new System.Windows.Forms.Padding(5);
            this.textoPrimeiroNome.Name = "textoPrimeiroNome";
            this.textoPrimeiroNome.Size = new System.Drawing.Size(299, 26);
            this.textoPrimeiroNome.TabIndex = 6;
            // 
            // botaoCadastra
            // 
            this.botaoCadastra.Location = new System.Drawing.Point(78, 189);
            this.botaoCadastra.Margin = new System.Windows.Forms.Padding(5);
            this.botaoCadastra.Name = "botaoCadastra";
            this.botaoCadastra.Size = new System.Drawing.Size(125, 35);
            this.botaoCadastra.TabIndex = 8;
            this.botaoCadastra.Text = "Cadastrar";
            this.botaoCadastra.UseVisualStyleBackColor = true;
            this.botaoCadastra.Click += new System.EventHandler(this.BotaoCadastra_Click);
            // 
            // botaoCancela
            // 
            this.botaoCancela.Location = new System.Drawing.Point(273, 189);
            this.botaoCancela.Margin = new System.Windows.Forms.Padding(5);
            this.botaoCancela.Name = "botaoCancela";
            this.botaoCancela.Size = new System.Drawing.Size(125, 35);
            this.botaoCancela.TabIndex = 9;
            this.botaoCancela.Text = "Cancelar";
            this.botaoCancela.UseVisualStyleBackColor = true;
            this.botaoCancela.Click += new System.EventHandler(this.BotaoCancela_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Novo Cliente";
            // 
            // textoCpf
            // 
            this.textoCpf.Location = new System.Drawing.Point(155, 133);
            this.textoCpf.Mask = "000,000,000-00";
            this.textoCpf.Name = "textoCpf";
            this.textoCpf.Size = new System.Drawing.Size(124, 26);
            this.textoCpf.TabIndex = 13;
            // 
            // FormularioNovoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 243);
            this.Controls.Add(this.textoCpf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textoUltimoNome);
            this.Controls.Add(this.labelUltimoNome);
            this.Controls.Add(this.botaoCancela);
            this.Controls.Add(this.botaoCadastra);
            this.Controls.Add(this.textoPrimeiroNome);
            this.Controls.Add(this.labelCpf);
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
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.TextBox textoPrimeiroNome;
        private System.Windows.Forms.Button botaoCadastra;
        private System.Windows.Forms.Button botaoCancela;
        private System.Windows.Forms.TextBox textoUltimoNome;
        private System.Windows.Forms.Label labelUltimoNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textoCpf;
    }
}