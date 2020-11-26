using SGM.Domain.Entities;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IOrcamentoRepository
    {
        IEnumerable<Orcamento> GetOrcamentoByAll();
        Count GetOrcamentoCount();
        Orcamento GetOrcamentoById(int orcamentoId);
        void SalvarOrcamento(Orcamento model);
        void AtualizarOrcamento(Orcamento model);
        void SalvarOrcamentoMaodeObra(OrcamentoMaodeObra orcamentoMaodeObra);
        void SalvarOrcamentoPeca(OrcamentoPeca orcamentoPeca);
        void DeletarOrcamentoMaodeObra(OrcamentoMaodeObra orcamentoMaodeObra);
        void DeletarOrcamentoPeca(OrcamentoPeca orcamentoPeca);
        IList<OrcamentoMaodeObra> GetOrcamentoMaodeObraByOrcamentoId(int orcamentoId);
        IList<OrcamentoPeca> GetOrcamentoPecaByOrcamentoId(int orcamentoId);
    }
}
