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
            this.SuspendLayout();
            // 
            // botaoBusca
            // 
            this.botaoBusca.Location = new System.Drawing.Point(279, 214);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(75, 23);
            this.botaoBusca.TabIndex = 11;
            this.botaoBusca.Text = "Buscar";
            this.botaoBusca.UseVisualStyleBackColor = true;
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
            // botaoExclui
            // 
            this.botaoExclui.Location = new System.Drawing.Point(185, 252);
            this.botaoExclui.Name = "botaoExclui";
            this.botaoExclui.Size = new System.Drawing.Size(82, 23);
            this.botaoExclui.TabIndex = 8;
            this.botaoExclui.Text = "Excluir ";
            this.botaoExclui.UseVisualStyleBackColor = true;
            // 
            // botaoSeleciona
            // 
            this.botaoSeleciona.Location = new System.Drawing.Point(16, 252);
            this.botaoSeleciona.Name = "botaoSeleciona";
            this.botaoSeleciona.Size = new System.Drawing.Size(75, 23);
            this.botaoSeleciona.TabIndex = 7;
            this.botaoSeleciona.Text = "Seleciona";
            this.botaoSeleciona.UseVisualStyleBackColor = true;
            this.botaoSeleciona.Click += new System.EventHandler(this.botaoSeleciona_Click);
            // 
            // listaVeiculos
            // 
            this.listaVeiculos.FormattingEnabled = true;
            this.listaVeiculos.Location = new System.Drawing.Point(12, 12);
            this.listaVeiculos.Name = "listaVeiculos";
            this.listaVeiculos.Size = new System.Drawing.Size(342, 173);
            this.listaVeiculos.TabIndex = 6;
            this.listaVeiculos.SelectedIndexChanged += new System.EventHandler(this.listaVeiculos_SelectedIndexChanged);
            // 
            // botaoNovo
            // 
            this.botaoNovo.Location = new System.Drawing.Point(97, 252);
            this.botaoNovo.Name = "botaoNovo";
            this.botaoNovo.Size = new System.Drawing.Size(82, 23);
            this.botaoNovo.TabIndex = 12;
            this.botaoNovo.Text = "Novo";
            this.botaoNovo.UseVisualStyleBackColor = true;
            // 
            // botaoCancela
            // 
            this.botaoCancela.Location = new System.Drawing.Point(272, 252);
            this.botaoCancela.Name = "botaoCancela";
            this.botaoCancela.Size = new System.Drawing.Size(82, 23);
            this.botaoCancela.TabIndex = 13;
            this.botaoCancela.Text = "Cancela";
            this.botaoCancela.UseVisualStyleBackColor = true;
            // 
            // FormularioEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 293);
            this.Controls.Add(this.botaoCancela);
            this.Controls.Add(this.botaoNovo);
            this.Controls.Add(this.botaoBusca);
            this.Controls.Add(this.textoModelo);
            this.Controls.Add(this.labeModelo);
            this.Controls.Add(this.botaoExclui);
            this.Controls.Add(this.botaoSeleciona);
            this.Controls.Add(this.listaVeiculos);
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
    }
}