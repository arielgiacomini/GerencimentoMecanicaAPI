using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IMaodeObraServices
    {
        IEnumerable<MaodeObraViewModel> GetMaodeObraByAll();
        IEnumerable<MaodeObraViewModel> GetMaodeObraByAllPaginado(int page);
        Count GetMaodeObraCount();
        MaodeObraViewModel GetMaodeObraById(int orcamentoId);
        void InativarMaodeObra(int maoDeObraId);
        void AtualizarOrSalvar(MaodeObraViewModel model);
        IList<MaodeObraViewModel> GetMaodeObraByDescricao(string descricao);
    }
}
