using AutoMapper;
using SGMLoquinho.ApplicationServices.ViewModels;
using SGMLoquinho.Domain.Entities;

namespace SGMLoquinho.ApplicationServices.AutoMapper
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<RhColaboradoresViewModel, Colaborador>();
        }
    }
}
