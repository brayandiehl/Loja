namespace Loja.Telas.Configuracoes.Estrategia
{
    partial class Estrategias
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
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtSalvar = new System.Windows.Forms.Button();
            this.TabelaStatus = new System.Windows.Forms.DataGridView();
            this.TabelaClasses = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorParametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(93, 465);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 44;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            // 
            // BtSalvar
            // 
            this.BtSalvar.Location = new System.Drawing.Point(12, 465);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtSalvar.TabIndex = 43;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // TabelaStatus
            // 
            this.TabelaStatus.AllowUserToAddRows = false;
            this.TabelaStatus.AllowUserToDeleteRows = false;
            this.TabelaStatus.AllowUserToResizeColumns = false;
            this.TabelaStatus.AllowUserToResizeRows = false;
            this.TabelaStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.ValorParametro,
            this.dataGridViewTextBoxColumn2});
            this.TabelaStatus.Location = new System.Drawing.Point(12, 162);
            this.TabelaStatus.Name = "TabelaStatus";
            this.TabelaStatus.ShowCellToolTips = false;
            this.TabelaStatus.ShowEditingIcon = false;
            this.TabelaStatus.ShowRowErrors = false;
            this.TabelaStatus.Size = new System.Drawing.Size(594, 295);
            this.TabelaStatus.TabIndex = 42;
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
            this.TabelaClasses.Size = new System.Drawing.Size(594, 144);
            this.TabelaClasses.TabIndex = 41;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Status";
            this.dataGridViewTextBoxColumn1.MaxInputLength = 10;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // ValorParametro
            // 
            this.ValorParametro.HeaderText = "Parâmetro";
            this.ValorParametro.Name = "ValorParametro";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn2.MaxInputLength = 50;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 350;
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
            this.DescricaoClasse.Width = 490;
            // 
            // Estrategias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 500);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.TabelaStatus);
            this.Controls.Add(this.TabelaClasses);
            this.Name = "Estrategias";
            this.Text = "Estrategias";
            ((System.ComponentModel.ISupportInitialize)(this.TabelaStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaClasses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtSalvar;
        private System.Windows.Forms.DataGridView TabelaStatus;
        private System.Windows.Forms.DataGridView TabelaClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorParametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoClasse;
    }
}