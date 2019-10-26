using SGMLoquinho.Domain.Entities;
using SGMLoquinho.Infrastructure.Context;
using SGMLoquinho.Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SGMLoquinho.Infrastructure.Repositories.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly SGMLoquinhoContext _sGMLoquinhoContext;

        public ClienteRepository(SGMLoquinhoContext context)
        {
            _sGMLoquinhoContext = context;
        }

        public IEnumerable<Cliente> GetByAll()
        {
            return _sGMLoquinhoContext.Cliente.ToList();
        }
    }
}
