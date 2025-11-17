using ControlePecas.Repositories;

namespace ControlePecas.Features
{
    public class DeletarPeca
    {
        private readonly DeletarPecaRepo _deletarPecaRepo;

        public DeletarPeca(DeletarPecaRepo deletarPecaRepo)
        {
            _deletarPecaRepo= deletarPecaRepo;
        }

        public void Executar(int codControle)
        {
           _deletarPecaRepo.Executar(codControle);
        }
    }
}
