using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loja.Telas.Estoque.Recebimento.CadastraRecebimento
{
    public partial class CadastrarRecebimento : Form
    {
        public CadastrarRecebimento()
        {
            InitializeComponent();
        }

        private void BtLocalizarItem_Click(object sender, EventArgs e)
        {

            ItensRecebimento ir = new ItensRecebimento();
            ir.Show();
            

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            Loja.Telas.Estoque.Recebimento.CadastraRecebimento.Pagamento pag = new Pagamento();
            pag.Show();
        }
    }
}
