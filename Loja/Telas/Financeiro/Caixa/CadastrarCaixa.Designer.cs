namespace Loja.Telas.Financeiro.Caixa
{
    partial class CadastrarCaixa
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
            this.NrCaixa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Localizacao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AceitaCartaoSim = new System.Windows.Forms.RadioButton();
            this.AceitaCartaoNao = new System.Windows.Forms.RadioButton();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.BtLocalizar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AtivoNao = new System.Windows.Forms.RadioButton();
            this.AtivoSim = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NrCaixa
            // 
            this.NrCaixa.Location = new System.Drawing.Point(100, 12);
            this.NrCaixa.Name = "NrCaixa";
            this.NrCaixa.Size = new System.Drawing.Size(124, 20);
            this.NrCaixa.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numero Caixa";
            // 
            // Localizacao
            // 
            this.Localizacao.Location = new System.Drawing.Point(100, 38);
            this.Localizacao.Name = "Localizacao";
            this.Localizacao.Size = new System.Drawing.Size(277, 20);
            this.Localizacao.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Localização:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Aceita Cartão:";
            // 
            // AceitaCartaoSim
            // 
            this.AceitaCartaoSim.AutoSize = true;
            this.AceitaCartaoSim.Checked = true;
            this.AceitaCartaoSim.Location = new System.Drawing.Point(94, 14);
            this.AceitaCartaoSim.Name = "AceitaCartaoSim";
            this.AceitaCartaoSim.Size = new System.Drawing.Size(42, 17);
            this.AceitaCartaoSim.TabIndex = 31;
            this.AceitaCartaoSim.TabStop = true;
            this.AceitaCartaoSim.Text = "Sim";
            this.AceitaCartaoSim.UseVisualStyleBackColor = true;
            // 
            // AceitaCartaoNao
            // 
            this.AceitaCartaoNao.AutoSize = true;
            this.AceitaCartaoNao.Location = new System.Drawing.Point(142, 14);
            this.AceitaCartaoNao.Name = "AceitaCartaoNao";
            this.AceitaCartaoNao.Size = new System.Drawing.Size(45, 17);
            this.AceitaCartaoNao.TabIndex = 32;
            this.AceitaCartaoNao.Text = "Não";
            this.AceitaCartaoNao.UseVisualStyleBackColor = true;
            // 
            // BtSalvar
            // 
            this.BtSalvar.Location = new System.Drawing.Point(12, 154);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtSalvar.TabIndex = 70;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            // 
            // BtLocalizar
            // 
            this.BtLocalizar.Location = new System.Drawing.Point(93, 154);
            this.BtLocalizar.Name = "BtLocalizar";
            this.BtLocalizar.Size = new System.Drawing.Size(75, 23);
            this.BtLocalizar.TabIndex = 80;
            this.BtLocalizar.Text = "Localizar";
            this.BtLocalizar.UseVisualStyleBackColor = true;
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(302, 154);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 90;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AceitaCartaoSim);
            this.groupBox1.Controls.Add(this.AceitaCartaoNao);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 39);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AtivoNao);
            this.groupBox2.Controls.Add(this.AtivoSim);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 39);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            // 
            // AtivoNao
            // 
            this.AtivoNao.AutoSize = true;
            this.AtivoNao.Location = new System.Drawing.Point(142, 14);
            this.AtivoNao.Name = "AtivoNao";
            this.AtivoNao.Size = new System.Drawing.Size(45, 17);
            this.AtivoNao.TabIndex = 42;
            this.AtivoNao.Text = "Não";
            this.AtivoNao.UseVisualStyleBackColor = true;
            // 
            // AtivoSim
            // 
            this.AtivoSim.AutoSize = true;
            this.AtivoSim.Checked = true;
            this.AtivoSim.Location = new System.Drawing.Point(94, 14);
            this.AtivoSim.Name = "AtivoSim";
            this.AtivoSim.Size = new System.Drawing.Size(42, 17);
            this.AtivoSim.TabIndex = 41;
            this.AtivoSim.TabStop = true;
            this.AtivoSim.Text = "Sim";
            this.AtivoSim.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "Ativo";
            // 
            // CadastrarCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 191);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtLocalizar);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Localizacao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NrCaixa);
            this.Name = "CadastrarCaixa";
            this.Text = "CadastrarCaixa";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NrCaixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Localizacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton AceitaCartaoSim;
        private System.Windows.Forms.RadioButton AceitaCartaoNao;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.Button BtLocalizar;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton AtivoNao;
        private System.Windows.Forms.RadioButton AtivoSim;
        private System.Windows.Forms.Label label4;
    }
}