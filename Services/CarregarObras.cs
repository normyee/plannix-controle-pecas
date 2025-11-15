using ControlePecas.Entity;
using ControlePecas.Repository;
using System.Collections.Generic;

namespace ControlePecas.Services
{
    public class CarregarObras
    {
        private readonly BuscarObrasRepository _buscarObrasRepository;

        public CarregarObras(BuscarObrasRepository buscarObrasRepository) {
            _buscarObrasRepository = buscarObrasRepository;
        }

        public List<Obra> Executar()
        {
            return _buscarObrasRepository.Executar();
        }
    }
}
