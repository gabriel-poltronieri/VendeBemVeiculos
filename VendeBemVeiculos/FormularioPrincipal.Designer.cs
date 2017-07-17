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
            this.BotaoVenda = new System.Windows.Forms.Button();
            this.BotaoEstoque = new System.Windows.Forms.Button();
            this.BotaoVendedores = new System.Windows.Forms.Button();
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
            // BotaoVenda
            // 
            this.BotaoVenda.Location = new System.Drawing.Point(29, 24);
            this.BotaoVenda.Name = "BotaoVenda";
            this.BotaoVenda.Size = new System.Drawing.Size(208, 57);
            this.BotaoVenda.TabIndex = 1;
            this.BotaoVenda.Text = "Realizar Venda";
            this.BotaoVenda.UseVisualStyleBackColor = true;
            this.BotaoVenda.Click += new System.EventHandler(this.BotaoVenda_Click);
            // 
            // BotaoEstoque
            // 
            this.BotaoEstoque.Location = new System.Drawing.Point(29, 87);
            this.BotaoEstoque.Name = "BotaoEstoque";
            this.BotaoEstoque.Size = new System.Drawing.Size(208, 57);
            this.BotaoEstoque.TabIndex = 2;
            this.BotaoEstoque.Text = "Estoque de Veículos";
            this.BotaoEstoque.UseVisualStyleBackColor = true;
            this.BotaoEstoque.Click += new System.EventHandler(this.BotaoEstoque_Click);
            // 
            // BotaoVendedores
            // 
            this.BotaoVendedores.Location = new System.Drawing.Point(29, 150);
            this.BotaoVendedores.Name = "BotaoVendedores";
            this.BotaoVendedores.Size = new System.Drawing.Size(208, 57);
            this.BotaoVendedores.TabIndex = 3;
            this.BotaoVendedores.Text = "Registro de Vendedores";
            this.BotaoVendedores.UseVisualStyleBackColor = true;
            this.BotaoVendedores.Click += new System.EventHandler(this.BotaoVendedores_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 231);
            this.Controls.Add(this.BotaoVendedores);
            this.Controls.Add(this.BotaoEstoque);
            this.Controls.Add(this.BotaoVenda);
            this.Controls.Add(this.Titulo);
            this.Name = "FormularioPrincipal";
            this.Text = "Vende Bem Veículos";
            this.Load += new System.EventHandler(this.FormularioPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Button BotaoVenda;
        private System.Windows.Forms.Button BotaoEstoque;
        private System.Windows.Forms.Button BotaoVendedores;
    }
}