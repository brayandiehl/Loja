namespace Loja.Telas.Financeiro.Caixa
{
    partial class AbrirCaixa
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
            this.CaixaDisponivel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Localizacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Operador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FundoInicial = new System.Windows.Forms.TextBox();
            this.DtAbertura = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtAbrirCaixa = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CaixaDisponivel
            // 
            this.CaixaDisponivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CaixaDisponivel.FormattingEnabled = true;
            this.CaixaDisponivel.Location = new System.Drawing.Point(108, 37);
            this.CaixaDisponivel.Name = "CaixaDisponivel";
            this.CaixaDisponivel.Size = new System.Drawing.Size(251, 21);
            this.CaixaDisponivel.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Caixa Disponível:";
            // 
            // Localizacao
            // 
            this.Localizacao.Enabled = false;
            this.Localizacao.Location = new System.Drawing.Point(108, 64);
            this.Localizacao.Name = "Localizacao";
            this.Localizacao.Size = new System.Drawing.Size(251, 20);
            this.Localizacao.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Localização:";
            // 
            // Operador
            // 
            this.Operador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Operador.FormattingEnabled = true;
            this.Operador.Location = new System.Drawing.Point(108, 90);
            this.Operador.Name = "Operador";
            this.Operador.Size = new System.Drawing.Size(251, 21);
            this.Operador.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Operador:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fundo Inícial:";
            // 
            // FundoInicial
            // 
            this.FundoInicial.Location = new System.Drawing.Point(108, 117);
            this.FundoInicial.Name = "FundoInicial";
            this.FundoInicial.Size = new System.Drawing.Size(100, 20);
            this.FundoInicial.TabIndex = 50;
            // 
            // DtAbertura
            // 
            this.DtAbertura.Enabled = false;
            this.DtAbertura.Location = new System.Drawing.Point(108, 11);
            this.DtAbertura.Mask = "00/00/0000 90:00";
            this.DtAbertura.Name = "DtAbertura";
            this.DtAbertura.Size = new System.Drawing.Size(100, 20);
            this.DtAbertura.TabIndex = 10;
            this.DtAbertura.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data Abertura:";
            // 
            // BtAbrirCaixa
            // 
            this.BtAbrirCaixa.Location = new System.Drawing.Point(9, 165);
            this.BtAbrirCaixa.Name = "BtAbrirCaixa";
            this.BtAbrirCaixa.Size = new System.Drawing.Size(75, 23);
            this.BtAbrirCaixa.TabIndex = 60;
            this.BtAbrirCaixa.Text = "Abrir Caixa";
            this.BtAbrirCaixa.UseVisualStyleBackColor = true;
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(307, 165);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 70;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            // 
            // AbrirCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 200);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtAbrirCaixa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DtAbertura);
            this.Controls.Add(this.FundoInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Operador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Localizacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CaixaDisponivel);
            this.Name = "AbrirCaixa";
            this.Text = "AbrirCaixa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CaixaDisponivel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Localizacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Operador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FundoInicial;
        private System.Windows.Forms.MaskedTextBox DtAbertura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtAbrirCaixa;
        private System.Windows.Forms.Button BtCancelar;
    }
}