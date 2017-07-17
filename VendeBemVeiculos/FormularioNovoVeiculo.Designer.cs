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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboVeiculo = new System.Windows.Forms.ComboBox();
            this.TextoMarca = new System.Windows.Forms.TextBox();
            this.TextoModelo = new System.Windows.Forms.TextBox();
            this.TextoAno = new System.Windows.Forms.TextBox();
            this.TextoPreco = new System.Windows.Forms.TextBox();
            this.TextoQuantidade = new System.Windows.Forms.TextBox();
            this.BotaoAdicionar = new System.Windows.Forms.Button();
            this.BotaoCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veículo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Marca:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ano:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Preço:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Quantidade:";
            // 
            // ComboVeiculo
            // 
            this.ComboVeiculo.FormattingEnabled = true;
            this.ComboVeiculo.Location = new System.Drawing.Point(91, 6);
            this.ComboVeiculo.Name = "ComboVeiculo";
            this.ComboVeiculo.Size = new System.Drawing.Size(181, 21);
            this.ComboVeiculo.TabIndex = 6;
            this.ComboVeiculo.SelectedIndexChanged += new System.EventHandler(this.comboVeiculo_SelectedIndexChanged);
            // 
            // TextoMarca
            // 
            this.TextoMarca.Location = new System.Drawing.Point(91, 31);
            this.TextoMarca.Name = "TextoMarca";
            this.TextoMarca.Size = new System.Drawing.Size(181, 20);
            this.TextoMarca.TabIndex = 7;
            // 
            // TextoModelo
            // 
            this.TextoModelo.Location = new System.Drawing.Point(91, 57);
            this.TextoModelo.Name = "TextoModelo";
            this.TextoModelo.Size = new System.Drawing.Size(181, 20);
            this.TextoModelo.TabIndex = 8;
            // 
            // TextoAno
            // 
            this.TextoAno.Location = new System.Drawing.Point(91, 83);
            this.TextoAno.Name = "TextoAno";
            this.TextoAno.Size = new System.Drawing.Size(181, 20);
            this.TextoAno.TabIndex = 9;
            // 
            // TextoPreco
            // 
            this.TextoPreco.Location = new System.Drawing.Point(91, 109);
            this.TextoPreco.Name = "TextoPreco";
            this.TextoPreco.Size = new System.Drawing.Size(181, 20);
            this.TextoPreco.TabIndex = 10;
            // 
            // TextoQuantidade
            // 
            this.TextoQuantidade.Location = new System.Drawing.Point(91, 135);
            this.TextoQuantidade.Name = "TextoQuantidade";
            this.TextoQuantidade.Size = new System.Drawing.Size(181, 20);
            this.TextoQuantidade.TabIndex = 11;
            // 
            // BotaoAdicionar
            // 
            this.BotaoAdicionar.Location = new System.Drawing.Point(43, 161);
            this.BotaoAdicionar.Name = "BotaoAdicionar";
            this.BotaoAdicionar.Size = new System.Drawing.Size(75, 23);
            this.BotaoAdicionar.TabIndex = 12;
            this.BotaoAdicionar.Text = "Adicionar";
            this.BotaoAdicionar.UseVisualStyleBackColor = true;
            this.BotaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // BotaoCancelar
            // 
            this.BotaoCancelar.Location = new System.Drawing.Point(179, 161);
            this.BotaoCancelar.Name = "BotaoCancelar";
            this.BotaoCancelar.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancelar.TabIndex = 13;
            this.BotaoCancelar.Text = "Cancelar";
            this.BotaoCancelar.UseVisualStyleBackColor = true;
            this.BotaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // FormularioNovoVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 190);
            this.Controls.Add(this.BotaoCancelar);
            this.Controls.Add(this.BotaoAdicionar);
            this.Controls.Add(this.TextoQuantidade);
            this.Controls.Add(this.TextoPreco);
            this.Controls.Add(this.TextoAno);
            this.Controls.Add(this.TextoModelo);
            this.Controls.Add(this.TextoMarca);
            this.Controls.Add(this.ComboVeiculo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioNovoVeiculo";
            this.Load += new System.EventHandler(this.FormulárioNovoVeiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboVeiculo;
        private System.Windows.Forms.TextBox TextoMarca;
        private System.Windows.Forms.TextBox TextoModelo;
        private System.Windows.Forms.TextBox TextoAno;
        private System.Windows.Forms.TextBox TextoPreco;
        private System.Windows.Forms.TextBox TextoQuantidade;
        private System.Windows.Forms.Button BotaoAdicionar;
        private System.Windows.Forms.Button BotaoCancelar;
    }
}