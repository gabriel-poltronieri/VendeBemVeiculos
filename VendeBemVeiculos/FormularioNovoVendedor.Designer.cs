namespace VendeBemVeiculos
{
    partial class FormularioNovoVendedor
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
            this.BotaoCancela = new System.Windows.Forms.Button();
            this.BotaoCadastra = new System.Windows.Forms.Button();
            this.TextoSenha = new System.Windows.Forms.TextBox();
            this.TextoNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotaoCancela
            // 
            this.BotaoCancela.Location = new System.Drawing.Point(203, 84);
            this.BotaoCancela.Margin = new System.Windows.Forms.Padding(4);
            this.BotaoCancela.Name = "BotaoCancela";
            this.BotaoCancela.Size = new System.Drawing.Size(100, 28);
            this.BotaoCancela.TabIndex = 19;
            this.BotaoCancela.Text = "Cancelar";
            this.BotaoCancela.UseVisualStyleBackColor = true;
            this.BotaoCancela.Click += new System.EventHandler(this.BotaoCancela_Click);
            // 
            // BotaoCadastra
            // 
            this.BotaoCadastra.Location = new System.Drawing.Point(47, 84);
            this.BotaoCadastra.Margin = new System.Windows.Forms.Padding(4);
            this.BotaoCadastra.Name = "BotaoCadastra";
            this.BotaoCadastra.Size = new System.Drawing.Size(100, 28);
            this.BotaoCadastra.TabIndex = 18;
            this.BotaoCadastra.Text = "Cadastrar";
            this.BotaoCadastra.UseVisualStyleBackColor = true;
            this.BotaoCadastra.Click += new System.EventHandler(this.BotaoCadastra_Click);
            // 
            // TextoSenha
            // 
            this.TextoSenha.Location = new System.Drawing.Point(118, 37);
            this.TextoSenha.Margin = new System.Windows.Forms.Padding(4);
            this.TextoSenha.Name = "TextoSenha";
            this.TextoSenha.Size = new System.Drawing.Size(240, 22);
            this.TextoSenha.TabIndex = 17;
            // 
            // TextoNome
            // 
            this.TextoNome.Location = new System.Drawing.Point(118, 5);
            this.TextoNome.Margin = new System.Windows.Forms.Padding(4);
            this.TextoNome.Name = "TextoNome";
            this.TextoNome.Size = new System.Drawing.Size(240, 22);
            this.TextoNome.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome";
            // 
            // FormularioNovoVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 129);
            this.Controls.Add(this.BotaoCancela);
            this.Controls.Add(this.BotaoCadastra);
            this.Controls.Add(this.TextoSenha);
            this.Controls.Add(this.TextoNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioNovoVendedor";
            this.Text = "FormularioNovoVendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotaoCancela;
        private System.Windows.Forms.Button BotaoCadastra;
        private System.Windows.Forms.TextBox TextoSenha;
        private System.Windows.Forms.TextBox TextoNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}