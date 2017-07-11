﻿namespace VendeBemVeiculos
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
            this.comboVendedor = new System.Windows.Forms.ComboBox();
            this.groupVeiculo = new System.Windows.Forms.GroupBox();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.botaoPagamento = new System.Windows.Forms.Button();
            this.labelValor = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.comboAno = new System.Windows.Forms.ComboBox();
            this.comboModelo = new System.Windows.Forms.ComboBox();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.comboVeiculo = new System.Windows.Forms.ComboBox();
            this.labelAno = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelVeiculo = new System.Windows.Forms.Label();
            this.botaoBuscaCliente = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.groupClienteVendedor.Controls.Add(this.textBox1);
            this.groupClienteVendedor.Controls.Add(this.botaoBuscaCliente);
            this.groupClienteVendedor.Controls.Add(this.comboVendedor);
            this.groupClienteVendedor.Controls.Add(this.labelVendedor);
            this.groupClienteVendedor.Controls.Add(this.labelCliente);
            this.groupClienteVendedor.Location = new System.Drawing.Point(12, 25);
            this.groupClienteVendedor.Name = "groupClienteVendedor";
            this.groupClienteVendedor.Size = new System.Drawing.Size(349, 145);
            this.groupClienteVendedor.TabIndex = 3;
            this.groupClienteVendedor.TabStop = false;
            this.groupClienteVendedor.Text = "Cliente/Vendedor";
            // 
            // comboVendedor
            // 
            this.comboVendedor.FormattingEnabled = true;
            this.comboVendedor.Location = new System.Drawing.Point(89, 29);
            this.comboVendedor.Name = "comboVendedor";
            this.comboVendedor.Size = new System.Drawing.Size(249, 21);
            this.comboVendedor.TabIndex = 4;
            this.comboVendedor.SelectedIndexChanged += new System.EventHandler(this.comboVendedor_SelectedIndexChanged);
            // 
            // groupVeiculo
            // 
            this.groupVeiculo.Controls.Add(this.botaoCancelar);
            this.groupVeiculo.Controls.Add(this.botaoPagamento);
            this.groupVeiculo.Controls.Add(this.labelValor);
            this.groupVeiculo.Controls.Add(this.labelPreco);
            this.groupVeiculo.Controls.Add(this.comboAno);
            this.groupVeiculo.Controls.Add(this.comboModelo);
            this.groupVeiculo.Controls.Add(this.comboMarca);
            this.groupVeiculo.Controls.Add(this.comboVeiculo);
            this.groupVeiculo.Controls.Add(this.labelAno);
            this.groupVeiculo.Controls.Add(this.labelModelo);
            this.groupVeiculo.Controls.Add(this.labelMarca);
            this.groupVeiculo.Controls.Add(this.labelVeiculo);
            this.groupVeiculo.Location = new System.Drawing.Point(12, 176);
            this.groupVeiculo.Name = "groupVeiculo";
            this.groupVeiculo.Size = new System.Drawing.Size(349, 162);
            this.groupVeiculo.TabIndex = 4;
            this.groupVeiculo.TabStop = false;
            this.groupVeiculo.Text = "Veículo";
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Location = new System.Drawing.Point(221, 122);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.botaoCancelar.TabIndex = 18;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // botaoPagamento
            // 
            this.botaoPagamento.Location = new System.Drawing.Point(67, 122);
            this.botaoPagamento.Name = "botaoPagamento";
            this.botaoPagamento.Size = new System.Drawing.Size(75, 23);
            this.botaoPagamento.TabIndex = 17;
            this.botaoPagamento.Text = "Pagamento";
            this.botaoPagamento.UseVisualStyleBackColor = true;
            this.botaoPagamento.Click += new System.EventHandler(this.botaoPagamento_Click);
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Location = new System.Drawing.Point(178, 94);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(36, 13);
            this.labelValor.TabIndex = 16;
            this.labelValor.Text = "R$ ----";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(140, 94);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(35, 13);
            this.labelPreco.TabIndex = 15;
            this.labelPreco.Text = "Preço";
            // 
            // comboAno
            // 
            this.comboAno.FormattingEnabled = true;
            this.comboAno.Location = new System.Drawing.Point(239, 54);
            this.comboAno.Name = "comboAno";
            this.comboAno.Size = new System.Drawing.Size(99, 21);
            this.comboAno.TabIndex = 13;
            this.comboAno.SelectedIndexChanged += new System.EventHandler(this.comboAno_SelectedIndexChanged);
            // 
            // comboModelo
            // 
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Location = new System.Drawing.Point(67, 54);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(108, 21);
            this.comboModelo.TabIndex = 12;
            this.comboModelo.SelectedIndexChanged += new System.EventHandler(this.comboModelo_SelectedIndexChanged);
            // 
            // comboMarca
            // 
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(239, 27);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(99, 21);
            this.comboMarca.TabIndex = 11;
            this.comboMarca.SelectedIndexChanged += new System.EventHandler(this.comboMarca_SelectedIndexChanged);
            // 
            // comboVeiculo
            // 
            this.comboVeiculo.FormattingEnabled = true;
            this.comboVeiculo.Location = new System.Drawing.Point(67, 27);
            this.comboVeiculo.Name = "comboVeiculo";
            this.comboVeiculo.Size = new System.Drawing.Size(108, 21);
            this.comboVeiculo.TabIndex = 10;
            this.comboVeiculo.SelectedIndexChanged += new System.EventHandler(this.comboVeiculo_SelectedIndexChanged);
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(207, 57);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(26, 13);
            this.labelAno.TabIndex = 9;
            this.labelAno.Text = "Ano";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(17, 57);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(42, 13);
            this.labelModelo.TabIndex = 8;
            this.labelModelo.Text = "Modelo";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(196, 30);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(37, 13);
            this.labelMarca.TabIndex = 7;
            this.labelMarca.Text = "Marca";
            // 
            // labelVeiculo
            // 
            this.labelVeiculo.AutoSize = true;
            this.labelVeiculo.Location = new System.Drawing.Point(17, 30);
            this.labelVeiculo.Name = "labelVeiculo";
            this.labelVeiculo.Size = new System.Drawing.Size(44, 13);
            this.labelVeiculo.TabIndex = 6;
            this.labelVeiculo.Text = "Veículo";
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(249, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "Cliente";
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
        private System.Windows.Forms.ComboBox comboVendedor;
        private System.Windows.Forms.GroupBox groupVeiculo;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.ComboBox comboAno;
        private System.Windows.Forms.ComboBox comboModelo;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Button botaoPagamento;
        private System.Windows.Forms.ComboBox comboVeiculo;
        private System.Windows.Forms.Label labelVeiculo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button botaoBuscaCliente;
    }
}

