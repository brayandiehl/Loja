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
            Classes.ClassEstrategia.RetornarEstrategias(TabelaClasses);
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {

        }

        private void TabelaClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Classes.ClassEstrategia.RetornaParametros(TabelaStatus, TabelaClasses.Rows[e.RowIndex].Cells["Classe"].Value.ToString());
            }
        }
    }
}
