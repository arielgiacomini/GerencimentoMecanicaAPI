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
        void Salvar(Veiculo model);
        void Atualizar(Veiculo model);
    }
}
