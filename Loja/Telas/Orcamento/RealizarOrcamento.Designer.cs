namespace Loja.Telas.Orcamento
{
    partial class RealizarOrcamento
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
            this.ItensDoOracamento = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OracamentoProdutos = new System.Windows.Forms.TabPage();
            this.OracamentoAquarios = new System.Windows.Forms.TabPage();
            this.BtInserir = new System.Windows.Forms.Button();
            this.QuantidadeProduto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BtLocalizarItem = new System.Windows.Forms.Button();
            this.DescricaoProduto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Produto = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.NomeCliete = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CnpjCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.DataOrcamento = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.NrOrcamento = new System.Windows.Forms.TextBox();
            this.CodProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorItens = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.QtdItens = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.DescontoPorcentagem = new System.Windows.Forms.TextBox();
            this.DescontoReais = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.Acrescimo = new System.Windows.Forms.TextBox();
            this.VolorTotalOracamento = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.BtRemoverItem = new System.Windows.Forms.Button();
            this.Observacao = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.BtImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItensDoOracamento)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.OracamentoProdutos.SuspendLayout();
            this.OracamentoAquarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItensDoOracamento
            // 
            this.ItensDoOracamento.AllowUserToAddRows = false;
            this.ItensDoOracamento.AllowUserToDeleteRows = false;
            this.ItensDoOracamento.AllowUserToResizeColumns = false;
            this.ItensDoOracamento.AllowUserToResizeRows = false;
            this.ItensDoOracamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItensDoOracamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodProduto,
            this.Descricao,
            this.Qtd,
            this.ValorItem,
            this.ValorTotal});
            this.ItensDoOracamento.Location = new System.Drawing.Point(500, 15);
            this.ItensDoOracamento.Name = "ItensDoOracamento";
            this.ItensDoOracamento.RowHeadersVisible = false;
            this.ItensDoOracamento.Size = new System.Drawing.Size(696, 419);
            this.ItensDoOracamento.TabIndex = 240;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.OracamentoProdutos);
            this.tabControl1.Controls.Add(this.OracamentoAquarios);
            this.tabControl1.Location = new System.Drawing.Point(12, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(482, 131);
            this.tabControl1.TabIndex = 50;
            // 
            // OracamentoProdutos
            // 
            this.OracamentoProdutos.Controls.Add(this.BtInserir);
            this.OracamentoProdutos.Controls.Add(this.QuantidadeProduto);
            this.OracamentoProdutos.Controls.Add(this.label8);
            this.OracamentoProdutos.Controls.Add(this.BtLocalizarItem);
            this.OracamentoProdutos.Controls.Add(this.DescricaoProduto);
            this.OracamentoProdutos.Controls.Add(this.label7);
            this.OracamentoProdutos.Controls.Add(this.label6);
            this.OracamentoProdutos.Controls.Add(this.Produto);
            this.OracamentoProdutos.Location = new System.Drawing.Point(4, 22);
            this.OracamentoProdutos.Name = "OracamentoProdutos";
            this.OracamentoProdutos.Padding = new System.Windows.Forms.Padding(3);
            this.OracamentoProdutos.Size = new System.Drawing.Size(474, 105);
            this.OracamentoProdutos.TabIndex = 0;
            this.OracamentoProdutos.Text = "Produtos";
            this.OracamentoProdutos.UseVisualStyleBackColor = true;
            // 
            // OracamentoAquarios
            // 
            this.OracamentoAquarios.Controls.Add(this.label9);
            this.OracamentoAquarios.Controls.Add(this.textBox6);
            this.OracamentoAquarios.Controls.Add(this.label5);
            this.OracamentoAquarios.Controls.Add(this.textBox5);
            this.OracamentoAquarios.Controls.Add(this.textBox4);
            this.OracamentoAquarios.Controls.Add(this.label4);
            this.OracamentoAquarios.Controls.Add(this.label3);
            this.OracamentoAquarios.Controls.Add(this.textBox3);
            this.OracamentoAquarios.Controls.Add(this.label2);
            this.OracamentoAquarios.Controls.Add(this.textBox2);
            this.OracamentoAquarios.Controls.Add(this.label1);
            this.OracamentoAquarios.Controls.Add(this.textBox1);
            this.OracamentoAquarios.Location = new System.Drawing.Point(4, 22);
            this.OracamentoAquarios.Name = "OracamentoAquarios";
            this.OracamentoAquarios.Padding = new System.Windows.Forms.Padding(3);
            this.OracamentoAquarios.Size = new System.Drawing.Size(474, 105);
            this.OracamentoAquarios.TabIndex = 1;
            this.OracamentoAquarios.Text = "Aquários";
            this.OracamentoAquarios.UseVisualStyleBackColor = true;
            // 
            // BtInserir
            // 
            this.BtInserir.Location = new System.Drawing.Point(195, 58);
            this.BtInserir.Name = "BtInserir";
            this.BtInserir.Size = new System.Drawing.Size(75, 20);
            this.BtInserir.TabIndex = 100;
            this.BtInserir.Text = "Inserir";
            this.BtInserir.UseVisualStyleBackColor = true;
            // 
            // QuantidadeProduto
            // 
            this.QuantidadeProduto.Location = new System.Drawing.Point(89, 58);
            this.QuantidadeProduto.Name = "QuantidadeProduto";
            this.QuantidadeProduto.Size = new System.Drawing.Size(100, 20);
            this.QuantidadeProduto.TabIndex = 90;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 107;
            this.label8.Text = "Quantidade:";
            // 
            // BtLocalizarItem
            // 
            this.BtLocalizarItem.Location = new System.Drawing.Point(362, 6);
            this.BtLocalizarItem.Name = "BtLocalizarItem";
            this.BtLocalizarItem.Size = new System.Drawing.Size(75, 20);
            this.BtLocalizarItem.TabIndex = 70;
            this.BtLocalizarItem.Text = "Localizar";
            this.BtLocalizarItem.UseVisualStyleBackColor = true;
            // 
            // DescricaoProduto
            // 
            this.DescricaoProduto.Location = new System.Drawing.Point(89, 32);
            this.DescricaoProduto.Name = "DescricaoProduto";
            this.DescricaoProduto.Size = new System.Drawing.Size(348, 20);
            this.DescricaoProduto.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 106;
            this.label7.Text = "Descrição:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 105;
            this.label6.Text = "Produto:";
            // 
            // Produto
            // 
            this.Produto.Location = new System.Drawing.Point(89, 6);
            this.Produto.Name = "Produto";
            this.Produto.Size = new System.Drawing.Size(267, 20);
            this.Produto.TabIndex = 60;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 110;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Altura:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Largura:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 58);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Comprimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(188, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Vidro:";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(266, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 140;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(266, 32);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Peso:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(266, 58);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 160;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(188, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Mão de Obra:";
            // 
            // NomeCliete
            // 
            this.NomeCliete.Location = new System.Drawing.Point(83, 38);
            this.NomeCliete.Name = "NomeCliete";
            this.NomeCliete.Size = new System.Drawing.Size(411, 20);
            this.NomeCliete.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Nome:";
            // 
            // CnpjCpfCliente
            // 
            this.CnpjCpfCliente.Location = new System.Drawing.Point(83, 12);
            this.CnpjCpfCliente.Name = "CnpjCpfCliente";
            this.CnpjCpfCliente.Size = new System.Drawing.Size(100, 20);
            this.CnpjCpfCliente.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "CPF / CNPJ";
            // 
            // DataOrcamento
            // 
            this.DataOrcamento.Location = new System.Drawing.Point(271, 12);
            this.DataOrcamento.Mask = "00/00/0000";
            this.DataOrcamento.Name = "DataOrcamento";
            this.DataOrcamento.Size = new System.Drawing.Size(66, 20);
            this.DataOrcamento.TabIndex = 20;
            this.DataOrcamento.ValidatingType = typeof(System.DateTime);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(189, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 41;
            this.label12.Text = "Dt. Orçamento";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(343, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Nr. Orçamento";
            // 
            // NrOrcamento
            // 
            this.NrOrcamento.Location = new System.Drawing.Point(425, 12);
            this.NrOrcamento.Name = "NrOrcamento";
            this.NrOrcamento.Size = new System.Drawing.Size(69, 20);
            this.NrOrcamento.TabIndex = 30;
            // 
            // CodProduto
            // 
            this.CodProduto.HeaderText = "Cod Produto";
            this.CodProduto.Name = "CodProduto";
            this.CodProduto.Width = 180;
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descricao";
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 300;
            // 
            // Qtd
            // 
            this.Qtd.HeaderText = "Qtd";
            this.Qtd.Name = "Qtd";
            this.Qtd.Width = 50;
            // 
            // ValorItem
            // 
            this.ValorItem.HeaderText = "Vl Item";
            this.ValorItem.Name = "ValorItem";
            this.ValorItem.Width = 80;
            // 
            // ValorTotal
            // 
            this.ValorTotal.HeaderText = "Vl Total";
            this.ValorTotal.Name = "ValorTotal";
            this.ValorTotal.Width = 80;
            // 
            // ValorItens
            // 
            this.ValorItens.Location = new System.Drawing.Point(89, 200);
            this.ValorItens.Name = "ValorItens";
            this.ValorItens.Size = new System.Drawing.Size(100, 20);
            this.ValorItens.TabIndex = 170;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 203);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 50;
            this.label14.Text = "Valor Itens";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(195, 204);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Qtd. Itens:";
            // 
            // QtdItens
            // 
            this.QtdItens.Location = new System.Drawing.Point(257, 201);
            this.QtdItens.Name = "QtdItens";
            this.QtdItens.Size = new System.Drawing.Size(52, 20);
            this.QtdItens.TabIndex = 180;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(9, 229);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 53;
            this.label16.Text = "Desconto %";
            // 
            // DescontoPorcentagem
            // 
            this.DescontoPorcentagem.Location = new System.Drawing.Point(89, 226);
            this.DescontoPorcentagem.Name = "DescontoPorcentagem";
            this.DescontoPorcentagem.Size = new System.Drawing.Size(78, 20);
            this.DescontoPorcentagem.TabIndex = 190;
            // 
            // DescontoReais
            // 
            this.DescontoReais.Location = new System.Drawing.Point(89, 255);
            this.DescontoReais.Name = "DescontoReais";
            this.DescontoReais.Size = new System.Drawing.Size(77, 20);
            this.DescontoReais.TabIndex = 200;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 258);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 13);
            this.label17.TabIndex = 55;
            this.label17.Text = "Desconto R$";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(9, 284);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 57;
            this.label18.Text = "Acréscimo R$";
            // 
            // Acrescimo
            // 
            this.Acrescimo.Location = new System.Drawing.Point(89, 281);
            this.Acrescimo.Name = "Acrescimo";
            this.Acrescimo.Size = new System.Drawing.Size(78, 20);
            this.Acrescimo.TabIndex = 210;
            // 
            // VolorTotalOracamento
            // 
            this.VolorTotalOracamento.Location = new System.Drawing.Point(89, 307);
            this.VolorTotalOracamento.Name = "VolorTotalOracamento";
            this.VolorTotalOracamento.Size = new System.Drawing.Size(100, 20);
            this.VolorTotalOracamento.TabIndex = 220;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(9, 310);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 60;
            this.label19.Text = "Valor Total:";
            // 
            // BtRemoverItem
            // 
            this.BtRemoverItem.Location = new System.Drawing.Point(407, 201);
            this.BtRemoverItem.Name = "BtRemoverItem";
            this.BtRemoverItem.Size = new System.Drawing.Size(83, 20);
            this.BtRemoverItem.TabIndex = 250;
            this.BtRemoverItem.Text = "Remover Item";
            this.BtRemoverItem.UseVisualStyleBackColor = true;
            // 
            // Observacao
            // 
            this.Observacao.Location = new System.Drawing.Point(89, 333);
            this.Observacao.Name = "Observacao";
            this.Observacao.Size = new System.Drawing.Size(401, 20);
            this.Observacao.TabIndex = 230;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(9, 336);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 13);
            this.label20.TabIndex = 63;
            this.label20.Text = "Observação:";
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(419, 411);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 320;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            // 
            // BtSalvar
            // 
            this.BtSalvar.Location = new System.Drawing.Point(12, 411);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtSalvar.TabIndex = 300;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            // 
            // BtImprimir
            // 
            this.BtImprimir.Location = new System.Drawing.Point(93, 411);
            this.BtImprimir.Name = "BtImprimir";
            this.BtImprimir.Size = new System.Drawing.Size(75, 23);
            this.BtImprimir.TabIndex = 310;
            this.BtImprimir.Text = "Imprimir";
            this.BtImprimir.UseVisualStyleBackColor = true;
            // 
            // RealizarOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 443);
            this.Controls.Add(this.BtImprimir);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.Observacao);
            this.Controls.Add(this.BtRemoverItem);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.VolorTotalOracamento);
            this.Controls.Add(this.Acrescimo);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.DescontoReais);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.DescontoPorcentagem);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.QtdItens);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.ValorItens);
            this.Controls.Add(this.NrOrcamento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.NomeCliete);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CnpjCpfCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DataOrcamento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ItensDoOracamento);
            this.Name = "RealizarOrcamento";
            this.Text = "RealizarOrcamento";
            ((System.ComponentModel.ISupportInitialize)(this.ItensDoOracamento)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.OracamentoProdutos.ResumeLayout(false);
            this.OracamentoProdutos.PerformLayout();
            this.OracamentoAquarios.ResumeLayout(false);
            this.OracamentoAquarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ItensDoOracamento;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OracamentoProdutos;
        private System.Windows.Forms.TabPage OracamentoAquarios;
        private System.Windows.Forms.Button BtInserir;
        private System.Windows.Forms.TextBox QuantidadeProduto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtLocalizarItem;
        private System.Windows.Forms.TextBox DescricaoProduto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Produto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NomeCliete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox CnpjCpfCliente;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox DataOrcamento;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox NrOrcamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorTotal;
        private System.Windows.Forms.TextBox ValorItens;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox QtdItens;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox DescontoPorcentagem;
        private System.Windows.Forms.TextBox DescontoReais;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox Acrescimo;
        private System.Windows.Forms.TextBox VolorTotalOracamento;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button BtRemoverItem;
        private System.Windows.Forms.TextBox Observacao;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.Button BtImprimir;
    }
}