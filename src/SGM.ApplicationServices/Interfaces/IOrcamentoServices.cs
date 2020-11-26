using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IOrcamentoServices
    {
        IEnumerable<OrcamentoViewModel> GetOrcamentoByAll();
        Count GetOrcamentoCount();
        OrcamentoViewModel GetOrcamentoById(int orcamentoId);
        void AtualizarOrSalvar(OrcamentoViewModel model);
        void SalvarOrcamentoMaodeObra(OrcamentoMaodeObraViewModel orcamentoMaodeObraViewModel);
        void SalvarOrcamentoPeca(OrcamentoPecaViewModel orcamentoPecaViewModel);
        void DeletarOrcamentoPeca(OrcamentoPecaViewModel orcamentoPecaViewModel);
        void DeletarOrcamentoMaodeObra(OrcamentoMaodeObraViewModel orcamentoMaodeObraViewModel);
        IList<OrcamentoMaodeObraViewModel> GetOrcamentoMaodeObraByOrcamentoId(int orcamentoId);
        IList<OrcamentoPecaViewModel> GetOrcamentoPecaByOrcamentoId(int orcamentoId);
    }
}