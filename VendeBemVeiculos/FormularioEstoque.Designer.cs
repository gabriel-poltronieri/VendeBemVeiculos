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
            this.BotaoBusca = new System.Windows.Forms.Button();
            this.TextoModelo = new System.Windows.Forms.TextBox();
            this.labeModelo = new System.Windows.Forms.Label();
            this.BotaoExclui = new System.Windows.Forms.Button();
            this.BotaoSeleciona = new System.Windows.Forms.Button();
            this.ListaVeiculos = new System.Windows.Forms.ListBox();
            this.BotaoNovo = new System.Windows.Forms.Button();
            this.BotaoCancela = new System.Windows.Forms.Button();
            this.RadioCarro = new System.Windows.Forms.RadioButton();
            this.RadioMoto = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // BotaoBusca
            // 
            this.BotaoBusca.Location = new System.Drawing.Point(279, 214);
            this.BotaoBusca.Name = "BotaoBusca";
            this.BotaoBusca.Size = new System.Drawing.Size(75, 23);
            this.BotaoBusca.TabIndex = 11;
            this.BotaoBusca.Text = "Buscar";
            this.BotaoBusca.UseVisualStyleBackColor = true;
            this.BotaoBusca.Click += new System.EventHandler(this.BotaoBusca_Click);
            // 
            // TextoModelo
            // 
            this.TextoModelo.Location = new System.Drawing.Point(57, 216);
            this.TextoModelo.Name = "TextoModelo";
            this.TextoModelo.Size = new System.Drawing.Size(216, 20);
            this.TextoModelo.TabIndex = 10;
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
            // BotaoExclui
            // 
            this.BotaoExclui.Location = new System.Drawing.Point(185, 252);
            this.BotaoExclui.Name = "BotaoExclui";
            this.BotaoExclui.Size = new System.Drawing.Size(82, 23);
            this.BotaoExclui.TabIndex = 8;
            this.BotaoExclui.Text = "Excluir ";
            this.BotaoExclui.UseVisualStyleBackColor = true;
            this.BotaoExclui.Click += new System.EventHandler(this.BotaoExclui_Click);
            // 
            // BotaoSeleciona
            // 
            this.BotaoSeleciona.Location = new System.Drawing.Point(16, 252);
            this.BotaoSeleciona.Name = "BotaoSeleciona";
            this.BotaoSeleciona.Size = new System.Drawing.Size(75, 23);
            this.BotaoSeleciona.TabIndex = 7;
            this.BotaoSeleciona.Text = "Seleciona";
            this.BotaoSeleciona.UseVisualStyleBackColor = true;
            this.BotaoSeleciona.Click += new System.EventHandler(this.BotaoSeleciona_Click);
            // 
            // ListaVeiculos
            // 
            this.ListaVeiculos.FormattingEnabled = true;
            this.ListaVeiculos.Location = new System.Drawing.Point(12, 12);
            this.ListaVeiculos.Name = "ListaVeiculos";
            this.ListaVeiculos.Size = new System.Drawing.Size(342, 173);
            this.ListaVeiculos.TabIndex = 6;
            this.ListaVeiculos.SelectedIndexChanged += new System.EventHandler(this.ListaVeiculos_SelectedIndexChanged);
            // 
            // BotaoNovo
            // 
            this.BotaoNovo.Location = new System.Drawing.Point(97, 252);
            this.BotaoNovo.Name = "BotaoNovo";
            this.BotaoNovo.Size = new System.Drawing.Size(82, 23);
            this.BotaoNovo.TabIndex = 12;
            this.BotaoNovo.Text = "Novo";
            this.BotaoNovo.UseVisualStyleBackColor = true;
            this.BotaoNovo.Click += new System.EventHandler(this.BotaoNovo_Click);
            // 
            // BotaoCancela
            // 
            this.BotaoCancela.Location = new System.Drawing.Point(272, 252);
            this.BotaoCancela.Name = "BotaoCancela";
            this.BotaoCancela.Size = new System.Drawing.Size(82, 23);
            this.BotaoCancela.TabIndex = 13;
            this.BotaoCancela.Text = "Cancela";
            this.BotaoCancela.UseVisualStyleBackColor = true;
            this.BotaoCancela.Click += new System.EventHandler(this.BotaoCancela_Click);
            // 
            // RadioCarro
            // 
            this.RadioCarro.AutoSize = true;
            this.RadioCarro.Location = new System.Drawing.Point(57, 191);
            this.RadioCarro.Name = "RadioCarro";
            this.RadioCarro.Size = new System.Drawing.Size(50, 17);
            this.RadioCarro.TabIndex = 14;
            this.RadioCarro.TabStop = true;
            this.RadioCarro.Text = "Carro";
            this.RadioCarro.UseVisualStyleBackColor = true;
            this.RadioCarro.CheckedChanged += new System.EventHandler(this.RadioCarro_CheckedChange);
            // 
            // RadioMoto
            // 
            this.RadioMoto.AutoSize = true;
            this.RadioMoto.Location = new System.Drawing.Point(237, 191);
            this.RadioMoto.Name = "RadioMoto";
            this.RadioMoto.Size = new System.Drawing.Size(49, 17);
            this.RadioMoto.TabIndex = 15;
            this.RadioMoto.TabStop = true;
            this.RadioMoto.Text = "Moto";
            this.RadioMoto.UseVisualStyleBackColor = true;
            this.RadioMoto.CheckedChanged += new System.EventHandler(this.RadioMoto_CheckedChanged);
            // 
            // FormularioEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 293);
            this.Controls.Add(this.RadioMoto);
            this.Controls.Add(this.RadioCarro);
            this.Controls.Add(this.BotaoCancela);
            this.Controls.Add(this.BotaoNovo);
            this.Controls.Add(this.BotaoBusca);
            this.Controls.Add(this.TextoModelo);
            this.Controls.Add(this.labeModelo);
            this.Controls.Add(this.BotaoExclui);
            this.Controls.Add(this.BotaoSeleciona);
            this.Controls.Add(this.ListaVeiculos);
            this.Name = "FormularioEstoque";
            this.Text = "Estoque de Veículos";
            this.Load += new System.EventHandler(this.FormularioEstoque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotaoBusca;
        private System.Windows.Forms.TextBox TextoModelo;
        private System.Windows.Forms.Label labeModelo;
        private System.Windows.Forms.Button BotaoExclui;
        private System.Windows.Forms.Button BotaoSeleciona;
        private System.Windows.Forms.ListBox ListaVeiculos;
        private System.Windows.Forms.Button BotaoNovo;
        private System.Windows.Forms.Button BotaoCancela;
        private System.Windows.Forms.RadioButton RadioCarro;
        private System.Windows.Forms.RadioButton RadioMoto;
    }
}