namespace Loja.Telas.Financeiro.Caixa
{
    partial class SaidaCaixa
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
            this.Caixas = new System.Windows.Forms.DataGridView();
            this.Caixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Motivo = new System.Windows.Forms.TextBox();
            this.CaixaSelecionado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ValorRetirado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Solicitante = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DataOperacao = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Caixas)).BeginInit();
            this.SuspendLayout();
            // 
            // Caixas
            // 
            this.Caixas.AllowUserToAddRows = false;
            this.Caixas.AllowUserToDeleteRows = false;
            this.Caixas.AllowUserToResizeColumns = false;
            this.Caixas.AllowUserToResizeRows = false;
            this.Caixas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Caixas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Caixa,
            this.Operador,
            this.Valor});
            this.Caixas.Location = new System.Drawing.Point(12, 12);
            this.Caixas.Name = "Caixas";
            this.Caixas.ReadOnly = true;
            this.Caixas.RowHeadersVisible = false;
            this.Caixas.Size = new System.Drawing.Size(604, 210);
            this.Caixas.TabIndex = 10;
            // 
            // Caixa
            // 
            this.Caixa.HeaderText = "Caixa";
            this.Caixa.Name = "Caixa";
            this.Caixa.ReadOnly = true;
            this.Caixa.Width = 200;
            // 
            // Operador
            // 
            this.Operador.HeaderText = "Oeprador";
            this.Operador.Name = "Operador";
            this.Operador.ReadOnly = true;
            this.Operador.Width = 300;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Motivo";
            // 
            // Motivo
            // 
            this.Motivo.Location = new System.Drawing.Point(87, 254);
            this.Motivo.Name = "Motivo";
            this.Motivo.Size = new System.Drawing.Size(529, 20);
            this.Motivo.TabIndex = 40;
            // 
            // CaixaSelecionado
            // 
            this.CaixaSelecionado.Enabled = false;
            this.CaixaSelecionado.Location = new System.Drawing.Point(87, 228);
            this.CaixaSelecionado.Name = "CaixaSelecionado";
            this.CaixaSelecionado.Size = new System.Drawing.Size(100, 20);
            this.CaixaSelecionado.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Caixa";
            // 
            // ValorRetirado
            // 
            this.ValorRetirado.Location = new System.Drawing.Point(87, 280);
            this.ValorRetirado.Name = "ValorRetirado";
            this.ValorRetirado.Size = new System.Drawing.Size(100, 20);
            this.ValorRetirado.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Valor";
            // 
            // Solicitante
            // 
            this.Solicitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Solicitante.FormattingEnabled = true;
            this.Solicitante.Location = new System.Drawing.Point(87, 306);
            this.Solicitante.Name = "Solicitante";
            this.Solicitante.Size = new System.Drawing.Size(256, 21);
            this.Solicitante.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Solicitante";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Data Operação:";
            // 
            // DataOperacao
            // 
            this.DataOperacao.Location = new System.Drawing.Point(282, 228);
            this.DataOperacao.Mask = "00/00/0000 90:00";
            this.DataOperacao.Name = "DataOperacao";
            this.DataOperacao.Size = new System.Drawing.Size(100, 20);
            this.DataOperacao.TabIndex = 30;
            this.DataOperacao.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 100;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 110;
            this.button2.Text = "Excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SaidaCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 383);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataOperacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Solicitante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ValorRetirado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CaixaSelecionado);
            this.Controls.Add(this.Motivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Caixas);
            this.Name = "SaidaCaixa";
            this.Text = "SaidaCaixa";
            ((System.ComponentModel.ISupportInitialize)(this.Caixas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Caixas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Motivo;
        private System.Windows.Forms.TextBox CaixaSelecionado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ValorRetirado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Solicitante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox DataOperacao;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}