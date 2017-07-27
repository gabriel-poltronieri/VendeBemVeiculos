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
            this.textoCliente = new System.Windows.Forms.TextBox();
            this.botaoBuscaCliente = new System.Windows.Forms.Button();
            this.comboVendedor = new System.Windows.Forms.ComboBox();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.botaoPagamento = new System.Windows.Forms.Button();
            this.textoVeiculo = new System.Windows.Forms.TextBox();
            this.botaoVeiculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupClienteVendedor.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(122, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(107, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Vende Bem Veículos";
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.Location = new System.Drawing.Point(17, 32);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(53, 13);
            this.labelVendedor.TabIndex = 1;
            this.labelVendedor.Text = "Vendedor";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Location = new System.Drawing.Point(17, 71);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(39, 13);
            this.labelCliente.TabIndex = 2;
            this.labelCliente.Text = "Cliente";
            // 
            // groupClienteVendedor
            // 
            this.groupClienteVendedor.Controls.Add(this.textoVeiculo);
            this.groupClienteVendedor.Controls.Add(this.botaoVeiculo);
            this.groupClienteVendedor.Controls.Add(this.label1);
            this.groupClienteVendedor.Controls.Add(this.botaoCancelar);
            this.groupClienteVendedor.Controls.Add(this.textoCliente);
            this.groupClienteVendedor.Controls.Add(this.botaoPagamento);
            this.groupClienteVendedor.Controls.Add(this.botaoBuscaCliente);
            this.groupClienteVendedor.Controls.Add(this.comboVendedor);
            this.groupClienteVendedor.Controls.Add(this.labelVendedor);
            this.groupClienteVendedor.Controls.Add(this.labelCliente);
            this.groupClienteVendedor.Location = new System.Drawing.Point(12, 25);
            this.groupClienteVendedor.Name = "groupClienteVendedor";
            this.groupClienteVendedor.Size = new System.Drawing.Size(349, 232);
            this.groupClienteVendedor.TabIndex = 3;
            this.groupClienteVendedor.TabStop = false;
            this.groupClienteVendedor.Text = "Envolvidos";
            // 
            // textoCliente
            // 
            this.textoCliente.Location = new System.Drawing.Point(89, 68);
            this.textoCliente.Name = "textoCliente";
            this.textoCliente.ReadOnly = true;
            this.textoCliente.Size = new System.Drawing.Size(249, 20);
            this.textoCliente.TabIndex = 7;
            this.textoCliente.Text = "Cliente";
            // 
            // botaoBuscaCliente
            // 
            this.botaoBuscaCliente.Location = new System.Drawing.Point(239, 105);
            this.botaoBuscaCliente.Name = "botaoBuscaCliente";
            this.botaoBuscaCliente.Size = new System.Drawing.Size(99, 23);
            this.botaoBuscaCliente.TabIndex = 6;
            this.botaoBuscaCliente.Text = "Buscar Cliente";
            this.botaoBuscaCliente.UseVisualStyleBackColor = true;
            // 
            // comboVendedor
            // 
            this.comboVendedor.FormattingEnabled = true;
            this.comboVendedor.Location = new System.Drawing.Point(89, 29);
            this.comboVendedor.Name = "comboVendedor";
            this.comboVendedor.Size = new System.Drawing.Size(249, 21);
            this.comboVendedor.TabIndex = 4;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Location = new System.Drawing.Point(202, 203);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.botaoCancelar.TabIndex = 18;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            // 
            // botaoPagamento
            // 
            this.botaoPagamento.Location = new System.Drawing.Point(56, 203);
            this.botaoPagamento.Name = "botaoPagamento";
            this.botaoPagamento.Size = new System.Drawing.Size(75, 23);
            this.botaoPagamento.TabIndex = 17;
            this.botaoPagamento.Text = "Pagamento";
            this.botaoPagamento.UseVisualStyleBackColor = true;
            // 
            // textoVeiculo
            // 
            this.textoVeiculo.Location = new System.Drawing.Point(89, 145);
            this.textoVeiculo.Name = "textoVeiculo";
            this.textoVeiculo.ReadOnly = true;
            this.textoVeiculo.Size = new System.Drawing.Size(249, 20);
            this.textoVeiculo.TabIndex = 21;
            this.textoVeiculo.Text = "Veiculo";
            // 
            // botaoVeiculo
            // 
            this.botaoVeiculo.Location = new System.Drawing.Point(239, 171);
            this.botaoVeiculo.Name = "botaoVeiculo";
            this.botaoVeiculo.Size = new System.Drawing.Size(99, 23);
            this.botaoVeiculo.TabIndex = 20;
            this.botaoVeiculo.Text = "Buscar Veiculo";
            this.botaoVeiculo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Veiculo";
            // 
            // FormularioVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 256);
            this.Controls.Add(this.groupClienteVendedor);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormularioVenda";
            this.Text = "Dados da venda";
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
        private System.Windows.Forms.Button botaoBuscaCliente;
        private System.Windows.Forms.TextBox textoVeiculo;
        private System.Windows.Forms.Button botaoVeiculo;
        private System.Windows.Forms.Label label1;
    }
}

