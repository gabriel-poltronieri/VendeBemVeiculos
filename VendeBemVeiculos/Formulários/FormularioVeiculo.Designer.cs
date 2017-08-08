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
            this.botaoFiltrar = new System.Windows.Forms.Button();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.botaoSelecionar = new System.Windows.Forms.Button();
            this.listaVeiculos = new System.Windows.Forms.ListBox();
            this.botaoNovo = new System.Windows.Forms.Button();
            this.botaoCancelar = new System.Windows.Forms.Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelValorPreco = new System.Windows.Forms.Label();
            this.labelPreco = new System.Windows.Forms.Label();
            this.labelTítulo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botaoFiltrar
            // 
            this.botaoFiltrar.Location = new System.Drawing.Point(305, 310);
            this.botaoFiltrar.Margin = new System.Windows.Forms.Padding(5);
            this.botaoFiltrar.Name = "botaoFiltrar";
            this.botaoFiltrar.Size = new System.Drawing.Size(125, 35);
            this.botaoFiltrar.TabIndex = 11;
            this.botaoFiltrar.Text = "Filtrar";
            this.botaoFiltrar.UseVisualStyleBackColor = true;
            this.botaoFiltrar.Click += new System.EventHandler(this.BotaoFiltrar_Click);
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Location = new System.Drawing.Point(554, 435);
            this.botaoExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(199, 45);
            this.botaoExcluir.TabIndex = 8;
            this.botaoExcluir.Text = "Excluir ";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Click += new System.EventHandler(this.BotaoExcluir_Click);
            // 
            // botaoSelecionar
            // 
            this.botaoSelecionar.Location = new System.Drawing.Point(124, 435);
            this.botaoSelecionar.Margin = new System.Windows.Forms.Padding(5);
            this.botaoSelecionar.Name = "botaoSelecionar";
            this.botaoSelecionar.Size = new System.Drawing.Size(186, 45);
            this.botaoSelecionar.TabIndex = 7;
            this.botaoSelecionar.Text = "Selecionar";
            this.botaoSelecionar.UseVisualStyleBackColor = true;
            this.botaoSelecionar.Click += new System.EventHandler(this.BotaoSeleciona_Click);
            // 
            // listaVeiculos
            // 
            this.listaVeiculos.FormattingEnabled = true;
            this.listaVeiculos.ItemHeight = 20;
            this.listaVeiculos.Location = new System.Drawing.Point(26, 61);
            this.listaVeiculos.Margin = new System.Windows.Forms.Padding(5);
            this.listaVeiculos.Name = "listaVeiculos";
            this.listaVeiculos.Size = new System.Drawing.Size(568, 364);
            this.listaVeiculos.TabIndex = 6;
            this.listaVeiculos.SelectedIndexChanged += new System.EventHandler(this.ListaVeiculos_SelectedIndexChanged);
            // 
            // botaoNovo
            // 
            this.botaoNovo.Location = new System.Drawing.Point(334, 435);
            this.botaoNovo.Margin = new System.Windows.Forms.Padding(5);
            this.botaoNovo.Name = "botaoNovo";
            this.botaoNovo.Size = new System.Drawing.Size(199, 45);
            this.botaoNovo.TabIndex = 12;
            this.botaoNovo.Text = "Novo";
            this.botaoNovo.UseVisualStyleBackColor = true;
            this.botaoNovo.Click += new System.EventHandler(this.BotaoNovo_Click);
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Location = new System.Drawing.Point(779, 435);
            this.botaoCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(199, 45);
            this.botaoCancelar.TabIndex = 13;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            this.botaoCancelar.Click += new System.EventHandler(this.BotaoCancela_Click);
            // 
            // radioCarro
            // 
            this.radioCarro.AutoSize = true;
            this.radioCarro.Location = new System.Drawing.Point(80, 41);
            this.radioCarro.Margin = new System.Windows.Forms.Padding(5);
            this.radioCarro.Name = "radioCarro";
            this.radioCarro.Size = new System.Drawing.Size(81, 24);
            this.radioCarro.TabIndex = 14;
            this.radioCarro.Text = "Carros";
            this.radioCarro.UseVisualStyleBackColor = true;
            this.radioCarro.CheckedChanged += new System.EventHandler(this.RadioCarro_CheckedChanged);
            // 
            // radioMotos
            // 
            this.radioMotos.AutoSize = true;
            this.radioMotos.Location = new System.Drawing.Point(312, 41);
            this.radioMotos.Margin = new System.Windows.Forms.Padding(5);
            this.radioMotos.Name = "radioMotos";
            this.radioMotos.Size = new System.Drawing.Size(76, 24);
            this.radioMotos.TabIndex = 15;
            this.radioMotos.TabStop = true;
            this.radioMotos.Text = "Motos";
            this.radioMotos.UseVisualStyleBackColor = true;
            this.radioMotos.CheckedChanged += new System.EventHandler(this.RadioMotos_CheckedChanged);
            // 
            // comboMarca
            // 
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(135, 99);
            this.comboMarca.Margin = new System.Windows.Forms.Padding(5);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(294, 28);
            this.comboMarca.TabIndex = 16;
            this.comboMarca.SelectedIndexChanged += new System.EventHandler(this.ComboMarca_SelectedIndexChanged);
            // 
            // comboModelo
            // 
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Location = new System.Drawing.Point(135, 155);
            this.comboModelo.Margin = new System.Windows.Forms.Padding(5);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(294, 28);
            this.comboModelo.TabIndex = 17;
            this.comboModelo.SelectedIndexChanged += new System.EventHandler(this.ComboModelo_SelectedIndexChanged);
            // 
            // comboAno
            // 
            this.comboAno.FormattingEnabled = true;
            this.comboAno.Location = new System.Drawing.Point(135, 218);
            this.comboAno.Margin = new System.Windows.Forms.Padding(5);
            this.comboAno.Name = "comboAno";
            this.comboAno.Size = new System.Drawing.Size(294, 28);
            this.comboAno.TabIndex = 18;
            this.comboAno.SelectedIndexChanged += new System.EventHandler(this.ComboAno_SelectedIndexChanged);
            // 
            // labelMarca
            // 
            this.labelMarca.AutoSize = true;
            this.labelMarca.Location = new System.Drawing.Point(38, 104);
            this.labelMarca.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMarca.Name = "labelMarca";
            this.labelMarca.Size = new System.Drawing.Size(61, 20);
            this.labelMarca.TabIndex = 19;
            this.labelMarca.Text = "Marca:";
            // 
            // labelModelo
            // 
            this.labelModelo.AutoSize = true;
            this.labelModelo.Location = new System.Drawing.Point(38, 159);
            this.labelModelo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelModelo.Name = "labelModelo";
            this.labelModelo.Size = new System.Drawing.Size(68, 20);
            this.labelModelo.TabIndex = 20;
            this.labelModelo.Text = "Modelo:";
            // 
            // labelAno
            // 
            this.labelAno.AutoSize = true;
            this.labelAno.Location = new System.Drawing.Point(38, 222);
            this.labelAno.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAno.Name = "labelAno";
            this.labelAno.Size = new System.Drawing.Size(43, 20);
            this.labelAno.TabIndex = 21;
            this.labelAno.Text = "Ano:";
            // 
            // labelQuantidade
            // 
            this.labelQuantidade.AutoSize = true;
            this.labelQuantidade.Location = new System.Drawing.Point(271, 266);
            this.labelQuantidade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelQuantidade.Name = "labelQuantidade";
            this.labelQuantidade.Size = new System.Drawing.Size(99, 20);
            this.labelQuantidade.TabIndex = 22;
            this.labelQuantidade.Text = "Quantidade:";
            // 
            // labelValorQuantidade
            // 
            this.labelValorQuantidade.AutoSize = true;
            this.labelValorQuantidade.Location = new System.Drawing.Point(402, 266);
            this.labelValorQuantidade.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelValorQuantidade.Name = "labelValorQuantidade";
            this.labelValorQuantidade.Size = new System.Drawing.Size(21, 20);
            this.labelValorQuantidade.TabIndex = 23;
            this.labelValorQuantidade.Text = "--";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelValorPreco);
            this.groupBox1.Controls.Add(this.labelPreco);
            this.groupBox1.Controls.Add(this.labelMarca);
            this.groupBox1.Controls.Add(this.labelValorQuantidade);
            this.groupBox1.Controls.Add(this.botaoFiltrar);
            this.groupBox1.Controls.Add(this.labelQuantidade);
            this.groupBox1.Controls.Add(this.radioCarro);
            this.groupBox1.Controls.Add(this.labelAno);
            this.groupBox1.Controls.Add(this.radioMotos);
            this.groupBox1.Controls.Add(this.labelModelo);
            this.groupBox1.Controls.Add(this.comboMarca);
            this.groupBox1.Controls.Add(this.comboModelo);
            this.groupBox1.Controls.Add(this.comboAno);
            this.groupBox1.Location = new System.Drawing.Point(620, 61);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(471, 354);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro de Busca";
            // 
            // labelValorPreco
            // 
            this.labelValorPreco.AutoSize = true;
            this.labelValorPreco.Location = new System.Drawing.Point(91, 266);
            this.labelValorPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelValorPreco.Name = "labelValorPreco";
            this.labelValorPreco.Size = new System.Drawing.Size(54, 20);
            this.labelValorPreco.TabIndex = 25;
            this.labelValorPreco.Text = "R$----";
            // 
            // labelPreco
            // 
            this.labelPreco.AutoSize = true;
            this.labelPreco.Location = new System.Drawing.Point(22, 266);
            this.labelPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPreco.Name = "labelPreco";
            this.labelPreco.Size = new System.Drawing.Size(58, 20);
            this.labelPreco.TabIndex = 24;
            this.labelPreco.Text = "Preço:";
            // 
            // labelTítulo
            // 
            this.labelTítulo.AutoSize = true;
            this.labelTítulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTítulo.Location = new System.Drawing.Point(479, 9);
            this.labelTítulo.Name = "labelTítulo";
            this.labelTítulo.Size = new System.Drawing.Size(210, 25);
            this.labelTítulo.TabIndex = 25;
            this.labelTítulo.Text = "Estoque de Veículos";
            // 
            // FormularioVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 501);
            this.Controls.Add(this.labelTítulo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoNovo);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.botaoSelecionar);
            this.Controls.Add(this.listaVeiculos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormularioVeiculo";
            this.Text = "Vende Bem Veículos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoFiltrar;
        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.Button botaoSelecionar;
        private System.Windows.Forms.ListBox listaVeiculos;
        private System.Windows.Forms.Button botaoNovo;
        private System.Windows.Forms.Button botaoCancelar;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelValorPreco;
        private System.Windows.Forms.Label labelPreco;
        private System.Windows.Forms.Label labelTítulo;
    }
}