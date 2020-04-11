using SGM.ApplicationServices.ViewModels;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IClienteServices
    {
        IEnumerable<ClienteViewModel> GetByAll();
        ClienteViewModel GetById(int clienteId);
        void Salvar(ClienteViewModel model);
        void Atualizar(ClienteViewModel model);
    }
}
