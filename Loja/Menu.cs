using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loja
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void entidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Cadastro.Entidade entidade = new Telas.Cadastro.Entidade();
            entidade.Show();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Cadastro.Produto produto = new Telas.Cadastro.Produto();
            produto.Show();
        }

        private void parametrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Configuracoes.Estrategia.ClassesEstrategia classesEstrategia = new Telas.Configuracoes.Estrategia.ClassesEstrategia();
            classesEstrategia.Show();

        }

        private void estratégiasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Telas.Configuracoes.Estrategia.Estrategias estrategias = new Telas.Configuracoes.Estrategia.Estrategias();
            estrategias.Show();
        }

        private void classesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Configuracoes.Parametrizacoes.Classes classes = new Telas.Configuracoes.Parametrizacoes.Classes();
            classes.Show();
        }

        private void statusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telas.Configuracoes.Parametrizacoes.Status status = new Telas.Configuracoes.Parametrizacoes.Status();
            status.Show();
        }
    }
}
