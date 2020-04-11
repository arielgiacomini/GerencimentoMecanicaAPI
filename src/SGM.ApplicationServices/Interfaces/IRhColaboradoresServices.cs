using SGM.ApplicationServices.ViewModels;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IRhColaboradoresServices
    {
        IEnumerable<RhColaboradoresViewModel> GetByAll();
        void Salvar(RhColaboradoresViewModel entidade);
    }
}
