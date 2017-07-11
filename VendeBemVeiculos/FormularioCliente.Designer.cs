namespace VendeBemVeiculos
{
    partial class FormularioCliente
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labeCpf = new System.Windows.Forms.Label();
            this.textCpf = new System.Windows.Forms.TextBox();
            this.botaoBusca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 173);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Seleciona";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Novo Cliente";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // labeCpf
            // 
            this.labeCpf.AutoSize = true;
            this.labeCpf.Location = new System.Drawing.Point(13, 192);
            this.labeCpf.Name = "labeCpf";
            this.labeCpf.Size = new System.Drawing.Size(30, 13);
            this.labeCpf.TabIndex = 3;
            this.labeCpf.Text = "CPF:";
            // 
            // textCpf
            // 
            this.textCpf.Location = new System.Drawing.Point(57, 189);
            this.textCpf.Name = "textCpf";
            this.textCpf.Size = new System.Drawing.Size(134, 20);
            this.textCpf.TabIndex = 4;
            // 
            // botaoBusca
            // 
            this.botaoBusca.Location = new System.Drawing.Point(197, 187);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(75, 23);
            this.botaoBusca.TabIndex = 5;
            this.botaoBusca.Text = "Buscar";
            this.botaoBusca.UseVisualStyleBackColor = true;
            // 
            // FormularioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 258);
            this.Controls.Add(this.botaoBusca);
            this.Controls.Add(this.textCpf);
            this.Controls.Add(this.labeCpf);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Name = "FormularioCliente";
            this.Text = "FormularioCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labeCpf;
        private System.Windows.Forms.TextBox textCpf;
        private System.Windows.Forms.Button botaoBusca;
    }
}