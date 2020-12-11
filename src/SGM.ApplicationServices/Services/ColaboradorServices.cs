using AutoMapper;
using SGM.ApplicationServices.Interfaces;
using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Entities;
using SGM.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Services
{
    public class ColaboradorServices : IColaboradorServices
    {
        private readonly IColaboradorRepository _colaboradorRepository;
        private readonly IMapper _mapper;

        public ColaboradorServices(IColaboradorRepository colaboradorRepository, IMapper mapper)
        {
            _colaboradorRepository = colaboradorRepository;
            _mapper = mapper;
        }

        public IEnumerable<ColaboradorViewModel> GetByAll()
        {
            return _mapper.Map<IEnumerable<ColaboradorViewModel>>(_colaboradorRepository.GetByAll());
        }

        public ColaboradorViewModel GetById(int colaboradorId)
        {
            return _mapper.Map<ColaboradorViewModel>(_colaboradorRepository.GetById(colaboradorId));
        }

        public ColaboradorViewModel GetByColaboradorLogin(string colaboradorLogin)
        {
            return _mapper.Map<ColaboradorViewModel>(_colaboradorRepository.GetByColaboradorLogin(colaboradorLogin));
        }

        public void Salvar(ColaboradorViewModel model)
        {
            var entidade = _mapper.Map<Colaborador>(model);
            _colaboradorRepository.Salvar(entidade);
        }

        public void Atualizar(ColaboradorViewModel model)
        {
            var colaborador = _colaboradorRepository.GetById(model.ColaboradorId);

            if (colaborador == null)
            {
                _colaboradorRepository.Salvar(new Colaborador()
                {
                    Usuario = model.Usuario,
                    Senha = model.Senha,
                    Nome = model.Nome,
                    NomeCompleto = model.NomeCompleto,
                    Apelido = model.Apelido,
                    CPF = model.CPF,
                    RG = model.RG,
                    DataAdmissao = model.DataAdmissao,
                    DataDemissao = model.DataDemissao,
                    DataCadastro = DateTime.Now
                });
            }
            else
            {
                _colaboradorRepository.Atualizar(new Colaborador()
                {
                    ColaboradorId = model.ColaboradorId,
                    Usuario = model.Usuario,
                    Senha = model.Senha,
                    Nome = model.Nome,
                    NomeCompleto = model.NomeCompleto,
                    Apelido = model.Apelido,
                    CPF = model.CPF,
                    RG = model.RG,
                    DataAdmissao = model.DataAdmissao,
                    DataDemissao = model.DataDemissao,
                    DataAlteracao = DateTime.Now
                });
            }
        }
    }
}
