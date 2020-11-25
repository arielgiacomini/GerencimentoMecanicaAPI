﻿using AutoMapper;
using SGM.ApplicationServices.Interfaces;
using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Entities;
using SGM.Domain.Utils;
using SGM.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Services
{
    public class VeiculoServices : IVeiculoServices
    {
        private readonly IVeiculoRepository _veiculoRepository;
        private readonly IVeiculoMarcaRepository _veiculoMarcaRepository;
        private readonly IMapper _mapper;

        public VeiculoServices(IVeiculoRepository veiculoRepository, IVeiculoMarcaRepository veiculoMarcaRepository, IMapper mapper)
        {
            _veiculoRepository = veiculoRepository;
            _veiculoMarcaRepository = veiculoMarcaRepository;
            _mapper = mapper;
        }

        public IEnumerable<VeiculoViewModel> GetByAll()
        {
            return _mapper.Map<IEnumerable<VeiculoViewModel>>(_veiculoRepository.GetByAll());
        }

        public Count GetCount()
        {
            return _mapper.Map<Count>(_veiculoRepository.GetCount());
        }

        public VeiculoViewModel GetById(int orcamentoId)
        {
            return _mapper.Map<VeiculoViewModel>(_veiculoRepository.GetById(orcamentoId));
        }

        public void InativarVeiculo(int veiculoId)
        {
            _veiculoRepository.InativarVeiculo(veiculoId);
        }

        public int AtualizarOrSalvar(VeiculoViewModel model)
        {
            var veiculo = _veiculoRepository.GetById(model.VeiculoId);

            if (veiculo == null)
            {
                return _veiculoRepository.Salvar(new Veiculo()
                {
                    VeiculoId = model.VeiculoId,
                    MarcaId = model.MarcaId,
                    Modelo = model.Modelo,
                    VeiculoAtivo = true,
                    DataCadastro = DateTime.Now
                });
            }
            else
            {
                _veiculoRepository.Atualizar(new Veiculo()
                {
                    VeiculoId = model.VeiculoId,
                    MarcaId = model.MarcaId,
                    Modelo = model.Modelo,
                    VeiculoAtivo = model.VeiculoAtivo
                });

                return 0;
            }
        }

        public VeiculoMarcaViewModel GetMarcaByMarcaId(int marcaId)
        {
            return _mapper.Map<VeiculoMarcaViewModel>(_veiculoMarcaRepository.GetById(marcaId));
        }

        public IList<VeiculoMarcaViewModel> GetMarcasByAll()
        {
            return _mapper.Map<IList<VeiculoMarcaViewModel>>(_veiculoMarcaRepository.GetMarcasByAll());
        }
    }
}
