namespace VendeBemVeiculos
{
    partial class FormularioVendedores
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
            this.botaoBusca = new System.Windows.Forms.Button();
            this.textoRegistro = new System.Windows.Forms.TextBox();
            this.labeRegistro = new System.Windows.Forms.Label();
            this.botaoNovo = new System.Windows.Forms.Button();
            this.listaVendedores = new System.Windows.Forms.ListBox();
            this.botaoSeleciona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoBusca
            // 
            this.botaoBusca.Location = new System.Drawing.Point(195, 185);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(75, 23);
            this.botaoBusca.TabIndex = 12;
            this.botaoBusca.Text = "Buscar";
            this.botaoBusca.UseVisualStyleBackColor = true;
            this.botaoBusca.Click += new System.EventHandler(this.BotaoBusca_Click);
            // 
            // textoRegistro
            // 
            this.textoRegistro.Location = new System.Drawing.Point(58, 188);
            this.textoRegistro.Name = "textoRegistro";
            this.textoRegistro.Size = new System.Drawing.Size(131, 20);
            this.textoRegistro.TabIndex = 11;
            // 
            // labeRegistro
            // 
            this.labeRegistro.AutoSize = true;
            this.labeRegistro.Location = new System.Drawing.Point(10, 190);
            this.labeRegistro.Name = "labeRegistro";
            this.labeRegistro.Size = new System.Drawing.Size(49, 13);
            this.labeRegistro.TabIndex = 10;
            this.labeRegistro.Text = "Registro:";
            // 
            // botaoNovo
            // 
            this.botaoNovo.Location = new System.Drawing.Point(164, 223);
            this.botaoNovo.Name = "botaoNovo";
            this.botaoNovo.Size = new System.Drawing.Size(82, 23);
            this.botaoNovo.TabIndex = 9;
            this.botaoNovo.Text = "Novo Vendedor";
            this.botaoNovo.UseVisualStyleBackColor = true;
            this.botaoNovo.Click += new System.EventHandler(this.BotaoNovo_Click);
            // 
            // listaVendedores
            // 
            this.listaVendedores.FormattingEnabled = true;
            this.listaVendedores.Location = new System.Drawing.Point(10, 11);
            this.listaVendedores.Name = "listaVendedores";
            this.listaVendedores.Size = new System.Drawing.Size(260, 173);
            this.listaVendedores.TabIndex = 7;
            this.listaVendedores.SelectedIndexChanged += new System.EventHandler(this.listaVendedores_SelectedIndexChanged);
            // 
            // botaoSeleciona
            // 
            this.botaoSeleciona.Location = new System.Drawing.Point(36, 223);
            this.botaoSeleciona.Name = "botaoSeleciona";
            this.botaoSeleciona.Size = new System.Drawing.Size(75, 23);
            this.botaoSeleciona.TabIndex = 8;
            this.botaoSeleciona.Text = "Seleciona";
            this.botaoSeleciona.UseVisualStyleBackColor = true;
            this.botaoSeleciona.Click += new System.EventHandler(this.BotaoSeleciona_Click);
            // 
            // FormularioVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 259);
            this.Controls.Add(this.botaoBusca);
            this.Controls.Add(this.textoRegistro);
            this.Controls.Add(this.labeRegistro);
            this.Controls.Add(this.botaoNovo);
            this.Controls.Add(this.botaoSeleciona);
            this.Controls.Add(this.listaVendedores);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormularioVendedores";
            this.Text = "FormularioVendedores";
            this.Load += new System.EventHandler(this.FormularioVendedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button botaoBusca;
        private System.Windows.Forms.TextBox textoRegistro;
        private System.Windows.Forms.Label labeRegistro;
        private System.Windows.Forms.Button botaoNovo;
        private System.Windows.Forms.ListBox listaVendedores;
        private System.Windows.Forms.Button botaoSeleciona;
    }
}