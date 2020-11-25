using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IClienteVeiculoRepository
    {
        IEnumerable<ClienteVeiculo> GetVeiculosClienteByClienteId(int clienteId);
        ClienteVeiculo GetVeiculoClienteByPlaca(string placa);
        ClienteVeiculo GetVeiculoClienteByClienteVeiculoId(int clienteVeiculoId);
        int SalvarClienteVeiculo(ClienteVeiculo clienteVeiculo);
        int AtualizarClienteVeiculo(ClienteVeiculo clienteVeiculo);
        void InativarClienteVeiculo(int clienteVeiculoId);

    }
}