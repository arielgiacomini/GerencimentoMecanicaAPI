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
        Cliente GetClienteByPlacaVeiculo(string placaVeiculo);
        void InativarCliente(int clienteId);
        Cliente GetClienteByLikePlacaOrNomeOrApelido(string valor);

        //IEnumerable<ClienteComplex> GetByAllPaginado(int page);
    }
}
