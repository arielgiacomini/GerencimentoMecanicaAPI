using SGM.Domain.Entities;
using SGM.Domain.Entities.Orcamentos;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IOrcamentoRepository
    {
        IEnumerable<Orcamento> GetByAll();
        IEnumerable<ClienteOrcamentos> GetByAllPaginado(int page);
        Count GetCount();
        Orcamento GetById(int orcamentoId);
        void Salvar(Orcamento model);
        void Atualizar(Orcamento model);
    }
}
