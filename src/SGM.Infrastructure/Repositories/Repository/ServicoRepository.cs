using SGM.Domain.Entities;
using SGM.Domain.Utils;
using SGM.Infrastructure.Context;
using SGM.Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SGM.Infrastructure.Repositories.Repository
{
    public class ServicoRepository: IServicoRepository
    {
        private readonly SGMContext _SGMContext;

        public ServicoRepository(SGMContext sgmContext)
        {
            _SGMContext = sgmContext;
        }

        public void Atualizar(Servico model)
        {
            var servico = GetById(model.ServicoId);
            servico.ClienteVeiculoId = model.ClienteVeiculoId;
            servico.Descricao = model.Descricao;
            servico.ValorAdicional = model.ValorAdicional;
            servico.PercentualDesconto = model.PercentualDesconto;
            servico.ValorDesconto = model.ValorDesconto;
            servico.ValorTotal = model.ValorTotal;
            servico.Status = model.Status;
            servico.Ativo = model.Ativo;

            _SGMContext.Update(servico);
            _SGMContext.SaveChanges();
        }

        public IEnumerable<Servico> GetByAll()
        {
            return _SGMContext.Servico.ToList();
        }

        public Servico GetById(int servicoId)
        {
            return _SGMContext.Servico.Where(x => x.ServicoId == servicoId).FirstOrDefault();
        }

        public Count GetCount()
        {
            var contagem = _SGMContext.Servico.Count();

            Count cont = new Count();
            {
                cont.Contagem = contagem;
            }

            return cont;

        }

        public void Salvar(Servico model)
        {
            _SGMContext.Servico.Add(model);
            _SGMContext.SaveChanges();
        }
    }
}