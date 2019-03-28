using System;

namespace Loja.Telas.Cadastro
{
    partial class Entidade
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
            this.Cpf_Cnpj = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RazaoSocial = new System.Windows.Forms.TextBox();
            this.Flg_ativo = new System.Windows.Forms.CheckBox();
            this.Grupo = new System.Windows.Forms.TextBox();
            this.DescricaoGrupo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sss = new System.Windows.Forms.TabControl();
            this.Endereco = new System.Windows.Forms.TabPage();
            this.BtLocalizarCep = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Estado = new System.Windows.Forms.TextBox();
            this.Bairro = new System.Windows.Forms.TextBox();
            this.Complemento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Cidade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Logradouro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cep = new System.Windows.Forms.MaskedTextBox();
            this.Contatos = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.NomeCelular2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.NomeCelular1 = new System.Windows.Forms.TextBox();
            this.Flg_whatsappCelular2 = new System.Windows.Forms.CheckBox();
            this.Flg_whatsappCelular1 = new System.Windows.Forms.CheckBox();
            this.Celular2 = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Celular1 = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Facebook = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.EmailContato = new System.Windows.Forms.TextBox();
            this.Configuracoes = new System.Windows.Forms.TabPage();
            this.Flg_Notificar_Aniversario = new System.Windows.Forms.CheckBox();
            this.Flg_Aceita_Fiado = new System.Windows.Forms.CheckBox();
            this.Flg_Notificar_Promocao = new System.Windows.Forms.CheckBox();
            this.Flg_notificar_vencimeneto = new System.Windows.Forms.CheckBox();
            this.Flg_notificar_produto_novo = new System.Windows.Forms.CheckBox();
            this.Flg_vip = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.DataCadastro = new System.Windows.Forms.MaskedTextBox();
            this.DataAlteracao = new System.Windows.Forms.MaskedTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.Bt_Salvar = new System.Windows.Forms.Button();
            this.Foto = new System.Windows.Forms.PictureBox();
            this.label18 = new System.Windows.Forms.Label();
            this.Bt_Tirar_Foto = new System.Windows.Forms.Button();
            this.BtCarregarFoto = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.Observacao = new System.Windows.Forms.TextBox();
            this.BtLocalizarEntidade = new System.Windows.Forms.Button();
            this.AtivarFoto = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.Nascimento = new System.Windows.Forms.MaskedTextBox();
            this.Idade = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.sss.SuspendLayout();
            this.Endereco.SuspendLayout();
            this.Contatos.SuspendLayout();
            this.Configuracoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).BeginInit();
            this.SuspendLayout();
            // 
            // Cpf_Cnpj
            // 
            this.Cpf_Cnpj.Location = new System.Drawing.Point(102, 38);
            this.Cpf_Cnpj.Name = "Cpf_Cnpj";
            this.Cpf_Cnpj.Size = new System.Drawing.Size(119, 20);
            this.Cpf_Cnpj.TabIndex = 40;
            this.Cpf_Cnpj.Enter += new System.EventHandler(this.Cpf_Cnpj_Enter);
            this.Cpf_Cnpj.Leave += new System.EventHandler(this.Cpf_Cnpj_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CNPJ / CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // RazaoSocial
            // 
            this.RazaoSocial.Location = new System.Drawing.Point(102, 64);
            this.RazaoSocial.Name = "RazaoSocial";
            this.RazaoSocial.Size = new System.Drawing.Size(620, 20);
            this.RazaoSocial.TabIndex = 60;
            // 
            // Flg_ativo
            // 
            this.Flg_ativo.AutoSize = true;
            this.Flg_ativo.Location = new System.Drawing.Point(227, 40);
            this.Flg_ativo.Name = "Flg_ativo";
            this.Flg_ativo.Size = new System.Drawing.Size(50, 17);
            this.Flg_ativo.TabIndex = 50;
            this.Flg_ativo.Text = "Ativo";
            this.Flg_ativo.UseVisualStyleBackColor = true;
            // 
            // Grupo
            // 
            this.Grupo.Location = new System.Drawing.Point(253, 12);
            this.Grupo.Name = "Grupo";
            this.Grupo.Size = new System.Drawing.Size(100, 20);
            this.Grupo.TabIndex = 20;
            this.Grupo.Enter += new System.EventHandler(this.Grupo_Enter);
            this.Grupo.Leave += new System.EventHandler(this.Grupo_Leave);
            // 
            // DescricaoGrupo
            // 
            this.DescricaoGrupo.Enabled = false;
            this.DescricaoGrupo.Location = new System.Drawing.Point(359, 12);
            this.DescricaoGrupo.Name = "DescricaoGrupo";
            this.DescricaoGrupo.Size = new System.Drawing.Size(363, 20);
            this.DescricaoGrupo.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Grupo:";
            // 
            // sss
            // 
            this.sss.Controls.Add(this.Endereco);
            this.sss.Controls.Add(this.Contatos);
            this.sss.Controls.Add(this.Configuracoes);
            this.sss.Location = new System.Drawing.Point(12, 116);
            this.sss.Name = "sss";
            this.sss.SelectedIndex = 0;
            this.sss.Size = new System.Drawing.Size(546, 181);
            this.sss.TabIndex = 82;
            // 
            // Endereco
            // 
            this.Endereco.Controls.Add(this.BtLocalizarCep);
            this.Endereco.Controls.Add(this.label11);
            this.Endereco.Controls.Add(this.Estado);
            this.Endereco.Controls.Add(this.Bairro);
            this.Endereco.Controls.Add(this.Complemento);
            this.Endereco.Controls.Add(this.label10);
            this.Endereco.Controls.Add(this.label9);
            this.Endereco.Controls.Add(this.Numero);
            this.Endereco.Controls.Add(this.label8);
            this.Endereco.Controls.Add(this.Cidade);
            this.Endereco.Controls.Add(this.label7);
            this.Endereco.Controls.Add(this.Logradouro);
            this.Endereco.Controls.Add(this.label6);
            this.Endereco.Controls.Add(this.label5);
            this.Endereco.Controls.Add(this.Cep);
            this.Endereco.Location = new System.Drawing.Point(4, 22);
            this.Endereco.Name = "Endereco";
            this.Endereco.Padding = new System.Windows.Forms.Padding(3);
            this.Endereco.Size = new System.Drawing.Size(538, 155);
            this.Endereco.TabIndex = 0;
            this.Endereco.Text = "Endereço";
            this.Endereco.UseVisualStyleBackColor = true;
            // 
            // BtLocalizarCep
            // 
            this.BtLocalizarCep.Location = new System.Drawing.Point(154, 5);
            this.BtLocalizarCep.Name = "BtLocalizarCep";
            this.BtLocalizarCep.Size = new System.Drawing.Size(75, 20);
            this.BtLocalizarCep.TabIndex = 100;
            this.BtLocalizarCep.Text = "Localizar";
            this.BtLocalizarCep.UseVisualStyleBackColor = true;
            this.BtLocalizarCep.Click += new System.EventHandler(this.BtLocalizar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Estado:";
            // 
            // Estado
            // 
            this.Estado.Location = new System.Drawing.Point(83, 110);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(174, 20);
            this.Estado.TabIndex = 160;
            // 
            // Bairro
            // 
            this.Bairro.Location = new System.Drawing.Point(343, 58);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(174, 20);
            this.Bairro.TabIndex = 130;
            // 
            // Complemento
            // 
            this.Complemento.Location = new System.Drawing.Point(343, 84);
            this.Complemento.Name = "Complemento";
            this.Complemento.Size = new System.Drawing.Size(174, 20);
            this.Complemento.TabIndex = 150;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(263, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Complemento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Bairro:";
            // 
            // Numero
            // 
            this.Numero.Location = new System.Drawing.Point(83, 84);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(174, 20);
            this.Numero.TabIndex = 140;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Número:";
            // 
            // Cidade
            // 
            this.Cidade.Location = new System.Drawing.Point(83, 58);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(174, 20);
            this.Cidade.TabIndex = 120;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cidade:";
            // 
            // Logradouro
            // 
            this.Logradouro.Location = new System.Drawing.Point(83, 32);
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.Size = new System.Drawing.Size(434, 20);
            this.Logradouro.TabIndex = 110;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Rua:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "CEP: ";
            // 
            // Cep
            // 
            this.Cep.Location = new System.Drawing.Point(83, 6);
            this.Cep.Mask = "#####-###";
            this.Cep.Name = "Cep";
            this.Cep.Size = new System.Drawing.Size(65, 20);
            this.Cep.TabIndex = 90;
            this.Cep.Leave += new System.EventHandler(this.Cep_Leave);
            // 
            // Contatos
            // 
            this.Contatos.Controls.Add(this.label22);
            this.Contatos.Controls.Add(this.NomeCelular2);
            this.Contatos.Controls.Add(this.label21);
            this.Contatos.Controls.Add(this.NomeCelular1);
            this.Contatos.Controls.Add(this.Flg_whatsappCelular2);
            this.Contatos.Controls.Add(this.Flg_whatsappCelular1);
            this.Contatos.Controls.Add(this.Celular2);
            this.Contatos.Controls.Add(this.label15);
            this.Contatos.Controls.Add(this.Celular1);
            this.Contatos.Controls.Add(this.label14);
            this.Contatos.Controls.Add(this.label13);
            this.Contatos.Controls.Add(this.Facebook);
            this.Contatos.Controls.Add(this.label12);
            this.Contatos.Controls.Add(this.EmailContato);
            this.Contatos.Location = new System.Drawing.Point(4, 22);
            this.Contatos.Name = "Contatos";
            this.Contatos.Padding = new System.Windows.Forms.Padding(3);
            this.Contatos.Size = new System.Drawing.Size(538, 155);
            this.Contatos.TabIndex = 1;
            this.Contatos.Text = "Contatos";
            this.Contatos.UseVisualStyleBackColor = true;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(280, 87);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(38, 13);
            this.label22.TabIndex = 254;
            this.label22.Text = "Nome:";
            // 
            // NomeCelular2
            // 
            this.NomeCelular2.Location = new System.Drawing.Point(324, 84);
            this.NomeCelular2.Name = "NomeCelular2";
            this.NomeCelular2.Size = new System.Drawing.Size(208, 20);
            this.NomeCelular2.TabIndex = 253;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(280, 61);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 13);
            this.label21.TabIndex = 252;
            this.label21.Text = "Nome:";
            // 
            // NomeCelular1
            // 
            this.NomeCelular1.Location = new System.Drawing.Point(324, 58);
            this.NomeCelular1.Name = "NomeCelular1";
            this.NomeCelular1.Size = new System.Drawing.Size(208, 20);
            this.NomeCelular1.TabIndex = 231;
            // 
            // Flg_whatsappCelular2
            // 
            this.Flg_whatsappCelular2.AutoSize = true;
            this.Flg_whatsappCelular2.Location = new System.Drawing.Point(192, 87);
            this.Flg_whatsappCelular2.Name = "Flg_whatsappCelular2";
            this.Flg_whatsappCelular2.Size = new System.Drawing.Size(76, 17);
            this.Flg_whatsappCelular2.TabIndex = 250;
            this.Flg_whatsappCelular2.Text = "WhatsApp";
            this.Flg_whatsappCelular2.UseVisualStyleBackColor = true;
            // 
            // Flg_whatsappCelular1
            // 
            this.Flg_whatsappCelular1.AutoSize = true;
            this.Flg_whatsappCelular1.Location = new System.Drawing.Point(192, 61);
            this.Flg_whatsappCelular1.Name = "Flg_whatsappCelular1";
            this.Flg_whatsappCelular1.Size = new System.Drawing.Size(76, 17);
            this.Flg_whatsappCelular1.TabIndex = 230;
            this.Flg_whatsappCelular1.Text = "WhatsApp";
            this.Flg_whatsappCelular1.UseVisualStyleBackColor = true;
            // 
            // Celular2
            // 
            this.Celular2.Location = new System.Drawing.Point(83, 84);
            this.Celular2.Name = "Celular2";
            this.Celular2.Size = new System.Drawing.Size(100, 20);
            this.Celular2.TabIndex = 240;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 87);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Celular:";
            // 
            // Celular1
            // 
            this.Celular1.Location = new System.Drawing.Point(83, 58);
            this.Celular1.Name = "Celular1";
            this.Celular1.Size = new System.Drawing.Size(100, 20);
            this.Celular1.TabIndex = 220;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 61);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Celular:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Facebook:";
            // 
            // Facebook
            // 
            this.Facebook.Location = new System.Drawing.Point(83, 32);
            this.Facebook.Name = "Facebook";
            this.Facebook.Size = new System.Drawing.Size(449, 20);
            this.Facebook.TabIndex = 210;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "E-mail:";
            // 
            // EmailContato
            // 
            this.EmailContato.Location = new System.Drawing.Point(83, 6);
            this.EmailContato.Name = "EmailContato";
            this.EmailContato.Size = new System.Drawing.Size(449, 20);
            this.EmailContato.TabIndex = 200;
            // 
            // Configuracoes
            // 
            this.Configuracoes.Controls.Add(this.Flg_Notificar_Aniversario);
            this.Configuracoes.Controls.Add(this.Flg_Aceita_Fiado);
            this.Configuracoes.Controls.Add(this.Flg_Notificar_Promocao);
            this.Configuracoes.Controls.Add(this.Flg_notificar_vencimeneto);
            this.Configuracoes.Controls.Add(this.Flg_notificar_produto_novo);
            this.Configuracoes.Controls.Add(this.Flg_vip);
            this.Configuracoes.Location = new System.Drawing.Point(4, 22);
            this.Configuracoes.Name = "Configuracoes";
            this.Configuracoes.Size = new System.Drawing.Size(538, 155);
            this.Configuracoes.TabIndex = 2;
            this.Configuracoes.Text = "Configurações";
            this.Configuracoes.UseVisualStyleBackColor = true;
            // 
            // Flg_Notificar_Aniversario
            // 
            this.Flg_Notificar_Aniversario.AutoSize = true;
            this.Flg_Notificar_Aniversario.Location = new System.Drawing.Point(143, 3);
            this.Flg_Notificar_Aniversario.Name = "Flg_Notificar_Aniversario";
            this.Flg_Notificar_Aniversario.Size = new System.Drawing.Size(120, 17);
            this.Flg_Notificar_Aniversario.TabIndex = 310;
            this.Flg_Notificar_Aniversario.Text = "Notificar Aniversário";
            this.Flg_Notificar_Aniversario.UseVisualStyleBackColor = true;
            // 
            // Flg_Aceita_Fiado
            // 
            this.Flg_Aceita_Fiado.AutoSize = true;
            this.Flg_Aceita_Fiado.Location = new System.Drawing.Point(3, 95);
            this.Flg_Aceita_Fiado.Name = "Flg_Aceita_Fiado";
            this.Flg_Aceita_Fiado.Size = new System.Drawing.Size(85, 17);
            this.Flg_Aceita_Fiado.TabIndex = 300;
            this.Flg_Aceita_Fiado.Text = "Aceita Fiado";
            this.Flg_Aceita_Fiado.UseVisualStyleBackColor = true;
            // 
            // Flg_Notificar_Promocao
            // 
            this.Flg_Notificar_Promocao.AutoSize = true;
            this.Flg_Notificar_Promocao.Location = new System.Drawing.Point(3, 72);
            this.Flg_Notificar_Promocao.Name = "Flg_Notificar_Promocao";
            this.Flg_Notificar_Promocao.Size = new System.Drawing.Size(116, 17);
            this.Flg_Notificar_Promocao.TabIndex = 290;
            this.Flg_Notificar_Promocao.Text = "Notificar Promoção";
            this.Flg_Notificar_Promocao.UseVisualStyleBackColor = true;
            // 
            // Flg_notificar_vencimeneto
            // 
            this.Flg_notificar_vencimeneto.AutoSize = true;
            this.Flg_notificar_vencimeneto.Location = new System.Drawing.Point(3, 49);
            this.Flg_notificar_vencimeneto.Name = "Flg_notificar_vencimeneto";
            this.Flg_notificar_vencimeneto.Size = new System.Drawing.Size(124, 17);
            this.Flg_notificar_vencimeneto.TabIndex = 280;
            this.Flg_notificar_vencimeneto.Text = "Notificar Vencimento";
            this.Flg_notificar_vencimeneto.UseVisualStyleBackColor = true;
            // 
            // Flg_notificar_produto_novo
            // 
            this.Flg_notificar_produto_novo.AutoSize = true;
            this.Flg_notificar_produto_novo.Location = new System.Drawing.Point(3, 26);
            this.Flg_notificar_produto_novo.Name = "Flg_notificar_produto_novo";
            this.Flg_notificar_produto_novo.Size = new System.Drawing.Size(134, 17);
            this.Flg_notificar_produto_novo.TabIndex = 270;
            this.Flg_notificar_produto_novo.Text = "Notificar Produto Novo";
            this.Flg_notificar_produto_novo.UseVisualStyleBackColor = true;
            // 
            // Flg_vip
            // 
            this.Flg_vip.AutoSize = true;
            this.Flg_vip.Location = new System.Drawing.Point(3, 3);
            this.Flg_vip.Name = "Flg_vip";
            this.Flg_vip.Size = new System.Drawing.Size(78, 17);
            this.Flg_vip.TabIndex = 260;
            this.Flg_vip.Text = "Cliente VIP";
            this.Flg_vip.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Data Cadastro:";
            // 
            // DataCadastro
            // 
            this.DataCadastro.Enabled = false;
            this.DataCadastro.Location = new System.Drawing.Point(102, 90);
            this.DataCadastro.Mask = "00/00/0000 90:00";
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.Size = new System.Drawing.Size(100, 20);
            this.DataCadastro.TabIndex = 70;
            this.DataCadastro.ValidatingType = typeof(System.DateTime);
            // 
            // DataAlteracao
            // 
            this.DataAlteracao.Enabled = false;
            this.DataAlteracao.Location = new System.Drawing.Point(299, 90);
            this.DataAlteracao.Mask = "00/00/0000 90:00";
            this.DataAlteracao.Name = "DataAlteracao";
            this.DataAlteracao.Size = new System.Drawing.Size(100, 20);
            this.DataAlteracao.TabIndex = 80;
            this.DataAlteracao.ValidatingType = typeof(System.DateTime);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(209, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(81, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Data Alteração:";
            // 
            // Bt_Salvar
            // 
            this.Bt_Salvar.Location = new System.Drawing.Point(15, 351);
            this.Bt_Salvar.Name = "Bt_Salvar";
            this.Bt_Salvar.Size = new System.Drawing.Size(75, 23);
            this.Bt_Salvar.TabIndex = 320;
            this.Bt_Salvar.Text = "Salvar";
            this.Bt_Salvar.UseVisualStyleBackColor = true;
            this.Bt_Salvar.Click += new System.EventHandler(this.Bt_Salvar_Click);
            // 
            // Foto
            // 
            this.Foto.Location = new System.Drawing.Point(564, 138);
            this.Foto.Name = "Foto";
            this.Foto.Size = new System.Drawing.Size(158, 130);
            this.Foto.TabIndex = 17;
            this.Foto.TabStop = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(565, 116);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(31, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Foto:";
            // 
            // Bt_Tirar_Foto
            // 
            this.Bt_Tirar_Foto.Location = new System.Drawing.Point(660, 274);
            this.Bt_Tirar_Foto.Name = "Bt_Tirar_Foto";
            this.Bt_Tirar_Foto.Size = new System.Drawing.Size(62, 23);
            this.Bt_Tirar_Foto.TabIndex = 190;
            this.Bt_Tirar_Foto.Text = "Tirar Foto";
            this.Bt_Tirar_Foto.UseVisualStyleBackColor = true;
            this.Bt_Tirar_Foto.Click += new System.EventHandler(this.Bt_Tirar_Foto_Click);
            // 
            // BtCarregarFoto
            // 
            this.BtCarregarFoto.Location = new System.Drawing.Point(564, 274);
            this.BtCarregarFoto.Name = "BtCarregarFoto";
            this.BtCarregarFoto.Size = new System.Drawing.Size(90, 23);
            this.BtCarregarFoto.TabIndex = 180;
            this.BtCarregarFoto.Text = "Carregar Foto";
            this.BtCarregarFoto.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 306);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 13);
            this.label19.TabIndex = 21;
            this.label19.Text = "Observação:";
            // 
            // Observacao
            // 
            this.Observacao.Location = new System.Drawing.Point(102, 303);
            this.Observacao.Name = "Observacao";
            this.Observacao.Size = new System.Drawing.Size(620, 20);
            this.Observacao.TabIndex = 310;
            // 
            // BtLocalizarEntidade
            // 
            this.BtLocalizarEntidade.Location = new System.Drawing.Point(102, 351);
            this.BtLocalizarEntidade.Name = "BtLocalizarEntidade";
            this.BtLocalizarEntidade.Size = new System.Drawing.Size(75, 23);
            this.BtLocalizarEntidade.TabIndex = 340;
            this.BtLocalizarEntidade.Text = "Localizar";
            this.BtLocalizarEntidade.UseVisualStyleBackColor = true;
            this.BtLocalizarEntidade.Click += new System.EventHandler(this.BtLocalizarEntidade_Click);
            // 
            // AtivarFoto
            // 
            this.AtivarFoto.AutoSize = true;
            this.AtivarFoto.Location = new System.Drawing.Point(669, 115);
            this.AtivarFoto.Name = "AtivarFoto";
            this.AtivarFoto.Size = new System.Drawing.Size(53, 17);
            this.AtivarFoto.TabIndex = 170;
            this.AtivarFoto.Text = "Ativar";
            this.AtivarFoto.UseVisualStyleBackColor = true;
            this.AtivarFoto.CheckedChanged += new System.EventHandler(this.AtivarFoto_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(405, 93);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 341;
            this.label20.Text = "Nascimento:";
            // 
            // Nascimento
            // 
            this.Nascimento.Location = new System.Drawing.Point(477, 90);
            this.Nascimento.Mask = "00/00/0000";
            this.Nascimento.Name = "Nascimento";
            this.Nascimento.Size = new System.Drawing.Size(65, 20);
            this.Nascimento.TabIndex = 81;
            this.Nascimento.ValidatingType = typeof(System.DateTime);
            this.Nascimento.Leave += new System.EventHandler(this.Nascimento_Leave);
            // 
            // Idade
            // 
            this.Idade.AutoSize = true;
            this.Idade.Location = new System.Drawing.Point(548, 93);
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(48, 13);
            this.Idade.TabIndex = 342;
            this.Idade.Text = "XX Anos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código:";
            // 
            // Codigo
            // 
            this.Codigo.Enabled = false;
            this.Codigo.Location = new System.Drawing.Point(102, 12);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(100, 20);
            this.Codigo.TabIndex = 10;
            // 
            // Entidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 388);
            this.Controls.Add(this.Idade);
            this.Controls.Add(this.Nascimento);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.AtivarFoto);
            this.Controls.Add(this.BtLocalizarEntidade);
            this.Controls.Add(this.Observacao);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.BtCarregarFoto);
            this.Controls.Add(this.Bt_Tirar_Foto);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.Foto);
            this.Controls.Add(this.Bt_Salvar);
            this.Controls.Add(this.DataAlteracao);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.DataCadastro);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.sss);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DescricaoGrupo);
            this.Controls.Add(this.Grupo);
            this.Controls.Add(this.Flg_ativo);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RazaoSocial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cpf_Cnpj);
            this.Name = "Entidade";
            this.Text = "Entidade";
            this.Load += new System.EventHandler(this.Entidade_Load);
            this.sss.ResumeLayout(false);
            this.Endereco.ResumeLayout(false);
            this.Endereco.PerformLayout();
            this.Contatos.ResumeLayout(false);
            this.Contatos.PerformLayout();
            this.Configuracoes.ResumeLayout(false);
            this.Configuracoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Foto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Cpf_Cnpj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox RazaoSocial;
        private System.Windows.Forms.CheckBox Flg_ativo;
        private System.Windows.Forms.TextBox Grupo;
        private System.Windows.Forms.TextBox DescricaoGrupo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl sss;
        private System.Windows.Forms.TabPage Endereco;
        private System.Windows.Forms.TabPage Contatos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox Cep;
        private System.Windows.Forms.TextBox Logradouro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Cidade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Numero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Bairro;
        private System.Windows.Forms.TextBox Complemento;
        private System.Windows.Forms.TextBox Estado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button BtLocalizarCep;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EmailContato;
        private System.Windows.Forms.MaskedTextBox Celular1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox Flg_whatsappCelular2;
        private System.Windows.Forms.CheckBox Flg_whatsappCelular1;
        private System.Windows.Forms.MaskedTextBox Celular2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.MaskedTextBox DataCadastro;
        private System.Windows.Forms.MaskedTextBox DataAlteracao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button Bt_Salvar;
        private System.Windows.Forms.PictureBox Foto;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button Bt_Tirar_Foto;
        private System.Windows.Forms.Button BtCarregarFoto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox Observacao;
        private System.Windows.Forms.Button BtLocalizarEntidade;
        private System.Windows.Forms.CheckBox AtivarFoto;
        private System.Windows.Forms.TabPage Configuracoes;
        private System.Windows.Forms.CheckBox Flg_vip;
        private System.Windows.Forms.CheckBox Flg_notificar_produto_novo;
        private System.Windows.Forms.CheckBox Flg_Notificar_Promocao;
        private System.Windows.Forms.CheckBox Flg_notificar_vencimeneto;
        private System.Windows.Forms.CheckBox Flg_Aceita_Fiado;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.MaskedTextBox Nascimento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Facebook;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox NomeCelular1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox NomeCelular2;
        private System.Windows.Forms.CheckBox Flg_Notificar_Aniversario;
        private System.Windows.Forms.Label Idade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Codigo;
    }
}