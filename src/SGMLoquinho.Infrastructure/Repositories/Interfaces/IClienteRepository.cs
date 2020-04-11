using SGMLoquinho.Domain.Entities;
using System.Collections.Generic;

namespace SGMLoquinho.Infrastructure.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetByAll();
        Cliente GetById(int clienteId);
        void Salvar(Cliente model);
        void Atualizar(Cliente entidade);
    }
}
