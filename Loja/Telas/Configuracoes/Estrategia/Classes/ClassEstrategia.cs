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
                    var query = "select c.classe, c.nome_classe, c.classe_ativa from classes_estrategias c";
                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataReader dr = cm.ExecuteReader();
                    int cont = 0;
                    while (dr.Read())
                    {
                        dgw.Rows.Insert(cont, dr["classe"], dr["nome_classe"], dr["classe_ativa"]);
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
                    int cont = 0;
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
                var InsereEstrategia = "INSERT INTO classes_estrategias(classe,nome_classe,classe_ativa,usuario_criacao)VALUES('" + estrategia + "','" + nomeEstrategia + "', '" + ativo + "', '" + usuario + "')";
                Loja.Classes.Banco.ExecutaQuery(InsereEstrategia);
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
