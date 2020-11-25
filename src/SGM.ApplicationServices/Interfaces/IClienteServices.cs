using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IClienteServices
    {
        IEnumerable<ClienteViewModel> GetByAll();
        Count GetCount();
        ClienteViewModel GetById(int clienteId);
        void Salvar(ClienteViewModel model);
        void Atualizar(ClienteViewModel model);
        IEnumerable<ClienteVeiculoViewModel> GetClienteVeiculoByClienteId(int clienteId);
        ClienteVeiculoViewModel GetVeiculoClienteByPlaca(string placa);
        ClienteViewModel GetClienteByDocumentoCliente(string documentoCliente);
        void InativarCliente(int solicitacaoId);
        ClienteVeiculoViewModel GetVeiculoClienteByClienteVeiculoId(int clienteVeiculoId);

        //IEnumerable<ClienteViewModel> GetByAllPaginado(int page);
    }
}
