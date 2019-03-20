namespace Loja.Telas.Configuracoes.Estrategia
{
    partial class ClassesEstrategiaDinamica
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
            this.TabelaClassesEstrategia = new System.Windows.Forms.DataGridView();
            this.Classe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoClasse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClasseAtiva = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaClassesEstrategia)).BeginInit();
            this.SuspendLayout();
            // 
            // TabelaClassesEstrategia
            // 
            this.TabelaClassesEstrategia.AllowUserToDeleteRows = false;
            this.TabelaClassesEstrategia.AllowUserToResizeColumns = false;
            this.TabelaClassesEstrategia.AllowUserToResizeRows = false;
            this.TabelaClassesEstrategia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaClassesEstrategia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Classe,
            this.DescricaoClasse,
            this.ClasseAtiva});
            this.TabelaClassesEstrategia.Location = new System.Drawing.Point(12, 12);
            this.TabelaClassesEstrategia.MultiSelect = false;
            this.TabelaClassesEstrategia.Name = "TabelaClassesEstrategia";
            this.TabelaClassesEstrategia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.TabelaClassesEstrategia.ShowCellToolTips = false;
            this.TabelaClassesEstrategia.ShowEditingIcon = false;
            this.TabelaClassesEstrategia.ShowRowErrors = false;
            this.TabelaClassesEstrategia.Size = new System.Drawing.Size(594, 287);
            this.TabelaClassesEstrategia.TabIndex = 11;
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
            this.DescricaoClasse.Width = 350;
            // 
            // ClasseAtiva
            // 
            this.ClasseAtiva.HeaderText = "Ativo";
            this.ClasseAtiva.Name = "ClasseAtiva";
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(93, 305);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 32;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            // 
            // BtSalvar
            // 
            this.BtSalvar.Location = new System.Drawing.Point(12, 305);
            this.BtSalvar.Name = "BtSalvar";
            this.BtSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtSalvar.TabIndex = 31;
            this.BtSalvar.Text = "Salvar";
            this.BtSalvar.UseVisualStyleBackColor = true;
            this.BtSalvar.Click += new System.EventHandler(this.BtSalvar_Click);
            // 
            // ClassesEstrategia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 339);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.TabelaClassesEstrategia);
            this.Name = "ClassesEstrategia";
            this.Text = "ClassesEstrategia";
            ((System.ComponentModel.ISupportInitialize)(this.TabelaClassesEstrategia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TabelaClassesEstrategia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoClasse;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClasseAtiva;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtSalvar;
    }
}