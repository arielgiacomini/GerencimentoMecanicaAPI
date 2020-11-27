using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<Orcamento> GetOrcamentoByAll()
        {
            return _SGMContext.Orcamento.AsNoTracking().ToList();
        }

        public Count GetOrcamentoCount()
        {
            var contagem = GetOrcamentoByAll().Count();

            Count cont = new Count();
            {
                cont.Contagem = contagem;
            }

            return cont;
        }

        public Orcamento GetOrcamentoById(int orcamentoId)
        {
            return _SGMContext.Orcamento.Where(x => x.OrcamentoId == orcamentoId).FirstOrDefault();
        }

        public int SalvarOrcamento(Orcamento orcamento)
        {
            _SGMContext.Orcamento.Add(orcamento);
            _SGMContext.SaveChanges();

            return orcamento.OrcamentoId;
        }

        public void AtualizarOrcamento(Orcamento orcamentoModel)
        {
            var orcamento = GetOrcamentoById(orcamentoModel.OrcamentoId);

            orcamento.ClienteVeiculoId = orcamentoModel.ClienteVeiculoId;
            orcamento.ColaboradorId = orcamentoModel.ColaboradorId;
            orcamento.Descricao = orcamentoModel.Descricao;
            orcamento.ValorMaodeObra = orcamentoModel.ValorMaodeObra;
            orcamento.ValorPeca = orcamentoModel.ValorPeca;
            orcamento.ValorAdicional = orcamentoModel.ValorAdicional;
            orcamento.PercentualDesconto = orcamentoModel.PercentualDesconto;
            orcamento.ValorDesconto = orcamentoModel.ValorDesconto;
            orcamento.ValorTotal = orcamentoModel.ValorTotal;
            orcamento.Status = orcamentoModel.Status;
            orcamento.Ativo = orcamentoModel.Ativo;
            orcamento.DataAlteracao = orcamentoModel.DataAlteracao;

            _SGMContext.Orcamento.Update(orcamento);
            _SGMContext.SaveChanges();
        }



        public int SalvarOrcamentoMaodeObra(OrcamentoMaodeObra orcamentoMaodeObra)
        {
            _SGMContext.OrcamentoMaodeObra.Add(orcamentoMaodeObra);
            _SGMContext.SaveChanges();

            return orcamentoMaodeObra.Id;
        }

        public int SalvarOrcamentoPeca(OrcamentoPeca orcamentoPeca)
        {
            _SGMContext.OrcamentoPeca.Add(orcamentoPeca);
            _SGMContext.SaveChanges();

            return orcamentoPeca.Id;
        }

        public void DeletarOrcamentoMaodeObra(OrcamentoMaodeObra orcamentoMaodeObra)
        {
            _SGMContext.OrcamentoMaodeObra.Remove(orcamentoMaodeObra);
            _SGMContext.SaveChanges();
        }

        public void DeletarOrcamentoPeca(OrcamentoPeca orcamentoPeca)
        {
            _SGMContext.OrcamentoPeca.Remove(orcamentoPeca);
            _SGMContext.SaveChanges();
        }

        public IList<OrcamentoMaodeObra> GetOrcamentoMaodeObraByOrcamentoId(int orcamentoId)
        {
            var orcamentoMaodeObra = _SGMContext.OrcamentoMaodeObra.AsNoTracking().Where(orcamento => orcamento.OrcamentoId == orcamentoId).ToList();

            return orcamentoMaodeObra;
        }

        public IList<OrcamentoPeca> GetOrcamentoPecaByOrcamentoId(int orcamentoId)
        {
            var orcamentoPeca = _SGMContext.OrcamentoPeca.AsNoTracking().Where(orcamento => orcamento.OrcamentoId == orcamentoId).ToList();

            return orcamentoPeca;
        }
    }
}
