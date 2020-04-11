using AutoMapper;
using SGMLoquinho.ApplicationServices.Interfaces;
using SGMLoquinho.ApplicationServices.ViewModels;
using SGMLoquinho.Domain.Entities;
using SGMLoquinho.Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;

namespace SGMLoquinho.ApplicationServices.Services
{
    public class RhColaboradoresServices : IRhColaboradoresServices
    {
        private readonly IColaboradorRepository _rhColaboradoresRepository;
        private readonly IMapper _mapper;

        public RhColaboradoresServices(IColaboradorRepository rhColaboradoresRepository, IMapper mapper)
        {
            _rhColaboradoresRepository = rhColaboradoresRepository;
            _mapper = mapper;
        }

        public IEnumerable<RhColaboradoresViewModel> GetByAll()
        {
            return _mapper.Map<IEnumerable<RhColaboradoresViewModel>>(_rhColaboradoresRepository.GetByAll());
        }

        public void Salvar(RhColaboradoresViewModel model)
        {
            var entidade = _mapper.Map<Colaborador>(model);
            _rhColaboradoresRepository.Salvar(entidade);
        }
    }
}
