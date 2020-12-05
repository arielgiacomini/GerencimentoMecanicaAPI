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
        int AtualizarOrSalvarOrcamento(OrcamentoViewModel model);
        int SalvarOrcamentoMaodeObra(OrcamentoMaodeObraViewModel orcamentoMaodeObraViewModel);
        int SalvarOrcamentoPeca(OrcamentoPecaViewModel orcamentoPecaViewModel);
        void DeletarOrcamentoPeca(OrcamentoPecaViewModel orcamentoPecaViewModel);
        void DeletarOrcamentoMaodeObra(OrcamentoMaodeObraViewModel orcamentoMaodeObraViewModel);
        IList<OrcamentoMaodeObraViewModel> GetOrcamentoMaodeObraByOrcamentoId(int orcamentoId);
        IList<OrcamentoPecaViewModel> GetOrcamentoPecaByOrcamentoId(int orcamentoId);
        IList<OrcamentoViewModel> GetOrcamentoByClienteVeiculoId(int clienteVeiculoId);
        IList<OrcamentoViewModel> GetUltimosOrcamentos(int quantidade);
    }
}