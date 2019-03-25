namespace Loja.Telas.Estoque.Saida.Desperdicio
{
    partial class CadastroDesperdicio
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
            this.BtRemoverItem = new System.Windows.Forms.Button();
            this.TabelaItens = new System.Windows.Forms.DataGridView();
            this.BtInserir = new System.Windows.Forms.Button();
            this.QuantidadeProduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtLocalizarItem = new System.Windows.Forms.Button();
            this.DescricaoProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Produto = new System.Windows.Forms.TextBox();
            this.DataDesperdicio = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NrDesperdicio = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Motivo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDesperdicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaItens)).BeginInit();
            this.SuspendLayout();
            // 
            // BtRemoverItem
            // 
            this.BtRemoverItem.Location = new System.Drawing.Point(798, 117);
            this.BtRemoverItem.Name = "BtRemoverItem";
            this.BtRemoverItem.Size = new System.Drawing.Size(88, 20);
            this.BtRemoverItem.TabIndex = 200;
            this.BtRemoverItem.Text = "Remover Item";
            this.BtRemoverItem.UseVisualStyleBackColor = true;
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
            this.Valor,
            this.TipoDesperdicio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TabelaItens.DefaultCellStyle = dataGridViewCellStyle2;
            this.TabelaItens.Location = new System.Drawing.Point(12, 143);
            this.TabelaItens.Name = "TabelaItens";
            this.TabelaItens.RowHeadersVisible = false;
            this.TabelaItens.Size = new System.Drawing.Size(872, 321);
            this.TabelaItens.TabIndex = 160;
            // 
            // BtInserir
            // 
            this.BtInserir.Location = new System.Drawing.Point(798, 90);
            this.BtInserir.Name = "BtInserir";
            this.BtInserir.Size = new System.Drawing.Size(86, 20);
            this.BtInserir.TabIndex = 150;
            this.BtInserir.Text = "Inserir";
            this.BtInserir.UseVisualStyleBackColor = true;
            // 
            // QuantidadeProduto
            // 
            this.QuantidadeProduto.Location = new System.Drawing.Point(115, 90);
            this.QuantidadeProduto.Name = "QuantidadeProduto";
            this.QuantidadeProduto.Size = new System.Drawing.Size(100, 20);
            this.QuantidadeProduto.TabIndex = 128;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 93);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 131;
            this.label8.Text = "Quantidade:";
            // 
            // BtLocalizarItem
            // 
            this.BtLocalizarItem.Location = new System.Drawing.Point(282, 38);
            this.BtLocalizarItem.Name = "BtLocalizarItem";
            this.BtLocalizarItem.Size = new System.Drawing.Size(75, 20);
            this.BtLocalizarItem.TabIndex = 126;
            this.BtLocalizarItem.Text = "Localizar";
            this.BtLocalizarItem.UseVisualStyleBackColor = true;
            // 
            // DescricaoProduto
            // 
            this.DescricaoProduto.Location = new System.Drawing.Point(115, 64);
            this.DescricaoProduto.Name = "DescricaoProduto";
            this.DescricaoProduto.Size = new System.Drawing.Size(770, 20);
            this.DescricaoProduto.TabIndex = 127;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 130;
            this.label7.Text = "Descrição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 129;
            this.label6.Text = "Produto:";
            // 
            // Produto
            // 
            this.Produto.Location = new System.Drawing.Point(115, 38);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(165, 20);
            this.Produto.TabIndex = 125;
            // 
            // DataDesperdicio
            // 
            this.DataDesperdicio.Location = new System.Drawing.Point(294, 12);
            this.DataDesperdicio.Name = "DataDesperdicio";
            this.DataDesperdicio.Size = new System.Drawing.Size(100, 20);
            this.DataDesperdicio.TabIndex = 124;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 122;
            this.label2.Text = "Data Registro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 121;
            this.label1.Text = "Numero Desperdício";
            // 
            // NrDesperdicio
            // 
            this.NrDesperdicio.Enabled = false;
            this.NrDesperdicio.Location = new System.Drawing.Point(115, 12);
            this.NrDesperdicio.Name = "NrDesperdicio";
            this.NrDesperdicio.Size = new System.Drawing.Size(100, 20);
            this.NrDesperdicio.TabIndex = 123;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(656, 20);
            this.textBox1.TabIndex = 140;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 136;
            this.label3.Text = "Observação:";
            // 
            // Motivo
            // 
            this.Motivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Motivo.FormattingEnabled = true;
            this.Motivo.Location = new System.Drawing.Point(269, 90);
            this.Motivo.Name = "Motivo";
            this.Motivo.Size = new System.Drawing.Size(503, 21);
            this.Motivo.TabIndex = 130;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 138;
            this.label4.Text = "Motivo:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 470);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 200;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(809, 470);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 210;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
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
            this.ValorItem.HeaderText = "Valor Item";
            this.ValorItem.Name = "ValorItem";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // TipoDesperdicio
            // 
            this.TipoDesperdicio.HeaderText = "Desperdício";
            this.TipoDesperdicio.Name = "TipoDesperdicio";
            this.TipoDesperdicio.Width = 300;
            // 
            // CadastroDesperdicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 499);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Motivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.DataDesperdicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NrDesperdicio);
            this.Name = "CadastroDesperdicio";
            this.Text = "CadastroDesperdicio";
            ((System.ComponentModel.ISupportInitialize)(this.TabelaItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtRemoverItem;
        private System.Windows.Forms.DataGridView TabelaItens;
        private System.Windows.Forms.Button BtInserir;
        private System.Windows.Forms.TextBox QuantidadeProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtLocalizarItem;
        private System.Windows.Forms.TextBox DescricaoProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Produto;
        private System.Windows.Forms.MaskedTextBox DataDesperdicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NrDesperdicio;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Motivo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDesperdicio;
    }
}