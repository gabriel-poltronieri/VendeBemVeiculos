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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.botaoVenda = new System.Windows.Forms.Button();
            this.botaoNovoVendedor = new System.Windows.Forms.Button();
            this.botaoHistorico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(98, 9);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(213, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Vende Bem Veículos";
            // 
            // botaoVenda
            // 
            this.botaoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoVenda.Location = new System.Drawing.Point(69, 55);
            this.botaoVenda.Margin = new System.Windows.Forms.Padding(4);
            this.botaoVenda.Name = "botaoVenda";
            this.botaoVenda.Size = new System.Drawing.Size(277, 70);
            this.botaoVenda.TabIndex = 1;
            this.botaoVenda.Text = "Realizar Venda";
            this.botaoVenda.UseVisualStyleBackColor = true;
            this.botaoVenda.Click += new System.EventHandler(this.BotaoVenda_Click);
            // 
            // botaoNovoVendedor
            // 
            this.botaoNovoVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoNovoVendedor.Location = new System.Drawing.Point(69, 132);
            this.botaoNovoVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.botaoNovoVendedor.Name = "botaoNovoVendedor";
            this.botaoNovoVendedor.Size = new System.Drawing.Size(277, 70);
            this.botaoNovoVendedor.TabIndex = 3;
            this.botaoNovoVendedor.Text = "Registrar Novo Vendedor";
            this.botaoNovoVendedor.UseVisualStyleBackColor = true;
            this.botaoNovoVendedor.Click += new System.EventHandler(this.BotaoVendedores_Click);
            // 
            // botaoHistorico
            // 
            this.botaoHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoHistorico.Location = new System.Drawing.Point(69, 210);
            this.botaoHistorico.Margin = new System.Windows.Forms.Padding(4);
            this.botaoHistorico.Name = "botaoHistorico";
            this.botaoHistorico.Size = new System.Drawing.Size(277, 70);
            this.botaoHistorico.TabIndex = 4;
            this.botaoHistorico.Text = "Histórico de Vendas";
            this.botaoHistorico.UseVisualStyleBackColor = true;
            this.botaoHistorico.Click += new System.EventHandler(this.BotaoHistorico_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 325);
            this.Controls.Add(this.botaoHistorico);
            this.Controls.Add(this.botaoNovoVendedor);
            this.Controls.Add(this.botaoVenda);
            this.Controls.Add(this.labelTitulo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormularioPrincipal";
            this.Text = "Vende Bem Veículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button botaoVenda;
        private System.Windows.Forms.Button botaoNovoVendedor;
        private System.Windows.Forms.Button botaoHistorico;
    }
}