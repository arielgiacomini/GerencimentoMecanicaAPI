﻿using SGM.Domain.Entities;
using SGM.Domain.Utils;
using SGM.Infrastructure.Context;
using SGM.Infrastructure.Repositories.Interfaces;
using System;
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

        public IEnumerable<MaodeObra> GetByAll()
        {
            return _SGMContext.MaodeObra.ToList();
        }

        public IEnumerable<MaodeObra> GetByAllPaginado(int page)
        {

            return _SGMContext.MaodeObra.Skip((page - 1) * 5).Take(5).ToList();
        }

        public Count GetCount()
        {
            var contagem = _SGMContext.MaodeObra.Count();

            Count cont = new Count();
            {
                cont.Contagem = contagem;
            }

            return cont;
        }

        public MaodeObra GetById(int maoDeObraId)
        {
            return _SGMContext.MaodeObra.Where(x => x.MaodeObraId == maoDeObraId).FirstOrDefault();
        }

        public void InativarMaoDeObra(MaodeObra maoDeObra)
        {
            maoDeObra.Ativo = false;
            maoDeObra.VigenciaFinal = DateTime.Now;

            _SGMContext.Update(maoDeObra);
            _SGMContext.SaveChanges();

        }

        public void Salvar(MaodeObra entidade)
        {
            _SGMContext.MaodeObra.Add(entidade);
            _SGMContext.SaveChanges();
        }

        public void Atualizar(MaodeObra entidade)
        {
            var maoDeObra = GetById(entidade.MaodeObraId);
            maoDeObra.Descricao = entidade.Descricao;
            maoDeObra.Tipo = entidade.Tipo;
            maoDeObra.Valor = entidade.Valor;
            maoDeObra.VigenciaInicial = entidade.VigenciaInicial;
            maoDeObra.VigenciaFinal = entidade.VigenciaFinal;
            maoDeObra.Ativo = entidade.Ativo;

            _SGMContext.Update(maoDeObra);
            _SGMContext.SaveChanges();
        }
    }
}
