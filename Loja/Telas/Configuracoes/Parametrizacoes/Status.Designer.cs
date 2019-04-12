namespace Loja.Telas.Configuracoes.Parametrizacoes
{
    partial class Status
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
            this.TabelaClasses = new System.Windows.Forms.DataGridView();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabelaStatus = new System.Windows.Forms.DataGridView();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.ColunaStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // TabelaClasses
            // 
            this.TabelaClasses.AllowUserToAddRows = false;
            this.TabelaClasses.AllowUserToDeleteRows = false;
            this.TabelaClasses.AllowUserToResizeColumns = false;
            this.TabelaClasses.AllowUserToResizeRows = false;
            this.TabelaClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Classe,
            this.DescricaoClasse});
            this.TabelaClasses.Location = new System.Drawing.Point(12, 12);
            this.TabelaClasses.MultiSelect = false;
            this.TabelaClasses.Name = "TabelaClasses";
            this.TabelaClasses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.TabelaClasses.RowHeadersVisible = false;
            this.TabelaClasses.ShowCellToolTips = false;
            this.TabelaClasses.ShowEditingIcon = false;
            this.TabelaClasses.ShowRowErrors = false;
            this.TabelaClasses.Size = new System.Drawing.Size(493, 144);
            this.TabelaClasses.TabIndex = 10;
            this.TabelaClasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaClasses_CellClick);
            // 
            // Classe
            // 
            this.Classe.HeaderText = "Classe";
            this.Classe.MaxInputLength = 10;
            this.Classe.Name = "Classe";
            this.Classe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DescricaoClasse
            // 
            this.DescricaoClasse.HeaderText = "Descrição";
            this.DescricaoClasse.MaxInputLength = 50;
            this.DescricaoClasse.Name = "DescricaoClasse";
            this.DescricaoClasse.Width = 390;
            // 
            // TabelaStatus
            // 
            this.TabelaStatus.AllowUserToResizeColumns = false;
            this.TabelaStatus.AllowUserToResizeRows = false;
            this.TabelaStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColunaStatus,
            this.Descricao});
            this.TabelaStatus.Location = new System.Drawing.Point(12, 162);
            this.TabelaStatus.Name = "TabelaStatus";
            this.TabelaStatus.ShowCellToolTips = false;
            this.TabelaStatus.ShowEditingIcon = false;
            this.TabelaStatus.ShowRowErrors = false;
            this.TabelaStatus.Size = new System.Drawing.Size(493, 295);
            this.TabelaStatus.TabIndex = 20;
            this.TabelaStatus.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelaStatus_CellClick);
            // 
            // BtSalvar
            // 
            this.BtSalvar.Location = new System.Drawing.Point(12, 465);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtSalvar.TabIndex = 30;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(93, 465);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 40;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            // 
            // ColunaStatus
            // 
            this.ColunaStatus.HeaderText = "Status";
            this.ColunaStatus.MaxInputLength = 10;
            this.ColunaStatus.Name = "ColunaStatus";
            // 
            // Descricao
            // 
            this.Descricao.HeaderText = "Descrição";
            this.Descricao.MaxInputLength = 50;
            this.Descricao.Name = "Descricao";
            this.Descricao.Width = 350;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 500);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.TabelaStatus);
            this.Controls.Add(this.TabelaClasses);
            this.Name = "Status";
            this.Text = "Status";
            this.Load += new System.EventHandler(this.Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabelaClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaStatus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TabelaClasses;
        private System.Windows.Forms.DataGridView TabelaStatus;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoClasse;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descricao;
    }
}