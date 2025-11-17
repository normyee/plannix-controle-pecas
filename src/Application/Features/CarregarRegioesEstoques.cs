using ControlePecas.Entities;
using ControlePecas.Repositories;
using System.Collections.Generic;

namespace ControlePecas.Features
{
    public class CarregarRegioesEstoques
    {
        private readonly BuscarRegioesEstoquesRepo _buscarRegioesEstoquesRepo;

        public CarregarRegioesEstoques(BuscarRegioesEstoquesRepo buscarRegioesEstoquesRepo)
        {
            _buscarRegioesEstoquesRepo = buscarRegioesEstoquesRepo;
        }

        public List<Regiao> Executar()
        {
            return _buscarRegioesEstoquesRepo.Executar();
        }
    }
}
