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
            this.BotaoBusca = new System.Windows.Forms.Button();
            this.TextoRegistro = new System.Windows.Forms.TextBox();
            this.labeRegistro = new System.Windows.Forms.Label();
            this.BotaoNovo = new System.Windows.Forms.Button();
            this.ListaVendedores = new System.Windows.Forms.ListBox();
            this.BotaoSeleciona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotaoBusca
            // 
            this.BotaoBusca.Location = new System.Drawing.Point(195, 185);
            this.BotaoBusca.Name = "BotaoBusca";
            this.BotaoBusca.Size = new System.Drawing.Size(75, 23);
            this.BotaoBusca.TabIndex = 12;
            this.BotaoBusca.Text = "Buscar";
            this.BotaoBusca.UseVisualStyleBackColor = true;
            this.BotaoBusca.Click += new System.EventHandler(this.BotaoBusca_Click);
            // 
            // TextoRegistro
            // 
            this.TextoRegistro.Location = new System.Drawing.Point(58, 188);
            this.TextoRegistro.Name = "TextoRegistro";
            this.TextoRegistro.Size = new System.Drawing.Size(131, 20);
            this.TextoRegistro.TabIndex = 11;
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
            // BotaoNovo
            // 
            this.BotaoNovo.Location = new System.Drawing.Point(164, 223);
            this.BotaoNovo.Name = "BotaoNovo";
            this.BotaoNovo.Size = new System.Drawing.Size(82, 23);
            this.BotaoNovo.TabIndex = 9;
            this.BotaoNovo.Text = "Novo Vendedor";
            this.BotaoNovo.UseVisualStyleBackColor = true;
            this.BotaoNovo.Click += new System.EventHandler(this.BotaoNovo_Click);
            // 
            // ListaVendedores
            // 
            this.ListaVendedores.FormattingEnabled = true;
            this.ListaVendedores.Location = new System.Drawing.Point(10, 11);
            this.ListaVendedores.Name = "ListaVendedores";
            this.ListaVendedores.Size = new System.Drawing.Size(260, 173);
            this.ListaVendedores.TabIndex = 7;
            this.ListaVendedores.SelectedIndexChanged += new System.EventHandler(this.listaVendedores_SelectedIndexChanged);
            // 
            // BotaoSeleciona
            // 
            this.BotaoSeleciona.Location = new System.Drawing.Point(36, 223);
            this.BotaoSeleciona.Name = "BotaoSeleciona";
            this.BotaoSeleciona.Size = new System.Drawing.Size(75, 23);
            this.BotaoSeleciona.TabIndex = 8;
            this.BotaoSeleciona.Text = "Seleciona";
            this.BotaoSeleciona.UseVisualStyleBackColor = true;
            this.BotaoSeleciona.Click += new System.EventHandler(this.BotaoSeleciona_Click);
            // 
            // FormularioVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 259);
            this.Controls.Add(this.BotaoBusca);
            this.Controls.Add(this.TextoRegistro);
            this.Controls.Add(this.labeRegistro);
            this.Controls.Add(this.BotaoNovo);
            this.Controls.Add(this.BotaoSeleciona);
            this.Controls.Add(this.ListaVendedores);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormularioVendedores";
            this.Text = "FormularioVendedores";
            this.Load += new System.EventHandler(this.FormularioVendedores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BotaoBusca;
        private System.Windows.Forms.TextBox TextoRegistro;
        private System.Windows.Forms.Label labeRegistro;
        private System.Windows.Forms.Button BotaoNovo;
        private System.Windows.Forms.ListBox ListaVendedores;
        private System.Windows.Forms.Button BotaoSeleciona;
    }
}