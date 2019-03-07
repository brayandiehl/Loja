namespace Loja.Telas.Estoque.Saida.Pedido
{
    partial class PagamentoPedido
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
            this.label1 = new System.Windows.Forms.Label();
            this.NumeroPedido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DataCompra = new System.Windows.Forms.MaskedTextBox();
            this.Cliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ValorPedido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.QtdItensPedido = new System.Windows.Forms.TextBox();
            this.FormaPagamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Dinheiro = new System.Windows.Forms.TabPage();
            this.Troco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ValorRecebido = new System.Windows.Forms.TextBox();
            this.Cartao = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.ValorComJuros = new System.Windows.Forms.TextBox();
            this.Cobrar = new System.Windows.Forms.CheckBox();
            this.Juros = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ValorCobrado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CartaoForma = new System.Windows.Forms.ComboBox();
            this.Cheque = new System.Windows.Forms.TabPage();
            this.DataDepositoCheques = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.QtdCheques = new System.Windows.Forms.TextBox();
            this.DescontoPorcentagem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DescontoReais = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ValorFinal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Observacao = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Dinheiro.SuspendLayout();
            this.Cartao.SuspendLayout();
            this.Cheque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataDepositoCheques)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido:";
            // 
            // NumeroPedido
            // 
            this.NumeroPedido.Enabled = false;
            this.NumeroPedido.Location = new System.Drawing.Point(90, 12);
            this.NumeroPedido.Name = "NumeroPedido";
            this.NumeroPedido.Size = new System.Drawing.Size(127, 20);
            this.NumeroPedido.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Compra:";
            // 
            // DataCompra
            // 
            this.DataCompra.Enabled = false;
            this.DataCompra.Location = new System.Drawing.Point(301, 12);
            this.DataCompra.Name = "DataCompra";
            this.DataCompra.Size = new System.Drawing.Size(100, 20);
            this.DataCompra.TabIndex = 20;
            // 
            // Cliente
            // 
            this.Cliente.Enabled = false;
            this.Cliente.Location = new System.Drawing.Point(90, 38);
            this.Cliente.Name = "Cliente";
            this.Cliente.Size = new System.Drawing.Size(486, 20);
            this.Cliente.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor:";
            // 
            // ValorPedido
            // 
            this.ValorPedido.Enabled = false;
            this.ValorPedido.Location = new System.Drawing.Point(90, 64);
            this.ValorPedido.Name = "ValorPedido";
            this.ValorPedido.Size = new System.Drawing.Size(100, 20);
            this.ValorPedido.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Qtd Itens:";
            // 
            // QtdItensPedido
            // 
            this.QtdItensPedido.Enabled = false;
            this.QtdItensPedido.Location = new System.Drawing.Point(90, 90);
            this.QtdItensPedido.Name = "QtdItensPedido";
            this.QtdItensPedido.Size = new System.Drawing.Size(100, 20);
            this.QtdItensPedido.TabIndex = 50;
            // 
            // FormaPagamento
            // 
            this.FormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FormaPagamento.FormattingEnabled = true;
            this.FormaPagamento.Location = new System.Drawing.Point(312, 64);
            this.FormaPagamento.Name = "FormaPagamento";
            this.FormaPagamento.Size = new System.Drawing.Size(262, 21);
            this.FormaPagamento.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Forma de Pagamento:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Dinheiro);
            this.tabControl1.Controls.Add(this.Cartao);
            this.tabControl1.Controls.Add(this.Cheque);
            this.tabControl1.Location = new System.Drawing.Point(15, 142);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(562, 166);
            this.tabControl1.TabIndex = 100;
            // 
            // Dinheiro
            // 
            this.Dinheiro.Controls.Add(this.Troco);
            this.Dinheiro.Controls.Add(this.label8);
            this.Dinheiro.Controls.Add(this.label7);
            this.Dinheiro.Controls.Add(this.ValorRecebido);
            this.Dinheiro.Location = new System.Drawing.Point(4, 22);
            this.Dinheiro.Name = "Dinheiro";
            this.Dinheiro.Padding = new System.Windows.Forms.Padding(3);
            this.Dinheiro.Size = new System.Drawing.Size(554, 140);
            this.Dinheiro.TabIndex = 0;
            this.Dinheiro.Text = "Dinheiro";
            this.Dinheiro.UseVisualStyleBackColor = true;
            // 
            // Troco
            // 
            this.Troco.Location = new System.Drawing.Point(74, 32);
            this.Troco.Name = "Troco";
            this.Troco.Size = new System.Drawing.Size(100, 20);
            this.Troco.TabIndex = 120;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Troco:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Recebido:";
            // 
            // ValorRecebido
            // 
            this.ValorRecebido.Location = new System.Drawing.Point(74, 6);
            this.ValorRecebido.Name = "ValorRecebido";
            this.ValorRecebido.Size = new System.Drawing.Size(100, 20);
            this.ValorRecebido.TabIndex = 110;
            // 
            // Cartao
            // 
            this.Cartao.Controls.Add(this.label17);
            this.Cartao.Controls.Add(this.ValorComJuros);
            this.Cartao.Controls.Add(this.Cobrar);
            this.Cartao.Controls.Add(this.Juros);
            this.Cartao.Controls.Add(this.label16);
            this.Cartao.Controls.Add(this.label14);
            this.Cartao.Controls.Add(this.ValorCobrado);
            this.Cartao.Controls.Add(this.label9);
            this.Cartao.Controls.Add(this.CartaoForma);
            this.Cartao.Location = new System.Drawing.Point(4, 22);
            this.Cartao.Name = "Cartao";
            this.Cartao.Padding = new System.Windows.Forms.Padding(3);
            this.Cartao.Size = new System.Drawing.Size(554, 140);
            this.Cartao.TabIndex = 1;
            this.Cartao.Text = "Cartão";
            this.Cartao.UseVisualStyleBackColor = true;
            this.Cartao.Click += new System.EventHandler(this.Cartao_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 13);
            this.label17.TabIndex = 12;
            this.label17.Text = "Valor c/ Juros";
            // 
            // ValorComJuros
            // 
            this.ValorComJuros.Enabled = false;
            this.ValorComJuros.Location = new System.Drawing.Point(83, 33);
            this.ValorComJuros.Name = "ValorComJuros";
            this.ValorComJuros.Size = new System.Drawing.Size(100, 20);
            this.ValorComJuros.TabIndex = 160;
            // 
            // Cobrar
            // 
            this.Cobrar.AutoSize = true;
            this.Cobrar.Location = new System.Drawing.Point(364, 8);
            this.Cobrar.Name = "Cobrar";
            this.Cobrar.Size = new System.Drawing.Size(57, 17);
            this.Cobrar.TabIndex = 150;
            this.Cobrar.Text = "Cobrar";
            this.Cobrar.UseVisualStyleBackColor = true;
            // 
            // Juros
            // 
            this.Juros.Location = new System.Drawing.Point(304, 6);
            this.Juros.Name = "Juros";
            this.Juros.Size = new System.Drawing.Size(54, 20);
            this.Juros.TabIndex = 140;
            this.Juros.Text = "3,2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(257, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Juros %:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Cobrado:";
            // 
            // ValorCobrado
            // 
            this.ValorCobrado.Location = new System.Drawing.Point(83, 59);
            this.ValorCobrado.Name = "ValorCobrado";
            this.ValorCobrado.Size = new System.Drawing.Size(100, 20);
            this.ValorCobrado.TabIndex = 170;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Forma:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // CartaoForma
            // 
            this.CartaoForma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CartaoForma.FormattingEnabled = true;
            this.CartaoForma.Location = new System.Drawing.Point(83, 6);
            this.CartaoForma.Name = "CartaoForma";
            this.CartaoForma.Size = new System.Drawing.Size(168, 21);
            this.CartaoForma.TabIndex = 130;
            // 
            // Cheque
            // 
            this.Cheque.Controls.Add(this.DataDepositoCheques);
            this.Cheque.Controls.Add(this.label15);
            this.Cheque.Controls.Add(this.QtdCheques);
            this.Cheque.Location = new System.Drawing.Point(4, 22);
            this.Cheque.Name = "Cheque";
            this.Cheque.Size = new System.Drawing.Size(554, 140);
            this.Cheque.TabIndex = 2;
            this.Cheque.Text = "Cheque";
            this.Cheque.UseVisualStyleBackColor = true;
            // 
            // DataDepositoCheques
            // 
            this.DataDepositoCheques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataDepositoCheques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Valor});
            this.DataDepositoCheques.Location = new System.Drawing.Point(151, 6);
            this.DataDepositoCheques.Name = "DataDepositoCheques";
            this.DataDepositoCheques.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataDepositoCheques.Size = new System.Drawing.Size(247, 124);
            this.DataDepositoCheques.TabIndex = 190;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(1, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Qtd Cheques:";
            // 
            // QtdCheques
            // 
            this.QtdCheques.Location = new System.Drawing.Point(74, 6);
            this.QtdCheques.Name = "QtdCheques";
            this.QtdCheques.Size = new System.Drawing.Size(68, 20);
            this.QtdCheques.TabIndex = 180;
            // 
            // DescontoPorcentagem
            // 
            this.DescontoPorcentagem.Location = new System.Drawing.Point(234, 116);
            this.DescontoPorcentagem.Name = "DescontoPorcentagem";
            this.DescontoPorcentagem.Size = new System.Drawing.Size(68, 20);
            this.DescontoPorcentagem.TabIndex = 80;
            this.DescontoPorcentagem.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(164, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Desconto %";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // DescontoReais
            // 
            this.DescontoReais.Location = new System.Drawing.Point(90, 116);
            this.DescontoReais.Name = "DescontoReais";
            this.DescontoReais.Size = new System.Drawing.Size(68, 20);
            this.DescontoReais.TabIndex = 70;
            this.DescontoReais.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Desconto R$:";
            // 
            // ValorFinal
            // 
            this.ValorFinal.Enabled = false;
            this.ValorFinal.Location = new System.Drawing.Point(374, 116);
            this.ValorFinal.Name = "ValorFinal";
            this.ValorFinal.Size = new System.Drawing.Size(100, 20);
            this.ValorFinal.TabIndex = 90;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(309, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Valor Final:";
            // 
            // Observacao
            // 
            this.Observacao.Location = new System.Drawing.Point(90, 310);
            this.Observacao.Name = "Observacao";
            this.Observacao.Size = new System.Drawing.Size(483, 20);
            this.Observacao.TabIndex = 200;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 5;
            this.label13.Text = "Observação:";
            // 
            // BtSalvar
            // 
            this.BtSalvar.Location = new System.Drawing.Point(12, 347);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtSalvar.TabIndex = 300;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(498, 347);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 310;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            // 
            // PagamentoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 382);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Observacao);
            this.Controls.Add(this.ValorFinal);
            this.Controls.Add(this.DescontoPorcentagem);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DescontoReais);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FormaPagamento);
            this.Controls.Add(this.QtdItensPedido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ValorPedido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cliente);
            this.Controls.Add(this.DataCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumeroPedido);
            this.Controls.Add(this.label1);
            this.Name = "PagamentoPedido";
            this.Text = "PagamentoPedido";
            this.tabControl1.ResumeLayout(false);
            this.Dinheiro.ResumeLayout(false);
            this.Dinheiro.PerformLayout();
            this.Cartao.ResumeLayout(false);
            this.Cartao.PerformLayout();
            this.Cheque.ResumeLayout(false);
            this.Cheque.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataDepositoCheques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumeroPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox DataCompra;
        private System.Windows.Forms.TextBox Cliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ValorPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox QtdItensPedido;
        private System.Windows.Forms.ComboBox FormaPagamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Dinheiro;
        private System.Windows.Forms.TabPage Cartao;
        private System.Windows.Forms.TabPage Cheque;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ValorRecebido;
        private System.Windows.Forms.TextBox Troco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CartaoForma;
        private System.Windows.Forms.TextBox DescontoPorcentagem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox DescontoReais;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ValorFinal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox ValorCobrado;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox QtdCheques;
        private System.Windows.Forms.DataGridView DataDepositoCheques;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.TextBox Juros;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox Cobrar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox ValorComJuros;
        private System.Windows.Forms.TextBox Observacao;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.Button BtCancelar;
    }
}