using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IOrcamentoRepository
    {
        IEnumerable<Orcamento> GetByAll();
        Orcamento GetById(int orcamentoId);
        void Salvar(Orcamento model);
        void Atualizar(Orcamento model);
    }
}
