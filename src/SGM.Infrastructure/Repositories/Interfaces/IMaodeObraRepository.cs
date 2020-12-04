using SGM.Domain.Entities;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IMaodeObraRepository
    {
        IEnumerable<MaodeObra> GetMaodeObraByAll();
        IEnumerable<MaodeObra> GetMaodeObraByAllPaginado(int page);
        Count GetMaodeObraCount();
        MaodeObra GetMaodeObraById(int orcamentoId);
        void InativarMaoDeObra(MaodeObra maoDeObra);
        void Salvar(MaodeObra model);
        void Atualizar(MaodeObra model);
        IList<MaodeObra> GetMaodeObraByDescricao(string descricao);
    }
}
