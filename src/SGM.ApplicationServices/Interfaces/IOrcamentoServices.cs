using SGM.ApplicationServices.ViewModels;
using SGM.ApplicationServices.ViewModels.Orcamentos;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IOrcamentoServices
    {
        IEnumerable<OrcamentoViewModel> GetByAll();
        IEnumerable<ClienteOrcamentosViewModel> GetByAllPaginado(int page);
        Count GetCount();
        OrcamentoViewModel GetById(int orcamentoId);
        void AtualizarOrSalvar(OrcamentoViewModel model);
    }
}