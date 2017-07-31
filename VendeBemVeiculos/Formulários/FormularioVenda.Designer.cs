namespace VendeBemVeiculos
{
    partial class FormularioVenda
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
            this.labelVendedor = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.groupClienteVendedor = new System.Windows.Forms.GroupBox();
            this.textoVeiculo = new System.Windows.Forms.TextBox();
            this.botaoVeiculo = new System.Windows.Forms.Button();
            this.labelVeiculo = new System.Windows.Forms.Label();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.textoCliente = new System.Windows.Forms.TextBox();
            this.botaoPagamento = new System.Windows.Forms.Button();
            this.botaoBuscarCliente = new System.Windows.Forms.Button();
            this.comboVendedor = new System.Windows.Forms.ComboBox();
            this.groupClienteVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(218, 9);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(213, 25);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Vende Bem Veículos";
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.Location = new System.Drawing.Point(20, 47);
            this.labelVendedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(85, 20);
            this.labelVendedor.TabIndex = 1;
            this.labelVendedor.Text = "Vendedor:";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(39, 106);
            this.labelCliente.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(66, 20);
            this.labelCliente.TabIndex = 2;
            this.labelCliente.Text = "Cliente:";
            // 
            // groupClienteVendedor
            // 
            this.groupClienteVendedor.Controls.Add(this.textoVeiculo);
            this.groupClienteVendedor.Controls.Add(this.botaoVeiculo);
            this.groupClienteVendedor.Controls.Add(this.labelVeiculo);
            this.groupClienteVendedor.Controls.Add(this.botaoCancelar);
            this.groupClienteVendedor.Controls.Add(this.textoCliente);
            this.groupClienteVendedor.Controls.Add(this.botaoPagamento);
            this.groupClienteVendedor.Controls.Add(this.botaoBuscarCliente);
            this.groupClienteVendedor.Controls.Add(this.comboVendedor);
            this.groupClienteVendedor.Controls.Add(this.labelVendedor);
            this.groupClienteVendedor.Controls.Add(this.labelCliente);
            this.groupClienteVendedor.Location = new System.Drawing.Point(25, 51);
            this.groupClienteVendedor.Margin = new System.Windows.Forms.Padding(5);
            this.groupClienteVendedor.Name = "groupClienteVendedor";
            this.groupClienteVendedor.Padding = new System.Windows.Forms.Padding(5);
            this.groupClienteVendedor.Size = new System.Drawing.Size(581, 390);
            this.groupClienteVendedor.TabIndex = 3;
            this.groupClienteVendedor.TabStop = false;
            this.groupClienteVendedor.Text = "Envolvidos";
            // 
            // textoVeiculo
            // 
            this.textoVeiculo.Location = new System.Drawing.Point(125, 221);
            this.textoVeiculo.Margin = new System.Windows.Forms.Padding(5);
            this.textoVeiculo.Name = "textoVeiculo";
            this.textoVeiculo.ReadOnly = true;
            this.textoVeiculo.Size = new System.Drawing.Size(413, 26);
            this.textoVeiculo.TabIndex = 21;
            this.textoVeiculo.Text = "Selecione um Veículo";
            // 
            // botaoVeiculo
            // 
            this.botaoVeiculo.Location = new System.Drawing.Point(375, 267);
            this.botaoVeiculo.Margin = new System.Windows.Forms.Padding(5);
            this.botaoVeiculo.Name = "botaoVeiculo";
            this.botaoVeiculo.Size = new System.Drawing.Size(165, 35);
            this.botaoVeiculo.TabIndex = 20;
            this.botaoVeiculo.Text = "Buscar Veiculo";
            this.botaoVeiculo.UseVisualStyleBackColor = true;
            this.botaoVeiculo.Click += new System.EventHandler(this.BotaoBucaVeiculo_Click);
            // 
            // labelVeiculo
            // 
            this.labelVeiculo.AutoSize = true;
            this.labelVeiculo.Location = new System.Drawing.Point(36, 226);
            this.labelVeiculo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelVeiculo.Name = "labelVeiculo";
            this.labelVeiculo.Size = new System.Drawing.Size(69, 20);
            this.labelVeiculo.TabIndex = 19;
            this.labelVeiculo.Text = "Veiculo:";
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Location = new System.Drawing.Point(342, 331);
            this.botaoCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(125, 35);
            this.botaoCancelar.TabIndex = 18;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            this.botaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // textoCliente
            // 
            this.textoCliente.Location = new System.Drawing.Point(125, 104);
            this.textoCliente.Margin = new System.Windows.Forms.Padding(5);
            this.textoCliente.Name = "textoCliente";
            this.textoCliente.ReadOnly = true;
            this.textoCliente.Size = new System.Drawing.Size(413, 26);
            this.textoCliente.TabIndex = 7;
            this.textoCliente.Text = "Selecione um Cliente";
            // 
            // botaoPagamento
            // 
            this.botaoPagamento.Location = new System.Drawing.Point(100, 331);
            this.botaoPagamento.Margin = new System.Windows.Forms.Padding(5);
            this.botaoPagamento.Name = "botaoPagamento";
            this.botaoPagamento.Size = new System.Drawing.Size(125, 35);
            this.botaoPagamento.TabIndex = 17;
            this.botaoPagamento.Text = "Pagamento";
            this.botaoPagamento.UseVisualStyleBackColor = true;
            this.botaoPagamento.Click += new System.EventHandler(this.BotaoPagamento_Click);
            // 
            // botaoBuscarCliente
            // 
            this.botaoBuscarCliente.Location = new System.Drawing.Point(375, 160);
            this.botaoBuscarCliente.Margin = new System.Windows.Forms.Padding(5);
            this.botaoBuscarCliente.Name = "botaoBuscarCliente";
            this.botaoBuscarCliente.Size = new System.Drawing.Size(165, 35);
            this.botaoBuscarCliente.TabIndex = 6;
            this.botaoBuscarCliente.Text = "Buscar Cliente";
            this.botaoBuscarCliente.UseVisualStyleBackColor = true;
            this.botaoBuscarCliente.Click += new System.EventHandler(this.BotaoBuscaCliente_Click);
            // 
            // comboVendedor
            // 
            this.comboVendedor.FormattingEnabled = true;
            this.comboVendedor.Location = new System.Drawing.Point(125, 44);
            this.comboVendedor.Margin = new System.Windows.Forms.Padding(5);
            this.comboVendedor.Name = "comboVendedor";
            this.comboVendedor.Size = new System.Drawing.Size(413, 28);
            this.comboVendedor.TabIndex = 4;
            this.comboVendedor.Text = "Escolha uma opção";
            this.comboVendedor.SelectedIndexChanged += new System.EventHandler(this.ComboVendedor_SelectedIndexChanged);
            // 
            // FormularioVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 471);
            this.Controls.Add(this.groupClienteVendedor);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormularioVenda";
            this.Text = "Vende Bem Veículos";
            this.groupClienteVendedor.ResumeLayout(false);
            this.groupClienteVendedor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.GroupBox groupClienteVendedor;
        private System.Windows.Forms.ComboBox comboVendedor;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Button botaoPagamento;
        private System.Windows.Forms.TextBox textoCliente;
        private System.Windows.Forms.Button botaoBuscarCliente;
        private System.Windows.Forms.TextBox textoVeiculo;
        private System.Windows.Forms.Button botaoVeiculo;
        private System.Windows.Forms.Label labelVeiculo;
    }
}

