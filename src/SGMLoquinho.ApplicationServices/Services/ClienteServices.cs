using AutoMapper;
using SGMLoquinho.ApplicationServices.Interfaces;
using SGMLoquinho.ApplicationServices.ViewModels;
using SGMLoquinho.Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;

namespace SGMLoquinho.ApplicationServices.Services
{
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteServices(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public IEnumerable<ClienteViewModel> GetByAll()
        {
            return _mapper.Map<IEnumerable<ClienteViewModel>>(_clienteRepository.GetByAll());
        }
    }
}
