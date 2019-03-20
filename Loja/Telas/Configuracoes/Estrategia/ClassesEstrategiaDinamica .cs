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
    public partial class ClassesEstrategiaDinamica : Form
    {
        public ClassesEstrategiaDinamica()
        {
            InitializeComponent();
            RecuperaClasses();
        }

        private void RecuperaClasses()
        {
            try
            {
                if (!Classes.ClassEstrategia.RetornarEstrategias(TabelaClassesEstrategia))
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
            for (int a = 0; a < TabelaClassesEstrategia.RowCount - 1; a++)
            {
                if (!TabelaClassesEstrategia.Rows[a].Cells["Classe"].ReadOnly)
                {
                    int EstrategiaAtiva = 0;
                    if (Convert.ToBoolean(TabelaClassesEstrategia.Rows[a].Cells["ClasseAtiva"].Value))
                    {
                        EstrategiaAtiva = 1;
                    }
                    if (Classes.ClassEstrategia.ValidaCampos(TabelaClassesEstrategia))
                    {
                        if (Classes.ClassEstrategia.InsereEstrategia(TabelaClassesEstrategia.Rows[a].Cells["Classe"].Value.ToString(), TabelaClassesEstrategia.Rows[a].Cells["DescricaoClasse"].Value.ToString(), Convert.ToString(EstrategiaAtiva), "BRAYAN"))
                        {
                            MessageBox.Show("Estratégias Salvas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        else
                        {
                            if (MessageBox.Show(Classes.ClassEstrategia.Erro + "\nDesejá continuar?", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                            {
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(Classes.ClassEstrategia.Erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
