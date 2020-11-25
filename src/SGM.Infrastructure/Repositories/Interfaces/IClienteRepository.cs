using SGM.Domain.Entities;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetByAll();
        Count GetCount();
        Cliente GetById(int clienteId);
        int Salvar(Cliente entidade);
        void Atualizar(Cliente entidade);
        Cliente GetClienteByDocumentoCliente(string documentoCliente);
        void InativarCliente(int clienteId);

        //IEnumerable<ClienteComplex> GetByAllPaginado(int page);
    }
}
