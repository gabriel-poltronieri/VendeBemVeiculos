namespace VendeBemVeiculos
{
    partial class FormularioNovoCliente
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
            this.TextoNome = new System.Windows.Forms.TextBox();
            this.TextoCpf = new System.Windows.Forms.TextBox();
            this.BotaoCadastra = new System.Windows.Forms.Button();
            this.BotaoCancela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPF";
            // 
            // TextoNome
            // 
            this.TextoNome.Location = new System.Drawing.Point(91, 6);
            this.TextoNome.Name = "TextoNome";
            this.TextoNome.Size = new System.Drawing.Size(181, 20);
            this.TextoNome.TabIndex = 6;
            // 
            // TextoCpf
            // 
            this.TextoCpf.Location = new System.Drawing.Point(91, 32);
            this.TextoCpf.Name = "TextoCpf";
            this.TextoCpf.Size = new System.Drawing.Size(181, 20);
            this.TextoCpf.TabIndex = 7;
            // 
            // BotaoCadastra
            // 
            this.BotaoCadastra.Location = new System.Drawing.Point(46, 68);
            this.BotaoCadastra.Name = "BotaoCadastra";
            this.BotaoCadastra.Size = new System.Drawing.Size(75, 23);
            this.BotaoCadastra.TabIndex = 8;
            this.BotaoCadastra.Text = "Cadastrar";
            this.BotaoCadastra.UseVisualStyleBackColor = true;
            // 
            // BotaoCancela
            // 
            this.BotaoCancela.Location = new System.Drawing.Point(163, 68);
            this.BotaoCancela.Name = "BotaoCancela";
            this.BotaoCancela.Size = new System.Drawing.Size(75, 23);
            this.BotaoCancela.TabIndex = 9;
            this.BotaoCancela.Text = "Cancelar";
            this.BotaoCancela.UseVisualStyleBackColor = true;
            // 
            // FormularioNovoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.BotaoCancela);
            this.Controls.Add(this.BotaoCadastra);
            this.Controls.Add(this.TextoCpf);
            this.Controls.Add(this.TextoNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormularioNovoCliente";
            this.Text = "Novo Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextoNome;
        private System.Windows.Forms.TextBox TextoCpf;
        private System.Windows.Forms.Button BotaoCadastra;
        private System.Windows.Forms.Button BotaoCancela;
    }
}