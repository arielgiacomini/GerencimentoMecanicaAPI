using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IColaboradorRepository
    {
        IEnumerable<Colaborador> GetByAll();
        Colaborador GetById(int colaboradorId);
        void Salvar(Colaborador model);
        void Atualizar(Colaborador model);
        Colaborador GetByColaboradorLogin(string colaboradorLogin);
    }
}
