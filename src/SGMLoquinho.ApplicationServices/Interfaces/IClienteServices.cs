using SGMLoquinho.ApplicationServices.ViewModels;
using System.Collections.Generic;

namespace SGMLoquinho.ApplicationServices.Interfaces
{
    public interface IClienteServices
    {
        IEnumerable<ClienteViewModel> GetByAll();
    }
}
