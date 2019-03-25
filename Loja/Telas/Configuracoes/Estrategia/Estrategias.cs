using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Loja.Telas.Configuracoes.Estrategia.Classes;

namespace Loja.Telas.Configuracoes.Estrategia
{
    public partial class Estrategias : Form
    {
        private string ClasseSelecionada { get; set; }
        public Estrategias()
        {
            InitializeComponent();
            ClassEstrategia.RetornarEstrategias(TabelaClasses);
            TabelaStatus.Rows[0].Cells[1].ReadOnly = true;
        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            for (int a = 0; a < TabelaStatus.RowCount - 1; a++)
            {
                //Pega os valores do Parametro
                if (string.IsNullOrEmpty((string)TabelaStatus.Rows[a].Cells["ValorParametro"].Value))
                {
                    if (MessageBox.Show("Valor do Paramêtro está em branco! \nAo continuar será atribuido atuomáticamente o valor 0!\nDesejá continuar?", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                    {
                        Cursor = Cursors.Default;
                        return;
                    }
                    else
                    {
                        TabelaStatus[1, a].Value = "0";
                    }
                }
                var ParametroAtual = TabelaStatus.Rows[a].Cells["ValorParametro"].Value.ToString();
                Classes.ClassEstrategia.RetornaValorParametro(ClasseSelecionada, TabelaStatus.Rows[a].Cells["Estrategia"].Value.ToString());
                if ((!ParametroAtual.Equals(ClassEstrategia.Parametro)) && (!string.IsNullOrEmpty(ClassEstrategia.Parametro)))
                {
                    if (!ClassEstrategia.AtualizaValorParametro(ClasseSelecionada, TabelaStatus.Rows[a].Cells["Estrategia"].Value.ToString(), ParametroAtual))
                    {
                        if (MessageBox.Show("Erro ao Atualizar\nClasse:  " + ClasseSelecionada + "\nEstratégia: " + TabelaStatus.Rows[a].Cells["Estrategia"].Value.ToString() + "\nParametro: " + ParametroAtual + "\nErro: " + Classes.ClassEstrategia.Erro + "\n\nDEsejá continuar sem atualizar o parametro acima?", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                        {
                            Cursor = Cursors.Default;
                            return;
                        }
                    }
                }
                //Pega as descrição
                if (string.IsNullOrEmpty((string)TabelaStatus.Rows[a].Cells["Descricao"].Value))
                {
                    if (MessageBox.Show("Valor do Descrição está em branco! \nAo continuar será atribuido atuomáticamente o descrição 0!\nDesejá continuar?", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                    {
                        Cursor = Cursors.Default;
                        return;
                    }
                    else
                    {
                        TabelaStatus[2, a].Value = "0";
                    }
                }
                var DescricaoAtual = TabelaStatus.Rows[a].Cells["Descricao"].Value.ToString();
                //Classes.ClassEstrategia.RetornaValorParametro(ClasseSelecionada, TabelaStatus.Rows[a].Cells["Descricao"].Value.ToString());
                var teste = ClassEstrategia.DescricaoParametro;
                if ((!DescricaoAtual.Equals(ClassEstrategia.DescricaoParametro)) && (!string.IsNullOrEmpty(ClassEstrategia.DescricaoParametro)))
                {

                    if (!ClassEstrategia.AtualizaValorParametroDescricao(ClasseSelecionada, TabelaStatus.Rows[a].Cells["Estrategia"].Value.ToString(), DescricaoAtual))
                    {
                        if (MessageBox.Show("Erro ao Atualizar\nClasse:  " + ClasseSelecionada + "\nDescricção da Estratégia: " + TabelaStatus.Rows[a].Cells["Descricao"].Value.ToString() + "\nParametro: " + ParametroAtual + "\nErro: " + Classes.ClassEstrategia.Erro + "\n\nDEsejá continuar sem atualizar o parametro acima?", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                        {
                            Cursor = Cursors.Default;
                            return;
                        }
                    }

                }
                //Estrategia

                if (string.IsNullOrEmpty(ClassEstrategia.Parametro) && string.IsNullOrEmpty(ClassEstrategia.DescricaoParametro))
                {
                    if (string.IsNullOrEmpty((string)TabelaStatus.Rows[a].Cells["Estrategia"].Value))
                    {
                        if (MessageBox.Show("Valor da Estratégia está em branco! \nAo continuar será atribuido atuomáticamente a estratégia 0!\nDesejá continuar?", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                        {
                            //Cursor = Cursors.Default;
                            return;
                        }

                    }
                    if (!ClassEstrategia.InsereNovoParametro(ClasseSelecionada, TabelaStatus.Rows[a].Cells["Estrategia"].Value.ToString(), ParametroAtual, DescricaoAtual))
                    {
                        MessageBox.Show("Erro ao inserir novo parametro\nErro: " + ClassEstrategia.Erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("Estratégia " + TabelaStatus.Rows[a].Cells["Estrategia"].Value.ToString() + " Inserida com sucesso",  "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);

                    }
                }


            }

            Cursor = Cursors.Default;
        }

        private void TabelaClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ClasseSelecionada = TabelaClasses.Rows[e.RowIndex].Cells["Classe"].Value.ToString();
                Classes.ClassEstrategia.RetornaParametros(TabelaStatus, ClasseSelecionada);
                //TabelaStatus.Rows[0].Cells[1].ReadOnly = false;

            }
        }


    }
}
