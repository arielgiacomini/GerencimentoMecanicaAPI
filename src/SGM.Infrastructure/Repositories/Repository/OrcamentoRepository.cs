using SGM.Domain.Entities;
using SGM.Infrastructure.Context;
using SGM.Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SGM.Infrastructure.Repositories.Repository
{
    public class OrcamentoRepository : IOrcamentoRepository
    {
        private readonly SGMContext _SGMContext;

        public OrcamentoRepository(SGMContext sgmContext)
        {
            _SGMContext = sgmContext;
        }

        public IEnumerable<Orcamento> GetByAll()
        {
            return _SGMContext.Orcamento.ToList();
        }

        public Orcamento GetById(int orcamentoId)
        {
            return _SGMContext.Orcamento.Where(x => x.OrcamentoId == orcamentoId).FirstOrDefault();
        }

        public void Salvar(Orcamento entidade)
        {
            _SGMContext.Orcamento.Add(entidade);
            _SGMContext.SaveChanges();
        }

        public void Atualizar(Orcamento entidade)
        {
            var orcamento = GetById(entidade.OrcamentoId);
            orcamento.Descricao = entidade.Descricao;
            orcamento.ValorAdicional = entidade.ValorAdicional;
            orcamento.PercentualDesconto = entidade.PercentualDesconto;
            orcamento.ValorDesconto = entidade.ValorDesconto;
            orcamento.ValorTotal = entidade.ValorTotal;
            orcamento.StatusId = entidade.StatusId;
            orcamento.Ativo = entidade.Ativo;

            _SGMContext.Update(orcamento);
            _SGMContext.SaveChanges();
        }
    }
}
