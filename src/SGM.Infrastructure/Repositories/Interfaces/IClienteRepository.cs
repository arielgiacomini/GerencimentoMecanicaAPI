using SGM.Domain.Entities;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetByAll();
        IEnumerable<Cliente> GetByAllPaginado(int page);
        Count GetCount();
        Cliente GetById(int clienteId);
        void Salvar(Cliente model);
        void Atualizar(Cliente entidade);
    }
}
