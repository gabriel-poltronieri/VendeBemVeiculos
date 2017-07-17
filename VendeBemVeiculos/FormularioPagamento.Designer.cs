namespace VendeBemVeiculos
{
    partial class FormularioPagamento
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
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.labelVeiculo = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.groupPagamento = new System.Windows.Forms.GroupBox();
            this.ValorPreco = new System.Windows.Forms.Label();
            this.ValorVeiculo = new System.Windows.Forms.Label();
            this.ValorVendedor = new System.Windows.Forms.Label();
            this.ValorCliente = new System.Windows.Forms.Label();
            this.BotaoEfetiva = new System.Windows.Forms.Button();
            this.BotaoCancela = new System.Windows.Forms.Button();
            this.groupPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(6, 16);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(42, 13);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = "Cliente:";
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.Location = new System.Drawing.Point(6, 40);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(56, 13);
            this.labelVendedor.TabIndex = 1;
            this.labelVendedor.Text = "Vendedor:";
            // 
            // labelVeiculo
            // 
            this.labelVeiculo.AutoSize = true;
            this.labelVeiculo.Location = new System.Drawing.Point(6, 64);
            this.labelVeiculo.Name = "labelVeiculo";
            this.labelVeiculo.Size = new System.Drawing.Size(47, 13);
            this.labelVeiculo.TabIndex = 2;
            this.labelVeiculo.Text = "Veículo:";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(6, 86);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(37, 13);
            this.labelValor.TabIndex = 3;
            this.labelValor.Text = "Valor: ";
            // 
            // groupPagamento
            // 
            this.groupPagamento.Controls.Add(this.ValorPreco);
            this.groupPagamento.Controls.Add(this.ValorVeiculo);
            this.groupPagamento.Controls.Add(this.ValorVendedor);
            this.groupPagamento.Controls.Add(this.ValorCliente);
            this.groupPagamento.Controls.Add(this.labelCliente);
            this.groupPagamento.Controls.Add(this.labelVendedor);
            this.groupPagamento.Controls.Add(this.labelValor);
            this.groupPagamento.Controls.Add(this.labelVeiculo);
            this.groupPagamento.Location = new System.Drawing.Point(13, 13);
            this.groupPagamento.Name = "groupPagamento";
            this.groupPagamento.Size = new System.Drawing.Size(259, 106);
            this.groupPagamento.TabIndex = 5;
            this.groupPagamento.TabStop = false;
            this.groupPagamento.Text = "Pagamento";
            // 
            // ValorPreco
            // 
            this.ValorPreco.AutoSize = true;
            this.ValorPreco.Location = new System.Drawing.Point(123, 86);
            this.ValorPreco.Name = "ValorPreco";
            this.ValorPreco.Size = new System.Drawing.Size(35, 13);
            this.ValorPreco.TabIndex = 8;
            this.ValorPreco.Text = "Preco";
            // 
            // ValorVeiculo
            // 
            this.ValorVeiculo.AutoSize = true;
            this.ValorVeiculo.Location = new System.Drawing.Point(123, 64);
            this.ValorVeiculo.Name = "ValorVeiculo";
            this.ValorVeiculo.Size = new System.Drawing.Size(42, 13);
            this.ValorVeiculo.TabIndex = 7;
            this.ValorVeiculo.Text = "Veiculo";
            // 
            // ValorVendedor
            // 
            this.ValorVendedor.AutoSize = true;
            this.ValorVendedor.Location = new System.Drawing.Point(123, 40);
            this.ValorVendedor.Name = "ValorVendedor";
            this.ValorVendedor.Size = new System.Drawing.Size(53, 13);
            this.ValorVendedor.TabIndex = 6;
            this.ValorVendedor.Text = "Vendedor";
            // 
            // ValorCliente
            // 
            this.ValorCliente.AutoSize = true;
            this.ValorCliente.Location = new System.Drawing.Point(123, 16);
            this.ValorCliente.Name = "ValorCliente";
            this.ValorCliente.Size = new System.Drawing.Size(39, 13);
            this.ValorCliente.TabIndex = 5;
            this.ValorCliente.Text = "Cliente";
            // 
            // BotaoEfetiva
            // 
            this.BotaoEfetiva.Location = new System.Drawing.Point(24, 125);
            this.BotaoEfetiva.Name = "BotaoEfetiva";
            this.BotaoEfetiva.Size = new System.Drawing.Size(111, 23);
            this.BotaoEfetiva.TabIndex = 6;
            this.BotaoEfetiva.Text = "Efetivar Compra";
            this.BotaoEfetiva.UseVisualStyleBackColor = true;
            this.BotaoEfetiva.Click += new System.EventHandler(this.BotaoEfetiva_Click);
            // 
            // BotaoCancela
            // 
            this.BotaoCancela.Location = new System.Drawing.Point(183, 125);
            this.BotaoCancela.Name = "BotaoCancela";
            this.BotaoCancela.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancela.TabIndex = 7;
            this.BotaoCancela.Text = "Cancelar";
            this.BotaoCancela.UseVisualStyleBackColor = true;
            this.BotaoCancela.Click += new System.EventHandler(this.BotaoCancela_Click);
            // 
            // FormularioPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 158);
            this.Controls.Add(this.BotaoCancela);
            this.Controls.Add(this.BotaoEfetiva);
            this.Controls.Add(this.groupPagamento);
            this.Name = "FormularioPagamento";
            this.Text = "FormularioPagamento";
            this.Load += new System.EventHandler(this.FormularioPagamento_Load);
            this.groupPagamento.ResumeLayout(false);
            this.groupPagamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelVeiculo;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.GroupBox groupPagamento;
        private System.Windows.Forms.Button BotaoEfetiva;
        private System.Windows.Forms.Button BotaoCancela;
        private System.Windows.Forms.Label ValorPreco;
        private System.Windows.Forms.Label ValorVeiculo;
        private System.Windows.Forms.Label ValorVendedor;
        private System.Windows.Forms.Label ValorCliente;
    }
}