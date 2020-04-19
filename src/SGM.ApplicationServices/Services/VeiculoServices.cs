using AutoMapper;
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
        private readonly IMapper _mapper;

        public VeiculoServices(IVeiculoRepository veiculoRepository, IMapper mapper)
        {
            _veiculoRepository = veiculoRepository;
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

        public void AtualizarOrSalvar(VeiculoViewModel model)
        {
            var orcamento = _veiculoRepository.GetById(model.VeiculoId);

            if (orcamento == null)
            {
                _veiculoRepository.Salvar(new Veiculo()
                {
                    VeiculoId = model.VeiculoId,
                    Marca = model.Marca,
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
                    Marca = model.Marca,
                    Modelo = model.Modelo,
                    VeiculoAtivo = model.VeiculoAtivo
                });
            }
        }
    }
}
