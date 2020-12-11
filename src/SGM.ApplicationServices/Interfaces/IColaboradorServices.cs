using SGM.ApplicationServices.ViewModels;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IColaboradorServices
    {
        IEnumerable<ColaboradorViewModel> GetByAll();
        ColaboradorViewModel GetById(int colaboradorId);
        void Salvar(ColaboradorViewModel model);
        void Atualizar(ColaboradorViewModel model);
        ColaboradorViewModel GetByColaboradorLogin(string colaboradorLogin);
    }
}
