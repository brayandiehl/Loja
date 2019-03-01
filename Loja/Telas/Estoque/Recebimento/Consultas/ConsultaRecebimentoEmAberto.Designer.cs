namespace Loja.Telas.Estoque.Recebimento.Consultas
{
    partial class ConsultaRecebimentoEmAberto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumeroNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroNota,
            this.DataNota,
            this.Fornecedor,
            this.Status,
            this.Excluir});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(753, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // NumeroNota
            // 
            this.NumeroNota.HeaderText = "Num da Nota";
            this.NumeroNota.Name = "NumeroNota";
            this.NumeroNota.ReadOnly = true;
            // 
            // DataNota
            // 
            this.DataNota.HeaderText = "Data Nota";
            this.DataNota.Name = "DataNota";
            this.DataNota.ReadOnly = true;
            // 
            // Fornecedor
            // 
            this.Fornecedor.HeaderText = "Fornecedor";
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.ReadOnly = true;
            this.Fornecedor.Width = 300;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            this.Excluir.ReadOnly = true;
            // 
            // ConsultaRecebimentoEmAberto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultaRecebimentoEmAberto";
            this.Text = "Consulta Recebimento Em Aberto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataNota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}