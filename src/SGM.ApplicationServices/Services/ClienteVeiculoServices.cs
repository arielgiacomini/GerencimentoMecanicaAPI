using AutoMapper;
using SGM.ApplicationServices.Interfaces;
using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Entities;
using SGM.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Services
{
    public class ClienteVeiculoServices : IClienteVeiculoServices
    {
        private readonly IClienteVeiculoRepository _clienteVeiculoRepository;
        private readonly IMapper _mapper;

        public ClienteVeiculoServices(IClienteVeiculoRepository clienteVeiculoRepository, IMapper mapper)
        {
            _clienteVeiculoRepository = clienteVeiculoRepository;
            _mapper = mapper;
        }

        public IEnumerable<ClienteVeiculoViewModel> GetClienteVeiculoByClienteId(int clienteId)
        {
            return _mapper.Map<IEnumerable<ClienteVeiculoViewModel>>(_clienteVeiculoRepository.GetVeiculosClienteByClienteId(clienteId));
        }

        public ClienteVeiculoViewModel GetVeiculoClienteByPlaca(string placa)
        {
            return _mapper.Map<ClienteVeiculoViewModel>(_clienteVeiculoRepository.GetVeiculoClienteByPlaca(placa));
        }

        public ClienteVeiculoViewModel GetVeiculoClienteByClienteVeiculoId(int clienteVeiculoId)
        {
            return _mapper.Map<ClienteVeiculoViewModel>(_clienteVeiculoRepository.GetVeiculoClienteByClienteVeiculoId(clienteVeiculoId));
        }

        public int SalvarClienteVeiculo(ClienteVeiculoViewModel clienteVeiculoViewModel)
        {
            clienteVeiculoViewModel.DataCadastro = DateTime.Now;
            clienteVeiculoViewModel.Ativo = true;
            clienteVeiculoViewModel.DataAlteracao = null;

            return _clienteVeiculoRepository.SalvarClienteVeiculo(_mapper.Map<ClienteVeiculo>(clienteVeiculoViewModel));
        }

        public int AtualizarClienteVeiculo(ClienteVeiculoViewModel clienteVeiculoViewModel)
        {
            var clienteVeiculo = GetVeiculoClienteByClienteVeiculoId(clienteVeiculoViewModel.ClienteVeiculoId);

            clienteVeiculo.DataAlteracao = DateTime.Now;
            clienteVeiculo.CorVeiculo = clienteVeiculoViewModel.CorVeiculo;
            clienteVeiculo.Ativo = clienteVeiculoViewModel.Ativo;
            clienteVeiculo.VeiculoId = clienteVeiculoViewModel.VeiculoId;
            clienteVeiculo.PlacaVeiculo = clienteVeiculoViewModel.PlacaVeiculo;
            clienteVeiculo.KmRodados = clienteVeiculoViewModel.KmRodados;

            return _clienteVeiculoRepository.AtualizarClienteVeiculo(_mapper.Map<ClienteVeiculo>(clienteVeiculo));
        }

        public void InativarClienteVeiculo(int clienteVeiculoId)
        {
            _clienteVeiculoRepository.InativarClienteVeiculo(clienteVeiculoId);
        }
    }
}