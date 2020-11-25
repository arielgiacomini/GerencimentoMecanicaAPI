using SGM.ApplicationServices.ViewModels;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Interfaces
{
    public interface IClienteVeiculoServices
    {
        IEnumerable<ClienteVeiculoViewModel> GetClienteVeiculoByClienteId(int clienteId);
        ClienteVeiculoViewModel GetVeiculoClienteByPlaca(string placa);
        ClienteVeiculoViewModel GetVeiculoClienteByClienteVeiculoId(int clienteVeiculoId);
        int SalvarClienteVeiculo(ClienteVeiculoViewModel clienteVeiculoViewModel);
        int AtualizarClienteVeiculo(ClienteVeiculoViewModel clienteVeiculoViewModel);
        void InativarClienteVeiculo(int clienteVeiculoId);
    }
}