namespace Loja.Telas.Financeiro.Caixa
{
    partial class AcompanharCaixas
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
            this.Caixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtAbertura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorCartao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VlDinheiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Caixa,
            this.Localizacao,
            this.Operador,
            this.DtAbertura,
            this.ValorCartao,
            this.VlDinheiro,
            this.Total});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(980, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // Caixa
            // 
            this.Caixa.FillWeight = 69.28934F;
            this.Caixa.HeaderText = "Caixa";
            this.Caixa.MinimumWidth = 80;
            this.Caixa.Name = "Caixa";
            this.Caixa.Width = 80;
            // 
            // Localizacao
            // 
            this.Localizacao.FillWeight = 69.28934F;
            this.Localizacao.HeaderText = "Localizacao";
            this.Localizacao.MinimumWidth = 250;
            this.Localizacao.Name = "Localizacao";
            this.Localizacao.Width = 250;
            // 
            // Operador
            // 
            this.Operador.FillWeight = 69.28934F;
            this.Operador.HeaderText = "Operador";
            this.Operador.MinimumWidth = 300;
            this.Operador.Name = "Operador";
            this.Operador.Width = 300;
            // 
            // DtAbertura
            // 
            this.DtAbertura.FillWeight = 69.28934F;
            this.DtAbertura.HeaderText = "Dt. Abertura";
            this.DtAbertura.MinimumWidth = 90;
            this.DtAbertura.Name = "DtAbertura";
            this.DtAbertura.Width = 90;
            // 
            // ValorCartao
            // 
            this.ValorCartao.FillWeight = 69.28934F;
            this.ValorCartao.HeaderText = "Vl Cartão";
            this.ValorCartao.MinimumWidth = 80;
            this.ValorCartao.Name = "ValorCartao";
            this.ValorCartao.Width = 80;
            // 
            // VlDinheiro
            // 
            this.VlDinheiro.FillWeight = 69.28934F;
            this.VlDinheiro.HeaderText = "Valor Dinheiro";
            this.VlDinheiro.MinimumWidth = 80;
            this.VlDinheiro.Name = "VlDinheiro";
            this.VlDinheiro.Width = 98;
            // 
            // Total
            // 
            this.Total.FillWeight = 284.2639F;
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 80;
            this.Total.Name = "Total";
            this.Total.Width = 80;
            // 
            // AcompanharCaixas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(980, 453);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AcompanharCaixas";
            this.Text = "AcompanharCaixas";
            this.Load += new System.EventHandler(this.AcompanharCaixas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Caixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operador;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtAbertura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorCartao;
        private System.Windows.Forms.DataGridViewTextBoxColumn VlDinheiro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}