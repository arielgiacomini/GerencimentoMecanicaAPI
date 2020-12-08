using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IServicoServices
    {
        IEnumerable<ServicoViewModel> GetServicoByAll();
        Count GetServicoCount();
        ServicoViewModel GetServicoById(int servicoId);
        int AtualizarOrSalvar(ServicoViewModel model);
        IList<ServicoPecaViewModel> GetServicoPecaByServicoId(int servicoId);
        IList<ServicoMaodeObraViewModel> GetServicoMaodeObraByServicoId(int servicoId);
        void DeletarServicoPeca(ServicoPecaViewModel servicoPecaViewModel);
        void DeletarServicoMaodeObra(ServicoMaodeObraViewModel servicoMaodeObraViewModel);
        int SalvarServicoPeca(ServicoPecaViewModel servicoPecaViewModel);
        int SalvarServicoMaodeObra(ServicoMaodeObraViewModel servicoMaodeObraViewModel);
        IList<ServicoViewModel> GetUltimosServicos(int quantidade);
        IList<ServicoViewModel> GetServicoByClienteVeiculoId(int clienteVeiculoId);
    }
}