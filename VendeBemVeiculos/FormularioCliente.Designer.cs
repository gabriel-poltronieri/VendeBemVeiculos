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
            this.botaoNovoCliente = new System.Windows.Forms.Button();
            this.labeCPF = new System.Windows.Forms.Label();
            this.textoCPF = new System.Windows.Forms.TextBox();
            this.botaoBuscar = new System.Windows.Forms.Button();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listaClientes
            // 
            this.listaClientes.FormattingEnabled = true;
            this.listaClientes.Location = new System.Drawing.Point(12, 12);
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.Size = new System.Drawing.Size(260, 173);
            this.listaClientes.TabIndex = 0;
            this.listaClientes.SelectedIndexChanged += new System.EventHandler(this.ListaClientes_SelectedIndexChanged);
            // 
            // botaoSeleciona
            // 
            this.botaoSeleciona.Location = new System.Drawing.Point(12, 223);
            this.botaoSeleciona.Name = "botaoSeleciona";
            this.botaoSeleciona.Size = new System.Drawing.Size(75, 23);
            this.botaoSeleciona.TabIndex = 1;
            this.botaoSeleciona.Text = "Seleciona";
            this.botaoSeleciona.UseVisualStyleBackColor = true;
            // 
            // botaoNovoCliente
            // 
            this.botaoNovoCliente.Location = new System.Drawing.Point(190, 223);
            this.botaoNovoCliente.Name = "botaoNovoCliente";
            this.botaoNovoCliente.Size = new System.Drawing.Size(82, 23);
            this.botaoNovoCliente.TabIndex = 2;
            this.botaoNovoCliente.Text = "Novo Cliente";
            this.botaoNovoCliente.UseVisualStyleBackColor = true;
            this.botaoNovoCliente.Click += new System.EventHandler(this.BotaoNovoCliente_Click);
            // 
            // labeCPF
            // 
            this.labeCPF.AutoSize = true;
            this.labeCPF.Location = new System.Drawing.Point(13, 192);
            this.labeCPF.Name = "labeCPF";
            this.labeCPF.Size = new System.Drawing.Size(30, 13);
            this.labeCPF.TabIndex = 3;
            this.labeCPF.Text = "CPF:";
            // 
            // textoCPF
            // 
            this.textoCPF.Location = new System.Drawing.Point(57, 189);
            this.textoCPF.Name = "textoCPF";
            this.textoCPF.Size = new System.Drawing.Size(134, 20);
            this.textoCPF.TabIndex = 4;
            // 
            // botaoBuscar
            // 
            this.botaoBuscar.Location = new System.Drawing.Point(197, 187);
            this.botaoBuscar.Name = "botaoBuscar";
            this.botaoBuscar.Size = new System.Drawing.Size(75, 23);
            this.botaoBuscar.TabIndex = 5;
            this.botaoBuscar.Text = "Buscar";
            this.botaoBuscar.UseVisualStyleBackColor = true;
            this.botaoBuscar.Click += new System.EventHandler(this.BotaoBuscar_Click);
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Location = new System.Drawing.Point(100, 223);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(75, 23);
            this.botaoExcluir.TabIndex = 6;
            this.botaoExcluir.Text = "Excluir";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Click += new System.EventHandler(this.BotaoExcluir_Click);
            // 
            // FormularioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.botaoBuscar);
            this.Controls.Add(this.textoCPF);
            this.Controls.Add(this.labeCPF);
            this.Controls.Add(this.botaoNovoCliente);
            this.Controls.Add(this.botaoSeleciona);
            this.Controls.Add(this.listaClientes);
            this.Name = "FormularioCliente";
            this.Text = "FormularioCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaClientes;
        private System.Windows.Forms.Button botaoSeleciona;
        private System.Windows.Forms.Button botaoNovoCliente;
        private System.Windows.Forms.Label labeCPF;
        private System.Windows.Forms.TextBox textoCPF;
        private System.Windows.Forms.Button botaoBuscar;
        private System.Windows.Forms.Button botaoExcluir;
    }
}