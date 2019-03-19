using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loja.Telas.Configuracoes.Estrategia.Classes
{
    static class ClassEstrategia
    {
        public static string Erro { get; private set; }
        public static string QuantidadeRegistros { get; private set; }

        public static bool RetornarEstrategias(DataGridView dgw)
        {
            try
            {
                var conn = Loja.Classes.Banco.ConectaMysql();

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    var query = "";
                    if (dgw.Name.Trim().Equals("TabelaClassesEstrategia"))
                    {
                        query = "select c.classe, c.nome_classe, c.classe_ativa from classes_estrategias c order by c.id_classe desc";
                    }
                    else if (dgw.Name.Trim().Equals("TabelaClasses"))
                    {
                        query = "select c.classe, c.nome_classe, c.classe_ativa from classes_estrategias c where c.classe_ativa = '1' order by c.id_classe desc";
                    }
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataReader dr = cm.ExecuteReader();
                    int cont = 0;
                    while (dr.Read())
                    {
                        if (dgw.Name.Trim().Equals("TabelaClassesEstrategia"))
                        {
                            dgw.Rows.Insert(cont, dr["classe"], dr["nome_classe"], dr["classe_ativa"]);
                        }
                        else if (dgw.Name.Trim().Equals("TabelaClasses"))
                        {
                            dgw.Rows.Insert(cont, dr["classe"], dr["nome_classe"]);
                        }

                        dgw.Rows[cont].Cells["Classe"].ReadOnly = true;
                        dgw.Rows[cont].Cells["DescricaoClasse"].ReadOnly = true;
                    }

                    dr.Close();
                    conn.Close();
                    return true;
                }
                else
                {
                    Erro = "Falha abrir conexão com o banco de dados";
                    return false;
                }

            }
            catch (Exception ex)
            {
                Erro = ex.Message;
                return false;
            }

        }

        public static bool RetonraQuantidadeRegistros()
        {
            try
            {
                var conn = Loja.Classes.Banco.ConectaMysql();

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    var query = "select count(*) as qtd from classes_estrategias c";
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataReader dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        QuantidadeRegistros = dr["qtd"].ToString();
                    }

                    dr.Close();
                    conn.Close();
                    return true;
                }
                else
                {
                    Erro = "Falha abrir conexão com o banco de dados";
                    return false;
                }

            }
            catch (Exception ex)
            {
                Erro = ex.Message;
                return false;
            }
        }

        public static bool InsereEstrategia(string estrategia, string nomeEstrategia, string ativo, string usuario)
        {
            try
            {

                var InsereEstrategia = "INSERT INTO classes_estrategias(classe,nome_classe,classe_ativa,usuario_criacao, data_criacao)VALUES('" + estrategia + "','" + nomeEstrategia + "', '" + ativo + "', '" + usuario + "', NOW())";
                var retorno = Loja.Classes.Banco.ExecutaQuery(InsereEstrategia);
                if (retorno)
                {
                    return true;
                }
                else
                {
                    Erro = Loja.Classes.Banco.Erro;
                    return false;
                }


            }
            catch (Exception ex)
            {
                Erro = ex.Message;
                return false;
            }

        }

        public static bool ValidaCampos(DataGridView dgv)
        {
            for (int x = 0; x < dgv.RowCount - 1; x++)
            {
                if (string.IsNullOrEmpty((string)dgv.Rows[x].Cells[0].Value))
                {
                    Erro = "Campo " + dgv.Columns[0].HeaderText + " Deve conter informação!";
                    return false;
                }
                if (string.IsNullOrEmpty((string)dgv.Rows[x].Cells[1].Value))
                {
                    Erro = "Campo " + dgv.Columns[1].HeaderText + " Deve conter informação!";
                    return false;
                }
            }
            return true;
        }

        public static bool RetornaParametros(DataGridView dgv, string classe)
        {

            try
            {
                if (!string.IsNullOrEmpty(classe))
                {
                    dgv.Rows.Clear();
                    var sql = "select s.estrategia, s.nome_estrategia, s.parametro from estrategias s where s.classe = '" + classe + "' order by s.id_estrategia desc";
                    var conn = Loja.Classes.Banco.ConectaMysql();

                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    if (conn.State == ConnectionState.Open)
                    {
                        MySqlCommand cm = new MySqlCommand(sql, conn);
                        MySqlDataReader dr = cm.ExecuteReader();
                        int cont = 0;
                        while (dr.Read())
                        {

                            dgv.Rows.Insert(cont, dr["estrategia"], dr["parametro"], dr["nome_estrategia"]);

                            //dgv.Rows[cont].Cells["Classe"].ReadOnly = true;
                            //dgv.Rows[cont].Cells["DescricaoClasse"].ReadOnly = true;
                        }

                        dr.Close();
                        conn.Close();
                        return true;
                    }
                    else
                    {
                        Erro = "Falha abrir conexão com o banco de dados";
                        return false;
                    }


                }
                else
                {
                    Erro = "Código da classe para localizar as estratégias não pode ser em branco";
                    return false;
                }
            }
            catch (Exception ex)
            {
                Erro = ex.Message;
                return false;
            }

            return false;
        }
    }
}
