using SGM.Domain.Entities;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IPecaRepository
    {
        IEnumerable<Peca> GetPecaByAll();
        IEnumerable<Peca> GetPecaByAllPaginado(int page);
        Count GetPecaCount();
        Peca GetById(int pecaId);
        void InativarPeca(int pecaId);
        void Salvar(Peca model);
        void Atualizar(Peca model);
        IList<Peca> GetPecaByDescricao(string descricao);
    }
}

