namespace Loja.Telas.Estoque.Saida.Pedido
{
    partial class Pedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.NrPedido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DataVenda = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CnpjCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NomeCliete = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.BtInserir = new System.Windows.Forms.Button();
            this.QuantidadeProduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtLocalizarItem = new System.Windows.Forms.Button();
            this.DescricaoProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Produto = new System.Windows.Forms.TextBox();
            this.TabelaItens = new System.Windows.Forms.DataGridView();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtRemoverItem = new System.Windows.Forms.Button();
            this.ValorTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.QtdItens = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BtFinalizar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaItens)).BeginInit();
            this.SuspendLayout();
            // 
            // NrPedido
            // 
            this.NrPedido.Enabled = false;
            this.NrPedido.Location = new System.Drawing.Point(117, 12);
            this.NrPedido.Name = "NrPedido";
            this.NrPedido.Size = new System.Drawing.Size(100, 20);
            this.NrPedido.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número Pedido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Venda:";
            // 
            // DataVenda
            // 
            this.DataVenda.Location = new System.Drawing.Point(296, 12);
            this.DataVenda.Name = "DataVenda";
            this.DataVenda.Size = new System.Drawing.Size(100, 20);
            this.DataVenda.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CPF / CNPJ Cliente";
            // 
            // CnpjCpfCliente
            // 
            this.CnpjCpfCliente.Location = new System.Drawing.Point(117, 38);
            this.CnpjCpfCliente.Name = "CnpjCpfCliente";
            this.CnpjCpfCliente.Size = new System.Drawing.Size(100, 20);
            this.CnpjCpfCliente.TabIndex = 30;
            this.CnpjCpfCliente.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nome:";
            // 
            // NomeCliete
            // 
            this.NomeCliete.Location = new System.Drawing.Point(267, 38);
            this.NomeCliete.Name = "NomeCliete";
            this.NomeCliete.Size = new System.Drawing.Size(539, 20);
            this.NomeCliete.TabIndex = 40;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 50;
            this.button1.Text = "Localizar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtInserir
            // 
            this.BtInserir.Location = new System.Drawing.Point(223, 138);
            this.BtInserir.Name = "BtInserir";
            this.BtInserir.Size = new System.Drawing.Size(75, 20);
            this.BtInserir.TabIndex = 100;
            this.BtInserir.Text = "Inserir";
            this.BtInserir.UseVisualStyleBackColor = true;
            // 
            // QuantidadeProduto
            // 
            this.QuantidadeProduto.Location = new System.Drawing.Point(117, 138);
            this.QuantidadeProduto.Name = "QuantidadeProduto";
            this.QuantidadeProduto.Size = new System.Drawing.Size(100, 20);
            this.QuantidadeProduto.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 93;
            this.label8.Text = "Quantidade:";
            // 
            // BtLocalizarItem
            // 
            this.BtLocalizarItem.Location = new System.Drawing.Point(284, 86);
            this.BtLocalizarItem.Name = "BtLocalizarItem";
            this.BtLocalizarItem.Size = new System.Drawing.Size(75, 20);
            this.BtLocalizarItem.TabIndex = 70;
            this.BtLocalizarItem.Text = "Localizar";
            this.BtLocalizarItem.UseVisualStyleBackColor = true;
            // 
            // DescricaoProduto
            // 
            this.DescricaoProduto.Location = new System.Drawing.Point(117, 112);
            this.DescricaoProduto.Name = "DescricaoProduto";
            this.DescricaoProduto.Size = new System.Drawing.Size(770, 20);
            this.DescricaoProduto.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 92;
            this.label7.Text = "Descrição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 91;
            this.label6.Text = "Produto:";
            // 
            // Produto
            // 
            this.Produto.Location = new System.Drawing.Point(117, 86);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(165, 20);
            this.Produto.TabIndex = 60;
            // 
            // TabelaItens
            // 
            this.TabelaItens.AllowUserToAddRows = false;
            this.TabelaItens.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TabelaItens.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TabelaItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.CodProduto,
            this.Descricao,
            this.Quantidade,
            this.ValorItem,
            this.Valor});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabelaItens.DefaultCellStyle = dataGridViewCellStyle2;
            this.TabelaItens.Location = new System.Drawing.Point(15, 164);
            this.TabelaItens.Name = "TabelaItens";
            this.TabelaItens.RowHeadersVisible = false;
            this.TabelaItens.Size = new System.Drawing.Size(872, 321);
            this.TabelaItens.TabIndex = 110;
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
            this.Descricao.Width = 340;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            this.Quantidade.Width = 80;
            // 
            // ValorItem
            // 
            this.ValorItem.HeaderText = "ValorItem";
            this.ValorItem.Name = "ValorItem";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // BtRemoverItem
            // 
            this.BtRemoverItem.Location = new System.Drawing.Point(799, 138);
            this.BtRemoverItem.Name = "BtRemoverItem";
            this.BtRemoverItem.Size = new System.Drawing.Size(88, 20);
            this.BtRemoverItem.TabIndex = 120;
            this.BtRemoverItem.Text = "Remover Item";
            this.BtRemoverItem.UseVisualStyleBackColor = true;
            // 
            // ValorTotal
            // 
            this.ValorTotal.Location = new System.Drawing.Point(117, 491);
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Size = new System.Drawing.Size(100, 20);
            this.ValorTotal.TabIndex = 130;
            this.ValorTotal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 113;
            this.label5.Text = "Valor Total:";
            // 
            // QtdItens
            // 
            this.QtdItens.Location = new System.Drawing.Point(117, 517);
            this.QtdItens.Name = "QtdItens";
            this.QtdItens.Size = new System.Drawing.Size(100, 20);
            this.QtdItens.TabIndex = 140;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 520);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 115;
            this.label9.Text = "Quantidade Itens:";
            // 
            // BtFinalizar
            // 
            this.BtFinalizar.Location = new System.Drawing.Point(812, 491);
            this.BtFinalizar.Name = "BtFinalizar";
            this.BtFinalizar.Size = new System.Drawing.Size(75, 23);
            this.BtFinalizar.TabIndex = 200;
            this.BtFinalizar.Text = "Finalizar";
            this.BtFinalizar.UseVisualStyleBackColor = true;
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(812, 520);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 210;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            // 
            // Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 549);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtFinalizar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.QtdItens);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ValorTotal);
            this.Controls.Add(this.BtRemoverItem);
            this.Controls.Add(this.TabelaItens);
            this.Controls.Add(this.BtInserir);
            this.Controls.Add(this.QuantidadeProduto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BtLocalizarItem);
            this.Controls.Add(this.DescricaoProduto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Produto);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NomeCliete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CnpjCpfCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataVenda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NrPedido);
            this.Name = "Pedido";
            this.Text = "Pedido";
            this.Load += new System.EventHandler(this.Pedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NrPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox DataVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox CnpjCpfCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox NomeCliete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtInserir;
        private System.Windows.Forms.TextBox QuantidadeProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtLocalizarItem;
        private System.Windows.Forms.TextBox DescricaoProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Produto;
        private System.Windows.Forms.DataGridView TabelaItens;
        private System.Windows.Forms.Button BtRemoverItem;
        private System.Windows.Forms.TextBox ValorTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox QtdItens;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Button BtFinalizar;
        private System.Windows.Forms.Button BtCancelar;
    }
}