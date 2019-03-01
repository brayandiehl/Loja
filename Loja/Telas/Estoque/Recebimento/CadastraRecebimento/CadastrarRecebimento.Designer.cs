namespace Loja.Telas.Estoque.Recebimento.CadastraRecebimento
{
    partial class CadastrarRecebimento
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
            this.NumeroNota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataNota = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ValorNota = new System.Windows.Forms.TextBox();
            this.Fornecedor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TabelaItens = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DescricaoProduto = new System.Windows.Forms.TextBox();
            this.BtLocalizarItem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.QuantidadeProduto = new System.Windows.Forms.TextBox();
            this.BtInserir = new System.Windows.Forms.Button();
            this.BtRemover = new System.Windows.Forms.Button();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtLiberar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaItens)).BeginInit();
            this.SuspendLayout();
            // 
            // NumeroNota
            // 
            this.NumeroNota.Location = new System.Drawing.Point(91, 12);
            this.NumeroNota.Name = "NumeroNota";
            this.NumeroNota.Size = new System.Drawing.Size(100, 20);
            this.NumeroNota.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número Nota:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Nota:";
            // 
            // DataNota
            // 
            this.DataNota.Location = new System.Drawing.Point(262, 12);
            this.DataNota.Mask = "00/00/0000";
            this.DataNota.Name = "DataNota";
            this.DataNota.Size = new System.Drawing.Size(71, 20);
            this.DataNota.TabIndex = 20;
            this.DataNota.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor:";
            // 
            // ValorNota
            // 
            this.ValorNota.Location = new System.Drawing.Point(379, 12);
            this.ValorNota.Name = "ValorNota";
            this.ValorNota.Size = new System.Drawing.Size(86, 20);
            this.ValorNota.TabIndex = 30;
            // 
            // Fornecedor
            // 
            this.Fornecedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Fornecedor.FormattingEnabled = true;
            this.Fornecedor.Location = new System.Drawing.Point(91, 38);
            this.Fornecedor.Name = "Fornecedor";
            this.Fornecedor.Size = new System.Drawing.Size(603, 21);
            this.Fornecedor.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fornecedor:";
            // 
            // TabelaItens
            // 
            this.TabelaItens.AllowUserToAddRows = false;
            this.TabelaItens.AllowUserToResizeColumns = false;
            this.TabelaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.CodProduto,
            this.Descricao,
            this.Quantidade});
            this.TabelaItens.Location = new System.Drawing.Point(11, 155);
            this.TabelaItens.Name = "TabelaItens";
            this.TabelaItens.RowHeadersVisible = false;
            this.TabelaItens.Size = new System.Drawing.Size(682, 321);
            this.TabelaItens.TabIndex = 100;
            // 
            // Item
            // 
            this.Item.HeaderText = "Item";
            this.Item.Name = "Item";
            this.Item.ReadOnly = true;
            this.Item.Width = 60;
            // 
            // CodProduto
            // 
            this.CodProduto.HeaderText = "Cód Produto";
            this.CodProduto.Name = "CodProduto";
            this.CodProduto.ReadOnly = true;
            this.CodProduto.Width = 188;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.Name = "Descricao";
            this.Descricao.ReadOnly = true;
            this.Descricao.Width = 350;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 80;
            // 
            // Produto
            // 
            this.Produto.Location = new System.Drawing.Point(91, 77);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(165, 20);
            this.Produto.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Produto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Descrição:";
            // 
            // DescricaoProduto
            // 
            this.DescricaoProduto.Location = new System.Drawing.Point(91, 103);
            this.DescricaoProduto.Name = "DescricaoProduto";
            this.DescricaoProduto.Size = new System.Drawing.Size(602, 20);
            this.DescricaoProduto.TabIndex = 70;
            // 
            // BtLocalizarItem
            // 
            this.BtLocalizarItem.Location = new System.Drawing.Point(258, 77);
            this.BtLocalizarItem.Name = "BtLocalizarItem";
            this.BtLocalizarItem.Size = new System.Drawing.Size(75, 20);
            this.BtLocalizarItem.TabIndex = 60;
            this.BtLocalizarItem.Text = "Localizar";
            this.BtLocalizarItem.UseVisualStyleBackColor = true;
            this.BtLocalizarItem.Click += new System.EventHandler(this.BtLocalizarItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quantidade:";
            // 
            // QuantidadeProduto
            // 
            this.QuantidadeProduto.Location = new System.Drawing.Point(91, 129);
            this.QuantidadeProduto.Name = "QuantidadeProduto";
            this.QuantidadeProduto.Size = new System.Drawing.Size(100, 20);
            this.QuantidadeProduto.TabIndex = 80;
            // 
            // BtInserir
            // 
            this.BtInserir.Location = new System.Drawing.Point(197, 129);
            this.BtInserir.Name = "BtInserir";
            this.BtInserir.Size = new System.Drawing.Size(75, 20);
            this.BtInserir.TabIndex = 90;
            this.BtInserir.Text = "Inserir";
            this.BtInserir.UseVisualStyleBackColor = true;
            // 
            // BtRemover
            // 
            this.BtRemover.Location = new System.Drawing.Point(605, 129);
            this.BtRemover.Name = "BtRemover";
            this.BtRemover.Size = new System.Drawing.Size(88, 20);
            this.BtRemover.TabIndex = 110;
            this.BtRemover.Text = "Remover Item";
            this.BtRemover.UseVisualStyleBackColor = true;
            // 
            // BtSalvar
            // 
            this.BtSalvar.Location = new System.Drawing.Point(11, 482);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtSalvar.TabIndex = 120;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(619, 482);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 140;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BtLiberar
            // 
            this.BtLiberar.Location = new System.Drawing.Point(91, 482);
            this.BtLiberar.Name = "BtLiberar";
            this.BtLiberar.Size = new System.Drawing.Size(75, 23);
            this.BtLiberar.TabIndex = 130;
            this.BtLiberar.Text = "Liberar";
            this.BtLiberar.UseVisualStyleBackColor = true;
            // 
            // CadastrarRecebimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 540);
            this.Controls.Add(this.BtLiberar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.BtRemover);
            this.Controls.Add(this.BtInserir);
            this.Controls.Add(this.QuantidadeProduto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtLocalizarItem);
            this.Controls.Add(this.DescricaoProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Produto);
            this.Controls.Add(this.TabelaItens);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Fornecedor);
            this.Controls.Add(this.ValorNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataNota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumeroNota);
            this.Name = "CadastrarRecebimento";
            this.Text = "Recebimento";
            ((System.ComponentModel.ISupportInitialize)(this.TabelaItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumeroNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox DataNota;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ValorNota;
        private System.Windows.Forms.ComboBox Fornecedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView TabelaItens;
        private System.Windows.Forms.TextBox Produto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DescricaoProduto;
        private System.Windows.Forms.Button BtLocalizarItem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox QuantidadeProduto;
        private System.Windows.Forms.Button BtInserir;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Button BtRemover;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtLiberar;
    }
}