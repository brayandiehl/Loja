using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Loja.Classes
{
    static class Arquivos
    {
        public static string Erro { get; private set; }
        public static bool ArquivoExiste { get; private set; }


        public static bool VerificaArquivoExiste(string caminhoCompleto)
        {
            if (!string.IsNullOrEmpty(caminhoCompleto))
            {
                if (File.Exists(caminhoCompleto))
                {
                    ArquivoExiste = true;
                    return true;
                }
                else
                {
                    ArquivoExiste = false;
                    //Erro = "Arquivo Já existe";
                    return true;
                }
            }
            else
            {
                Erro = "Caminho do arquivo não pode estar em branco";
                return false;
            }
        }

        public static bool RemoveArquivo(string caminhoCompleto)
        {
            if (!string.IsNullOrEmpty(caminhoCompleto))
            {
                if (File.Exists(caminhoCompleto))
                {
                    FileInfo fi = new FileInfo(caminhoCompleto);
                    try
                    {
                        fi.Delete();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Erro = "Erro ao excluir a foto.\nErro: " + ex.Message;
                        return false;
                    }

                }
                else
                {
                    ArquivoExiste = false;
                    Erro = "Arquivo Já existe";
                    return false;
                }
            }
            else
            {
                Erro = "Caminho do arquivo não pode estar em branco";
                return false;
            }
        }
    }
}
