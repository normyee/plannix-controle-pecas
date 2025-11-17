using ControlePecas.Repositories;
using ControlePecas.Features;
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
            CarregarPecas carregarPecas = new CarregarPecas(new BuscarPecasRepo());
            ObterPeca obterPeca = new ObterPeca(new ObterPecaRepo());
            CriarPeca criarPeca = new CriarPeca(new CriarPecaRepo());
            AtualizarPeca atualizarPeca = new AtualizarPeca(new AtualizarPecaRepo());

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main(
                gerarRelatorio, 
                carregarObras, 
                carregarRegioesEstoques,
                carregarPecas,
                obterPeca,
                criarPeca,
                atualizarPeca
                ));
        }
    }
}
