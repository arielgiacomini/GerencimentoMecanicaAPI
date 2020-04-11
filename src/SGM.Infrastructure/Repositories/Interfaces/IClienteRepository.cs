using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetByAll();
        Cliente GetById(int clienteId);
        void Salvar(Cliente model);
        void Atualizar(Cliente entidade);
    }
}
