using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja.Telas.Cadastro.Classes
{
    class ClassEntidade
    {
        public int Cod { get; set; }
        public string Cpf_cnpj { get; set; } // 
        public bool Ativo { get; set; }
        public string Nome { get; set; }//
        public string Grupo { get; set; }  //
        public DateTime Data_cadastro { get; set; }
        public DateTime Data_alteracao { get; set; }
        public DateTime Data_nascimento { get; set; }//
        public int Idade { get; set; }
        public string CEP { get; set; }//
        public string Rua { get; set; }//
        public string Cidade { get; set; }//
        public string Bairro { get; set; }//
        public string Numero { get; set; }//
        public string Complemento { get; set; }
        public string Estado { get; set; }//
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Celular1 { get; set; }
        public bool WhatsApp_Celular1 { get; set; }
        public string Nome_Celular1 { get; set; }
        public string Celular2 { get; set; }
        public bool WhatsApp_Celular2 { get; set; }
        public string Nome_Celular2 { get; set; }
        public bool ClienteVip { get; set; }
        public bool NotificarProdutoNovo { get; set; }
        public bool NotificarVencimento { get; set; }
        public bool NotificarPromocao { get; set; }
        public bool AceitaFiado { get; set; }
        public bool NotificarAniversario { get; set; }
        public string Observacao { get; set; }
        public string CaminhoFoto { get; set; }
        public string Erro { get; private set; }

        public bool CadastraEntidade()
        {
            return false;
        }

        public bool RetornaEntidade()
        {
            return false;
        }
        public bool AtualizaEntidade()
        {
            return false;
        }

        public bool DeletaEntidade()
        {
            return false;
        }

        private bool ValidaCampos()
        {
            if (String.IsNullOrEmpty(Cpf_cnpj))
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
    }
}
