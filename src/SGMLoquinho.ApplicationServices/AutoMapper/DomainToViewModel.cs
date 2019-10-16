using AutoMapper;
using SGMLoquinho.ApplicationServices.ViewModels;
using SGMLoquinho.Domain.Entities;

namespace SGMLoquinho.ApplicationServices.AutoMapper
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<Cliente, ClienteViewModel>();
            //CreateMap<ClienteVeiculo, ClienteVeiculoViewModel>();
        }
    }
}
