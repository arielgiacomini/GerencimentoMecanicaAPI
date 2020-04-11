using SGMLoquinho.ApplicationServices.ViewModels;
using System.Collections.Generic;

namespace SGMLoquinho.ApplicationServices.Interfaces
{
    public interface IClienteServices
    {
        IEnumerable<ClienteViewModel> GetByAll();
        ClienteViewModel GetById(int clienteId);
        void Salvar(ClienteViewModel model);
        void Atualizar(ClienteViewModel model);
    }
}
