using SGM.Domain.Entities;
using SGM.Infrastructure.Context;
using SGM.Infrastructure.Repositories.Interfaces;
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
            return _SGMContext.Colaborador.ToList();
        }

        public void Salvar(Colaborador entidade)
        {
            _SGMContext.Add(entidade);
            _SGMContext.SaveChanges();
        }
    }
}
