namespace VendeBemVeiculos
{
    partial class FormularioEstoque
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
            this.textoModelo = new System.Windows.Forms.TextBox();
            this.labeModelo = new System.Windows.Forms.Label();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.botaoSeleciona = new System.Windows.Forms.Button();
            this.listaVeiculos = new System.Windows.Forms.ListBox();
            this.botaoNovo = new System.Windows.Forms.Button();
            this.botaoCancela = new System.Windows.Forms.Button();
            this.radioCarro = new System.Windows.Forms.RadioButton();
            this.radioMotos = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // botaoBuscar
            // 
            this.botaoBuscar.Location = new System.Drawing.Point(279, 214);
            this.botaoBuscar.Name = "botaoBuscar";
            this.botaoBuscar.Size = new System.Drawing.Size(75, 23);
            this.botaoBuscar.TabIndex = 11;
            this.botaoBuscar.Text = "Buscar";
            this.botaoBuscar.UseVisualStyleBackColor = true;
            this.botaoBuscar.Click += new System.EventHandler(this.BotaoBuscar_Click);
            // 
            // textoModelo
            // 
            this.textoModelo.Location = new System.Drawing.Point(57, 216);
            this.textoModelo.Name = "textoModelo";
            this.textoModelo.Size = new System.Drawing.Size(216, 20);
            this.textoModelo.TabIndex = 10;
            // 
            // labeModelo
            // 
            this.labeModelo.AutoSize = true;
            this.labeModelo.Location = new System.Drawing.Point(13, 219);
            this.labeModelo.Name = "labeModelo";
            this.labeModelo.Size = new System.Drawing.Size(43, 13);
            this.labeModelo.TabIndex = 9;
            this.labeModelo.Text = "Modeo:";
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Location = new System.Drawing.Point(185, 252);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(82, 23);
            this.botaoExcluir.TabIndex = 8;
            this.botaoExcluir.Text = "Excluir ";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Click += new System.EventHandler(this.BotaoExcluir_Click);
            // 
            // botaoSeleciona
            // 
            this.botaoSeleciona.Location = new System.Drawing.Point(16, 252);
            this.botaoSeleciona.Name = "botaoSeleciona";
            this.botaoSeleciona.Size = new System.Drawing.Size(75, 23);
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
            this.botaoNovo.Location = new System.Drawing.Point(97, 252);
            this.botaoNovo.Name = "botaoNovo";
            this.botaoNovo.Size = new System.Drawing.Size(82, 23);
            this.botaoNovo.TabIndex = 12;
            this.botaoNovo.Text = "Novo";
            this.botaoNovo.UseVisualStyleBackColor = true;
            this.botaoNovo.Click += new System.EventHandler(this.BotaoNovo_Click);
            // 
            // botaoCancela
            // 
            this.botaoCancela.Location = new System.Drawing.Point(272, 252);
            this.botaoCancela.Name = "botaoCancela";
            this.botaoCancela.Size = new System.Drawing.Size(82, 23);
            this.botaoCancela.TabIndex = 13;
            this.botaoCancela.Text = "Cancela";
            this.botaoCancela.UseVisualStyleBackColor = true;
            this.botaoCancela.Click += new System.EventHandler(this.BotaoCancela_Click);
            // 
            // radioCarro
            // 
            this.radioCarro.AutoSize = true;
            this.radioCarro.Location = new System.Drawing.Point(79, 193);
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
            this.radioMotos.Location = new System.Drawing.Point(219, 193);
            this.radioMotos.Name = "radioMotos";
            this.radioMotos.Size = new System.Drawing.Size(54, 17);
            this.radioMotos.TabIndex = 15;
            this.radioMotos.TabStop = true;
            this.radioMotos.Text = "Motos";
            this.radioMotos.UseVisualStyleBackColor = true;
            this.radioMotos.CheckedChanged += new System.EventHandler(this.RadioMotos_CheckedChanged);
            // 
            // FormularioEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 293);
            this.Controls.Add(this.radioMotos);
            this.Controls.Add(this.radioCarro);
            this.Controls.Add(this.botaoCancela);
            this.Controls.Add(this.botaoNovo);
            this.Controls.Add(this.botaoBuscar);
            this.Controls.Add(this.textoModelo);
            this.Controls.Add(this.labeModelo);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.botaoSeleciona);
            this.Controls.Add(this.listaVeiculos);
            this.Name = "FormularioEstoque";
            this.Text = "Estoque de Veículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoBuscar;
        private System.Windows.Forms.TextBox textoModelo;
        private System.Windows.Forms.Label labeModelo;
        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.Button botaoSeleciona;
        private System.Windows.Forms.ListBox listaVeiculos;
        private System.Windows.Forms.Button botaoNovo;
        private System.Windows.Forms.Button botaoCancela;
        private System.Windows.Forms.RadioButton radioCarro;
        private System.Windows.Forms.RadioButton radioMotos;
    }
}