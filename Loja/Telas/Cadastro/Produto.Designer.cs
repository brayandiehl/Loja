namespace Loja.Telas.Cadastro
{
    partial class Produto
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
            this.CodProduto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeProduto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Descricao = new System.Windows.Forms.TextBox();
            this.Marca = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Dados = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.EstoqueAtual = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.EstoqueMinimo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ValorVenda = new System.Windows.Forms.TextBox();
            this.Unidade = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GarantiasEmDias = new System.Windows.Forms.TextBox();
            this.Categoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Configuracao = new System.Windows.Forms.TabPage();
            this.BtAdicionarImagem = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.PrdAtivo = new System.Windows.Forms.CheckBox();
            this.AlertaProdutoVencer = new System.Windows.Forms.CheckBox();
            this.ControleLote = new System.Windows.Forms.CheckBox();
            this.ControlaValidade = new System.Windows.Forms.CheckBox();
            this.AlertaEstoqueMinimo = new System.Windows.Forms.CheckBox();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtLocalizar = new System.Windows.Forms.Button();
            this.ImagemProduto = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.Dados.SuspendLayout();
            this.Configuracao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cod. Produto:";
            // 
            // CodProduto
            // 
            this.CodProduto.Location = new System.Drawing.Point(94, 12);
            this.CodProduto.Name = "CodProduto";
            this.CodProduto.Size = new System.Drawing.Size(213, 20);
            this.CodProduto.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(313, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // NomeProduto
            // 
            this.NomeProduto.Location = new System.Drawing.Point(357, 12);
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.Size = new System.Drawing.Size(448, 20);
            this.NomeProduto.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição:";
            // 
            // Descricao
            // 
            this.Descricao.Location = new System.Drawing.Point(89, 6);
            this.Descricao.Name = "Descricao";
            this.Descricao.Size = new System.Drawing.Size(688, 20);
            this.Descricao.TabIndex = 40;
            // 
            // Marca
            // 
            this.Marca.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Marca.FormattingEnabled = true;
            this.Marca.Location = new System.Drawing.Point(89, 32);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(293, 21);
            this.Marca.TabIndex = 60;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Dados);
            this.tabControl1.Controls.Add(this.Configuracao);
            this.tabControl1.Location = new System.Drawing.Point(12, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(791, 233);
            this.tabControl1.TabIndex = 30;
            // 
            // Dados
            // 
            this.Dados.Controls.Add(this.label14);
            this.Dados.Controls.Add(this.EstoqueAtual);
            this.Dados.Controls.Add(this.label13);
            this.Dados.Controls.Add(this.EstoqueMinimo);
            this.Dados.Controls.Add(this.label10);
            this.Dados.Controls.Add(this.label8);
            this.Dados.Controls.Add(this.ValorVenda);
            this.Dados.Controls.Add(this.Unidade);
            this.Dados.Controls.Add(this.label9);
            this.Dados.Controls.Add(this.GarantiasEmDias);
            this.Dados.Controls.Add(this.Categoria);
            this.Dados.Controls.Add(this.label4);
            this.Dados.Controls.Add(this.Marca);
            this.Dados.Controls.Add(this.label5);
            this.Dados.Controls.Add(this.label3);
            this.Dados.Controls.Add(this.Descricao);
            this.Dados.Location = new System.Drawing.Point(4, 22);
            this.Dados.Name = "Dados";
            this.Dados.Padding = new System.Windows.Forms.Padding(3);
            this.Dados.Size = new System.Drawing.Size(783, 207);
            this.Dados.TabIndex = 0;
            this.Dados.Text = "Dados";
            this.Dados.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(229, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 28;
            this.label14.Text = "Estoque Atual";
            // 
            // EstoqueAtual
            // 
            this.EstoqueAtual.Enabled = false;
            this.EstoqueAtual.Location = new System.Drawing.Point(318, 86);
            this.EstoqueAtual.Name = "EstoqueAtual";
            this.EstoqueAtual.Size = new System.Drawing.Size(64, 20);
            this.EstoqueAtual.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Estoque Minimo";
            // 
            // EstoqueMinimo
            // 
            this.EstoqueMinimo.Location = new System.Drawing.Point(89, 112);
            this.EstoqueMinimo.Name = "EstoqueMinimo";
            this.EstoqueMinimo.Size = new System.Drawing.Size(100, 20);
            this.EstoqueMinimo.TabIndex = 120;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Valor Venda";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Unidade:";
            // 
            // ValorVenda
            // 
            this.ValorVenda.Location = new System.Drawing.Point(89, 86);
            this.ValorVenda.Name = "ValorVenda";
            this.ValorVenda.Size = new System.Drawing.Size(100, 20);
            this.ValorVenda.TabIndex = 110;
            // 
            // Unidade
            // 
            this.Unidade.FormattingEnabled = true;
            this.Unidade.Location = new System.Drawing.Point(89, 59);
            this.Unidade.Name = "Unidade";
            this.Unidade.Size = new System.Drawing.Size(134, 21);
            this.Unidade.TabIndex = 80;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(229, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Garantia Dias:";
            // 
            // GarantiasEmDias
            // 
            this.GarantiasEmDias.Location = new System.Drawing.Point(318, 60);
            this.GarantiasEmDias.Name = "GarantiasEmDias";
            this.GarantiasEmDias.Size = new System.Drawing.Size(64, 20);
            this.GarantiasEmDias.TabIndex = 90;
            // 
            // Categoria
            // 
            this.Categoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categoria.FormattingEnabled = true;
            this.Categoria.Location = new System.Drawing.Point(458, 32);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(319, 21);
            this.Categoria.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Marca:";
            // 
            // Configuracao
            // 
            this.Configuracao.Controls.Add(this.BtAdicionarImagem);
            this.Configuracao.Controls.Add(this.label15);
            this.Configuracao.Controls.Add(this.PrdAtivo);
            this.Configuracao.Controls.Add(this.AlertaProdutoVencer);
            this.Configuracao.Controls.Add(this.ControleLote);
            this.Configuracao.Controls.Add(this.ControlaValidade);
            this.Configuracao.Controls.Add(this.AlertaEstoqueMinimo);
            this.Configuracao.Controls.Add(this.ImagemProduto);
            this.Configuracao.Location = new System.Drawing.Point(4, 22);
            this.Configuracao.Name = "Configuracao";
            this.Configuracao.Padding = new System.Windows.Forms.Padding(3);
            this.Configuracao.Size = new System.Drawing.Size(783, 207);
            this.Configuracao.TabIndex = 1;
            this.Configuracao.Text = "Configuração";
            this.Configuracao.UseVisualStyleBackColor = true;
            this.Configuracao.Click += new System.EventHandler(this.Valores_Click);
            // 
            // BtAdicionarImagem
            // 
            this.BtAdicionarImagem.Location = new System.Drawing.Point(477, 178);
            this.BtAdicionarImagem.Name = "BtAdicionarImagem";
            this.BtAdicionarImagem.Size = new System.Drawing.Size(99, 23);
            this.BtAdicionarImagem.TabIndex = 60;
            this.BtAdicionarImagem.Text = "Adicionar Imagem";
            this.BtAdicionarImagem.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(535, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(31, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Foto:";
            // 
            // PrdAtivo
            // 
            this.PrdAtivo.AutoSize = true;
            this.PrdAtivo.Checked = true;
            this.PrdAtivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PrdAtivo.Location = new System.Drawing.Point(300, 6);
            this.PrdAtivo.Name = "PrdAtivo";
            this.PrdAtivo.Size = new System.Drawing.Size(90, 17);
            this.PrdAtivo.TabIndex = 50;
            this.PrdAtivo.Text = "Produto Ativo";
            this.PrdAtivo.UseVisualStyleBackColor = true;
            // 
            // AlertaProdutoVencer
            // 
            this.AlertaProdutoVencer.AutoSize = true;
            this.AlertaProdutoVencer.Checked = true;
            this.AlertaProdutoVencer.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AlertaProdutoVencer.Location = new System.Drawing.Point(135, 29);
            this.AlertaProdutoVencer.Name = "AlertaProdutoVencer";
            this.AlertaProdutoVencer.Size = new System.Drawing.Size(142, 17);
            this.AlertaProdutoVencer.TabIndex = 40;
            this.AlertaProdutoVencer.Text = "Alertar Produto a Vencer";
            this.AlertaProdutoVencer.UseVisualStyleBackColor = true;
            // 
            // ControleLote
            // 
            this.ControleLote.AutoSize = true;
            this.ControleLote.Location = new System.Drawing.Point(6, 29);
            this.ControleLote.Name = "ControleLote";
            this.ControleLote.Size = new System.Drawing.Size(89, 17);
            this.ControleLote.TabIndex = 20;
            this.ControleLote.Text = "Controla Lote";
            this.ControleLote.UseVisualStyleBackColor = true;
            // 
            // ControlaValidade
            // 
            this.ControlaValidade.AutoSize = true;
            this.ControlaValidade.Location = new System.Drawing.Point(6, 6);
            this.ControlaValidade.Name = "ControlaValidade";
            this.ControlaValidade.Size = new System.Drawing.Size(109, 17);
            this.ControlaValidade.TabIndex = 10;
            this.ControlaValidade.Text = "Controla Validade";
            this.ControlaValidade.UseVisualStyleBackColor = true;
            // 
            // AlertaEstoqueMinimo
            // 
            this.AlertaEstoqueMinimo.AutoSize = true;
            this.AlertaEstoqueMinimo.Checked = true;
            this.AlertaEstoqueMinimo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AlertaEstoqueMinimo.Location = new System.Drawing.Point(135, 6);
            this.AlertaEstoqueMinimo.Name = "AlertaEstoqueMinimo";
            this.AlertaEstoqueMinimo.Size = new System.Drawing.Size(134, 17);
            this.AlertaEstoqueMinimo.TabIndex = 30;
            this.AlertaEstoqueMinimo.Text = "Alertar Estoque Minimo";
            this.AlertaEstoqueMinimo.UseVisualStyleBackColor = true;
            // 
            // BtSalvar
            // 
            this.BtSalvar.Location = new System.Drawing.Point(12, 292);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtSalvar.TabIndex = 200;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(174, 292);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 220;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            // 
            // BtLocalizar
            // 
            this.BtLocalizar.Location = new System.Drawing.Point(93, 292);
            this.BtLocalizar.Name = "BtLocalizar";
            this.BtLocalizar.Size = new System.Drawing.Size(75, 23);
            this.BtLocalizar.TabIndex = 210;
            this.BtLocalizar.Text = "Localizar";
            this.BtLocalizar.UseVisualStyleBackColor = true;
            // 
            // ImagemProduto
            // 
            this.ImagemProduto.Location = new System.Drawing.Point(582, 6);
            this.ImagemProduto.Name = "ImagemProduto";
            this.ImagemProduto.Size = new System.Drawing.Size(195, 195);
            this.ImagemProduto.TabIndex = 13;
            this.ImagemProduto.TabStop = false;
            // 
            // Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 328);
            this.Controls.Add(this.BtLocalizar);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.NomeProduto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CodProduto);
            this.Controls.Add(this.label1);
            this.Name = "Produto";
            this.Text = "Produto";
            this.tabControl1.ResumeLayout(false);
            this.Dados.ResumeLayout(false);
            this.Dados.PerformLayout();
            this.Configuracao.ResumeLayout(false);
            this.Configuracao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImagemProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CodProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeProduto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Descricao;
        private System.Windows.Forms.ComboBox Marca;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Dados;
        private System.Windows.Forms.TabPage Configuracao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Categoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox GarantiasEmDias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Unidade;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ValorVenda;
        private System.Windows.Forms.CheckBox AlertaEstoqueMinimo;
        private System.Windows.Forms.CheckBox ControlaValidade;
        private System.Windows.Forms.CheckBox ControleLote;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox EstoqueMinimo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox EstoqueAtual;
        private System.Windows.Forms.CheckBox AlertaProdutoVencer;
        private System.Windows.Forms.CheckBox PrdAtivo;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtLocalizar;
        private System.Windows.Forms.PictureBox ImagemProduto;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtAdicionarImagem;
    }
}