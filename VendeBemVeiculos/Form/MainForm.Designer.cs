namespace VendeBemVeiculos
{
    partial class MainForm
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonSale = new System.Windows.Forms.Button();
            this.buttonNewSalesman = new System.Windows.Forms.Button();
            this.buttonHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(74, 7);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(175, 20);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Vende Bem Veículos";
            // 
            // buttonSale
            // 
            this.buttonSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSale.Location = new System.Drawing.Point(52, 45);
            this.buttonSale.Name = "buttonSale";
            this.buttonSale.Size = new System.Drawing.Size(208, 57);
            this.buttonSale.TabIndex = 1;
            this.buttonSale.Text = "Realizar Venda";
            this.buttonSale.UseVisualStyleBackColor = true;
            this.buttonSale.Click += new System.EventHandler(this.ButtonSale_Click);
            // 
            // buttonNewSalesman
            // 
            this.buttonNewSalesman.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewSalesman.Location = new System.Drawing.Point(52, 107);
            this.buttonNewSalesman.Name = "buttonNewSalesman";
            this.buttonNewSalesman.Size = new System.Drawing.Size(208, 57);
            this.buttonNewSalesman.TabIndex = 3;
            this.buttonNewSalesman.Text = "Registrar Novo Vendedor";
            this.buttonNewSalesman.UseVisualStyleBackColor = true;
            this.buttonNewSalesman.Click += new System.EventHandler(this.ButtonSalesman_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHistory.Location = new System.Drawing.Point(52, 171);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(208, 57);
            this.buttonHistory.TabIndex = 4;
            this.buttonHistory.Text = "Histórico de Vendas";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.ButtonHistory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 264);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.buttonNewSalesman);
            this.Controls.Add(this.buttonSale);
            this.Controls.Add(this.labelTitle);
            this.Name = "MainForm";
            this.Text = "Vende Bem Veículos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonSale;
        private System.Windows.Forms.Button buttonNewSalesman;
        private System.Windows.Forms.Button buttonHistory;
    }
}