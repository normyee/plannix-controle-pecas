using ControlePecas.Domain;
using ControlePecas.Repository.BuscarObrasRepository;
using System.Collections.Generic;

namespace ControlePecas.Services
{
    public class CarregarObras
    {
        private readonly BuscarObrasRepo _buscarObrasRepository;

        public CarregarObras(BuscarObrasRepo buscarObrasRepository) {
            _buscarObrasRepository = buscarObrasRepository;
        }

        public List<Obra> Executar()
        {
            return _buscarObrasRepository.Executar();
        }
    }
}
