using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IPecaServices
    {
        IEnumerable<PecaViewModel> GetPecaByAll();
        IEnumerable<PecaViewModel> GetPecaByAllPaginado(int page);
        Count GetPecaCount();
        PecaViewModel GetPecaById(int pecaId);
        void InativarPeca(int pecaId);
        void AtualizarOrSalvar(PecaViewModel model);
        IList<PecaViewModel> GetPecaByDescricao(string descricao);
    }
}
