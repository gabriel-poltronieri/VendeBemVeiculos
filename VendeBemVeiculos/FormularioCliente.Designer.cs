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
            this.listaClientes = new System.Windows.Forms.ListBox();
            this.botaoSeleciona = new System.Windows.Forms.Button();
            this.botaoNovo = new System.Windows.Forms.Button();
            this.labeCpf = new System.Windows.Forms.Label();
            this.textoCpf = new System.Windows.Forms.TextBox();
            this.botaoBusca = new System.Windows.Forms.Button();
            this.botaoExclui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaClientes
            // 
            this.listaClientes.FormattingEnabled = true;
            this.listaClientes.Location = new System.Drawing.Point(12, 12);
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.Size = new System.Drawing.Size(260, 173);
            this.listaClientes.TabIndex = 0;
            this.listaClientes.SelectedIndexChanged += new System.EventHandler(this.listaClientes_SelectedIndexChanged);
            // 
            // botaoSeleciona
            // 
            this.botaoSeleciona.Location = new System.Drawing.Point(28, 225);
            this.botaoSeleciona.Name = "botaoSeleciona";
            this.botaoSeleciona.Size = new System.Drawing.Size(75, 23);
            this.botaoSeleciona.TabIndex = 1;
            this.botaoSeleciona.Text = "Seleciona";
            this.botaoSeleciona.UseVisualStyleBackColor = true;
            this.botaoSeleciona.Click += new System.EventHandler(this.botaoSeleciona_Click);
            // 
            // botaoNovo
            // 
            this.botaoNovo.Location = new System.Drawing.Point(190, 225);
            this.botaoNovo.Name = "botaoNovo";
            this.botaoNovo.Size = new System.Drawing.Size(82, 23);
            this.botaoNovo.TabIndex = 2;
            this.botaoNovo.Text = "Novo Cliente";
            this.botaoNovo.UseVisualStyleBackColor = true;
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
            // textoCpf
            // 
            this.textoCpf.Location = new System.Drawing.Point(57, 189);
            this.textoCpf.Name = "textoCpf";
            this.textoCpf.Size = new System.Drawing.Size(134, 20);
            this.textoCpf.TabIndex = 4;
            // 
            // botaoBusca
            // 
            this.botaoBusca.Location = new System.Drawing.Point(197, 187);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(75, 23);
            this.botaoBusca.TabIndex = 5;
            this.botaoBusca.Text = "Buscar";
            this.botaoBusca.UseVisualStyleBackColor = true;
            this.botaoBusca.Click += new System.EventHandler(this.botaoBusca_Click);
            // 
            // botaoExclui
            // 
            this.botaoExclui.Location = new System.Drawing.Point(109, 225);
            this.botaoExclui.Name = "botaoExclui";
            this.botaoExclui.Size = new System.Drawing.Size(75, 23);
            this.botaoExclui.TabIndex = 6;
            this.botaoExclui.Text = "Excluir";
            this.botaoExclui.UseVisualStyleBackColor = true;
            // 
            // FormularioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 258);
            this.Controls.Add(this.botaoExclui);
            this.Controls.Add(this.botaoBusca);
            this.Controls.Add(this.textoCpf);
            this.Controls.Add(this.labeCpf);
            this.Controls.Add(this.botaoNovo);
            this.Controls.Add(this.botaoSeleciona);
            this.Controls.Add(this.listaClientes);
            this.Name = "FormularioCliente";
            this.Text = "FormularioCliente";
            this.Load += new System.EventHandler(this.FormularioCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaClientes;
        private System.Windows.Forms.Button botaoSeleciona;
        private System.Windows.Forms.Button botaoNovo;
        private System.Windows.Forms.Label labeCpf;
        private System.Windows.Forms.TextBox textoCpf;
        private System.Windows.Forms.Button botaoBusca;
        private System.Windows.Forms.Button botaoExclui;
    }
}