namespace Loja.Telas.Estoque.Estoque
{
    partial class Estoque
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
            this.EstoqueAtual = new System.Windows.Forms.DataGridView();
            this.CodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataValidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueAtual)).BeginInit();
            this.SuspendLayout();
            // 
            // EstoqueAtual
            // 
            this.EstoqueAtual.AllowUserToAddRows = false;
            this.EstoqueAtual.AllowUserToDeleteRows = false;
            this.EstoqueAtual.AllowUserToResizeColumns = false;
            this.EstoqueAtual.AllowUserToResizeRows = false;
            this.EstoqueAtual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EstoqueAtual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProduto,
            this.DescricaoProduto,
            this.Quantidade,
            this.DataValidade,
            this.Lote,
            this.Status,
            this.ValorItem,
            this.ValorTotal});
            this.EstoqueAtual.Location = new System.Drawing.Point(12, 12);
            this.EstoqueAtual.Name = "EstoqueAtual";
            this.EstoqueAtual.RowHeadersVisible = false;
            this.EstoqueAtual.Size = new System.Drawing.Size(1053, 469);
            this.EstoqueAtual.TabIndex = 0;
            // 
            // CodProduto
            // 
            this.CodProduto.HeaderText = "Cod. Produto";
            this.CodProduto.Name = "CodProduto";
            this.CodProduto.Width = 150;
            // 
            // DescricaoProduto
            // 
            this.DescricaoProduto.HeaderText = "Descricao";
            this.DescricaoProduto.Name = "DescricaoProduto";
            this.DescricaoProduto.Width = 300;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // DataValidade
            // 
            this.DataValidade.HeaderText = "Dt. Validade";
            this.DataValidade.Name = "DataValidade";
            // 
            // Lote
            // 
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // ValorItem
            // 
            this.ValorItem.HeaderText = "Valor Item";
            this.ValorItem.Name = "ValorItem";
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "Valor Total";
            this.ValorTotal.Name = "ValorTotal";
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 493);
            this.Controls.Add(this.EstoqueAtual);
            this.Name = "Estoque";
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.EstoqueAtual)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView EstoqueAtual;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataValidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
    }
}