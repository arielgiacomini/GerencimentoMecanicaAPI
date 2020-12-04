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
        IList<VeiculoViewModel> GetVeiculosByMarcaId(int marcaId);
        void InativarVeiculo(int veiculoId);
        int AtualizarOrSalvar(VeiculoViewModel model);
        VeiculoMarcaViewModel GetMarcaByMarcaId(int marcaId);
        IList<VeiculoMarcaViewModel> GetMarcasByAll();
        IList<VeiculoViewModel> GetVeiculoByDescricaoModelo(string descricaoModelo);
    }
}