using SGM.ApplicationServices.ViewModels;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IOrcamentoServices
    {
        IEnumerable<OrcamentoViewModel> GetByAll();
        OrcamentoViewModel GetById(int orcamentoId);
        void AtualizarOrSalvar(OrcamentoViewModel model);
    }
}
