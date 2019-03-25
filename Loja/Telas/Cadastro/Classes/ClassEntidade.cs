using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Loja.Classes;
using Loja.Telas.Configuracoes.Estrategia.Classes;
using MySql.Data.MySqlClient;

namespace Loja.Telas.Cadastro.Classes
{
    static class ClassEntidade
    {
        public static string Cod { get; set; }
        public static string Cpf_cnpj { get; set; } // 
        public static string Ativo { get; set; }
        public static string Nome { get; set; }//
        public static string Grupo { get; set; }  //
        public static string NomeGrupo { get; set; }  //
        public static string Data_cadastro { get; set; }
        public static string Data_alteracao { get; set; }
        public static string Data_nascimento { get; set; }//
        public static string Idade { get; set; }
        public static string CEP { get; set; }//
        public static string Rua { get; set; }//
        public static string Cidade { get; set; }//
        public static string Bairro { get; set; }//
        public static string Numero { get; set; }//
        public static string Complemento { get; set; }
        public static string Estado { get; set; }//
        public static string Email { get; set; }
        public static string Facebook { get; set; }
        public static string Celular1 { get; set; }
        public static string WhatsApp_Celular1 { get; set; }
        public static string Nome_Celular1 { get; set; }
        public static string Celular2 { get; set; }
        public static string WhatsApp_Celular2 { get; set; }
        public static string Nome_Celular2 { get; set; }
        public static string ClienteVip { get; set; }
        public static string NotificarProdutoNovo { get; set; }
        public static string NotificarVencimento { get; set; }
        public static string NotificarPromocao { get; set; }
        public static string AceitaFiado { get; set; }
        public static string NotificarAniversario { get; set; }
        public static string Observacao { get; set; }
        public static string NomeFoto { get; set; }
        public static string Erro { get; private set; }

        public static bool CadastraEntidade()
        {
            try
            {
                if (ValidaCampos())
                {
                    var cpf_cnpj_tratado = Cpf_cnpj.Replace(".", "").Replace(",", "").Replace("-", "").Replace("/", "").Replace("_", "");

                    string query = @"INSERT INTO entidade (cpf_cnpj, 
                                                       flg_ativo, 
                                                       razao_social, 
                                                       grupo_parametro, 
                                                       data_nascimento,
                                                       cep, 
                                                       rua,
                                                       cidade, 
                                                       bairro,
                                                       numero,
                                                       complemento, 
                                                       estado, email, 
                                                       facebook, 
                                                       celular1,
                                                       flg_whatsapp_celular1, 
                                                       nome_celular1,
                                                       celular2, 
                                                       flg_whatsapp_celular2,
                                                       nome_celular2,
                                                       flg_cliente_vip, 
                                                       flg_notificar_produto_novo, 
                                                       flg_notificar_vencimento, 
                                                       flg_notificar_promocao, 
                                                       flg_aceita_fiado, 
                                                       flg_notificar_aniversario,
                                                       nome_foto, 
                                                       observacao, 
                                                       status_entidade, 
                                                       data_cadastro, 
                                                       usuario_cadastro,
                                                       data_alteracao, 
                                                       usuario_alteracao)
                                    VALUES('" + cpf_cnpj_tratado + "', " +
                                                            "'" + Ativo + "', " +
                                                            "'" + Nome + "'," +
                                                            "'" + Grupo + "', " +
                                                            "'" + Data_nascimento + "'," +
                                                            "'" + CEP + "', " +
                                                            "'" + Rua + "', " +
                                                            "'" + Cidade + "', " +
                                                            "'" + Bairro + "', " +
                                                            "'" + Numero + "', " +
                                                            "'" + Complemento + "', " +
                                                            "'" + Estado + "', " +
                                                            "'" + Email + "', " +
                                                            "'" + Facebook + "', " +
                                                            "'" + Celular1 + "', " +
                                                            "'" + WhatsApp_Celular1 + "', " +
                                                            "'" + Nome_Celular1 + "', " +
                                                            "'" + Celular2 + "', " +
                                                            "'" + WhatsApp_Celular2 + "', " +
                                                            "'" + Nome_Celular2 + "', " +
                                                            "'" + ClienteVip + "', " +
                                                            "'" + NotificarProdutoNovo + "', " +
                                                            "'" + NotificarVencimento + "', " +
                                                            "'" + NotificarPromocao + "', " +
                                                            "'" + AceitaFiado + "', " +
                                                            "'" + NotificarAniversario + "', " +
                                                            "'" + NomeFoto + "', " +
                                                            "'" + Observacao + "', " +
                                                            "'1', " +
                                                            "now(), " +
                                                            "'" + Loja.Program.UsuarioLogado + "', " +
                                                            "now(), " +
                                                            "'" + Loja.Program.UsuarioLogado + "')";
                    if (!string.IsNullOrEmpty(query))
                    {
                        if (!Banco.ExecutaQuery(query))
                        {
                            Erro = Banco.Erro;
                            return false;
                        }
                        else
                        {
                            return true;
                        }
                    }
                    else
                    {
                        Erro = "Query de salvar a entidade não pode estar em branco";
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Erro = ex.Message;
                return false;
            }
        }

        public static bool RetornaEntidade(string cpf_cnpj, string grupo)
        {
            LimpaCampos();
            var cpf_cnpj_tratado = cpf_cnpj.Replace(".", "").Replace(",", "").Replace("-", "").Replace("/", "").Replace("_", "");

            if (string.IsNullOrEmpty(cpf_cnpj_tratado))
            {
                Erro = "CPF ou CNPJ não pode estrar em branco";
                return false;
            }
            if (string.IsNullOrEmpty(grupo))
            {
                Erro = "Grupo não pode estrar em branco";
                return false;
            }

            try
            {
                var conn = Loja.Classes.Banco.ConectaMysql();

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                if (conn.State == ConnectionState.Open)
                {
                    string query = @"select 
                                e.id_entidade,
                                e.cpf_cnpj,
                                e.flg_ativo,
                                e.razao_social,
                                e.grupo_parametro,
                                e.data_nascimento,
                                e.cep,
                                e.rua,
                                e.cidade,
                                e.bairro,
                                e.numero,
                                e.complemento,
                                e.estado,
                                e.email,
                                e.facebook,
                                e.celular1,
                                e.flg_whatsapp_celular1,
                                e.nome_celular1,
                                e.celular2,
                                e.flg_whatsapp_celular2,
                                e.nome_celular2,
                                e.flg_cliente_vip,
                                e.flg_notificar_produto_novo,
                                e.flg_notificar_vencimento,
                                e.flg_notificar_promocao,
                                e.flg_aceita_fiado,
                                e.flg_notificar_aniversario,
                                e.nome_foto,
                                e.observacao,
                                e.status_entidade,
                                e.data_cadastro,
                                e.usuario_cadastro,
                                e.data_alteracao,
                                e.usuario_alteracao
                             from entidade e where e.cpf_cnpj = '" + cpf_cnpj_tratado + "' and e.grupo_parametro = '" + grupo + "'";

                    MySqlCommand cm = new MySqlCommand(query, conn);
                    MySqlDataReader dr = cm.ExecuteReader();
                    while (dr.Read())
                    {
                        Cod = dr["id_entidade"].ToString();
                        Cpf_cnpj = dr["cpf_cnpj"].ToString();
                        Ativo = dr["flg_ativo"].ToString();
                        Nome = dr["razao_social"].ToString();
                        Grupo = dr["grupo_parametro"].ToString();
                        // NomeGrupo = dr["qtd"].ToString();
                        Data_cadastro = dr["data_cadastro"].ToString();
                        Data_alteracao = dr["data_alteracao"].ToString();
                        Data_nascimento = dr["data_nascimento"].ToString();
                        //Idade = dr["qtd"].ToString();
                        CEP = dr["cep"].ToString();
                        Rua = dr["rua"].ToString();
                        Cidade = dr["cidade"].ToString();
                        Bairro = dr["bairro"].ToString();
                        Numero = dr["numero"].ToString();
                        Complemento = dr["complemento"].ToString();
                        Estado = dr["estado"].ToString();
                        Email = dr["email"].ToString();
                        Facebook = dr["facebook"].ToString();
                        Celular1 = dr["celular1"].ToString();
                        WhatsApp_Celular1 = dr["flg_whatsapp_celular1"].ToString();
                        Nome_Celular1 = dr["nome_celular1"].ToString();
                        Celular2 = dr["celular2"].ToString();
                        WhatsApp_Celular2 = dr["flg_whatsapp_celular2"].ToString();
                        Nome_Celular2 = dr["nome_celular2"].ToString();
                        ClienteVip = dr["flg_cliente_vip"].ToString();
                        NotificarProdutoNovo = dr["flg_notificar_produto_novo"].ToString();
                        NotificarVencimento = dr["flg_notificar_vencimento"].ToString();
                        NotificarPromocao = dr["flg_notificar_promocao"].ToString();
                        AceitaFiado = dr["flg_aceita_fiado"].ToString();
                        NotificarAniversario = dr["flg_notificar_aniversario"].ToString();
                        Observacao = dr["observacao"].ToString();
                        NomeFoto = dr["nome_foto"].ToString();
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

        public static bool AtualizaEntidade()
        {
            return false;
        }

        public static bool DeletaEntidade()
        {
            return false;
        }

        private static bool ValidaCampos()
        {
            var cpf_cnpj_tratado = Cpf_cnpj.Replace(".", "").Replace(",", "").Replace("-", "").Replace("/", "").Replace("_", "");

            if (String.IsNullOrEmpty(cpf_cnpj_tratado))
            {
                Erro = "CPF / CNPJ deve conter informação";
                return false;
            }
            if (String.IsNullOrEmpty(Nome))
            {
                Erro = "Nome da Entidade não pode ser em branco";
                return false;
            }
            if (String.IsNullOrEmpty(Grupo))
            {
                Erro = "Grupo Deve conter informação";
                return false;
            }
            if (String.IsNullOrEmpty(CEP))
            {
                Erro = "CEP deve ser informado";
                return false;
            }
            if (String.IsNullOrEmpty(Rua))
            {
                Erro = "Rua deve ser informado";
                return false;
            }
            if (String.IsNullOrEmpty(Cidade))
            {
                Erro = "Cidade deve ser informada";
                return false;
            }
            if (String.IsNullOrEmpty(Bairro))
            {
                Erro = "Bairro deve ser informado";
                return false;
            }
            if (String.IsNullOrEmpty(Numero))
            {
                Erro = "Numero não pode ser em Branco";
                return false;
            }
            if (String.IsNullOrEmpty(Estado))
            {
                Erro = "Estado não pode estar em branco";
                return false;
            }
            return true;
        }

        private static bool LimpaCampos()
        {
            Cod = null;
            Cpf_cnpj = null;
            Ativo = null;
            Nome = null;
            Grupo = null;
            NomeGrupo = null;
            Data_cadastro = null;
            Data_alteracao = null;
            Data_nascimento = null;
            Idade = null;
            CEP = null;
            Rua = null;
            Cidade = null;
            Bairro = null;
            Numero = null;
            Complemento = null;
            Estado = null;
            Email = null;
            Facebook = null;
            Celular1 = null;
            WhatsApp_Celular1 = null;
            Nome_Celular1 = null;
            Celular2 = null;
            WhatsApp_Celular2 = null;
            Nome_Celular2 = null;
            ClienteVip = null;
            NotificarProdutoNovo = null;
            NotificarVencimento = null;
            NotificarPromocao = null;
            AceitaFiado = null;
            NotificarAniversario = null;
            Observacao = null;
            NomeFoto = null;
            Erro = null;
            return true;
        }

        public static bool LocaizaCep(string CEP)
        {
            try
            {
                if (Correios.ConsultaCEP(CEP))
                {
                    Cidade = Correios.Cidade;
                    Bairro = Correios.Bairro;
                    Rua = Correios.Endereco;
                    Bairro = Correios.Bairro;
                    Estado = Correios.Estado;
                    Complemento = Correios.Complemento;
                }
                else
                {
                    Erro = Correios.Erro;
                    return false;
                }
            }
            catch (Exception ex)
            {
                Erro = ex.Message;
                return false;
            }
            return true;
        }

        public static bool ValidaCnpjCpf(string cpf_cnpj, MaskedTextBox Campo)
        {
            try
            {
                var Cnpj_Cpf_tratado = cpf_cnpj.Replace("/", "").Replace(".", "").Replace("-", "").Replace("_", "").Replace(",", "");

                if (Cnpj_Cpf_tratado.Length == 11)
                {
                    if (!ValidaCpf(Cnpj_Cpf_tratado))
                    {
                        Erro = "CPF Inválido";
                        return false;
                    }
                    Campo.Mask = "###.###.###-##";
                    return true;
                }
                else if (Cnpj_Cpf_tratado.Length == 14)
                {
                    if (!ValidaCnpj(Cnpj_Cpf_tratado))
                    {
                        Erro = "CNPJ Inválido";
                        return false;
                    }
                    Campo.Mask = "##.###.###/####-##";
                    return true;
                }
                else
                {
                    Erro = "Mascará inválida";
                    return false;
                }

            }
            catch (Exception ex)
            {
                Erro = ex.Message;
                return false;
            }

        }

        private static bool ValidaCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            cpf = cpf.Trim().Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;

            for (int j = 0; j < 10; j++)
                if (j.ToString().PadLeft(11, char.Parse(j.ToString())) == cpf)
                    return false;

            string tempCpf = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            int resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }

        private static bool ValidaCnpj(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            cnpj = cnpj.Trim().Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;

            string tempCnpj = cnpj.Substring(0, 12);
            int soma = 0;

            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            int resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            string digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);
        }

        public static bool RetornaGrupoEntidade(string parametro)
        {
            try
            {
                if (string.IsNullOrEmpty(parametro))
                {
                    Erro = "Grupo da Entidade não pode estar em branco";
                    return false;
                }
                else
                {
                    if (ClassEstrategia.RetornaDescricaoParametro("GRUPO_ENT", parametro))
                    {
                        if (string.IsNullOrEmpty(ClassEstrategia.DescricaoParametro))
                        {
                            Erro = "Grupo Inválido";
                            return false;
                        }
                        else
                        {
                            NomeGrupo = ClassEstrategia.DescricaoParametro;
                            return true;
                        }
                    }
                    else
                    {
                        Erro = ClassEstrategia.Erro;
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Erro = ex.Message;
                return false;
            }
        }

        public static string ValidaCheckBox (CheckBox cb)
        {
            if (cb.Checked)
            {
                return "1";
            }
            else
            {
                return "0";
            }
        }




    }


}
