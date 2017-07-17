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
            this.TextoCliente = new System.Windows.Forms.TextBox();
            this.BotaoBuscaCliente = new System.Windows.Forms.Button();
            this.ComboVendedor = new System.Windows.Forms.ComboBox();
            this.groupVeiculo = new System.Windows.Forms.GroupBox();
            this.RadioMoto = new System.Windows.Forms.RadioButton();
            this.RadioCarro = new System.Windows.Forms.RadioButton();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.BotaoPagamento = new System.Windows.Forms.Button();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.ComboAno = new System.Windows.Forms.ComboBox();
            this.ComboModelo = new System.Windows.Forms.ComboBox();
            this.ComboMarca = new System.Windows.Forms.ComboBox();
            this.labelAno = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.groupClienteVendedor.SuspendLayout();
            this.groupVeiculo.SuspendLayout();
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
            this.groupClienteVendedor.Controls.Add(this.TextoCliente);
            this.groupClienteVendedor.Controls.Add(this.BotaoBuscaCliente);
            this.groupClienteVendedor.Controls.Add(this.ComboVendedor);
            this.groupClienteVendedor.Controls.Add(this.labelVendedor);
            this.groupClienteVendedor.Controls.Add(this.labelCliente);
            this.groupClienteVendedor.Location = new System.Drawing.Point(12, 25);
            this.groupClienteVendedor.Name = "groupClienteVendedor";
            this.groupClienteVendedor.Size = new System.Drawing.Size(349, 145);
            this.groupClienteVendedor.TabIndex = 3;
            this.groupClienteVendedor.TabStop = false;
            this.groupClienteVendedor.Text = "Cliente/Vendedor";
            // 
            // TextoCliente
            // 
            this.TextoCliente.Location = new System.Drawing.Point(89, 68);
            this.TextoCliente.Name = "TextoCliente";
            this.TextoCliente.ReadOnly = true;
            this.TextoCliente.Size = new System.Drawing.Size(249, 20);
            this.TextoCliente.TabIndex = 7;
            this.TextoCliente.Text = "Cliente";
            // 
            // BotaoBuscaCliente
            // 
            this.BotaoBuscaCliente.Location = new System.Drawing.Point(239, 105);
            this.BotaoBuscaCliente.Name = "BotaoBuscaCliente";
            this.BotaoBuscaCliente.Size = new System.Drawing.Size(99, 23);
            this.BotaoBuscaCliente.TabIndex = 6;
            this.BotaoBuscaCliente.Text = "Buscar Cliente";
            this.BotaoBuscaCliente.UseVisualStyleBackColor = true;
            this.BotaoBuscaCliente.Click += new System.EventHandler(this.BotaoBuscaCliente_Click);
            // 
            // ComboVendedor
            // 
            this.ComboVendedor.FormattingEnabled = true;
            this.ComboVendedor.Location = new System.Drawing.Point(89, 29);
            this.ComboVendedor.Name = "ComboVendedor";
            this.ComboVendedor.Size = new System.Drawing.Size(249, 21);
            this.ComboVendedor.TabIndex = 4;
            this.ComboVendedor.SelectedIndexChanged += new System.EventHandler(this.ComboVendedor_SelectedIndexChanged);
            // 
            // groupVeiculo
            // 
            this.groupVeiculo.Controls.Add(this.RadioMoto);
            this.groupVeiculo.Controls.Add(this.RadioCarro);
            this.groupVeiculo.Controls.Add(this.BotaoCancelar);
            this.groupVeiculo.Controls.Add(this.BotaoPagamento);
            this.groupVeiculo.Controls.Add(this.labelValor);
            this.groupVeiculo.Controls.Add(this.labelPreco);
            this.groupVeiculo.Controls.Add(this.ComboAno);
            this.groupVeiculo.Controls.Add(this.ComboModelo);
            this.groupVeiculo.Controls.Add(this.ComboMarca);
            this.groupVeiculo.Controls.Add(this.labelAno);
            this.groupVeiculo.Controls.Add(this.labelModelo);
            this.groupVeiculo.Controls.Add(this.labelMarca);
            this.groupVeiculo.Location = new System.Drawing.Point(12, 176);
            this.groupVeiculo.Name = "groupVeiculo";
            this.groupVeiculo.Size = new System.Drawing.Size(349, 162);
            this.groupVeiculo.TabIndex = 4;
            this.groupVeiculo.TabStop = false;
            this.groupVeiculo.Text = "Veículo";
            // 
            // RadioMoto
            // 
            this.RadioMoto.AutoSize = true;
            this.RadioMoto.Location = new System.Drawing.Point(221, 19);
            this.RadioMoto.Name = "RadioMoto";
            this.RadioMoto.Size = new System.Drawing.Size(49, 17);
            this.RadioMoto.TabIndex = 22;
            this.RadioMoto.Text = "Moto";
            this.RadioMoto.UseVisualStyleBackColor = true;
            this.RadioMoto.CheckedChanged += new System.EventHandler(this.RadioMoto_CheckedChanged);
            // 
            // RadioCarro
            // 
            this.RadioCarro.AutoSize = true;
            this.RadioCarro.Location = new System.Drawing.Point(67, 19);
            this.RadioCarro.Name = "RadioCarro";
            this.RadioCarro.Size = new System.Drawing.Size(50, 17);
            this.RadioCarro.TabIndex = 21;
            this.RadioCarro.Text = "Carro";
            this.RadioCarro.UseVisualStyleBackColor = true;
            this.RadioCarro.CheckedChanged += new System.EventHandler(this.RadioCarro_CheckedChanged);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(221, 122);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 18;
            this.BotaoCancelar.Text = "Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // BotaoPagamento
            // 
            this.BotaoPagamento.Location = new System.Drawing.Point(67, 122);
            this.BotaoPagamento.Name = "BotaoPagamento";
            this.BotaoPagamento.Size = new System.Drawing.Size(75, 23);
            this.BotaoPagamento.TabIndex = 17;
            this.BotaoPagamento.Text = "Pagamento";
            this.BotaoPagamento.UseVisualStyleBackColor = true;
            this.BotaoPagamento.Click += new System.EventHandler(this.BotaoPagamento_Click);
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(239, 77);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(36, 13);
            this.labelValor.TabIndex = 16;
            this.labelValor.Text = "R$ ----";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(198, 77);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(35, 13);
            this.labelPreco.TabIndex = 15;
            this.labelPreco.Text = "Preço";
            // 
            // ComboAno
            // 
            this.ComboAno.FormattingEnabled = true;
            this.ComboAno.Location = new System.Drawing.Point(67, 69);
            this.ComboAno.Name = "ComboAno";
            this.ComboAno.Size = new System.Drawing.Size(99, 21);
            this.ComboAno.TabIndex = 13;
            this.ComboAno.SelectedIndexChanged += new System.EventHandler(this.ComboAno_SelectedIndexChanged);
            // 
            // ComboModelo
            // 
            this.ComboModelo.FormattingEnabled = true;
            this.ComboModelo.Location = new System.Drawing.Point(239, 47);
            this.ComboModelo.Name = "ComboModelo";
            this.ComboModelo.Size = new System.Drawing.Size(104, 21);
            this.ComboModelo.TabIndex = 12;
            this.ComboModelo.SelectedIndexChanged += new System.EventHandler(this.ComboModelo_SelectedIndexChanged);
            // 
            // ComboMarca
            // 
            this.ComboMarca.FormattingEnabled = true;
            this.ComboMarca.Location = new System.Drawing.Point(67, 42);
            this.ComboMarca.Name = "ComboMarca";
            this.ComboMarca.Size = new System.Drawing.Size(99, 21);
            this.ComboMarca.TabIndex = 11;
            this.ComboMarca.SelectedIndexChanged += new System.EventHandler(this.ComboMarca_SelectedIndexChanged);
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(35, 72);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(26, 13);
            this.labelAno.TabIndex = 9;
            this.labelAno.Text = "Ano";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(191, 50);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(42, 13);
            this.labelModelo.TabIndex = 8;
            this.labelModelo.Text = "Modelo";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(24, 45);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 7;
            this.labelMarca.Text = "Marca";
            // 
            // FormularioVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 353);
            this.Controls.Add(this.groupVeiculo);
            this.Controls.Add(this.groupClienteVendedor);
            this.Controls.Add(this.labelTitulo);
            this.Name = "FormularioVenda";
            this.Text = "Dados da venda";
            this.Load += new System.EventHandler(this.FormularioVenda_Load);
            this.groupClienteVendedor.ResumeLayout(false);
            this.groupClienteVendedor.PerformLayout();
            this.groupVeiculo.ResumeLayout(false);
            this.groupVeiculo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.GroupBox groupClienteVendedor;
        private System.Windows.Forms.ComboBox ComboVendedor;
        private System.Windows.Forms.GroupBox groupVeiculo;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.ComboBox ComboAno;
        private System.Windows.Forms.ComboBox ComboModelo;
        private System.Windows.Forms.ComboBox ComboMarca;
        private System.Windows.Forms.Button BotaoCancelar;
        private System.Windows.Forms.Button BotaoPagamento;
        private System.Windows.Forms.TextBox TextoCliente;
        private System.Windows.Forms.Button BotaoBuscaCliente;
        private System.Windows.Forms.RadioButton RadioMoto;
        private System.Windows.Forms.RadioButton RadioCarro;
    }
}

