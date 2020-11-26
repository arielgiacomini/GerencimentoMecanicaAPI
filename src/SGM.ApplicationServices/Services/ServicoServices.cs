using AutoMapper;
using SGM.ApplicationServices.Interfaces;
using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Entities;
using SGM.Domain.Enuns;
using SGM.Domain.Utils;
using SGM.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Services
{
    public class ServicoServices : IServicoServices
    {
        private readonly IServicoRepository _servicoRepository;
        private readonly IMapper _mapper;

        public ServicoServices(IServicoRepository servicoRepository, IMapper mapper)
        {
            _servicoRepository = servicoRepository;
            _mapper = mapper;
        }

        public IEnumerable<ServicoViewModel> GetByAll()
        {
            return _mapper.Map<IEnumerable<ServicoViewModel>>(_servicoRepository.GetByAll());
        }

        public ServicoViewModel GetById(int servicoId)
        {
            return _mapper.Map<ServicoViewModel>(_servicoRepository.GetById(servicoId));
        }

        public Count GetCount()
        {
            return _mapper.Map<Count>(_servicoRepository.GetCount());
        }

        public void AtualizarOrSalvar(ServicoViewModel model)
        {
            var servico = _servicoRepository.GetById(model.ServicoId);

            if (servico == null)
            {
                _servicoRepository.Salvar(new Servico()
                {
                    ClienteVeiculoId = model.ClienteVeiculoId,
                    Descricao = model.Descricao,
                    ValorAdicional = model.ValorAdicional,
                    PercentualDesconto = model.PercentualDesconto,
                    ValorDesconto = model.ValorDesconto,
                    ValorTotal = model.ValorTotal,
                    Status = (int)StatusEnum.IniciadoPendente,
                    Ativo = true,
                    DataCadastro = DateTime.Now
                });
            }
            else
            {
                _servicoRepository.Atualizar(new Servico()
                {
                    ServicoId = model.ServicoId,
                    Descricao = model.Descricao,
                    ValorAdicional = model.ValorAdicional,
                    PercentualDesconto = model.PercentualDesconto,
                    ValorDesconto = model.ValorDesconto,
                    ValorTotal = model.ValorTotal,
                    Status = model.Status,
                    Ativo = model.Ativo
                });
            }
        }
    }
}