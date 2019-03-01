using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loja.Telas.Estoque.Recebimento.CadastraRecebimento
{
    public partial class ItensRecebimento : Form
    {
        public string CodigoProduto { get; private set; }

        public ItensRecebimento()
        {
            InitializeComponent();
        }
    }
}
