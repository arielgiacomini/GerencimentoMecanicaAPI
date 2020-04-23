using AutoMapper;
using SGM.ApplicationServices.ViewModels;
using SGM.ApplicationServices.ViewModels.Orcamentos;
using SGM.Domain.Entities;
using SGM.Domain.Entities.Orcamentos;

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
            CreateMap<ClienteOrcamentoList, ClienteOrcamentoListViewModel>();
            CreateMap<ClienteVeiculo, ClienteVeiculoViewModel>();
            CreateMap<Veiculo, VeiculoViewModel>();
        }
    }
}