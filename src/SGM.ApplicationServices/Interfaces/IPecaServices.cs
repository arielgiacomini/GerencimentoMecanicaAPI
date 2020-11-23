using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IPecaServices
    {
        IEnumerable<PecaViewModel> GetByAll();
        IEnumerable<PecaViewModel> GetByAllPaginado(int page);
        Count GetCount();
        PecaViewModel GetById(int pecaId);
        void InativarPeca(int pecaId);
        void AtualizarOrSalvar(PecaViewModel model);
    }
}
