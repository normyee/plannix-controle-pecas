using ControlePecas.Domain;
using ControlePecas.Repository;
using System.Collections.Generic;

namespace ControlePecas.Services
{
    public class CarregarRegioesEstoques
    {
        private readonly BuscarRegioesEstoquesRepo _buscarRegioesEstoquesRepository;

        public CarregarRegioesEstoques(BuscarRegioesEstoquesRepo buscarRegioesEstoquesRepository)
        {
            _buscarRegioesEstoquesRepository = buscarRegioesEstoquesRepository;
        }

        public List<Regiao> Executar()
        {
            return _buscarRegioesEstoquesRepository.Executar();
        }
    }
}
