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
            this.valorPreco = new System.Windows.Forms.Label();
            this.valorVeiculo = new System.Windows.Forms.Label();
            this.valorVendedor = new System.Windows.Forms.Label();
            this.valorCliente = new System.Windows.Forms.Label();
            this.butaoEfetiva = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.groupPagamento.Controls.Add(this.valorPreco);
            this.groupPagamento.Controls.Add(this.valorVeiculo);
            this.groupPagamento.Controls.Add(this.valorVendedor);
            this.groupPagamento.Controls.Add(this.valorCliente);
            this.groupPagamento.Controls.Add(this.labelCliente);
            this.groupPagamento.Controls.Add(this.labelVendedor);
            this.groupPagamento.Controls.Add(this.labelValor);
            this.groupPagamento.Controls.Add(this.labelVeiculo);
            this.groupPagamento.Location = new System.Drawing.Point(13, 13);
            this.groupPagamento.Name = "groupPagamento";
            this.groupPagamento.Size = new System.Drawing.Size(259, 107);
            this.groupPagamento.TabIndex = 5;
            this.groupPagamento.TabStop = false;
            this.groupPagamento.Text = "Pagamento";
            // 
            // valorPreco
            // 
            this.valorPreco.AutoSize = true;
            this.valorPreco.Location = new System.Drawing.Point(123, 86);
            this.valorPreco.Name = "valorPreco";
            this.valorPreco.Size = new System.Drawing.Size(35, 13);
            this.valorPreco.TabIndex = 8;
            this.valorPreco.Text = "Preco";
            // 
            // valorVeiculo
            // 
            this.valorVeiculo.AutoSize = true;
            this.valorVeiculo.Location = new System.Drawing.Point(123, 64);
            this.valorVeiculo.Name = "valorVeiculo";
            this.valorVeiculo.Size = new System.Drawing.Size(42, 13);
            this.valorVeiculo.TabIndex = 7;
            this.valorVeiculo.Text = "Veiculo";
            // 
            // valorVendedor
            // 
            this.valorVendedor.AutoSize = true;
            this.valorVendedor.Location = new System.Drawing.Point(123, 40);
            this.valorVendedor.Name = "valorVendedor";
            this.valorVendedor.Size = new System.Drawing.Size(53, 13);
            this.valorVendedor.TabIndex = 6;
            this.valorVendedor.Text = "Vendedor";
            // 
            // valorCliente
            // 
            this.valorCliente.AutoSize = true;
            this.valorCliente.Location = new System.Drawing.Point(123, 16);
            this.valorCliente.Name = "valorCliente";
            this.valorCliente.Size = new System.Drawing.Size(39, 13);
            this.valorCliente.TabIndex = 5;
            this.valorCliente.Text = "Cliente";
            // 
            // butaoEfetiva
            // 
            this.butaoEfetiva.Location = new System.Drawing.Point(22, 126);
            this.butaoEfetiva.Name = "butaoEfetiva";
            this.butaoEfetiva.Size = new System.Drawing.Size(111, 23);
            this.butaoEfetiva.TabIndex = 6;
            this.butaoEfetiva.Text = "Efetivar Compra";
            this.butaoEfetiva.UseVisualStyleBackColor = true;
            this.butaoEfetiva.Click += new System.EventHandler(this.butaoEfetiva_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(181, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormularioPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 159);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butaoEfetiva);
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
        private System.Windows.Forms.Button butaoEfetiva;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label valorPreco;
        private System.Windows.Forms.Label valorVeiculo;
        private System.Windows.Forms.Label valorVendedor;
        private System.Windows.Forms.Label valorCliente;
    }
}