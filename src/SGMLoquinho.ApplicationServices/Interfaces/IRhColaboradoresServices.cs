using SGMLoquinho.ApplicationServices.ViewModels;
using System.Collections.Generic;

namespace SGMLoquinho.ApplicationServices.Interfaces
{
    public interface IRhColaboradoresServices
    {
        IEnumerable<RhColaboradoresViewModel> GetByAll();
        void Salvar(RhColaboradoresViewModel entidade);
    }
}
