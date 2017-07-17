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
            this.botaoSenha = new System.Windows.Forms.Button();
            this.botaoSeleciona = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botaoBusca
            // 
            this.botaoBusca.Location = new System.Drawing.Point(260, 228);
            this.botaoBusca.Margin = new System.Windows.Forms.Padding(4);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(100, 28);
            this.botaoBusca.TabIndex = 12;
            this.botaoBusca.Text = "Buscar";
            this.botaoBusca.UseVisualStyleBackColor = true;
            this.botaoBusca.Click += new System.EventHandler(this.botaoBusca_Click);
            // 
            // textoRegistro
            // 
            this.textoRegistro.Location = new System.Drawing.Point(77, 231);
            this.textoRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.textoRegistro.Name = "textoRegistro";
            this.textoRegistro.Size = new System.Drawing.Size(173, 22);
            this.textoRegistro.TabIndex = 11;
            // 
            // labeRegistro
            // 
            this.labeRegistro.AutoSize = true;
            this.labeRegistro.Location = new System.Drawing.Point(14, 234);
            this.labeRegistro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeRegistro.Name = "labeRegistro";
            this.labeRegistro.Size = new System.Drawing.Size(65, 17);
            this.labeRegistro.TabIndex = 10;
            this.labeRegistro.Text = "Registro:";
            // 
            // botaoNovo
            // 
            this.botaoNovo.Location = new System.Drawing.Point(250, 275);
            this.botaoNovo.Margin = new System.Windows.Forms.Padding(4);
            this.botaoNovo.Name = "botaoNovo";
            this.botaoNovo.Size = new System.Drawing.Size(109, 28);
            this.botaoNovo.TabIndex = 9;
            this.botaoNovo.Text = "Novo Vendedor";
            this.botaoNovo.UseVisualStyleBackColor = true;
            this.botaoNovo.Click += new System.EventHandler(this.botaoNovo_Click);
            // 
            // listaVendedores
            // 
            this.listaVendedores.FormattingEnabled = true;
            this.listaVendedores.ItemHeight = 16;
            this.listaVendedores.Location = new System.Drawing.Point(13, 13);
            this.listaVendedores.Margin = new System.Windows.Forms.Padding(4);
            this.listaVendedores.Name = "listaVendedores";
            this.listaVendedores.Size = new System.Drawing.Size(345, 212);
            this.listaVendedores.TabIndex = 7;
            // 
            // botaoSenha
            // 
            this.botaoSenha.Location = new System.Drawing.Point(125, 275);
            this.botaoSenha.Margin = new System.Windows.Forms.Padding(4);
            this.botaoSenha.Name = "botaoSenha";
            this.botaoSenha.Size = new System.Drawing.Size(117, 28);
            this.botaoSenha.TabIndex = 13;
            this.botaoSenha.Text = "Definir Senha";
            this.botaoSenha.UseVisualStyleBackColor = true;
            // 
            // botaoSeleciona
            // 
            this.botaoSeleciona.Location = new System.Drawing.Point(17, 275);
            this.botaoSeleciona.Margin = new System.Windows.Forms.Padding(4);
            this.botaoSeleciona.Name = "botaoSeleciona";
            this.botaoSeleciona.Size = new System.Drawing.Size(100, 28);
            this.botaoSeleciona.TabIndex = 8;
            this.botaoSeleciona.Text = "Seleciona";
            this.botaoSeleciona.UseVisualStyleBackColor = true;
            // 
            // FormularioVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 319);
            this.Controls.Add(this.botaoSenha);
            this.Controls.Add(this.botaoBusca);
            this.Controls.Add(this.textoRegistro);
            this.Controls.Add(this.labeRegistro);
            this.Controls.Add(this.botaoNovo);
            this.Controls.Add(this.botaoSeleciona);
            this.Controls.Add(this.listaVendedores);
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
        private System.Windows.Forms.Button botaoSenha;
        private System.Windows.Forms.Button botaoSeleciona;
    }
}