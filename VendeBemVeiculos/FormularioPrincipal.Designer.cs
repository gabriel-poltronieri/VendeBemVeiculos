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
            this.Titulo.Location = new System.Drawing.Point(74, 8);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(107, 13);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Vende Bem Veículos";
            // 
            // botaoVenda
            // 
            this.botaoVenda.Location = new System.Drawing.Point(29, 24);
            this.botaoVenda.Name = "botaoVenda";
            this.botaoVenda.Size = new System.Drawing.Size(208, 57);
            this.botaoVenda.TabIndex = 1;
            this.botaoVenda.Text = "Realizar Venda";
            this.botaoVenda.UseVisualStyleBackColor = true;
            this.botaoVenda.Click += new System.EventHandler(this.botaoVenda_Click);
            // 
            // botaoEstoque
            // 
            this.botaoEstoque.Location = new System.Drawing.Point(29, 87);
            this.botaoEstoque.Name = "botaoEstoque";
            this.botaoEstoque.Size = new System.Drawing.Size(208, 57);
            this.botaoEstoque.TabIndex = 2;
            this.botaoEstoque.Text = "Estoque de Veículos";
            this.botaoEstoque.UseVisualStyleBackColor = true;
            // 
            // botaoVendedores
            // 
            this.botaoVendedores.Location = new System.Drawing.Point(29, 150);
            this.botaoVendedores.Name = "botaoVendedores";
            this.botaoVendedores.Size = new System.Drawing.Size(208, 57);
            this.botaoVendedores.TabIndex = 3;
            this.botaoVendedores.Text = "Registro de Vendedores";
            this.botaoVendedores.UseVisualStyleBackColor = true;
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 219);
            this.Controls.Add(this.botaoVendedores);
            this.Controls.Add(this.botaoEstoque);
            this.Controls.Add(this.botaoVenda);
            this.Controls.Add(this.Titulo);
            this.Name = "FormularioPrincipal";
            this.Text = "Vende Bem Veículos";
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