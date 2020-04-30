using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IOrcamentoServices
    {
        IEnumerable<OrcamentoViewModel> GetByAll();
        Count GetCount();
        OrcamentoViewModel GetById(int orcamentoId);
        void AtualizarOrSalvar(OrcamentoViewModel model);
    }
}