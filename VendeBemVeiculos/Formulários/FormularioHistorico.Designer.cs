namespace VendeBemVeiculos
{
    partial class FormularioHistorico
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
            this.listaHistorico = new System.Windows.Forms.ListBox();
            this.botaoDetalhes = new System.Windows.Forms.Button();
            this.botaoCancelar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaHistorico
            // 
            this.listaHistorico.FormattingEnabled = true;
            this.listaHistorico.ItemHeight = 20;
            this.listaHistorico.Location = new System.Drawing.Point(13, 72);
            this.listaHistorico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaHistorico.Name = "listaHistorico";
            this.listaHistorico.Size = new System.Drawing.Size(785, 384);
            this.listaHistorico.TabIndex = 0;
            this.listaHistorico.SelectedIndexChanged += new System.EventHandler(this.ListaHistorico_SelectedIndexChanged);
            // 
            // botaoDetalhes
            // 
            this.botaoDetalhes.Location = new System.Drawing.Point(112, 483);
            this.botaoDetalhes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botaoDetalhes.Name = "botaoDetalhes";
            this.botaoDetalhes.Size = new System.Drawing.Size(200, 42);
            this.botaoDetalhes.TabIndex = 1;
            this.botaoDetalhes.Text = "Detalhes da Venda";
            this.botaoDetalhes.UseVisualStyleBackColor = true;
            this.botaoDetalhes.Click += new System.EventHandler(this.BotaoDetalhes_Click);
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Location = new System.Drawing.Point(493, 483);
            this.botaoCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(177, 42);
            this.botaoCancelar.TabIndex = 2;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.UseVisualStyleBackColor = true;
            this.botaoCancelar.Click += new System.EventHandler(this.BotaoCancelar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(288, 18);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(206, 25);
            this.labelTitulo.TabIndex = 3;
            this.labelTitulo.Text = "Histórico de Vendas";
            // 
            // FormularioHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 547);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoDetalhes);
            this.Controls.Add(this.listaHistorico);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormularioHistorico";
            this.Text = "Vende Bem Veículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaHistorico;
        private System.Windows.Forms.Button botaoDetalhes;
        private System.Windows.Forms.Button botaoCancelar;
        private System.Windows.Forms.Label labelTitulo;
    }
}