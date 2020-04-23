using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IClienteServices
    {
        IEnumerable<ClienteViewModel> GetByAll();
        IEnumerable<ClienteViewModel> GetByAllPaginado(int page);
        Count GetCount();
        ClienteViewModel GetById(int clienteId);
        void Salvar(ClienteViewModel model);
        void Atualizar(ClienteViewModel model);
    }
}
