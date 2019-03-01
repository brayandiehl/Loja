namespace Loja.Telas.Configuracoes.Estrategia
{
    partial class ClassesEstrategia
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
            this.ClasseAtiva = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.BtSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TabelaClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // TabelaClasses
            // 
            this.TabelaClasses.AllowUserToResizeColumns = false;
            this.TabelaClasses.AllowUserToResizeRows = false;
            this.TabelaClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelaClasses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Classe,
            this.DescricaoClasse,
            this.ClasseAtiva});
            this.TabelaClasses.Location = new System.Drawing.Point(12, 12);
            this.TabelaClasses.MultiSelect = false;
            this.TabelaClasses.Name = "TabelaClasses";
            this.TabelaClasses.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.TabelaClasses.ShowCellToolTips = false;
            this.TabelaClasses.ShowEditingIcon = false;
            this.TabelaClasses.ShowRowErrors = false;
            this.TabelaClasses.Size = new System.Drawing.Size(594, 287);
            this.TabelaClasses.TabIndex = 11;
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
            // 
            // ClassesEstrategia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 339);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtSalvar);
            this.Controls.Add(this.TabelaClasses);
            this.Name = "ClassesEstrategia";
            this.Text = "ClassesEstrategia";
            ((System.ComponentModel.ISupportInitialize)(this.TabelaClasses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TabelaClasses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Classe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoClasse;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ClasseAtiva;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Button BtSalvar;
    }
}