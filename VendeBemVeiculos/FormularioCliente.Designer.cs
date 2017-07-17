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
            this.ListaClientes = new System.Windows.Forms.ListBox();
            this.BotaoSeleciona = new System.Windows.Forms.Button();
            this.BotaoNovo = new System.Windows.Forms.Button();
            this.labeCpf = new System.Windows.Forms.Label();
            this.TextoCpf = new System.Windows.Forms.TextBox();
            this.botaoBusca = new System.Windows.Forms.Button();
            this.BotaoExclui = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaClientes
            // 
            this.ListaClientes.FormattingEnabled = true;
            this.ListaClientes.Location = new System.Drawing.Point(12, 12);
            this.ListaClientes.Name = "ListaClientes";
            this.ListaClientes.Size = new System.Drawing.Size(260, 173);
            this.ListaClientes.TabIndex = 0;
            this.ListaClientes.SelectedIndexChanged += new System.EventHandler(this.ListaClientes_SelectedIndexChanged);
            // 
            // BotaoSeleciona
            // 
            this.BotaoSeleciona.Location = new System.Drawing.Point(19, 223);
            this.BotaoSeleciona.Name = "BotaoSeleciona";
            this.BotaoSeleciona.Size = new System.Drawing.Size(75, 23);
            this.BotaoSeleciona.TabIndex = 1;
            this.BotaoSeleciona.Text = "Seleciona";
            this.BotaoSeleciona.UseVisualStyleBackColor = true;
            this.BotaoSeleciona.Click += new System.EventHandler(this.BotaoSeleciona_Click);
            // 
            // BotaoNovo
            // 
            this.BotaoNovo.Location = new System.Drawing.Point(181, 223);
            this.BotaoNovo.Name = "BotaoNovo";
            this.BotaoNovo.Size = new System.Drawing.Size(82, 23);
            this.BotaoNovo.TabIndex = 2;
            this.BotaoNovo.Text = "Novo Cliente";
            this.BotaoNovo.UseVisualStyleBackColor = true;
            this.BotaoNovo.Click += new System.EventHandler(this.BotaoNovo_Click);
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
            // TextoCpf
            // 
            this.TextoCpf.Location = new System.Drawing.Point(57, 189);
            this.TextoCpf.Name = "TextoCpf";
            this.TextoCpf.Size = new System.Drawing.Size(134, 20);
            this.TextoCpf.TabIndex = 4;
            // 
            // botaoBusca
            // 
            this.botaoBusca.Location = new System.Drawing.Point(197, 187);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(75, 23);
            this.botaoBusca.TabIndex = 5;
            this.botaoBusca.Text = "Buscar";
            this.botaoBusca.UseVisualStyleBackColor = true;
            this.botaoBusca.Click += new System.EventHandler(this.BotaoBusca_Click);
            // 
            // BotaoExclui
            // 
            this.BotaoExclui.Location = new System.Drawing.Point(100, 223);
            this.BotaoExclui.Name = "BotaoExclui";
            this.BotaoExclui.Size = new System.Drawing.Size(75, 23);
            this.BotaoExclui.TabIndex = 6;
            this.BotaoExclui.Text = "Excluir";
            this.BotaoExclui.UseVisualStyleBackColor = true;
            this.BotaoExclui.Click += new System.EventHandler(this.BotaoExclui_Click);
            // 
            // FormularioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 258);
            this.Controls.Add(this.BotaoExclui);
            this.Controls.Add(this.botaoBusca);
            this.Controls.Add(this.TextoCpf);
            this.Controls.Add(this.labeCpf);
            this.Controls.Add(this.BotaoNovo);
            this.Controls.Add(this.BotaoSeleciona);
            this.Controls.Add(this.ListaClientes);
            this.Name = "FormularioCliente";
            this.Text = "FormularioCliente";
            this.Load += new System.EventHandler(this.FormularioCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListaClientes;
        private System.Windows.Forms.Button BotaoSeleciona;
        private System.Windows.Forms.Button BotaoNovo;
        private System.Windows.Forms.Label labeCpf;
        private System.Windows.Forms.TextBox TextoCpf;
        private System.Windows.Forms.Button botaoBusca;
        private System.Windows.Forms.Button BotaoExclui;
    }
}