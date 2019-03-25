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


        private void Bt_Tirar_Foto_Click(object sender, EventArgs e)
        {
            Foto.Image.Save("C:\\Temp\\teste1.png", System.Drawing.Imaging.ImageFormat.Png);
            MessageBox.Show("Salvo com sucesso");
        }

        private void AtivarFoto_CheckedChanged(object sender, EventArgs e)
        {
            if (AtivarFoto.Checked)
            {
                AForge.Video.DirectShow.FilterInfoCollection videosource = new AForge.Video.DirectShow.FilterInfoCollection(AForge.Video.DirectShow.FilterCategory.VideoInputDevice);
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
                    if (ClassEntidade.RetornaGrupoEntidade(Grupo.Text))
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
                if (Telas.Configuracoes.Estrategia.Classes.ClassEstrategia.RetornaValorParametro("ACOES", "LOCALIZA_CEP"))
                {
                    var valorParametro = Telas.Configuracoes.Estrategia.Classes.ClassEstrategia.Parametro;
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
                            }
                        }
                        else
                        {
                            Cursor = Cursors.Default;
                            MessageBox.Show("CEP não pode estrar em branco", "Erro: ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                else
                {
                    Cursor = Cursors.Default;
                    MessageBox.Show("Erro ao localizar valor do parametro.\nErro: " + Telas.Configuracoes.Estrategia.Classes.ClassEstrategia.Erro, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Erro: " + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!string.IsNullOrEmpty(Nascimento.Text.Replace("_", "").Replace("/", "")))
            {
                DateTime dt = Convert.ToDateTime(Nascimento.Text.Replace("_", ""));
                TimeSpan ts = DateTime.Today - dt;
                DateTime idade = (new DateTime() + ts).AddYears(-1);//.AddDays(-1);
                Idade.Text = idade.Year + " Anos";


            }
        }

        private void Bt_Salvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ClassEntidade.RetornaEntidade(Cpf_Cnpj.Text, Grupo.Text))
                {
                    if (string.IsNullOrEmpty(ClassEntidade.Cod))
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
                        ClassEntidade.Grupo = Grupo.Text;
                        ClassEntidade.Nome = RazaoSocial.Text;
                        ClassEntidade.Nome_Celular1 = NomeCelular1.Text;
                        ClassEntidade.Nome_Celular2 = NomeCelular2.Text;
                        ClassEntidade.NotificarAniversario = ClassEntidade.ValidaCheckBox(Flg_Notificar_Aniversario);
                        ClassEntidade.NotificarProdutoNovo = ClassEntidade.ValidaCheckBox(Flg_notificar_produto_novo);
                        ClassEntidade.NotificarPromocao = ClassEntidade.ValidaCheckBox(Flg_notificar_produto_novo);
                        
                    }
                }



            }
            catch (Exception ex)
            {

            }
        }
    }
}
