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
            this.botaoCancela = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.groupPagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(29, 25);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(66, 20);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = "Cliente:";
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.Location = new System.Drawing.Point(10, 61);
            this.labelVendedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(85, 20);
            this.labelVendedor.TabIndex = 1;
            this.labelVendedor.Text = "Vendedor:";
            // 
            // labelVeiculo
            // 
            this.labelVeiculo.AutoSize = true;
            this.labelVeiculo.Location = new System.Drawing.Point(26, 99);
            this.labelVeiculo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelVeiculo.Name = "labelVeiculo";
            this.labelVeiculo.Size = new System.Drawing.Size(69, 20);
            this.labelVeiculo.TabIndex = 2;
            this.labelVeiculo.Text = "Veículo:";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(37, 132);
            this.labelValor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(58, 20);
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
            this.groupPagamento.Location = new System.Drawing.Point(13, 44);
            this.groupPagamento.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupPagamento.Name = "groupPagamento";
            this.groupPagamento.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupPagamento.Size = new System.Drawing.Size(435, 165);
            this.groupPagamento.TabIndex = 5;
            this.groupPagamento.TabStop = false;
            this.groupPagamento.Text = "Pagamento";
            // 
            // valorPreco
            // 
            this.valorPreco.AutoSize = true;
            this.valorPreco.Location = new System.Drawing.Point(133, 132);
            this.valorPreco.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.valorPreco.Name = "valorPreco";
            this.valorPreco.Size = new System.Drawing.Size(53, 20);
            this.valorPreco.TabIndex = 8;
            this.valorPreco.Text = "Preco";
            // 
            // valorVeiculo
            // 
            this.valorVeiculo.AutoSize = true;
            this.valorVeiculo.Location = new System.Drawing.Point(133, 99);
            this.valorVeiculo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.valorVeiculo.Name = "valorVeiculo";
            this.valorVeiculo.Size = new System.Drawing.Size(64, 20);
            this.valorVeiculo.TabIndex = 7;
            this.valorVeiculo.Text = "Veiculo";
            // 
            // valorVendedor
            // 
            this.valorVendedor.AutoSize = true;
            this.valorVendedor.Location = new System.Drawing.Point(133, 61);
            this.valorVendedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.valorVendedor.Name = "valorVendedor";
            this.valorVendedor.Size = new System.Drawing.Size(80, 20);
            this.valorVendedor.TabIndex = 6;
            this.valorVendedor.Text = "Vendedor";
            // 
            // valorCliente
            // 
            this.valorCliente.AutoSize = true;
            this.valorCliente.Location = new System.Drawing.Point(133, 25);
            this.valorCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.valorCliente.Name = "valorCliente";
            this.valorCliente.Size = new System.Drawing.Size(61, 20);
            this.valorCliente.TabIndex = 5;
            this.valorCliente.Text = "Cliente";
            // 
            // butaoEfetiva
            // 
            this.butaoEfetiva.Location = new System.Drawing.Point(25, 229);
            this.butaoEfetiva.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.butaoEfetiva.Name = "butaoEfetiva";
            this.butaoEfetiva.Size = new System.Drawing.Size(185, 35);
            this.butaoEfetiva.TabIndex = 6;
            this.butaoEfetiva.Text = "Efetivar Compra";
            this.butaoEfetiva.UseVisualStyleBackColor = true;
            this.butaoEfetiva.Click += new System.EventHandler(this.BotaoEfetiva_Click);
            // 
            // botaoCancela
            // 
            this.botaoCancela.Location = new System.Drawing.Point(299, 229);
            this.botaoCancela.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.botaoCancela.Name = "botaoCancela";
            this.botaoCancela.Size = new System.Drawing.Size(125, 35);
            this.botaoCancela.TabIndex = 7;
            this.botaoCancela.Text = "Cancelar";
            this.botaoCancela.UseVisualStyleBackColor = true;
            this.botaoCancela.Click += new System.EventHandler(this.BotaoCancela_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(98, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(246, 25);
            this.labelTitulo.TabIndex = 8;
            this.labelTitulo.Text = "Confirmação de Compra";
            // 
            // FormularioPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 283);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.botaoCancela);
            this.Controls.Add(this.butaoEfetiva);
            this.Controls.Add(this.groupPagamento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormularioPagamento";
            this.Text = "Vende Bem Veículos";
            this.groupPagamento.ResumeLayout(false);
            this.groupPagamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelVeiculo;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.GroupBox groupPagamento;
        private System.Windows.Forms.Button butaoEfetiva;
        private System.Windows.Forms.Button botaoCancela;
        private System.Windows.Forms.Label valorPreco;
        private System.Windows.Forms.Label valorVeiculo;
        private System.Windows.Forms.Label valorVendedor;
        private System.Windows.Forms.Label valorCliente;
        private System.Windows.Forms.Label labelTitulo;
    }
}