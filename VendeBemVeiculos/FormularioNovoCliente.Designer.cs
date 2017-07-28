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
            this.textoCpf = new System.Windows.Forms.TextBox();
            this.botaoCadastra = new System.Windows.Forms.Button();
            this.botaoCancela = new System.Windows.Forms.Button();
            this.textoUltimoNome = new System.Windows.Forms.TextBox();
            this.labelUltimoNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPrimeiroNome
            // 
            this.labelPrimeiroNome.AutoSize = true;
            this.labelPrimeiroNome.Location = new System.Drawing.Point(12, 9);
            this.labelPrimeiroNome.Name = "labelPrimeiroNome";
            this.labelPrimeiroNome.Size = new System.Drawing.Size(75, 13);
            this.labelPrimeiroNome.TabIndex = 0;
            this.labelPrimeiroNome.Text = "Primeiro Nome";
            // 
            // labelCpf
            // 
            this.labelCpf.AutoSize = true;
            this.labelCpf.Location = new System.Drawing.Point(12, 61);
            this.labelCpf.Name = "labelCpf";
            this.labelCpf.Size = new System.Drawing.Size(27, 13);
            this.labelCpf.TabIndex = 1;
            this.labelCpf.Text = "CPF";
            // 
            // textoPrimeiroNome
            // 
            this.textoPrimeiroNome.Location = new System.Drawing.Point(91, 6);
            this.textoPrimeiroNome.Name = "textoPrimeiroNome";
            this.textoPrimeiroNome.Size = new System.Drawing.Size(181, 20);
            this.textoPrimeiroNome.TabIndex = 6;
            // 
            // textoCpf
            // 
            this.textoCpf.Location = new System.Drawing.Point(91, 58);
            this.textoCpf.Name = "textoCpf";
            this.textoCpf.Size = new System.Drawing.Size(181, 20);
            this.textoCpf.TabIndex = 7;
            // 
            // botaoCadastra
            // 
            this.botaoCadastra.Location = new System.Drawing.Point(44, 94);
            this.botaoCadastra.Name = "botaoCadastra";
            this.botaoCadastra.Size = new System.Drawing.Size(75, 23);
            this.botaoCadastra.TabIndex = 8;
            this.botaoCadastra.Text = "Cadastrar";
            this.botaoCadastra.UseVisualStyleBackColor = true;
            this.botaoCadastra.Click += new System.EventHandler(this.BotaoCadastra_Click);
            // 
            // botaoCancela
            // 
            this.botaoCancela.Location = new System.Drawing.Point(161, 94);
            this.botaoCancela.Name = "botaoCancela";
            this.botaoCancela.Size = new System.Drawing.Size(75, 23);
            this.botaoCancela.TabIndex = 9;
            this.botaoCancela.Text = "Cancelar";
            this.botaoCancela.UseVisualStyleBackColor = true;
            this.botaoCancela.Click += new System.EventHandler(this.BotaoCancela_Click);
            // 
            // textoUltimoNome
            // 
            this.textoUltimoNome.Location = new System.Drawing.Point(91, 32);
            this.textoUltimoNome.Name = "textoUltimoNome";
            this.textoUltimoNome.Size = new System.Drawing.Size(181, 20);
            this.textoUltimoNome.TabIndex = 11;
            // 
            // labelUltimoNome
            // 
            this.labelUltimoNome.AutoSize = true;
            this.labelUltimoNome.Location = new System.Drawing.Point(12, 35);
            this.labelUltimoNome.Name = "labelUltimoNome";
            this.labelUltimoNome.Size = new System.Drawing.Size(67, 13);
            this.labelUltimoNome.TabIndex = 10;
            this.labelUltimoNome.Text = "Último Nome";
            // 
            // FormularioNovoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 126);
            this.Controls.Add(this.textoUltimoNome);
            this.Controls.Add(this.labelUltimoNome);
            this.Controls.Add(this.botaoCancela);
            this.Controls.Add(this.botaoCadastra);
            this.Controls.Add(this.textoCpf);
            this.Controls.Add(this.textoPrimeiroNome);
            this.Controls.Add(this.labelCpf);
            this.Controls.Add(this.labelPrimeiroNome);
            this.Name = "FormularioNovoCliente";
            this.Text = "Novo Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPrimeiroNome;
        private System.Windows.Forms.Label labelCpf;
        private System.Windows.Forms.TextBox textoPrimeiroNome;
        private System.Windows.Forms.TextBox textoCpf;
        private System.Windows.Forms.Button botaoCadastra;
        private System.Windows.Forms.Button botaoCancela;
        private System.Windows.Forms.TextBox textoUltimoNome;
        private System.Windows.Forms.Label labelUltimoNome;
    }
}