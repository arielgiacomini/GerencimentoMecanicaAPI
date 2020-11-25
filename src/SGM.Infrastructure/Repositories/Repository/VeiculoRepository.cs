using Microsoft.EntityFrameworkCore;
using SGM.Domain.Entities;
using SGM.Domain.Utils;
using SGM.Infrastructure.Context;
using SGM.Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SGM.Infrastructure.Repositories.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly SGMContext _SGMContext;

        public VeiculoRepository(SGMContext sgmContext)
        {
            _SGMContext = sgmContext;
        }

        public IEnumerable<Veiculo> GetByAll()
        {
            return _SGMContext.Veiculo.AsNoTracking().Where(veiculo => veiculo.VeiculoAtivo).ToList();
        }

        public Count GetCount()
        {
            var contagem = _SGMContext.Veiculo.AsNoTracking().Where(veiculo => veiculo.VeiculoAtivo).Count();

            Count cont = new Count();
            {
                cont.Contagem = contagem;
            }

            return cont;
        }

        public Veiculo GetById(int veiculoId)
        {
            return _SGMContext.Veiculo.AsNoTracking().Where(veiculo => veiculo.VeiculoId == veiculoId).FirstOrDefault();
        }

        public void InativarVeiculo(int veiculoId)
        {
            var veiculo = GetById(veiculoId);

            veiculo.VeiculoAtivo = false;

            _SGMContext.Veiculo.Update(veiculo);
            _SGMContext.SaveChanges();
        }

        public int Salvar(Veiculo entidade)
        {
            _SGMContext.Veiculo.Add(entidade);
            _SGMContext.SaveChanges();

            return entidade.VeiculoId;
        }

        public void Atualizar(Veiculo entidade)
        {
            var orcamento = GetById(entidade.VeiculoId);

            orcamento.MarcaId = entidade.MarcaId;
            orcamento.Modelo = entidade.Modelo;
            orcamento.VeiculoAtivo = entidade.VeiculoAtivo;

            _SGMContext.Veiculo.Update(orcamento);
            _SGMContext.SaveChanges();
        }
    }
}