using SGM.Domain.Entities;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IPecaRepository
    {
        IEnumerable<Peca> GetByAll();
        IEnumerable<Peca> GetByAllPaginado(int page);
        Count GetCount();
        Peca GetById(int pecaId);
        void InativarPeca(int pecaId);
        void Salvar(Peca model);
        void Atualizar(Peca model);
    }
}

