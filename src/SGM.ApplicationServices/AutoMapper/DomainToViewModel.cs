using AutoMapper;
using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Entities;

namespace SGM.ApplicationServices.AutoMapper
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Colaborador, ColaboradorViewModel>();
            CreateMap<Orcamento, OrcamentoViewModel>();
            CreateMap<Peca, PecaViewModel>();
            CreateMap<MaodeObra, MaodeObraViewModel>();
            CreateMap<ClienteVeiculo, ClienteVeiculoViewModel>();
            CreateMap<Veiculo, VeiculoViewModel>();
        }
    }
}