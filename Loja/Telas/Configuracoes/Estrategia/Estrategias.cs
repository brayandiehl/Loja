using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loja.Telas.Configuracoes.Estrategia
{
    public partial class Estrategias : Form
    {
        public Estrategias()
        {
            InitializeComponent();
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            TabelaStatus.Rows.Insert(0,"Teste",null,"TESTE1");
        }
    }
}
