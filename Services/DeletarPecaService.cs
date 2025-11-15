using ControlePecas.Repository;

namespace ControlePecas.Services
{
    public class DeletarPecaService
    {
        private readonly DeletarPecaRepository _deletarPecaRepository;

        public DeletarPecaService(DeletarPecaRepository deletarPecaRepository)
        {
            _deletarPecaRepository = deletarPecaRepository;
        }

        public void Executar(int codControle)
        {
           _deletarPecaRepository.Executar(codControle);
        }
    }
}
