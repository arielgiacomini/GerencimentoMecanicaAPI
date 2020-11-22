using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IMaodeObraServices
    {
        IEnumerable<MaodeObraViewModel> GetByAll();
        IEnumerable<MaodeObraViewModel> GetByAllPaginado(int page);
        Count GetCount();
        MaodeObraViewModel GetById(int orcamentoId);
        void InativarMaodeObra(int maoDeObraId);
        void AtualizarOrSalvar(MaodeObraViewModel model);
    }
}
