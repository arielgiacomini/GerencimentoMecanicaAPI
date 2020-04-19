using AutoMapper;
using SGM.ApplicationServices.ViewModels;
using SGM.ApplicationServices.ViewModels.Orcamentos;
using SGM.Domain.Entities;
using SGM.Domain.Entities.Orcamentos;

namespace SGM.ApplicationServices.AutoMapper
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ColaboradorViewModel, Colaborador>();
            CreateMap<OrcamentoViewModel, Orcamento>();
            CreateMap<PecaViewModel, Peca>();
            CreateMap<MaodeObraViewModel, MaodeObra>();
            CreateMap<ClienteOrcamentosViewModel, ClienteOrcamentos>();
        }
    }
}
