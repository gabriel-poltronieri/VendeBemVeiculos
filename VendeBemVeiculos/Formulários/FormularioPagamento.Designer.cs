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
            this.labelValorPreco = new System.Windows.Forms.Label();
            this.labelValorVeiculo = new System.Windows.Forms.Label();
            this.labelValorVendedor = new System.Windows.Forms.Label();
            this.labelValorCliente = new System.Windows.Forms.Label();
            this.botaoEfetivar = new System.Windows.Forms.Button();
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
            this.groupPagamento.Controls.Add(this.labelValorPreco);
            this.groupPagamento.Controls.Add(this.labelValorVeiculo);
            this.groupPagamento.Controls.Add(this.labelValorVendedor);
            this.groupPagamento.Controls.Add(this.labelValorCliente);
            this.groupPagamento.Controls.Add(this.labelCliente);
            this.groupPagamento.Controls.Add(this.labelVendedor);
            this.groupPagamento.Controls.Add(this.labelValor);
            this.groupPagamento.Controls.Add(this.labelVeiculo);
            this.groupPagamento.Location = new System.Drawing.Point(13, 44);
            this.groupPagamento.Margin = new System.Windows.Forms.Padding(5);
            this.groupPagamento.Name = "groupPagamento";
            this.groupPagamento.Padding = new System.Windows.Forms.Padding(5);
            this.groupPagamento.Size = new System.Drawing.Size(435, 165);
            this.groupPagamento.TabIndex = 5;
            this.groupPagamento.TabStop = false;
            this.groupPagamento.Text = "Pagamento";
            // 
            // labelValorPreco
            // 
            this.labelValorPreco.AutoSize = true;
            this.labelValorPreco.Location = new System.Drawing.Point(133, 132);
            this.labelValorPreco.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelValorPreco.Name = "labelValorPreco";
            this.labelValorPreco.Size = new System.Drawing.Size(53, 20);
            this.labelValorPreco.TabIndex = 8;
            this.labelValorPreco.Text = "Preco";
            // 
            // labelValorVeiculo
            // 
            this.labelValorVeiculo.AutoSize = true;
            this.labelValorVeiculo.Location = new System.Drawing.Point(133, 99);
            this.labelValorVeiculo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelValorVeiculo.Name = "labelValorVeiculo";
            this.labelValorVeiculo.Size = new System.Drawing.Size(64, 20);
            this.labelValorVeiculo.TabIndex = 7;
            this.labelValorVeiculo.Text = "Veiculo";
            // 
            // labelValorVendedor
            // 
            this.labelValorVendedor.AutoSize = true;
            this.labelValorVendedor.Location = new System.Drawing.Point(133, 61);
            this.labelValorVendedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelValorVendedor.Name = "labelValorVendedor";
            this.labelValorVendedor.Size = new System.Drawing.Size(80, 20);
            this.labelValorVendedor.TabIndex = 6;
            this.labelValorVendedor.Text = "Vendedor";
            // 
            // labelValorCliente
            // 
            this.labelValorCliente.AutoSize = true;
            this.labelValorCliente.Location = new System.Drawing.Point(133, 25);
            this.labelValorCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelValorCliente.Name = "labelValorCliente";
            this.labelValorCliente.Size = new System.Drawing.Size(61, 20);
            this.labelValorCliente.TabIndex = 5;
            this.labelValorCliente.Text = "Cliente";
            // 
            // botaoEfetivar
            // 
            this.botaoEfetivar.Location = new System.Drawing.Point(25, 229);
            this.botaoEfetivar.Margin = new System.Windows.Forms.Padding(5);
            this.botaoEfetivar.Name = "botaoEfetivar";
            this.botaoEfetivar.Size = new System.Drawing.Size(185, 35);
            this.botaoEfetivar.TabIndex = 6;
            this.botaoEfetivar.Text = "Efetivar Compra";
            this.botaoEfetivar.UseVisualStyleBackColor = true;
            this.botaoEfetivar.Click += new System.EventHandler(this.BotaoEfetiva_Click);
            // 
            // botaoCancela
            // 
            this.botaoCancela.Location = new System.Drawing.Point(299, 229);
            this.botaoCancela.Margin = new System.Windows.Forms.Padding(5);
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
            this.Controls.Add(this.botaoEfetivar);
            this.Controls.Add(this.groupPagamento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
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
        private System.Windows.Forms.Button botaoEfetivar;
        private System.Windows.Forms.Button botaoCancela;
        private System.Windows.Forms.Label labelValorPreco;
        private System.Windows.Forms.Label labelValorVeiculo;
        private System.Windows.Forms.Label labelValorVendedor;
        private System.Windows.Forms.Label labelValorCliente;
        private System.Windows.Forms.Label labelTitulo;
    }
}