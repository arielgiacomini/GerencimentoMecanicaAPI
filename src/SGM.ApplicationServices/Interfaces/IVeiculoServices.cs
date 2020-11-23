using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IVeiculoServices
    {
        IEnumerable<VeiculoViewModel> GetByAll();
        Count GetCount();
        VeiculoViewModel GetById(int veiculoId);
        void InativarVeiculo(int veiculoId);
        void AtualizarOrSalvar(VeiculoViewModel model);
    }
}