using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Windows.Forms;

namespace Loja.Classes
{
    static class Correios
    {
        public static string Endereco { get; private set; }
        public static string Complemento { get; private set; }
        public static string Bairro { get; private set; }
        public static string Cidade { get; private set; }
        public static string Estado { get; private set; }
        public static string Erro { get; private set; }


        public static bool ConsultaCEP(string CEP)
        {
            try
            {
                Endereco = "";
                Complemento = "";
                Bairro = "";
                Cidade = "";
                Estado = "";

                var CepTratado = CEP.Trim().Replace(" ", "").Replace("_", "").Replace("-", "");
                var resposta = new Correio.AtendeClienteClient().consultaCEP(CepTratado);
                if (!string.IsNullOrEmpty(resposta.ToString()))
                {
                    Endereco = resposta.end;
                    Complemento = resposta.complemento2;
                    Bairro = resposta.bairro;
                    Cidade = resposta.cidade;
                    Estado = resposta.uf;
                    return true;
                }
                else
                {
                    Erro = "Erro ao Localizar o CEP: " + CEP;
                    return false;
                }


            }
            catch (Exception ex)
            {
                Erro = ex.Message;
                return false;
            }
        }


    }
}
