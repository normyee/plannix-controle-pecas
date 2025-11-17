using ControlePecas.Entities;
using ControlePecas.Repositories;
using System;

namespace ControlePecas.Features
{
    public class CriarPeca
    {
        private readonly CriarPecaRepo _criarPecaRepo;

        public CriarPeca(CriarPecaRepo criarPecaRepo)
        {
            _criarPecaRepo = criarPecaRepo;
        }

        public PecaObra Executar(PecaObra peca)
        {
            _criarPecaRepo.Executar(peca);
            return peca;
        }
    }
}
