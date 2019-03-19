using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Loja.Classes
{
    class Banco
    {
        public static string Erro { get; private set; }
        public static string LinhasAfetadas { get; private set; }

        public static MySqlConnection ConectaMysql()
        {
            MySqlConnection SQLConnection = new MySqlConnection();
            try
            {
                SQLConnection.ConnectionString = "Server=localhost;Database=emporiodosaquarios;Uid=root";
                return SQLConnection;

            }
            catch (Exception Ex)
            {
                Erro = Ex.Message;
                return null;
            }
        }
        public static bool ExecutaQuery(string query)
        {
            try
            {
                if (!string.IsNullOrEmpty(query))
                {
                    var conn = ConectaMysql();
                    if (conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }

                    if (conn.State == ConnectionState.Open)
                    {
                        MySqlCommand comando = new MySqlCommand(query, conn);
                        LinhasAfetadas = comando.ExecuteNonQuery().ToString();
                        ConectaMysql().Close();
                        return true;
                    }
                    else
                    {
                        Erro = "Falha ao abrir conexão";
                        return false;
                    }

                }
                else
                {
                    Erro = "Query não poder vazia";
                    return false;
                    //return "Query não pode ser nulla";
                }
            }
            catch (Exception EX)
            {
                Erro = "Erro: " + EX.Message;
                return false;
            }

        }
    }
}
