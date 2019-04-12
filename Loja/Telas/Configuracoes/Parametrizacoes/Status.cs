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
    public partial class Status : Form
    {



        public Status()
        {
            InitializeComponent();
            ClassParametros.RetornarParametros(TabelaClasses);
            TabelaStatus.Rows[0].Cells[1].ReadOnly = true;
        }

        private string ClasseSelecionada { get; set; }

        private void Status_Load(object sender, EventArgs e)
        {

        }

        private void BtSalvar_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            for (int a = 0; a < TabelaStatus.RowCount - 1; a++)
            {
                //Pega os valores do Parametro
                if (string.IsNullOrEmpty((string)TabelaStatus.Rows[a].Cells["ColunaStatus"].Value))
                {
                    MessageBox.Show("Valor do Status está em branco!", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    Cursor = Cursors.Default;
                    return;


                }
                var ParametroAtual = TabelaStatus.Rows[a].Cells["ColunaStatus"].Value.ToString();
                var DescricaoAtual = TabelaStatus.Rows[a].Cells["Descricao"].Value.ToString();

                ClassParametros.RetornaValorParametro(ClasseSelecionada, TabelaStatus.Rows[a].Cells["ColunaStatus"].Value.ToString());





               


                    if (string.IsNullOrEmpty(ClassParametros.Parametro) && string.IsNullOrEmpty(ClassParametros.DescricaoParametro))
                    {
                        if (string.IsNullOrEmpty((string)TabelaStatus.Rows[a].Cells["ColunaStatus"].Value))
                        {
                            if (MessageBox.Show("Valor da Estratégia está em branco! \nAo continuar será atribuido atuomáticamente a estratégia 0!\nDesejá continuar?", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                            {
                                //Cursor = Cursors.Default;
                                return;
                            }

                        }
                        if (!ClassParametros.InsereNovoParametro(ClasseSelecionada, TabelaStatus.Rows[a].Cells["ColunaStatus"].Value.ToString(), ParametroAtual, DescricaoAtual))
                        {
                            MessageBox.Show("Erro ao inserir novo parametro\nErro: " + ClassParametros.Erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else
                        {
                            MessageBox.Show("Estratégia " + TabelaStatus.Rows[a].Cells["ColunaStatus"].Value.ToString() + " Inserida com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);

                        }
                    }


                    /*S
                    if (!ClassParametros.AtualizaValorParametro(ClasseSelecionada, TabelaStatus.Rows[a].Cells["ColunaStatus"].Value.ToString(), ParametroAtual))
                    {
                        if (MessageBox.Show("Erro ao Atualizar\nClasse:  " + ClasseSelecionada + "\nStatus: " + TabelaStatus.Rows[a].Cells["ColunaStatus"].Value.ToString() + "\nErro: " + ClassParametros.Erro + "\n\nDEsejá continuar sem atualizar o parametro acima?", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                        {
                            Cursor = Cursors.Default;
                            return;
                        }
                    }
                    */
                
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
                
                //Classes.ClassEstrategia.RetornaValorParametro(ClasseSelecionada, TabelaStatus.Rows[a].Cells["Descricao"].Value.ToString());
                var teste = ClassParametros.DescricaoParametro;
                if ((!DescricaoAtual.Equals(ClassParametros.DescricaoParametro)) && (!string.IsNullOrEmpty(ClassParametros.DescricaoParametro)))
                {

                    if (!ClassParametros.AtualizaValorParametroDescricao(ClasseSelecionada, TabelaStatus.Rows[a].Cells["ColunaStatus"].Value.ToString(), DescricaoAtual))
                    {
                        if (MessageBox.Show("Erro ao Atualizar\nClasse:  " + ClasseSelecionada + "\nDescricao: " + TabelaStatus.Rows[a].Cells["Descricao"].Value.ToString() + "\nParametro: " + ParametroAtual + "\nErro: " + ClassParametros.Erro + "\n\nDEsejá continuar sem atualizar o parametro acima?", "ERRO", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.No)
                        {
                            Cursor = Cursors.Default;
                            return;
                        }
                    }

                }
                //Estrategia

               


            }

            Cursor = Cursors.Default;
        }

        private void TabelaStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TabelaClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ClasseSelecionada = TabelaClasses.Rows[e.RowIndex].Cells["Classe"].Value.ToString();
                ClassParametros.RetornaParametros(TabelaStatus, ClasseSelecionada);
                //TabelaStatus.Rows[0].Cells[1].ReadOnly = false;

            }
        }
    }
}
