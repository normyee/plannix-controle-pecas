using ControlePecas.Repository;
using ControlePecas.Repository.BuscarObrasRepository;
using ControlePecas.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlePecas
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GerarRelatorio gerarRelatorio = new GerarRelatorio();
            CarregarObras carregarObras = new CarregarObras(new BuscarObrasRepo());
            CarregarRegioesEstoques carregarRegioesEstoques = new CarregarRegioesEstoques(new BuscarRegioesEstoquesRepo());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(gerarRelatorio, carregarObras, carregarRegioesEstoques));
        }
    }
}
