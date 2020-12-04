using SGM.Domain.Entities;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IVeiculoRepository
    {
        IEnumerable<Veiculo> GetVeiculoByAll();
        Count GetVeiculoCount();
        Veiculo GetVeiculoById(int orcamentoId);
        IList<Veiculo> GetVeiculoByMarcaId(int marcaId);
        void InativarVeiculo(int veiculoId);
        int Salvar(Veiculo entidade);
        void Atualizar(Veiculo model);
        IList<Veiculo> GetVeiculoByDescricaoModelo(string descricaoModelo);
    }
}
