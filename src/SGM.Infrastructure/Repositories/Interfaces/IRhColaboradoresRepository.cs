using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IColaboradorRepository
    {
        IEnumerable<Colaborador> GetByAll();
        void Salvar(Colaborador entidade);
    }
}
