namespace VendeBemVeiculos
{
    partial class FormularioVeiculo
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
            this.botaoBuscar = new System.Windows.Forms.Button();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.botaoSeleciona = new System.Windows.Forms.Button();
            this.listaVeiculos = new System.Windows.Forms.ListBox();
            this.botaoNovo = new System.Windows.Forms.Button();
            this.botaoCancela = new System.Windows.Forms.Button();
            this.radioCarro = new System.Windows.Forms.RadioButton();
            this.radioMotos = new System.Windows.Forms.RadioButton();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.comboModelo = new System.Windows.Forms.ComboBox();
            this.comboAno = new System.Windows.Forms.ComboBox();
            this.labelMarca = new System.Windows.Forms.Label();
            this.labelModelo = new System.Windows.Forms.Label();
            this.labelAno = new System.Windows.Forms.Label();
            this.labelQuantidade = new System.Windows.Forms.Label();
            this.labelValorQuantidade = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botaoBuscar
            // 
            this.botaoBuscar.Location = new System.Drawing.Point(502, 170);
            this.botaoBuscar.Name = "botaoBuscar";
            this.botaoBuscar.Size = new System.Drawing.Size(75, 23);
            this.botaoBuscar.TabIndex = 11;
            this.botaoBuscar.Text = "Buscar";
            this.botaoBuscar.UseVisualStyleBackColor = true;
            this.botaoBuscar.Click += new System.EventHandler(this.BotaoBuscar_Click);
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Location = new System.Drawing.Point(302, 210);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(107, 33);
            this.botaoExcluir.TabIndex = 8;
            this.botaoExcluir.Text = "Excluir ";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Click += new System.EventHandler(this.BotaoExcluir_Click);
            // 
            // botaoSeleciona
            // 
            this.botaoSeleciona.Location = new System.Drawing.Point(44, 210);
            this.botaoSeleciona.Name = "botaoSeleciona";
            this.botaoSeleciona.Size = new System.Drawing.Size(100, 33);
            this.botaoSeleciona.TabIndex = 7;
            this.botaoSeleciona.Text = "Seleciona";
            this.botaoSeleciona.UseVisualStyleBackColor = true;
            // 
            // listaVeiculos
            // 
            this.listaVeiculos.FormattingEnabled = true;
            this.listaVeiculos.Location = new System.Drawing.Point(12, 12);
            this.listaVeiculos.Name = "listaVeiculos";
            this.listaVeiculos.Size = new System.Drawing.Size(342, 173);
            this.listaVeiculos.TabIndex = 6;
            this.listaVeiculos.SelectedIndexChanged += new System.EventHandler(this.ListaVeiculos_SelectedIndexChanged);
            // 
            // botaoNovo
            // 
            this.botaoNovo.Location = new System.Drawing.Point(170, 210);
            this.botaoNovo.Name = "botaoNovo";
            this.botaoNovo.Size = new System.Drawing.Size(107, 33);
            this.botaoNovo.TabIndex = 12;
            this.botaoNovo.Text = "Novo";
            this.botaoNovo.UseVisualStyleBackColor = true;
            this.botaoNovo.Click += new System.EventHandler(this.BotaoNovo_Click);
            // 
            // botaoCancela
            // 
            this.botaoCancela.Location = new System.Drawing.Point(437, 210);
            this.botaoCancela.Name = "botaoCancela";
            this.botaoCancela.Size = new System.Drawing.Size(107, 33);
            this.botaoCancela.TabIndex = 13;
            this.botaoCancela.Text = "Cancela";
            this.botaoCancela.UseVisualStyleBackColor = true;
            this.botaoCancela.Click += new System.EventHandler(this.BotaoCancela_Click);
            // 
            // radioCarro
            // 
            this.radioCarro.AutoSize = true;
            this.radioCarro.Location = new System.Drawing.Point(383, 26);
            this.radioCarro.Name = "radioCarro";
            this.radioCarro.Size = new System.Drawing.Size(55, 17);
            this.radioCarro.TabIndex = 14;
            this.radioCarro.Text = "Carros";
            this.radioCarro.UseVisualStyleBackColor = true;
            this.radioCarro.CheckedChanged += new System.EventHandler(this.RadioCarro_CheckedChanged);
            // 
            // radioMotos
            // 
            this.radioMotos.AutoSize = true;
            this.radioMotos.Location = new System.Drawing.Point(523, 26);
            this.radioMotos.Name = "radioMotos";
            this.radioMotos.Size = new System.Drawing.Size(54, 17);
            this.radioMotos.TabIndex = 15;
            this.radioMotos.TabStop = true;
            this.radioMotos.Text = "Motos";
            this.radioMotos.UseVisualStyleBackColor = true;
            this.radioMotos.CheckedChanged += new System.EventHandler(this.RadioMotos_CheckedChanged);
            // 
            // comboMarca
            // 
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(439, 66);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(121, 21);
            this.comboMarca.TabIndex = 16;
            this.comboMarca.SelectedIndexChanged += new System.EventHandler(this.ComboMarca_SelectedIndexChanged);
            // 
            // comboModelo
            // 
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Location = new System.Drawing.Point(439, 102);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(121, 21);
            this.comboModelo.TabIndex = 17;
            this.comboModelo.SelectedIndexChanged += new System.EventHandler(this.ComboModelo_SelectedIndexChanged);
            // 
            // comboAno
            // 
            this.comboAno.FormattingEnabled = true;
            this.comboAno.Location = new System.Drawing.Point(439, 143);
            this.comboAno.Name = "comboAno";
            this.comboAno.Size = new System.Drawing.Size(121, 21);
            this.comboAno.TabIndex = 18;
            this.comboAno.SelectedIndexChanged += new System.EventHandler(this.ComboAno_SelectedIndexChanged);
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(380, 69);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(40, 13);
            this.labelMarca.TabIndex = 19;
            this.labelMarca.Text = "Marca:";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(380, 105);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(45, 13);
            this.labelModelo.TabIndex = 20;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(380, 146);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(29, 13);
            this.labelAno.TabIndex = 21;
            this.labelAno.Text = "Ano:";
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(360, 175);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(65, 13);
            this.labelQuantidade.TabIndex = 22;
            this.labelQuantidade.Text = "Quantidade:";
            // 
            // labelValorQuantidade
            // 
            this.labelValorQuantidade.AutoSize = true;
            this.labelValorQuantidade.Location = new System.Drawing.Point(431, 175);
            this.labelValorQuantidade.Name = "labelValorQuantidade";
            this.labelValorQuantidade.Size = new System.Drawing.Size(0, 13);
            this.labelValorQuantidade.TabIndex = 23;
            // 
            // FormularioVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 255);
            this.Controls.Add(this.labelValorQuantidade);
            this.Controls.Add(this.labelQuantidade);
            this.Controls.Add(this.labelAno);
            this.Controls.Add(this.labelModelo);
            this.Controls.Add(this.labelMarca);
            this.Controls.Add(this.comboAno);
            this.Controls.Add(this.comboModelo);
            this.Controls.Add(this.comboMarca);
            this.Controls.Add(this.radioMotos);
            this.Controls.Add(this.radioCarro);
            this.Controls.Add(this.botaoCancela);
            this.Controls.Add(this.botaoNovo);
            this.Controls.Add(this.botaoBuscar);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.botaoSeleciona);
            this.Controls.Add(this.listaVeiculos);
            this.Name = "FormularioVeiculo";
            this.Text = "Estoque de Veículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoBuscar;
        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.Button botaoSeleciona;
        private System.Windows.Forms.ListBox listaVeiculos;
        private System.Windows.Forms.Button botaoNovo;
        private System.Windows.Forms.Button botaoCancela;
        private System.Windows.Forms.RadioButton radioCarro;
        private System.Windows.Forms.RadioButton radioMotos;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.ComboBox comboModelo;
        private System.Windows.Forms.ComboBox comboAno;
        private System.Windows.Forms.Label labelMarca;
        private System.Windows.Forms.Label labelModelo;
        private System.Windows.Forms.Label labelAno;
        private System.Windows.Forms.Label labelQuantidade;
        private System.Windows.Forms.Label labelValorQuantidade;
    }
}