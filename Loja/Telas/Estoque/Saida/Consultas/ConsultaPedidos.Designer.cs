namespace Loja.Telas.Estoque.Saida.Consultas
{
    partial class ConsultaPedidos
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
            this.Pedidos = new System.Windows.Forms.DataGridView();
            this.Pedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Excluir = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // Pedidos
            // 
            this.Pedidos.AllowUserToAddRows = false;
            this.Pedidos.AllowUserToDeleteRows = false;
            this.Pedidos.AllowUserToResizeColumns = false;
            this.Pedidos.AllowUserToResizeRows = false;
            this.Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pedido,
            this.DataPedido,
            this.Cliente,
            this.Status,
            this.Valor,
            this.Excluir});
            this.Pedidos.Location = new System.Drawing.Point(9, 12);
            this.Pedidos.Name = "Pedidos";
            this.Pedidos.RowHeadersVisible = false;
            this.Pedidos.Size = new System.Drawing.Size(854, 426);
            this.Pedidos.TabIndex = 1;
            // 
            // Pedido
            // 
            this.Pedido.HeaderText = "Pedido";
            this.Pedido.Name = "Pedido";
            this.Pedido.ReadOnly = true;
            // 
            // DataPedido
            // 
            this.DataPedido.HeaderText = "Data Pedido";
            this.DataPedido.Name = "DataPedido";
            this.DataPedido.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            this.Cliente.Width = 300;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 150;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Valor.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Excluir
            // 
            this.Excluir.HeaderText = "Excluir";
            this.Excluir.Name = "Excluir";
            // 
            // ConsultaPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 450);
            this.Controls.Add(this.Pedidos);
            this.Name = "ConsultaPedidos";
            this.Text = "ConsultaPedidos";
            ((System.ComponentModel.ISupportInitialize)(this.Pedidos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Pedidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewButtonColumn Excluir;
    }
}