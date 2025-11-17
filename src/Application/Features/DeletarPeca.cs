using ControlePecas.Repository;

namespace ControlePecas.Services
{
    public class DeletarPeca
    {
        private readonly DeletarPecaRepo _deletarPecaRepository;

        public DeletarPeca(DeletarPecaRepo deletarPecaRepository)
        {
            _deletarPecaRepository = deletarPecaRepository;
        }

        public void Executar(int codControle)
        {
           _deletarPecaRepository.Executar(codControle);
        }
    }
}
