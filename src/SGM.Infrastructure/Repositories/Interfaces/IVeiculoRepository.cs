using SGM.Domain.Entities;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IVeiculoRepository
    {
        IEnumerable<Veiculo> GetByAll();
        Count GetCount();
        Veiculo GetById(int orcamentoId);
        IList<Veiculo> GetVeiculoByMarcaId(int marcaId);
        void InativarVeiculo(int veiculoId);
        int Salvar(Veiculo entidade);
        void Atualizar(Veiculo model);
    }
}
