namespace VendeBemVeiculos
{
    partial class ClientForm
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
            this.listClients = new System.Windows.Forms.ListBox();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.buttonNewClient = new System.Windows.Forms.Button();
            this.labeCPF = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textCPF = new System.Windows.Forms.MaskedTextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listClients
            // 
            this.listClients.FormattingEnabled = true;
            this.listClients.ItemHeight = 16;
            this.listClients.Location = new System.Drawing.Point(14, 39);
            this.listClients.Margin = new System.Windows.Forms.Padding(5);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(466, 260);
            this.listClients.TabIndex = 0;
            this.listClients.SelectedIndexChanged += new System.EventHandler(this.ListClients_SelectedIndexChanged);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(24, 365);
            this.buttonSelect.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(125, 35);
            this.buttonSelect.TabIndex = 1;
            this.buttonSelect.Text = "Selecionar";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.ButtonSelect_Click);
            // 
            // buttonNewClient
            // 
            this.buttonNewClient.Location = new System.Drawing.Point(343, 366);
            this.buttonNewClient.Margin = new System.Windows.Forms.Padding(5);
            this.buttonNewClient.Name = "buttonNewClient";
            this.buttonNewClient.Size = new System.Drawing.Size(136, 35);
            this.buttonNewClient.TabIndex = 2;
            this.buttonNewClient.Text = "Novo Cliente";
            this.buttonNewClient.UseVisualStyleBackColor = true;
            this.buttonNewClient.Click += new System.EventHandler(this.ButtonNewClient_Click);
            // 
            // labeCPF
            // 
            this.labeCPF.AutoSize = true;
            this.labeCPF.Location = new System.Drawing.Point(66, 323);
            this.labeCPF.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labeCPF.Name = "labeCPF";
            this.labeCPF.Size = new System.Drawing.Size(38, 17);
            this.labeCPF.TabIndex = 3;
            this.labeCPF.Text = "CPF:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(302, 315);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(125, 35);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Buscar";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(186, 365);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(5);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 35);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Excluir";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(140, 319);
            this.textCPF.Mask = "000,000,000-00";
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(123, 23);
            this.textCPF.TabIndex = 7;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(192, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(74, 20);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Clientes";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 414);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labeCPF);
            this.Controls.Add(this.buttonNewClient);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.listClients);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ClientForm";
            this.Text = "Vende Bem Veículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listClients;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.Button buttonNewClient;
        private System.Windows.Forms.Label labeCPF;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.MaskedTextBox textCPF;
        private System.Windows.Forms.Label labelTitle;
    }
}