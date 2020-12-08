using Microsoft.EntityFrameworkCore;
using SGM.Domain.Entities;
using SGM.Domain.Utils;
using SGM.Infrastructure.Context;
using SGM.Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SGM.Infrastructure.Repositories.Repository
{
    public class ServicoRepository : IServicoRepository
    {
        private readonly SGMContext _SGMContext;

        public ServicoRepository(SGMContext sgmContext)
        {
            _SGMContext = sgmContext;
        }

        public IEnumerable<Servico> GetServicoByAll()
        {
            return _SGMContext.Servico.AsNoTracking().Where(servico => servico.Ativo).ToList();
        }

        public IList<Servico> GetUltimosServico(int quantidade)
        {
            return GetServicoByAll().OrderByDescending(x => x.DataCadastro).Take(quantidade).ToList();
        }

        public Count GetServicoCount()
        {
            var contagem = GetServicoByAll().Count();

            Count cont = new Count();
            {
                cont.Contagem = contagem;
            }

            return cont;

        }

        public Servico GetServicoById(int servicoId)
        {
            return _SGMContext.Servico.AsNoTracking().Where(x => x.ServicoId == servicoId).FirstOrDefault();
        }

        public IList<Servico> GetServicoByClienteVeiculoId(int clienteVeiculoId)
        {
            return _SGMContext.Servico.AsNoTracking().Where(servico => servico.ClienteVeiculoId == clienteVeiculoId).ToList();
        }

        public int SalvarServico(Servico model)
        {
            _SGMContext.Servico.Add(model);
            _SGMContext.SaveChanges();

            return model.ServicoId;
        }

        public void AtualizarServico(Servico model)
        {
            _SGMContext.Servico.Update(model);
            _SGMContext.SaveChanges();
        }

        public int SalvarServicoMaodeObra(ServicoMaodeObra servicoMaodeObra)
        {
            _SGMContext.ServicoMaodeObra.Add(servicoMaodeObra);
            _SGMContext.SaveChanges();

            return servicoMaodeObra.Id;
        }

        public int SalvarServicoPeca(ServicoPeca servicoPeca)
        {
            _SGMContext.ServicoPeca.Add(servicoPeca);
            _SGMContext.SaveChanges();

            return servicoPeca.Id;
        }

        public void DeletarServicoMaodeObra(ServicoMaodeObra servicoMaodeObra)
        {
            _SGMContext.ServicoMaodeObra.Remove(servicoMaodeObra);
            _SGMContext.SaveChanges();
        }

        public void DeletarServicoPeca(ServicoPeca servicoPeca)
        {
            _SGMContext.ServicoPeca.Remove(servicoPeca);
            _SGMContext.SaveChanges();
        }

        public IList<ServicoMaodeObra> GetServicoMaodeObraByServicoId(int servicoId)
        {
            var ServicoMaodeObra = _SGMContext.ServicoMaodeObra.AsNoTracking().Where(Servico => Servico.ServicoId == servicoId).ToList();

            return ServicoMaodeObra;
        }

        public IList<ServicoPeca> GetServicoPecaByServicoId(int servicoId)
        {
            var ServicoPeca = _SGMContext.ServicoPeca.AsNoTracking().Where(Servico => Servico.ServicoId == servicoId).ToList();

            return ServicoPeca;
        }
    }
}