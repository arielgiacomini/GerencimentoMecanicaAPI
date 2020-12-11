using Microsoft.EntityFrameworkCore;
using SGM.Domain.Entities;
using SGM.Infrastructure.Context;
using SGM.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGM.Infrastructure.Repositories.Repository
{
    public class ColaboradorRepository : IColaboradorRepository
    {
        private readonly SGMContext _SGMContext;

        public ColaboradorRepository(SGMContext context)
        {
            _SGMContext = context;
        }

        public IEnumerable<Colaborador> GetByAll()
        {
            return _SGMContext.Colaborador.AsNoTracking().ToList();
        }

        public Colaborador GetById(int colaboradorId)
        {
            return _SGMContext.Colaborador.AsNoTracking().Where(x => x.ColaboradorId == colaboradorId).FirstOrDefault();
        }

        public Colaborador GetByColaboradorLogin(string colaboradorLogin)
        {
            return _SGMContext.Colaborador.AsNoTracking().Where(x => x.Usuario == colaboradorLogin).FirstOrDefault();
        }

        public void Salvar(Colaborador entidade)
        {
            entidade.DataAlteracao = null;
            entidade.DataDemissao = null;

            _SGMContext.Colaborador.Add(entidade);
            _SGMContext.SaveChanges();
        }

        public void Atualizar(Colaborador entidade)
        {
            var colaborador = GetById(entidade.ColaboradorId);
            colaborador.Usuario = entidade.Usuario;
            colaborador.Senha = entidade.Senha;
            colaborador.Nome = entidade.Nome;
            colaborador.NomeCompleto = entidade.NomeCompleto;
            colaborador.Apelido = entidade.Apelido;
            colaborador.CPF = entidade.CPF;
            colaborador.RG = entidade.RG;
            colaborador.DataDemissao = entidade.DataDemissao;
            colaborador.DataAlteracao = DateTime.Now;

            _SGMContext.Update(colaborador);
            _SGMContext.SaveChanges();
        }
    }
}
