using SGM.Domain.Entities;
using SGM.Domain.Utils;
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

        public Count GetCount()
        {
            var contagem = _SGMContext.Orcamento.Count();

            Count cont = new Count();
            {
                cont.Contagem = contagem;
            }

            return cont;
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
            orcamento.ClienteId = entidade.ClienteId;
            orcamento.ClienteVeiculoId = entidade.ClienteVeiculoId;
            orcamento.Descricao = entidade.Descricao;
            orcamento.ValorAdicional = entidade.ValorAdicional;
            orcamento.PercentualDesconto = entidade.PercentualDesconto;
            orcamento.ValorDesconto = entidade.ValorDesconto;
            orcamento.ValorTotal = entidade.ValorTotal;
            orcamento.Status = entidade.Status;
            orcamento.Ativo = entidade.Ativo;

            _SGMContext.Update(orcamento);
            _SGMContext.SaveChanges();
        }
    }
}
