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
            this.label5 = new System.Windows.Forms.Label();
            this.groupPagamento = new System.Windows.Forms.GroupBox();
            this.comboPagamento = new System.Windows.Forms.ComboBox();
            this.valorPreco = new System.Windows.Forms.Label();
            this.valorVeiculo = new System.Windows.Forms.Label();
            this.valorVendedor = new System.Windows.Forms.Label();
            this.valorCliente = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Forma de Pagamento: ";
            // 
            // groupPagamento
            // 
            this.groupPagamento.Controls.Add(this.comboPagamento);
            this.groupPagamento.Controls.Add(this.valorPreco);
            this.groupPagamento.Controls.Add(this.valorVeiculo);
            this.groupPagamento.Controls.Add(this.valorVendedor);
            this.groupPagamento.Controls.Add(this.valorCliente);
            this.groupPagamento.Controls.Add(this.labelCliente);
            this.groupPagamento.Controls.Add(this.label5);
            this.groupPagamento.Controls.Add(this.labelVendedor);
            this.groupPagamento.Controls.Add(this.labelValor);
            this.groupPagamento.Controls.Add(this.labelVeiculo);
            this.groupPagamento.Location = new System.Drawing.Point(13, 13);
            this.groupPagamento.Name = "groupPagamento";
            this.groupPagamento.Size = new System.Drawing.Size(259, 127);
            this.groupPagamento.TabIndex = 5;
            this.groupPagamento.TabStop = false;
            this.groupPagamento.Text = "Pagamento";
            // 
            // comboPagamento
            // 
            this.comboPagamento.FormattingEnabled = true;
            this.comboPagamento.Location = new System.Drawing.Point(126, 105);
            this.comboPagamento.Name = "comboPagamento";
            this.comboPagamento.Size = new System.Drawing.Size(121, 21);
            this.comboPagamento.TabIndex = 9;
            // 
            // valorPreco
            // 
            this.valorPreco.AutoSize = true;
            this.valorPreco.Location = new System.Drawing.Point(69, 86);
            this.valorPreco.Name = "valorPreco";
            this.valorPreco.Size = new System.Drawing.Size(35, 13);
            this.valorPreco.TabIndex = 8;
            this.valorPreco.Text = "Preco";
            // 
            // valorVeiculo
            // 
            this.valorVeiculo.AutoSize = true;
            this.valorVeiculo.Location = new System.Drawing.Point(69, 64);
            this.valorVeiculo.Name = "valorVeiculo";
            this.valorVeiculo.Size = new System.Drawing.Size(42, 13);
            this.valorVeiculo.TabIndex = 7;
            this.valorVeiculo.Text = "Veiculo";
            // 
            // valorVendedor
            // 
            this.valorVendedor.AutoSize = true;
            this.valorVendedor.Location = new System.Drawing.Point(69, 40);
            this.valorVendedor.Name = "valorVendedor";
            this.valorVendedor.Size = new System.Drawing.Size(53, 13);
            this.valorVendedor.TabIndex = 6;
            this.valorVendedor.Text = "Vendedor";
            // 
            // valorCliente
            // 
            this.valorCliente.AutoSize = true;
            this.valorCliente.Location = new System.Drawing.Point(69, 16);
            this.valorCliente.Name = "valorCliente";
            this.valorCliente.Size = new System.Drawing.Size(39, 13);
            this.valorCliente.TabIndex = 5;
            this.valorCliente.Text = "Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Efetivar Pagamento";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 147);
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
            this.ClientSize = new System.Drawing.Size(284, 175);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupPagamento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboPagamento;
        private System.Windows.Forms.Label valorPreco;
        private System.Windows.Forms.Label valorVeiculo;
        private System.Windows.Forms.Label valorVendedor;
        private System.Windows.Forms.Label valorCliente;
    }
}