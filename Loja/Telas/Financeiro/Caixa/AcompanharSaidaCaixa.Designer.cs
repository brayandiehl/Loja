namespace Loja.Telas.Financeiro.Caixa
{
    partial class AcompanharSaidaCaixa
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
            this.SaidaCaixa = new System.Windows.Forms.DataGridView();
            this.Caixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SaidaCaixa)).BeginInit();
            this.SuspendLayout();
            // 
            // SaidaCaixa
            // 
            this.SaidaCaixa.AllowUserToAddRows = false;
            this.SaidaCaixa.AllowUserToDeleteRows = false;
            this.SaidaCaixa.AllowUserToResizeColumns = false;
            this.SaidaCaixa.AllowUserToResizeRows = false;
            this.SaidaCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaidaCaixa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Caixa,
            this.Solicitante,
            this.Motivo,
            this.Valor,
            this.Excluir});
            this.SaidaCaixa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaidaCaixa.Location = new System.Drawing.Point(0, 0);
            this.SaidaCaixa.Name = "SaidaCaixa";
            this.SaidaCaixa.RowHeadersVisible = false;
            this.SaidaCaixa.Size = new System.Drawing.Size(903, 450);
            this.SaidaCaixa.TabIndex = 0;
            // 
            // Caixa
            // 
            this.Caixa.HeaderText = "Caixa";
            this.Caixa.Name = "Caixa";
            // 
            // Solicitante
            // 
            this.Solicitante.HeaderText = "Solicitante";
            this.Solicitante.Name = "Solicitante";
            this.Solicitante.Width = 250;
            // 
            // Motivo
            // 
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.Width = 350;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            // 
            // AcompanharSaidaCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.Controls.Add(this.SaidaCaixa);
            this.Name = "AcompanharSaidaCaixa";
            this.Text = "AcompanharSaidaCaixa";
            this.Load += new System.EventHandler(this.AcompanharSaidaCaixa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaidaCaixa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SaidaCaixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}