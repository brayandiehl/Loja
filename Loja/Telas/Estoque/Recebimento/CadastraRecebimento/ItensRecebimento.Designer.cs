namespace Loja.Telas.Estoque.Recebimento.CadastraRecebimento
{
    partial class ItensRecebimento
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
            this.ListaProdutos = new System.Windows.Forms.DataGridView();
            this.Localizar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtLocalizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaProdutos)).BeginInit();
            this.SuspendLayout();
            // 
            // ListaProdutos
            // 
            this.ListaProdutos.AllowUserToAddRows = false;
            this.ListaProdutos.AllowUserToDeleteRows = false;
            this.ListaProdutos.AllowUserToResizeColumns = false;
            this.ListaProdutos.AllowUserToResizeRows = false;
            this.ListaProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaProdutos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProduto,
            this.Produto});
            this.ListaProdutos.Location = new System.Drawing.Point(12, 38);
            this.ListaProdutos.Name = "ListaProdutos";
            this.ListaProdutos.RowHeadersVisible = false;
            this.ListaProdutos.Size = new System.Drawing.Size(604, 261);
            this.ListaProdutos.TabIndex = 30;
            // 
            // Localizar
            // 
            this.Localizar.Location = new System.Drawing.Point(91, 12);
            this.Localizar.Name = "Localizar";
            this.Localizar.Size = new System.Drawing.Size(444, 20);
            this.Localizar.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Descrição:";
            // 
            // CodProduto
            // 
            this.CodProduto.HeaderText = "Cod Produto";
            this.CodProduto.Name = "CodProduto";
            this.CodProduto.ReadOnly = true;
            this.CodProduto.Width = 200;
            // 
            // Produto
            // 
            this.Produto.HeaderText = "Descrição Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            this.Produto.Width = 400;
            // 
            // BtLocalizar
            // 
            this.BtLocalizar.Location = new System.Drawing.Point(541, 12);
            this.BtLocalizar.Name = "BtLocalizar";
            this.BtLocalizar.Size = new System.Drawing.Size(75, 20);
            this.BtLocalizar.TabIndex = 20;
            this.BtLocalizar.Text = "Localizar";
            this.BtLocalizar.UseVisualStyleBackColor = true;
            // 
            // ItensRecebimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 311);
            this.Controls.Add(this.BtLocalizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Localizar);
            this.Controls.Add(this.ListaProdutos);
            this.Name = "ItensRecebimento";
            this.Text = "ItensRecebimento";
            ((System.ComponentModel.ISupportInitialize)(this.ListaProdutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ListaProdutos;
        private System.Windows.Forms.TextBox Localizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.Button BtLocalizar;
    }
}