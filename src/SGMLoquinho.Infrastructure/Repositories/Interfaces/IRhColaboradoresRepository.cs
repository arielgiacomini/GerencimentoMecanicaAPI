using SGMLoquinho.Domain.Entities;
using System.Collections.Generic;

namespace SGMLoquinho.Infrastructure.Repositories.Interfaces
{
    public interface IColaboradorRepository
    {
        IEnumerable<Colaborador> GetByAll();
        void Salvar(Colaborador entidade);
    }
}
