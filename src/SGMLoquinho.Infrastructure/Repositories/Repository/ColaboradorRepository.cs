using SGMLoquinho.Domain.Entities;
using SGMLoquinho.Infrastructure.Context;
using SGMLoquinho.Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SGMLoquinho.Infrastructure.Repositories.Repository
{
    public class ColaboradorRepository : IColaboradorRepository
    {
        private readonly SGMLoquinhoContext _sGMLoquinhoContext;

        public ColaboradorRepository(SGMLoquinhoContext context)
        {
            _sGMLoquinhoContext = context;
        }

        public IEnumerable<Colaborador> GetByAll()
        {
            return _sGMLoquinhoContext.Colaborador.ToList();
        }

        public void Salvar(Colaborador entidade)
        {
            _sGMLoquinhoContext.Add(entidade);
            _sGMLoquinhoContext.SaveChanges();
        }
    }
}
