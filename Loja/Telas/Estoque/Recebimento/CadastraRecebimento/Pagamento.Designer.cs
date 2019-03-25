namespace Loja.Telas.Estoque.Recebimento.CadastraRecebimento
{
    partial class Pagamento
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
            this.ValorPagamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FormaPagamento = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Avista = new System.Windows.Forms.TabPage();
            this.TipoPagamentoAvista = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataVencimentoAvista = new System.Windows.Forms.MaskedTextBox();
            this.Parcelado = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.BtSalvarData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumParcela = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.NumeroParcelas = new System.Windows.Forms.TextBox();
            this.TipoPagamentoParcelado = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DataVencimentoParcelado = new System.Windows.Forms.MaskedTextBox();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Avista.SuspendLayout();
            this.Parcelado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ValorPagamento
            // 
            this.ValorPagamento.Location = new System.Drawing.Point(80, 12);
            this.ValorPagamento.Name = "ValorPagamento";
            this.ValorPagamento.Size = new System.Drawing.Size(100, 20);
            this.ValorPagamento.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Forma de Pagamento:";
            // 
            // FormaPagamento
            // 
            this.FormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormaPagamento.FormattingEnabled = true;
            this.FormaPagamento.Location = new System.Drawing.Point(303, 12);
            this.FormaPagamento.Name = "FormaPagamento";
            this.FormaPagamento.Size = new System.Drawing.Size(242, 21);
            this.FormaPagamento.TabIndex = 20;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Avista);
            this.tabControl1.Controls.Add(this.Parcelado);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(533, 221);
            this.tabControl1.TabIndex = 4;
            // 
            // Avista
            // 
            this.Avista.Controls.Add(this.TipoPagamentoAvista);
            this.Avista.Controls.Add(this.label4);
            this.Avista.Controls.Add(this.label3);
            this.Avista.Controls.Add(this.DataVencimentoAvista);
            this.Avista.Location = new System.Drawing.Point(4, 22);
            this.Avista.Name = "Avista";
            this.Avista.Padding = new System.Windows.Forms.Padding(3);
            this.Avista.Size = new System.Drawing.Size(525, 195);
            this.Avista.TabIndex = 0;
            this.Avista.Text = "Avista";
            this.Avista.UseVisualStyleBackColor = true;
            // 
            // TipoPagamentoAvista
            // 
            this.TipoPagamentoAvista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoPagamentoAvista.FormattingEnabled = true;
            this.TipoPagamentoAvista.Location = new System.Drawing.Point(287, 6);
            this.TipoPagamentoAvista.Name = "TipoPagamentoAvista";
            this.TipoPagamentoAvista.Size = new System.Drawing.Size(232, 21);
            this.TipoPagamentoAvista.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo de Pagamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Data Pagamento:";
            // 
            // DataVencimentoAvista
            // 
            this.DataVencimentoAvista.Location = new System.Drawing.Point(104, 6);
            this.DataVencimentoAvista.Mask = "00/00/0000";
            this.DataVencimentoAvista.Name = "DataVencimentoAvista";
            this.DataVencimentoAvista.Size = new System.Drawing.Size(68, 20);
            this.DataVencimentoAvista.TabIndex = 30;
            this.DataVencimentoAvista.ValidatingType = typeof(System.DateTime);
            // 
            // Parcelado
            // 
            this.Parcelado.Controls.Add(this.label9);
            this.Parcelado.Controls.Add(this.textBox1);
            this.Parcelado.Controls.Add(this.label8);
            this.Parcelado.Controls.Add(this.maskedTextBox1);
            this.Parcelado.Controls.Add(this.BtSalvarData);
            this.Parcelado.Controls.Add(this.dataGridView1);
            this.Parcelado.Controls.Add(this.label7);
            this.Parcelado.Controls.Add(this.NumeroParcelas);
            this.Parcelado.Controls.Add(this.TipoPagamentoParcelado);
            this.Parcelado.Controls.Add(this.label6);
            this.Parcelado.Controls.Add(this.label5);
            this.Parcelado.Controls.Add(this.DataVencimentoParcelado);
            this.Parcelado.Location = new System.Drawing.Point(4, 22);
            this.Parcelado.Name = "Parcelado";
            this.Parcelado.Padding = new System.Windows.Forms.Padding(3);
            this.Parcelado.Size = new System.Drawing.Size(525, 195);
            this.Parcelado.TabIndex = 1;
            this.Parcelado.Text = "Parcelado";
            this.Parcelado.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 102;
            this.label9.Text = "Dias Por Parcela:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(104, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(68, 20);
            this.textBox1.TabIndex = 101;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(72, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "Pagamento:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(144, 139);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(68, 20);
            this.maskedTextBox1.TabIndex = 90;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // BtSalvarData
            // 
            this.BtSalvarData.Location = new System.Drawing.Point(137, 165);
            this.BtSalvarData.Name = "BtSalvarData";
            this.BtSalvarData.Size = new System.Drawing.Size(75, 23);
            this.BtSalvarData.TabIndex = 100;
            this.BtSalvarData.Text = "Salvar Data";
            this.BtSalvarData.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumParcela,
            this.Valor,
            this.Data});
            this.dataGridView1.Location = new System.Drawing.Point(218, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(304, 156);
            this.dataGridView1.TabIndex = 80;
            // 
            // NumParcela
            // 
            this.NumParcela.HeaderText = "Num Parcela";
            this.NumParcela.Name = "NumParcela";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Num. de Parcelas";
            // 
            // NumeroParcelas
            // 
            this.NumeroParcelas.Location = new System.Drawing.Point(104, 32);
            this.NumeroParcelas.Name = "NumeroParcelas";
            this.NumeroParcelas.Size = new System.Drawing.Size(68, 20);
            this.NumeroParcelas.TabIndex = 70;
            // 
            // TipoPagamentoParcelado
            // 
            this.TipoPagamentoParcelado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoPagamentoParcelado.FormattingEnabled = true;
            this.TipoPagamentoParcelado.Location = new System.Drawing.Point(287, 6);
            this.TipoPagamentoParcelado.Name = "TipoPagamentoParcelado";
            this.TipoPagamentoParcelado.Size = new System.Drawing.Size(232, 21);
            this.TipoPagamentoParcelado.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Tipo de Pagamento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data Pagamento";
            // 
            // DataVencimentoParcelado
            // 
            this.DataVencimentoParcelado.Location = new System.Drawing.Point(104, 6);
            this.DataVencimentoParcelado.Mask = "00/00/0000";
            this.DataVencimentoParcelado.Name = "DataVencimentoParcelado";
            this.DataVencimentoParcelado.Size = new System.Drawing.Size(68, 20);
            this.DataVencimentoParcelado.TabIndex = 50;
            this.DataVencimentoParcelado.ValidatingType = typeof(System.DateTime);
            // 
            // BtSalvar
            // 
            this.BtSalvar.Location = new System.Drawing.Point(16, 265);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtSalvar.TabIndex = 200;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(470, 265);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 210;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            // 
            // Pagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 302);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.FormaPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ValorPagamento);
            this.Name = "Pagamento";
            this.Text = "Pagamento";
            this.tabControl1.ResumeLayout(false);
            this.Avista.ResumeLayout(false);
            this.Avista.PerformLayout();
            this.Parcelado.ResumeLayout(false);
            this.Parcelado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ValorPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox FormaPagamento;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Avista;
        private System.Windows.Forms.TabPage Parcelado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox DataVencimentoAvista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TipoPagamentoAvista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NumeroParcelas;
        private System.Windows.Forms.ComboBox TipoPagamentoParcelado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox DataVencimentoParcelado;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumParcela;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button BtSalvarData;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
    }
}