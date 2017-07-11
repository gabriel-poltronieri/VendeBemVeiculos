namespace VendeBemVeiculos
{
    partial class FormularioConfirmacao
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
            this.labelSenha = new System.Windows.Forms.Label();
            this.textoSenha = new System.Windows.Forms.TextBox();
            this.botaoConfirma = new System.Windows.Forms.Button();
            this.botaoCancela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Location = new System.Drawing.Point(12, 15);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(41, 13);
            this.labelSenha.TabIndex = 0;
            this.labelSenha.Text = "Senha:";
            // 
            // textoSenha
            // 
            this.textoSenha.Location = new System.Drawing.Point(59, 12);
            this.textoSenha.Name = "textoSenha";
            this.textoSenha.Size = new System.Drawing.Size(100, 20);
            this.textoSenha.TabIndex = 1;
            // 
            // botaoConfirma
            // 
            this.botaoConfirma.Location = new System.Drawing.Point(12, 44);
            this.botaoConfirma.Name = "botaoConfirma";
            this.botaoConfirma.Size = new System.Drawing.Size(75, 23);
            this.botaoConfirma.TabIndex = 2;
            this.botaoConfirma.Text = "Confirmar";
            this.botaoConfirma.UseVisualStyleBackColor = true;
            this.botaoConfirma.Click += new System.EventHandler(this.botaoConfirma_Click);
            // 
            // botaoCancela
            // 
            this.botaoCancela.Location = new System.Drawing.Point(93, 44);
            this.botaoCancela.Name = "botaoCancela";
            this.botaoCancela.Size = new System.Drawing.Size(75, 23);
            this.botaoCancela.TabIndex = 3;
            this.botaoCancela.Text = "Cancelar";
            this.botaoCancela.UseVisualStyleBackColor = true;
            this.botaoCancela.Click += new System.EventHandler(this.botaoCancela_Click);
            // 
            // FormularioConfirmação
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(181, 79);
            this.Controls.Add(this.botaoCancela);
            this.Controls.Add(this.botaoConfirma);
            this.Controls.Add(this.textoSenha);
            this.Controls.Add(this.labelSenha);
            this.Name = "FormularioConfirmação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox textoSenha;
        private System.Windows.Forms.Button botaoConfirma;
        private System.Windows.Forms.Button botaoCancela;
    }
}