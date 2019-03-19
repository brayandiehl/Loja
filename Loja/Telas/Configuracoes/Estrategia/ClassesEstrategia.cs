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
    public partial class ClassesEstrategia : Form
    {
        public ClassesEstrategia()
        {
            InitializeComponent();
            RecuperaClasses();
        }

        private void RecuperaClasses()
        {
            try
            {
                if (!Classes.ClassEstrategia.RetornarEstrategias(TabelaClasses))
                {
                    MessageBox.Show(Classes.ClassEstrategia.Erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {


            if (Classes.ClassEstrategia.RetonraQuantidadeRegistros())
            {


                for (int a = 0; a <= TabelaClasses.RowCount - 1; a++)
                {
                    if()
                }


                int linhas = (TabelaClasses.RowCount - 1) - Convert.ToInt32(Classes.ClassEstrategia.QuantidadeRegistros);

                var teste = TabelaClasses.Rows[1].Cells["Classe"].ReadOnly;






                for (int a = Convert.ToInt32(Classes.ClassEstrategia.QuantidadeRegistros); a <= linhas; a++)
                {


                }

            }





        }
    }
}
