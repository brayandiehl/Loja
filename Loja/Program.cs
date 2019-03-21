using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Loja
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        /// 
        public static string UsuarioLogado { get; set; }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            UsuarioLogado = "BRAYAN";
            Application.Run(new Telas.Configuracoes.Estrategia.Estrategias());
        }
    }
}
