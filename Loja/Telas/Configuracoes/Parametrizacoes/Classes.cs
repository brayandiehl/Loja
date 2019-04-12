using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Loja.Telas.Configuracoes.Parametrizacoes.Classe;

namespace Loja.Telas.Configuracoes.Parametrizacoes
{
    public partial class Classes : Form
    {
        public Classes()
        {
            InitializeComponent();
            RecuperaParametros();
        }


        private void RecuperaParametros()
        {
            try
            {
                if (!ClassParametros.RetornarParametros(TabelaClasses))
                {
                    MessageBox.Show(ClassParametros.Erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtSalvar_Click(object sender, EventArgs e)
        {
            for (int a = 0; a < TabelaClasses.RowCount - 1; a++)
            {
                if (!TabelaClasses.Rows[a].Cells["Classe"].ReadOnly)
                {
                    int EstrategiaAtiva = 0;
                    if (Convert.ToBoolean(TabelaClasses.Rows[a].Cells["ClasseAtiva"].Value))
                    {
                        EstrategiaAtiva = 1;
                    }
                    if (ClassParametros.ValidaCampos(TabelaClasses))
                    {
                        if (ClassParametros.InsereEstrategia(TabelaClasses.Rows[a].Cells["Classe"].Value.ToString(), TabelaClasses.Rows[a].Cells["DescricaoClasse"].Value.ToString(), Convert.ToString(EstrategiaAtiva), "BRAYAN"))
                        {
                            MessageBox.Show("Estratégias Salvas com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        else
                        {
                            if (MessageBox.Show(ClassParametros.Erro + "\nDesejá continuar?", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                            {
                                return;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show(ClassParametros.Erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
