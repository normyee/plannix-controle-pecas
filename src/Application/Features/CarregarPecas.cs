using ControlePecas.Entities;
using ControlePecas.Repositories;
using System.Collections.Generic;

namespace ControlePecas.Features
{
    public class CarregarPecas
    {
        private readonly BuscarPecasRepo _buscarPecasRepo;

        public CarregarPecas(BuscarPecasRepo buscarPecasRepo)
        {
            _buscarPecasRepo = buscarPecasRepo;
        }

        public List<PecaItem> Executar(int codObra, int idRegiao)
        {
            return _buscarPecasRepo.Executar(codObra, idRegiao);
        }
    }
}
