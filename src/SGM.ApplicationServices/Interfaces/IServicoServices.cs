using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IServicoServices
    {
        IEnumerable<ServicoViewModel> GetByAll();
        Count GetCount();
        ServicoViewModel GetById(int servicoId);
        void AtualizarOrSalvar(ServicoViewModel model);
    }
}