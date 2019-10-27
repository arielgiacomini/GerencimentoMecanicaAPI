using SGMLoquinho.Domain.Entities;
using SGMLoquinho.Infrastructure.Context;
using SGMLoquinho.Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SGMLoquinho.Infrastructure.Repositories.Repository
{
    public class RhColaboradoresRepository : IRhColaboradoresRepository
    {
        private readonly SGMLoquinhoContext _sGMLoquinhoContext;

        public RhColaboradoresRepository(SGMLoquinhoContext context)
        {
            _sGMLoquinhoContext = context;
        }

        public IEnumerable<RhColaboradores> GetByAll()
        {
            return _sGMLoquinhoContext.RhColaboradores.ToList();
        }

        public void Salvar(RhColaboradores entidade)
        {
            _sGMLoquinhoContext.Add(entidade);
            _sGMLoquinhoContext.SaveChanges();
        }
    }
}
