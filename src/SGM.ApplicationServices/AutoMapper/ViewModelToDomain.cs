﻿using AutoMapper;
using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Entities;

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
            CreateMap<ClienteVeiculoViewModel, ClienteVeiculo>();
            CreateMap<VeiculoViewModel, Veiculo>();
        }
    }
}