using Microsoft.EntityFrameworkCore;
using SGM.Domain.Entities;
using SGM.Infrastructure.Context;
using SGM.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGM.Infrastructure.Repositories.Repository
{
    public class ClienteVeiculoRepository : IClienteVeiculoRepository
    {
        private readonly SGMContext _SGMContext;

        public ClienteVeiculoRepository(SGMContext sGMContext)
        {
            _SGMContext = sGMContext;
        }

        public IEnumerable<ClienteVeiculo> GetVeiculosClienteByClienteId(int clienteId)
        {
            return _SGMContext.ClienteVeiculo.AsNoTracking().Where(veiculosCliente => veiculosCliente.ClienteId == clienteId && veiculosCliente.Ativo).ToList();
        }

        public ClienteVeiculo GetVeiculoClienteByPlaca(string placa)
        {
            return _SGMContext.ClienteVeiculo.AsNoTracking().Where(clienteVeiculo => clienteVeiculo.PlacaVeiculo.Replace("-", "") == placa.Replace("-", "") && clienteVeiculo.Ativo).FirstOrDefault();
        }

        public ClienteVeiculo GetVeiculoClienteByClienteVeiculoId(int clienteVeiculoId)
        {
            return _SGMContext.ClienteVeiculo.AsNoTracking().Where(clienteVeiculo => clienteVeiculo.ClienteVeiculoId == clienteVeiculoId).FirstOrDefault();
        }

        public int SalvarClienteVeiculo(ClienteVeiculo clienteVeiculo)
        {
            _SGMContext.ClienteVeiculo.Add(clienteVeiculo);
            _SGMContext.SaveChanges();

            return clienteVeiculo.ClienteVeiculoId;
        }

        public int AtualizarClienteVeiculo(ClienteVeiculo clienteVeiculo)
        {
            _SGMContext.ClienteVeiculo.Update(clienteVeiculo);
            _SGMContext.SaveChanges();

            return clienteVeiculo.ClienteVeiculoId;
        }

        public void InativarClienteVeiculo(int clienteVeiculoId)
        {
            var clienteVeiculo = GetVeiculoClienteByClienteVeiculoId(clienteVeiculoId);

            clienteVeiculo.DataAlteracao = DateTime.Now;
            clienteVeiculo.Ativo = false;

            _SGMContext.ClienteVeiculo.Update(clienteVeiculo);
            _SGMContext.SaveChanges();
        }
    }
}