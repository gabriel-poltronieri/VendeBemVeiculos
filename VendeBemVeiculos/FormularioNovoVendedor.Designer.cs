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
            this.TextoNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BotaoCancela
            // 
            this.BotaoCancela.Location = new System.Drawing.Point(168, 36);
            this.BotaoCancela.Name = "BotaoCancela";
            this.BotaoCancela.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancela.TabIndex = 19;
            this.BotaoCancela.Text = "Cancelar";
            this.BotaoCancela.UseVisualStyleBackColor = true;
            this.BotaoCancela.Click += new System.EventHandler(this.BotaoCancela_Click);
            // 
            // BotaoCadastra
            // 
            this.BotaoCadastra.Location = new System.Drawing.Point(51, 36);
            this.BotaoCadastra.Name = "BotaoCadastra";
            this.BotaoCadastra.Size = new System.Drawing.Size(75, 23);
            this.BotaoCadastra.TabIndex = 18;
            this.BotaoCadastra.Text = "Cadastrar";
            this.BotaoCadastra.UseVisualStyleBackColor = true;
            this.BotaoCadastra.Click += new System.EventHandler(this.BotaoCadastra_Click);
            // 
            // TextoNome
            // 
            this.TextoNome.Location = new System.Drawing.Point(88, 4);
            this.TextoNome.Name = "TextoNome";
            this.TextoNome.Size = new System.Drawing.Size(181, 20);
            this.TextoNome.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome";
            // 
            // FormularioNovoVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 71);
            this.Controls.Add(this.BotaoCancela);
            this.Controls.Add(this.BotaoCadastra);
            this.Controls.Add(this.TextoNome);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormularioNovoVendedor";
            this.Text = "FormularioNovoVendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotaoCancela;
        private System.Windows.Forms.Button BotaoCadastra;
        private System.Windows.Forms.TextBox TextoNome;
        private System.Windows.Forms.Label label1;
    }
}