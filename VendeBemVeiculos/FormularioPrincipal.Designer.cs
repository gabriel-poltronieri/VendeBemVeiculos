namespace VendeBemVeiculos
{
    partial class FormularioPrincipal
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
            this.Titulo = new System.Windows.Forms.Label();
            this.botaoVenda = new System.Windows.Forms.Button();
            this.botaoEstoque = new System.Windows.Forms.Button();
            this.botaoVendedores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.Location = new System.Drawing.Point(99, 10);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(138, 17);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Vende Bem Veículos";
            // 
            // botaoVenda
            // 
            this.botaoVenda.Location = new System.Drawing.Point(39, 30);
            this.botaoVenda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botaoVenda.Name = "botaoVenda";
            this.botaoVenda.Size = new System.Drawing.Size(277, 70);
            this.botaoVenda.TabIndex = 1;
            this.botaoVenda.Text = "Realizar Venda";
            this.botaoVenda.UseVisualStyleBackColor = true;
            this.botaoVenda.Click += new System.EventHandler(this.BotaoVenda_Click);
            // 
            // botaoEstoque
            // 
            this.botaoEstoque.Location = new System.Drawing.Point(39, 107);
            this.botaoEstoque.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botaoEstoque.Name = "botaoEstoque";
            this.botaoEstoque.Size = new System.Drawing.Size(277, 70);
            this.botaoEstoque.TabIndex = 2;
            this.botaoEstoque.Text = "Estoque de Veículos";
            this.botaoEstoque.UseVisualStyleBackColor = true;
            this.botaoEstoque.Click += new System.EventHandler(this.botaoEstoque_Click);
            // 
            // botaoVendedores
            // 
            this.botaoVendedores.Location = new System.Drawing.Point(39, 185);
            this.botaoVendedores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botaoVendedores.Name = "botaoVendedores";
            this.botaoVendedores.Size = new System.Drawing.Size(277, 70);
            this.botaoVendedores.TabIndex = 3;
            this.botaoVendedores.Text = "Registro de Vendedores";
            this.botaoVendedores.UseVisualStyleBackColor = true;
            this.botaoVendedores.Click += new System.EventHandler(this.botaoVendedores_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 270);
            this.Controls.Add(this.botaoVendedores);
            this.Controls.Add(this.botaoEstoque);
            this.Controls.Add(this.botaoVenda);
            this.Controls.Add(this.Titulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormularioPrincipal";
            this.Text = "Vende Bem Veículos";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button botaoVenda;
        private System.Windows.Forms.Button botaoEstoque;
        private System.Windows.Forms.Button botaoVendedores;
    }
}