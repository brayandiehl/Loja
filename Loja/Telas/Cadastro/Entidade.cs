using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using AForge.Video.DirectShow;
using System.IO;
using AForge.Video;
using Loja.Telas.Cadastro.Classes;
using Loja.Telas.Configuracoes.Estrategia.Classes;

namespace Loja.Telas.Cadastro
{

    public partial class Entidade : Form
    {
        AForge.Video.DirectShow.VideoCaptureDevice videoSource;

        public Entidade()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }




        private void SalvaFoto()
        {
            try
            {
                ClassEntidade.CaminhoFoto = null;
                if (ClassEstrategia.RetornaValorParametro("ACOES", "VALIDA_CPF_CNPJ"))
                {
                    if (ClassEstrategia.Parametro.Equals("1"))
                    {
                        if (!ClassEntidade.ValidaCnpjCpf(Cpf_Cnpj.Text, Cpf_Cnpj))
                        {
                            Cursor = Cursors.Default;
                            MessageBox.Show("Erro: " + ClassEntidade.Erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            if (Foto.Image != null)
                            {
                                if (ClassEstrategia.RetornaValorParametro("PARAMETROS", "CAMINHO_FOTOS"))
                                {
                                    if (!ClassEstrategia.Parametro.Equals("0"))
                                    {
                                        var cpf_cnpj_tratado = Cpf_Cnpj.Text.Replace(".", "").Replace(",", "").Replace("-", "").Replace("/", "").Replace("_", "");

                                        var caminho = ClassEstrategia.Parametro;

                                        if (ClassEstrategia.RetornaValorParametro("PARAMETROS", "FORMATO_FOTOS"))
                                        {

                                            caminho = caminho + cpf_cnpj_tratado + ClassEstrategia.Parametro;
                                            ClassEntidade.CaminhoFoto = caminho;

                                            if (Loja.Classes.Arquivos.VerificaArquivoExiste(caminho))
                                            {
                                                if (Loja.Classes.Arquivos.ArquivoExiste)
                                                {
                                                    if (MessageBox.Show("Já Existe uma imagem com esse nome.\nDeseja substituir a que já existe?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.None) == DialogResult.Yes)
                                                    {
                                                        if (Loja.Classes.Arquivos.RemoveArquivo(caminho))
                                                        {
                                                            Foto.Image.Save(caminho);
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Erro: " + Loja.Classes.Arquivos.Erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                    Foto.Image.Save(caminho);
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Erro: " + Loja.Classes.Arquivos.Erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Cursor = Cursors.Default;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        Cursor = Cursors.Default;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            //Foto.Image.Save("C:\\Temp\\teste1.png", System.Drawing.Imaging.ImageFormat.);
            //MessageBox.Show("Salvo com sucesso");
        }

        private void AtivarFoto_CheckedChanged(object sender, EventArgs e)
        {
            if (AtivarFoto.Checked)
            {
                FilterInfoCollection videosource = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                if (videosource != null)
                {
                    videoSource = new AForge.Video.DirectShow.VideoCaptureDevice(videosource[0].MonikerString); ;
                    videoSource.VideoResolution = videoSource.VideoCapabilities[1];
                    videoSource.NewFrame += (s, a) => Foto.Image = (Bitmap)a.Frame.Clone();
                    videoSource.Start();


                }
            }
            else
            {
                if (videoSource.IsRunning)
                {
                    videoSource.Stop();
                }
            }
        }

        private void Grupo_Leave(object sender, EventArgs e)
        {
            try

            {
                if (!string.IsNullOrEmpty(Grupo.Text.ToUpper()))
                {
                    Cursor = Cursors.WaitCursor;
                    if (ClassEntidade.RetornaGrupoEntidade(Grupo.Text.ToUpper()))
                    {
                        DescricaoGrupo.Text = ClassEntidade.NomeGrupo;
                        Cursor = Cursors.Default;
                    }
                    else
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show("Erro ao obter descrição do Grupo\nErro: " + ClassEntidade.Erro, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Erro " + ex.Message, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (!string.IsNullOrEmpty(Cep.Text.ToString().Replace("_", "").Replace("-", "")))
                {
                    if (ClassEntidade.LocaizaCep(Cep.Text))
                    {
                        Logradouro.Text = ClassEntidade.Rua;
                        Cidade.Text = ClassEntidade.Cidade;
                        Complemento.Text = ClassEntidade.Complemento;
                        Estado.Text = ClassEntidade.Estado;
                        Bairro.Text = ClassEntidade.Bairro;
                        Cursor = Cursors.Default;
                    }
                    else
                    {
                        Cursor = Cursors.Default;
                        MessageBox.Show("Erro ao localizar CEP!\nErro; " + ClassEntidade.Erro, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show("CEP não pode estrar em branco", "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Erro " + ex.Message, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void Cep_Leave(object sender, EventArgs e)
        {
            try
            {
                if (ClassEstrategia.RetornaValorParametro("ACOES", "LOCALIZA_CEP"))
                {
                    var valorParametro = ClassEstrategia.Parametro;
                    if (valorParametro.Equals("1"))
                    {
                        Cursor = Cursors.WaitCursor;
                        if (!string.IsNullOrEmpty(Cep.Text.ToString().Replace("_", "").Replace("-", "")))
                        {
                            if (ClassEntidade.LocaizaCep(Cep.Text))
                            {
                                Logradouro.Text = ClassEntidade.Rua;
                                Cidade.Text = ClassEntidade.Cidade;
                                Complemento.Text = ClassEntidade.Complemento;
                                Estado.Text = ClassEntidade.Estado;
                                Bairro.Text = ClassEntidade.Bairro;
                                Cursor = Cursors.Default;
                            }
                            else
                            {
                                Cursor = Cursors.Default;
                                MessageBox.Show("Erro ao localizar CEP!\nErro; " + ClassEntidade.Erro, "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            Cursor = Cursors.Default;
                            MessageBox.Show("CEP não pode estrar em branco", "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                }
                else
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show("Erro ao localizar valor do parametro.\nErro: " + Telas.Configuracoes.Estrategia.Classes.ClassEstrategia.Erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Cpf_Cnpj_Leave(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                if (string.IsNullOrEmpty(Cpf_Cnpj.Text.ToString().Replace("/", "").Replace(".", "").Replace("-", "").Replace("_", "").Replace(",", "")))
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show("CPF / CNPJ não pode estrar em branco", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (ClassEstrategia.RetornaValorParametro("ACOES", "VALIDA_CPF_CNPJ"))
                    {
                        if (ClassEstrategia.Parametro.Equals("1"))
                        {
                            if (!ClassEntidade.ValidaCnpjCpf(Cpf_Cnpj.Text, Cpf_Cnpj))
                            {
                                Cursor = Cursors.Default;
                                MessageBox.Show("Erro: " + ClassEntidade.Erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                Cursor = Cursors.Default;
                            }
                        }
                        else
                        {
                            Cursor = Cursors.Default;
                        }
                    }
                    Cursor = Cursors.WaitCursor;
                    if (ClassEstrategia.RetornaValorParametro("ACOES", "LOCALIZA_ENTIDADE"))
                    {
                        if (ClassEstrategia.Parametro.Equals("1"))
                        {
                            var cpf_cnpj_tratado = Cpf_Cnpj.Text.Replace(".", "").Replace(",", "").Replace("-", "").Replace("/", "").Replace("_", "");
                            if (ClassEntidade.RetornaEntidade(cpf_cnpj_tratado, Grupo.Text.ToUpper()))
                            {
                                if (!string.IsNullOrEmpty(ClassEntidade.Cod))
                                {
                                    PreencheCampoTela();
                                    CalculaIdade();
                                }
                                else
                                {
                                    LimpaCamposTela();
                                }
                                Cursor = Cursors.Default;
                            }
                            else
                            {
                                Cursor = Cursors.Default;
                                MessageBox.Show("Erro: " + ClassEntidade.Erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                        else
                        {
                            Cursor = Cursors.Default;
                        }

                    }
                    else
                    {
                        Cursor = Cursors.Default;
                    }

                }

            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Cpf_Cnpj_Enter(object sender, EventArgs e)
        {
            Cpf_Cnpj.Mask = "";
        }

        private void Grupo_Enter(object sender, EventArgs e)
        {
            DescricaoGrupo.Text = "";
        }

        private void Nascimento_Leave(object sender, EventArgs e)
                {
            //var data_tradata =
            CalculaIdade();


        }

        private void Bt_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                ClassEntidade.AceitaFiado = ClassEntidade.ValidaCheckBox(Flg_Aceita_Fiado);
                ClassEntidade.Ativo = ClassEntidade.ValidaCheckBox(Flg_ativo);
                ClassEntidade.Bairro = Bairro.Text;
                ClassEntidade.Celular1 = Celular1.Text;
                ClassEntidade.Celular2 = Celular2.Text;
                ClassEntidade.CEP = Cep.Text;
                ClassEntidade.Cidade = Cidade.Text;
                ClassEntidade.ClienteVip = ClassEntidade.ValidaCheckBox(Flg_vip);
                ClassEntidade.Complemento = Complemento.Text;
                ClassEntidade.Cpf_cnpj = Cpf_Cnpj.Text;
                ClassEntidade.Data_nascimento = Nascimento.Text;
                ClassEntidade.Email = EmailContato.Text;
                ClassEntidade.Estado = Estado.Text;
                ClassEntidade.Facebook = Facebook.Text;
                ClassEntidade.Grupo = Grupo.Text.ToUpper();
                ClassEntidade.Nome = RazaoSocial.Text;
                ClassEntidade.Nome_Celular1 = NomeCelular1.Text;
                ClassEntidade.Nome_Celular2 = NomeCelular2.Text;
                ClassEntidade.NotificarAniversario = ClassEntidade.ValidaCheckBox(Flg_Notificar_Aniversario);
                ClassEntidade.NotificarProdutoNovo = ClassEntidade.ValidaCheckBox(Flg_notificar_produto_novo);
                ClassEntidade.NotificarPromocao = ClassEntidade.ValidaCheckBox(Flg_notificar_produto_novo);
                ClassEntidade.NotificarVencimento = ClassEntidade.ValidaCheckBox(Flg_notificar_vencimeneto);
                ClassEntidade.Numero = Numero.Text;
                ClassEntidade.Observacao = Observacao.Text;
                ClassEntidade.Rua = Logradouro.Text;
                ClassEntidade.WhatsApp_Celular1 = ClassEntidade.ValidaCheckBox(Flg_whatsappCelular1);
                ClassEntidade.WhatsApp_Celular2 = ClassEntidade.ValidaCheckBox(Flg_whatsappCelular2);
                SalvaFoto();
                if (ClassEntidade.RetornaIdEntidade(Cpf_Cnpj.Text, Grupo.Text.ToUpper()))
                {
                    if (string.IsNullOrEmpty(ClassEntidade.Cod))
                    {
                        if (ClassEntidade.CadastraEntidade())
                        {
                            MessageBox.Show("Entidade salva com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao salvar entidade.\nErro: " + ClassEntidade.Erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (ClassEntidade.AtualizaEntidade())
                        {
                            MessageBox.Show("Entidade atualizar com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
                        }
                        else
                        {
                            MessageBox.Show("Erro ao atualizar entidade.\nErro: " + ClassEntidade.Erro, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreencheCampoTela()
        {
            Flg_Aceita_Fiado.Checked = ClassEntidade.PreencheCheckBox(ClassEntidade.AceitaFiado);
            Flg_ativo.Checked = ClassEntidade.PreencheCheckBox(ClassEntidade.Ativo);
            Bairro.Text = ClassEntidade.Bairro;
            Celular1.Text = ClassEntidade.Celular1;
            Celular2.Text = ClassEntidade.Celular2;
            Cep.Text = ClassEntidade.CEP;
            Cidade.Text = ClassEntidade.Cidade;
            Flg_vip.Checked = ClassEntidade.PreencheCheckBox(ClassEntidade.ClienteVip);
            Complemento.Text = ClassEntidade.Complemento;
            Cpf_Cnpj.Text = ClassEntidade.Cpf_cnpj;
            Nascimento.Text = ClassEntidade.Data_nascimento;
            EmailContato.Text = ClassEntidade.Email;
            Estado.Text = ClassEntidade.Estado;
            Facebook.Text = ClassEntidade.Facebook;
            Grupo.Text = ClassEntidade.Grupo.ToUpper();
            RazaoSocial.Text = ClassEntidade.Nome;
            NomeCelular1.Text = ClassEntidade.Nome_Celular1;
            NomeCelular2.Text = ClassEntidade.Nome_Celular2;
            Flg_Notificar_Aniversario.Checked = ClassEntidade.PreencheCheckBox(ClassEntidade.NotificarAniversario);
            Flg_notificar_produto_novo.Checked = ClassEntidade.PreencheCheckBox(ClassEntidade.NotificarProdutoNovo);
            Flg_notificar_produto_novo.Checked = ClassEntidade.PreencheCheckBox(ClassEntidade.NotificarPromocao);
            Flg_notificar_vencimeneto.Checked = ClassEntidade.PreencheCheckBox(ClassEntidade.NotificarVencimento);
            Numero.Text = ClassEntidade.Numero;
            Observacao.Text = ClassEntidade.Observacao;
            Logradouro.Text = ClassEntidade.Rua;
            Flg_whatsappCelular1.Checked = ClassEntidade.PreencheCheckBox(ClassEntidade.WhatsApp_Celular1);
            Flg_whatsappCelular2.Checked = ClassEntidade.PreencheCheckBox(ClassEntidade.WhatsApp_Celular2);
            DataAlteracao.Text = ClassEntidade.Data_alteracao;
            DataCadastro.Text = ClassEntidade.Data_cadastro;
            Codigo.Text = ClassEntidade.Cod;
            Foto.ImageLocation = ClassEntidade.CaminhoFoto;
        }

        private void CalculaIdade()
        {
            var data_tratada = Nascimento.Text.Replace("_", "").Replace("/", "").Replace(" ", "");

            if (!string.IsNullOrEmpty(data_tratada))
            {
                DateTime dt = Convert.ToDateTime(Nascimento.Text.Replace("_", ""));
                if (dt < DateTime.Today.AddYears(-1))
                {
                    TimeSpan ts = DateTime.Today - dt;
                    DateTime idade = (new DateTime() + ts).AddYears(-1);//.AddDays(-1);
                    Idade.Text = idade.Year + " Anos";
                }
                else
                {
                    Idade.Text = "XX Anos";
                    MessageBox.Show("Data Inválida!\nData deve ser menor quee a data atual.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

            }
        }

        private void LimpaCamposTela()
        {
            Flg_Aceita_Fiado.Checked = false;
            Flg_ativo.Checked = false;
            Bairro.Text = null;
            Celular1.Text = null;
            Celular2.Text = null;
            Cep.Text = null;
            Cidade.Text = null;
            Flg_vip.Checked = false;
            Complemento.Text = null;
            //Cpf_Cnpj.Text = null;
            Nascimento.Text = null;
            EmailContato.Text = null;
            Estado.Text = null;
            Facebook.Text = null;
            //Grupo.Text = null;
            RazaoSocial.Text = null;
            NomeCelular1.Text = null;
            NomeCelular2.Text = null;
            Flg_Notificar_Aniversario.Checked = false;
            Flg_notificar_produto_novo.Checked = false;
            Flg_notificar_produto_novo.Checked = false;
            Flg_notificar_vencimeneto.Checked = false;
            Numero.Text = null;
            Observacao.Text = null;
            Logradouro.Text = null;
            Flg_whatsappCelular1.Checked = false;
            Flg_whatsappCelular2.Checked = false;
            DataAlteracao.Text = null;
            DataCadastro.Text = null;
            Codigo.Text = null;
            Idade.Text = "XX Anos";
            Foto.Image = null;
        }

        private void Entidade_Load(object sender, EventArgs e)
        {
            if (ClassEstrategia.RetornaValorParametro("ACOES", "LOCALIZA_ENTIDADE"))
            {
                if (ClassEstrategia.Parametro.Equals("1"))
                {
                    BtLocalizarEntidade.Enabled = false;
                }
            }

            if (ClassEstrategia.RetornaValorParametro("ACOES", "LOCALIZA_CEP"))
            {
                if (ClassEstrategia.Parametro.Equals("1"))
                {
                    BtLocalizarCep.Enabled = false;
                }
            }
        }

        private void BtLocalizarEntidade_Click(object sender, EventArgs e)
        {
            try
            {
                var cpf_cnpj_tratado = Cpf_Cnpj.Text.Replace(".", "").Replace(",", "").Replace("-", "").Replace("/", "").Replace("_", "");
                if (ClassEntidade.RetornaEntidade(cpf_cnpj_tratado, Grupo.Text.ToUpper()))
                {
                    if (!string.IsNullOrEmpty(ClassEntidade.Cod))
                    {
                        PreencheCampoTela();
                        CalculaIdade();
                    }
                    else
                    {
                        LimpaCamposTela();
                    }
                    Cursor = Cursors.Default;
                }
                else
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show("Erro: " + ClassEntidade.Erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
