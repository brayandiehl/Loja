namespace Loja.Telas.Financeiro.Caixa
{
    partial class FecharCaixa
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
            this.label5 = new System.Windows.Forms.Label();
            this.DtAbertura = new System.Windows.Forms.MaskedTextBox();
            this.FundoInicial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Localizacao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CaixaDisponivel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DtFechamento = new System.Windows.Forms.MaskedTextBox();
            this.ValorDinheiro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ValorCartao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ValorVendas = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ValorTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Diferenca = new System.Windows.Forms.TextBox();
            this.Operador = new System.Windows.Forms.TextBox();
            this.Observacao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Data Abertura:";
            // 
            // DtAbertura
            // 
            this.DtAbertura.Enabled = false;
            this.DtAbertura.Location = new System.Drawing.Point(108, 86);
            this.DtAbertura.Mask = "00/00/0000 90:00";
            this.DtAbertura.Name = "DtAbertura";
            this.DtAbertura.Size = new System.Drawing.Size(100, 20);
            this.DtAbertura.TabIndex = 40;
            this.DtAbertura.ValidatingType = typeof(System.DateTime);
            // 
            // FundoInicial
            // 
            this.FundoInicial.Enabled = false;
            this.FundoInicial.Location = new System.Drawing.Point(292, 86);
            this.FundoInicial.Name = "FundoInicial";
            this.FundoInicial.Size = new System.Drawing.Size(100, 20);
            this.FundoInicial.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 54;
            this.label4.Text = "Fundo Inícial:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Operador:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Localização:";
            // 
            // Localizacao
            // 
            this.Localizacao.Enabled = false;
            this.Localizacao.Location = new System.Drawing.Point(108, 33);
            this.Localizacao.Name = "Localizacao";
            this.Localizacao.Size = new System.Drawing.Size(284, 20);
            this.Localizacao.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Caixa Disponível:";
            // 
            // CaixaDisponivel
            // 
            this.CaixaDisponivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CaixaDisponivel.FormattingEnabled = true;
            this.CaixaDisponivel.Location = new System.Drawing.Point(108, 6);
            this.CaixaDisponivel.Name = "CaixaDisponivel";
            this.CaixaDisponivel.Size = new System.Drawing.Size(284, 21);
            this.CaixaDisponivel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Data Fechamento";
            // 
            // DtFechamento
            // 
            this.DtFechamento.Enabled = false;
            this.DtFechamento.Location = new System.Drawing.Point(108, 112);
            this.DtFechamento.Mask = "00/00/0000 90:00";
            this.DtFechamento.Name = "DtFechamento";
            this.DtFechamento.Size = new System.Drawing.Size(100, 20);
            this.DtFechamento.TabIndex = 50;
            this.DtFechamento.ValidatingType = typeof(System.DateTime);
            // 
            // ValorDinheiro
            // 
            this.ValorDinheiro.Location = new System.Drawing.Point(108, 164);
            this.ValorDinheiro.Name = "ValorDinheiro";
            this.ValorDinheiro.Size = new System.Drawing.Size(100, 20);
            this.ValorDinheiro.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Valor Dinheiro";
            // 
            // ValorCartao
            // 
            this.ValorCartao.Location = new System.Drawing.Point(108, 138);
            this.ValorCartao.Name = "ValorCartao";
            this.ValorCartao.Size = new System.Drawing.Size(100, 20);
            this.ValorCartao.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Valor Cartão";
            // 
            // ValorVendas
            // 
            this.ValorVendas.Enabled = false;
            this.ValorVendas.Location = new System.Drawing.Point(292, 112);
            this.ValorVendas.Name = "ValorVendas";
            this.ValorVendas.Size = new System.Drawing.Size(100, 20);
            this.ValorVendas.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(214, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 69;
            this.label9.Text = "Valor Vendas:";
            // 
            // ValorTotal
            // 
            this.ValorTotal.Enabled = false;
            this.ValorTotal.Location = new System.Drawing.Point(108, 190);
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Size = new System.Drawing.Size(100, 20);
            this.ValorTotal.TabIndex = 100;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "Valor Total";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(214, 193);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 73;
            this.label11.Text = "Diferença";
            // 
            // Diferenca
            // 
            this.Diferenca.Enabled = false;
            this.Diferenca.Location = new System.Drawing.Point(292, 190);
            this.Diferenca.Name = "Diferenca";
            this.Diferenca.Size = new System.Drawing.Size(100, 20);
            this.Diferenca.TabIndex = 110;
            // 
            // Operador
            // 
            this.Operador.Enabled = false;
            this.Operador.Location = new System.Drawing.Point(108, 59);
            this.Operador.Name = "Operador";
            this.Operador.Size = new System.Drawing.Size(284, 20);
            this.Operador.TabIndex = 30;
            // 
            // Observacao
            // 
            this.Observacao.Location = new System.Drawing.Point(108, 216);
            this.Observacao.Name = "Observacao";
            this.Observacao.Size = new System.Drawing.Size(284, 20);
            this.Observacao.TabIndex = 120;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 77;
            this.label12.Text = "Observação:";
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(317, 252);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 210;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            // 
            // BtSalvar
            // 
            this.BtSalvar.Location = new System.Drawing.Point(15, 252);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtSalvar.TabIndex = 200;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            // 
            // FecharCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 287);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Observacao);
            this.Controls.Add(this.Operador);
            this.Controls.Add(this.Diferenca);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ValorTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ValorVendas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ValorCartao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ValorDinheiro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DtFechamento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtAbertura);
            this.Controls.Add(this.FundoInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Localizacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CaixaDisponivel);
            this.Name = "FecharCaixa";
            this.Text = "FecharCaixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox DtAbertura;
        private System.Windows.Forms.TextBox FundoInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Localizacao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CaixaDisponivel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox DtFechamento;
        private System.Windows.Forms.TextBox ValorDinheiro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ValorCartao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ValorVendas;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ValorTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Diferenca;
        private System.Windows.Forms.TextBox Operador;
        private System.Windows.Forms.TextBox Observacao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtSalvar;
    }
}