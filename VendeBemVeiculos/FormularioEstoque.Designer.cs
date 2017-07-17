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
            this.botaoBusca = new System.Windows.Forms.Button();
            this.textoModelo = new System.Windows.Forms.TextBox();
            this.labeModelo = new System.Windows.Forms.Label();
            this.botaoExclui = new System.Windows.Forms.Button();
            this.botaoSeleciona = new System.Windows.Forms.Button();
            this.listaVeiculos = new System.Windows.Forms.ListBox();
            this.botaoNovo = new System.Windows.Forms.Button();
            this.botaoCancela = new System.Windows.Forms.Button();
            this.radioCarro = new System.Windows.Forms.RadioButton();
            this.radioMoto = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // botaoBusca
            // 
            this.botaoBusca.Location = new System.Drawing.Point(372, 263);
            this.botaoBusca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(100, 28);
            this.botaoBusca.TabIndex = 11;
            this.botaoBusca.Text = "Buscar";
            this.botaoBusca.UseVisualStyleBackColor = true;
            this.botaoBusca.Click += new System.EventHandler(this.BotaoBusca_Click);
            // 
            // textoModelo
            // 
            this.textoModelo.Location = new System.Drawing.Point(76, 266);
            this.textoModelo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textoModelo.Name = "textoModelo";
            this.textoModelo.Size = new System.Drawing.Size(287, 22);
            this.textoModelo.TabIndex = 10;
            // 
            // labeModelo
            // 
            this.labeModelo.AutoSize = true;
            this.labeModelo.Location = new System.Drawing.Point(17, 270);
            this.labeModelo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeModelo.Name = "labeModelo";
            this.labeModelo.Size = new System.Drawing.Size(55, 17);
            this.labeModelo.TabIndex = 9;
            this.labeModelo.Text = "Modeo:";
            // 
            // botaoExclui
            // 
            this.botaoExclui.Location = new System.Drawing.Point(247, 310);
            this.botaoExclui.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botaoExclui.Name = "botaoExclui";
            this.botaoExclui.Size = new System.Drawing.Size(109, 28);
            this.botaoExclui.TabIndex = 8;
            this.botaoExclui.Text = "Excluir ";
            this.botaoExclui.UseVisualStyleBackColor = true;
            this.botaoExclui.Click += new System.EventHandler(this.BotaoExclui_Click);
            // 
            // botaoSeleciona
            // 
            this.botaoSeleciona.Location = new System.Drawing.Point(21, 310);
            this.botaoSeleciona.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botaoSeleciona.Name = "botaoSeleciona";
            this.botaoSeleciona.Size = new System.Drawing.Size(100, 28);
            this.botaoSeleciona.TabIndex = 7;
            this.botaoSeleciona.Text = "Seleciona";
            this.botaoSeleciona.UseVisualStyleBackColor = true;
            this.botaoSeleciona.Click += new System.EventHandler(this.BotaoSeleciona_Click);
            // 
            // listaVeiculos
            // 
            this.listaVeiculos.FormattingEnabled = true;
            this.listaVeiculos.ItemHeight = 16;
            this.listaVeiculos.Location = new System.Drawing.Point(16, 15);
            this.listaVeiculos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaVeiculos.Name = "listaVeiculos";
            this.listaVeiculos.Size = new System.Drawing.Size(455, 212);
            this.listaVeiculos.TabIndex = 6;
            this.listaVeiculos.SelectedIndexChanged += new System.EventHandler(this.ListaVeiculos_SelectedIndexChanged);
            // 
            // botaoNovo
            // 
            this.botaoNovo.Location = new System.Drawing.Point(129, 310);
            this.botaoNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botaoNovo.Name = "botaoNovo";
            this.botaoNovo.Size = new System.Drawing.Size(109, 28);
            this.botaoNovo.TabIndex = 12;
            this.botaoNovo.Text = "Novo";
            this.botaoNovo.UseVisualStyleBackColor = true;
            this.botaoNovo.Click += new System.EventHandler(this.BotaoNovo_Click);
            // 
            // botaoCancela
            // 
            this.botaoCancela.Location = new System.Drawing.Point(363, 310);
            this.botaoCancela.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botaoCancela.Name = "botaoCancela";
            this.botaoCancela.Size = new System.Drawing.Size(109, 28);
            this.botaoCancela.TabIndex = 13;
            this.botaoCancela.Text = "Cancela";
            this.botaoCancela.UseVisualStyleBackColor = true;
            this.botaoCancela.Click += new System.EventHandler(this.BotaoCancela_Click);
            // 
            // radioCarro
            // 
            this.radioCarro.AutoSize = true;
            this.radioCarro.Location = new System.Drawing.Point(76, 235);
            this.radioCarro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioCarro.Name = "radioCarro";
            this.radioCarro.Size = new System.Drawing.Size(64, 21);
            this.radioCarro.TabIndex = 14;
            this.radioCarro.TabStop = true;
            this.radioCarro.Text = "Carro";
            this.radioCarro.UseVisualStyleBackColor = true;
            this.radioCarro.CheckedChanged += new System.EventHandler(this.RadioCarro_CheckedChange);
            // 
            // radioMoto
            // 
            this.radioMoto.AutoSize = true;
            this.radioMoto.Location = new System.Drawing.Point(316, 235);
            this.radioMoto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioMoto.Name = "radioMoto";
            this.radioMoto.Size = new System.Drawing.Size(60, 21);
            this.radioMoto.TabIndex = 15;
            this.radioMoto.TabStop = true;
            this.radioMoto.Text = "Moto";
            this.radioMoto.UseVisualStyleBackColor = true;
            this.radioMoto.CheckedChanged += new System.EventHandler(this.RadioMoto_CheckedChanged);
            // 
            // FormularioEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 361);
            this.Controls.Add(this.radioMoto);
            this.Controls.Add(this.radioCarro);
            this.Controls.Add(this.botaoCancela);
            this.Controls.Add(this.botaoNovo);
            this.Controls.Add(this.botaoBusca);
            this.Controls.Add(this.textoModelo);
            this.Controls.Add(this.labeModelo);
            this.Controls.Add(this.botaoExclui);
            this.Controls.Add(this.botaoSeleciona);
            this.Controls.Add(this.listaVeiculos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormularioEstoque";
            this.Text = "Estoque de Veículos";
            this.Load += new System.EventHandler(this.FormularioEstoque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botaoBusca;
        private System.Windows.Forms.TextBox textoModelo;
        private System.Windows.Forms.Label labeModelo;
        private System.Windows.Forms.Button botaoExclui;
        private System.Windows.Forms.Button botaoSeleciona;
        private System.Windows.Forms.ListBox listaVeiculos;
        private System.Windows.Forms.Button botaoNovo;
        private System.Windows.Forms.Button botaoCancela;
        private System.Windows.Forms.RadioButton radioCarro;
        private System.Windows.Forms.RadioButton radioMoto;
    }
}