using Microsoft.EntityFrameworkCore;
using SGM.Domain.Entities;
using SGM.Domain.Utils;
using SGM.Infrastructure.Context;
using SGM.Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SGM.Infrastructure.Repositories.Repository
{
    public class MaodeObraRepository : IMaodeObraRepository
    {
        private readonly SGMContext _SGMContext;

        public MaodeObraRepository(SGMContext sgmContext)
        {
            _SGMContext = sgmContext;
        }

        public IEnumerable<MaodeObra> GetMaodeObraByAll()
        {
            return _SGMContext.MaodeObra.AsNoTracking().Where(x => x.Ativo).ToList();
        }

        public IEnumerable<MaodeObra> GetMaodeObraByAllPaginado(int page)
        {

            return _SGMContext.MaodeObra.AsNoTracking().Where(x => x.Ativo).Skip((page - 1) * 5).Take(5).ToList();
        }

        public Count GetMaodeObraCount()
        {
            var contagem = GetMaodeObraByAll().Count();

            Count cont = new Count();
            {
                cont.Contagem = contagem;
            }

            return cont;
        }

        public MaodeObra GetMaodeObraById(int maoDeObraId)
        {
            return _SGMContext.MaodeObra.AsNoTracking().Where(x => x.MaodeObraId == maoDeObraId).FirstOrDefault();
        }

        public IList<MaodeObra> GetMaodeObraByDescricao(string descricao)
        {
            return _SGMContext.MaodeObra.AsNoTracking().Where(mao => mao.Descricao.Contains(descricao)).ToList();
        }

        public void InativarMaoDeObra(MaodeObra maoDeObra)
        {
            _SGMContext.MaodeObra.Update(maoDeObra);
            _SGMContext.SaveChanges();
        }

        public void Salvar(MaodeObra entidade)
        {
            _SGMContext.MaodeObra.Add(entidade);
            _SGMContext.SaveChanges();
        }

        public void Atualizar(MaodeObra entidade)
        {
            var maoDeObra = GetMaodeObraById(entidade.MaodeObraId);

            maoDeObra.Descricao = entidade.Descricao;
            maoDeObra.Tipo = entidade.Tipo;
            maoDeObra.Valor = entidade.Valor;
            maoDeObra.VigenciaInicial = entidade.VigenciaInicial;
            maoDeObra.VigenciaFinal = entidade.VigenciaFinal;
            maoDeObra.Ativo = entidade.Ativo;

            _SGMContext.MaodeObra.Update(maoDeObra);
            _SGMContext.SaveChanges();
        }
    }
}