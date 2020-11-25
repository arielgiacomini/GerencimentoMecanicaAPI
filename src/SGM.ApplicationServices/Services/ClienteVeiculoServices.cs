using AutoMapper;
using SGM.ApplicationServices.Interfaces;
using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Entities;
using SGM.Infrastructure.Repositories.Interfaces;
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
            return _clienteVeiculoRepository.SalvarClienteVeiculo(_mapper.Map<ClienteVeiculo>(clienteVeiculoViewModel));
        }

        public int AtualizarClienteVeiculo(ClienteVeiculoViewModel clienteVeiculoViewModel)
        {
            return _clienteVeiculoRepository.AtualizarClienteVeiculo(_mapper.Map<ClienteVeiculo>(clienteVeiculoViewModel));
        }
    }
}