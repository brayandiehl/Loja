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
            if(Grupo.Text == "1")
            {
                DescricaoGrupo.Text = "Cliente";
            }
            else
            {
                DescricaoGrupo.Text = "";
            }
        }
    }
}
