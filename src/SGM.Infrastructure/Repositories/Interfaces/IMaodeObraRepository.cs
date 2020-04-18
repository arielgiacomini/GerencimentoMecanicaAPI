using SGM.Domain.Entities;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IMaodeObraRepository
    {
        IEnumerable<MaodeObra> GetByAll();
        IEnumerable<MaodeObra> GetByAllPaginado(int page);
        Count GetCount();
        MaodeObra GetById(int orcamentoId);
        void Salvar(MaodeObra model);
        void Atualizar(MaodeObra model);
    }
}
