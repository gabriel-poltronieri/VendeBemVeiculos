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
            this.botaoSelecionar = new System.Windows.Forms.Button();
            this.botaoNovoCliente = new System.Windows.Forms.Button();
            this.labeCPF = new System.Windows.Forms.Label();
            this.botaoBuscar = new System.Windows.Forms.Button();
            this.botaoExcluir = new System.Windows.Forms.Button();
            this.textoCPF = new System.Windows.Forms.MaskedTextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listaClientes
            // 
            this.listaClientes.FormattingEnabled = true;
            this.listaClientes.ItemHeight = 20;
            this.listaClientes.Location = new System.Drawing.Point(14, 39);
            this.listaClientes.Margin = new System.Windows.Forms.Padding(5);
            this.listaClientes.Name = "listaClientes";
            this.listaClientes.Size = new System.Drawing.Size(466, 264);
            this.listaClientes.TabIndex = 0;
            this.listaClientes.SelectedIndexChanged += new System.EventHandler(this.ListaClientes_SelectedIndexChanged);
            // 
            // botaoSelecionar
            // 
            this.botaoSelecionar.Location = new System.Drawing.Point(24, 365);
            this.botaoSelecionar.Margin = new System.Windows.Forms.Padding(5);
            this.botaoSelecionar.Name = "botaoSelecionar";
            this.botaoSelecionar.Size = new System.Drawing.Size(125, 35);
            this.botaoSelecionar.TabIndex = 1;
            this.botaoSelecionar.Text = "Selecionar";
            this.botaoSelecionar.UseVisualStyleBackColor = true;
            this.botaoSelecionar.Click += new System.EventHandler(this.BotaoSeleciona_Click);
            // 
            // botaoNovoCliente
            // 
            this.botaoNovoCliente.Location = new System.Drawing.Point(343, 366);
            this.botaoNovoCliente.Margin = new System.Windows.Forms.Padding(5);
            this.botaoNovoCliente.Name = "botaoNovoCliente";
            this.botaoNovoCliente.Size = new System.Drawing.Size(136, 35);
            this.botaoNovoCliente.TabIndex = 2;
            this.botaoNovoCliente.Text = "Novo Cliente";
            this.botaoNovoCliente.UseVisualStyleBackColor = true;
            this.botaoNovoCliente.Click += new System.EventHandler(this.BotaoNovoCliente_Click);
            // 
            // labeCPF
            // 
            this.labeCPF.AutoSize = true;
            this.labeCPF.Location = new System.Drawing.Point(66, 323);
            this.labeCPF.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labeCPF.Name = "labeCPF";
            this.labeCPF.Size = new System.Drawing.Size(47, 20);
            this.labeCPF.TabIndex = 3;
            this.labeCPF.Text = "CPF:";
            // 
            // botaoBuscar
            // 
            this.botaoBuscar.Location = new System.Drawing.Point(302, 315);
            this.botaoBuscar.Margin = new System.Windows.Forms.Padding(5);
            this.botaoBuscar.Name = "botaoBuscar";
            this.botaoBuscar.Size = new System.Drawing.Size(125, 35);
            this.botaoBuscar.TabIndex = 5;
            this.botaoBuscar.Text = "Buscar";
            this.botaoBuscar.UseVisualStyleBackColor = true;
            this.botaoBuscar.Click += new System.EventHandler(this.BotaoBuscar_Click);
            // 
            // botaoExcluir
            // 
            this.botaoExcluir.Location = new System.Drawing.Point(186, 365);
            this.botaoExcluir.Margin = new System.Windows.Forms.Padding(5);
            this.botaoExcluir.Name = "botaoExcluir";
            this.botaoExcluir.Size = new System.Drawing.Size(125, 35);
            this.botaoExcluir.TabIndex = 6;
            this.botaoExcluir.Text = "Excluir";
            this.botaoExcluir.UseVisualStyleBackColor = true;
            this.botaoExcluir.Click += new System.EventHandler(this.BotaoExcluir_Click);
            // 
            // textoCPF
            // 
            this.textoCPF.Location = new System.Drawing.Point(140, 319);
            this.textoCPF.Mask = "000,000,000-00";
            this.textoCPF.Name = "textoCPF";
            this.textoCPF.Size = new System.Drawing.Size(123, 26);
            this.textoCPF.TabIndex = 7;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(192, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(91, 25);
            this.labelTitulo.TabIndex = 8;
            this.labelTitulo.Text = "Clientes";
            // 
            // FormularioCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 414);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.textoCPF);
            this.Controls.Add(this.botaoExcluir);
            this.Controls.Add(this.botaoBuscar);
            this.Controls.Add(this.labeCPF);
            this.Controls.Add(this.botaoNovoCliente);
            this.Controls.Add(this.botaoSelecionar);
            this.Controls.Add(this.listaClientes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FormularioCliente";
            this.Text = "Vende Bem Veículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listaClientes;
        private System.Windows.Forms.Button botaoSelecionar;
        private System.Windows.Forms.Button botaoNovoCliente;
        private System.Windows.Forms.Label labeCPF;
        private System.Windows.Forms.Button botaoBuscar;
        private System.Windows.Forms.Button botaoExcluir;
        private System.Windows.Forms.MaskedTextBox textoCPF;
        private System.Windows.Forms.Label labelTitulo;
    }
}