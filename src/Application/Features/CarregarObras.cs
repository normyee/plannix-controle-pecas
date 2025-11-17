using ControlePecas.Entities;
using ControlePecas.Repositories;
using System.Collections.Generic;

namespace ControlePecas.Features
{
    public class CarregarObras
    {
        private readonly BuscarObrasRepo _buscarObrasRepo;

        public CarregarObras(BuscarObrasRepo buscarObrasRepo) {
            _buscarObrasRepo = buscarObrasRepo;
        }

        public List<Obra> Executar()
        {
            return _buscarObrasRepo.Executar();
        }
    }
}
