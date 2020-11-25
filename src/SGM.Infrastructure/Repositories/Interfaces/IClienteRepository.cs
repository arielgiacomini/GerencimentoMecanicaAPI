﻿using SGM.Domain.Entities;
using SGM.Domain.Utils;
using System.Collections.Generic;

namespace SGM.Infrastructure.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> GetByAll();
        Count GetCount();
        Cliente GetById(int clienteId);
        void Salvar(Cliente model);
        void Atualizar(Cliente entidade);
        IEnumerable<ClienteVeiculo> GetVeiculosClienteByClienteId(int clienteId);
        ClienteVeiculo GetVeiculoClienteByPlaca(string placa);
        Cliente GetClienteByDocumentoCliente(string documentoCliente);
        void InativarCliente(int clienteId);
        ClienteVeiculo GetVeiculoClienteByClienteVeiculoId(int clienteVeiculoId);

        //IEnumerable<ClienteComplex> GetByAllPaginado(int page);
    }
}
