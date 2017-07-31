namespace VendeBemVeiculos
{
    partial class FormularioNovoVeiculo
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
            this.labelVeiculo = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.comboVeiculo = new System.Windows.Forms.ComboBox();
            this.textoMarca = new System.Windows.Forms.TextBox();
            this.textoModelo = new System.Windows.Forms.TextBox();
            this.textoAno = new System.Windows.Forms.TextBox();
            this.textoPreco = new System.Windows.Forms.TextBox();
            this.botaoAdicionar = new System.Windows.Forms.Button();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelVeiculo
            // 
            this.labelVeiculo.AutoSize = true;
            this.labelVeiculo.Location = new System.Drawing.Point(31, 58);
            this.labelVeiculo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelVeiculo.Name = "labelVeiculo";
            this.labelVeiculo.Size = new System.Drawing.Size(69, 20);
            this.labelVeiculo.TabIndex = 0;
            this.labelVeiculo.Text = "Veículo:";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(35, 137);
            this.labelModelo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(68, 20);
            this.labelModelo.TabIndex = 1;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(43, 97);
            this.labelMarca.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(61, 20);
            this.labelMarca.TabIndex = 2;
            this.labelMarca.Text = "Marca:";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(61, 177);
            this.labelAno.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(43, 20);
            this.labelAno.TabIndex = 3;
            this.labelAno.Text = "Ano:";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(46, 217);
            this.labelPreco.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(58, 20);
            this.labelPreco.TabIndex = 4;
            this.labelPreco.Text = "Preço:";
            // 
            // comboVeiculo
            // 
            this.comboVeiculo.FormattingEnabled = true;
            this.comboVeiculo.Location = new System.Drawing.Point(131, 53);
            this.comboVeiculo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.comboVeiculo.Name = "comboVeiculo";
            this.comboVeiculo.Size = new System.Drawing.Size(299, 28);
            this.comboVeiculo.TabIndex = 6;
            // 
            // textoMarca
            // 
            this.textoMarca.Location = new System.Drawing.Point(131, 92);
            this.textoMarca.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textoMarca.Name = "textoMarca";
            this.textoMarca.Size = new System.Drawing.Size(299, 26);
            this.textoMarca.TabIndex = 7;
            // 
            // textoModelo
            // 
            this.textoModelo.Location = new System.Drawing.Point(131, 132);
            this.textoModelo.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textoModelo.Name = "textoModelo";
            this.textoModelo.Size = new System.Drawing.Size(299, 26);
            this.textoModelo.TabIndex = 8;
            // 
            // textoAno
            // 
            this.textoAno.Location = new System.Drawing.Point(131, 172);
            this.textoAno.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textoAno.Name = "textoAno";
            this.textoAno.Size = new System.Drawing.Size(299, 26);
            this.textoAno.TabIndex = 9;
            // 
            // textoPreco
            // 
            this.textoPreco.Location = new System.Drawing.Point(131, 212);
            this.textoPreco.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textoPreco.Name = "textoPreco";
            this.textoPreco.Size = new System.Drawing.Size(299, 26);
            this.textoPreco.TabIndex = 10;
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.Location = new System.Drawing.Point(65, 267);
            this.botaoAdicionar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(125, 35);
            this.botaoAdicionar.TabIndex = 12;
            this.botaoAdicionar.Text = "Adicionar";
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.BotaoAdicionar_Click);
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Location = new System.Drawing.Point(291, 267);
            this.botaoCancelar.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(125, 35);
            this.botaoCancelar.TabIndex = 13;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            this.botaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(156, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(140, 25);
            this.labelTitulo.TabIndex = 14;
            this.labelTitulo.Text = "Novo Veículo";
            // 
            // FormularioNovoVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 339);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoAdicionar);
            this.Controls.Add(this.textoPreco);
            this.Controls.Add(this.textoAno);
            this.Controls.Add(this.textoModelo);
            this.Controls.Add(this.textoMarca);
            this.Controls.Add(this.comboVeiculo);
            this.Controls.Add(this.labelPreco);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelVeiculo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FormularioNovoVeiculo";
            this.Text = "Vende Bem Veículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVeiculo;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.ComboBox comboVeiculo;
        private System.Windows.Forms.TextBox textoMarca;
        private System.Windows.Forms.TextBox textoModelo;
        private System.Windows.Forms.TextBox textoAno;
        private System.Windows.Forms.TextBox textoPreco;
        private System.Windows.Forms.Button botaoAdicionar;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Label labelTitulo;
    }
}