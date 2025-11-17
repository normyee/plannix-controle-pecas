using ControlePecas.Entities;
using ControlePecas.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlePecas.Features
{
    public class ObterPeca
    {
        private ObterPecaRepo _obterPecaRepo;
        public ObterPeca(ObterPecaRepo obterPecaRepo)
        {
            _obterPecaRepo = obterPecaRepo;
        }

        public PecaObra Executar(int idPeca)
        {
          return  _obterPecaRepo.Executar(idPeca);
        }
    }
}
