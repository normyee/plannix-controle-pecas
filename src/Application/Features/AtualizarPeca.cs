using ControlePecas.Entities;
using ControlePecas.Repositories;

namespace ControlePecas.Features
{
    public class AtualizarPeca
    {
        private readonly AtualizarPecaRepo _atualizarPecaRepo;

        public AtualizarPeca(AtualizarPecaRepo atualizarPecaRepo)
        {
            _atualizarPecaRepo = atualizarPecaRepo;
        }

        public PecaObra Executar(int codControle, PecaObra peca)
        {
            _atualizarPecaRepo.Executar(codControle, peca);
            return peca;
        }
    }
}
