using ControlePecas.Entity;
using ControlePecas.Repository;
using System.Collections.Generic;

namespace ControlePecas.Services
{
    public class CarregarRegioesEstoques
    {
        private readonly BuscarRegioesEstoquesRepository _buscarRegioesEstoquesRepository;

        public CarregarRegioesEstoques(BuscarRegioesEstoquesRepository buscarRegioesEstoquesRepository)
        {
            _buscarRegioesEstoquesRepository = buscarRegioesEstoquesRepository;
        }

        public List<Regiao> Executar()
        {
            return _buscarRegioesEstoquesRepository.Executar();
        }
    }
}
