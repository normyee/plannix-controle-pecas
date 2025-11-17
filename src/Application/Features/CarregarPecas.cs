using ControlePecas.Domain;
using ControlePecas.Repository;
using System.Collections.Generic;

namespace ControlePecas.Services
{
    public class CarregarPecas
    {
        private readonly BuscarPecasRepo _buscarPecasRepository;

        public CarregarPecas(BuscarPecasRepo buscarPecasRepository)
        {
            _buscarPecasRepository = buscarPecasRepository;
        }

        public List<PecaItem> Executar(int codObra, int idRegiao)
        {
            return _buscarPecasRepository.Executar(codObra, idRegiao);
        }
    }
}
