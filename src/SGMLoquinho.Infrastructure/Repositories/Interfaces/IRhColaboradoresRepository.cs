using SGMLoquinho.Domain.Entities;
using System.Collections.Generic;

namespace SGMLoquinho.Infrastructure.Repositories.Interfaces
{
    public interface IRhColaboradoresRepository
    {
        IEnumerable<RhColaboradores> GetByAll();
        void Salvar(RhColaboradores entidade);
    }
}
