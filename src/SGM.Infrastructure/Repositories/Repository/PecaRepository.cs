using Microsoft.EntityFrameworkCore;
using SGM.Domain.Entities;
using SGM.Domain.Utils;
using SGM.Infrastructure.Context;
using SGM.Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SGM.Infrastructure.Repositories.Repository
{
    public class PecaRepository : IPecaRepository
    {
        private readonly SGMContext _SGMContext;

        public PecaRepository(SGMContext sgmContext)
        {
            _SGMContext = sgmContext;
        }

        public IEnumerable<Peca> GetPecaByAll()
        {
            return _SGMContext.Peca.AsNoTracking().Where(peca => peca.Ativo).ToList();
        }

        public IEnumerable<Peca> GetPecaByAllPaginado(int page)
        {
            return _SGMContext.Peca.AsNoTracking().Where(peca => peca.Ativo).Skip((page - 1) * 5).Take(5).ToList();
        }

        public Count GetPecaCount()
        {
            var contagem = GetPecaByAll().Count();

            Count cont = new Count();
            {
                cont.Contagem = contagem;
            }

            return cont;
        }

        public Peca GetById(int pecaId)
        {
            return _SGMContext.Peca.AsNoTracking().Where(x => x.PecaId == pecaId).FirstOrDefault();
        }

        public IList<Peca> GetPecaByDescricao(string descricao)
        {
            return _SGMContext.Peca.AsNoTracking().Where(peca => peca.Descricao.Contains(descricao)).ToList();
        }

        public void InativarPeca(int pecaId)
        {
            var peca = GetById(pecaId);

            peca.Ativo = false;

            _SGMContext.Peca.Update(peca);
            _SGMContext.SaveChanges();
        }

        public void Salvar(Peca entidade)
        {
            _SGMContext.Peca.Add(entidade);
            _SGMContext.SaveChanges();
        }

        public void Atualizar(Peca entidade)
        {
            var peca = GetById(entidade.PecaId);

            peca.Descricao = entidade.Descricao;
            peca.Fornecedor = entidade.Fornecedor;
            peca.Valor = entidade.Valor;
            peca.ValorFrete = entidade.ValorFrete;
            peca.Ativo = entidade.Ativo;

            _SGMContext.Peca.Update(peca);
            _SGMContext.SaveChanges();
        }
    }
}