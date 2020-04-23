using AutoMapper;
using SGM.ApplicationServices.Interfaces;
using SGM.ApplicationServices.ViewModels;
using SGM.ApplicationServices.ViewModels.Orcamentos;
using SGM.Domain.Entities;
using SGM.Domain.Enuns;
using SGM.Domain.Utils;
using SGM.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Services
{
    public class OrcamentoServices : IOrcamentoServices
    {
        private readonly IOrcamentoRepository _orcamentoRepository;
        private readonly IMapper _mapper;

        public OrcamentoServices(IOrcamentoRepository orcamentoRepository, IMapper mapper)
        {
            _orcamentoRepository = orcamentoRepository;
            _mapper = mapper;
        }

        public IEnumerable<OrcamentoViewModel> GetByAll()
        {
            return _mapper.Map<IEnumerable<OrcamentoViewModel>>(_orcamentoRepository.GetByAll());
        }

        public Count GetCount()
        {
            return _mapper.Map<Count>(_orcamentoRepository.GetCount());
        }

        public OrcamentoViewModel GetById(int orcamentoId)
        {
            return _mapper.Map<OrcamentoViewModel>(_orcamentoRepository.GetById(orcamentoId));
        }

        public void AtualizarOrSalvar(OrcamentoViewModel model)
        {
            var orcamento = _orcamentoRepository.GetById(model.OrcamentoId);

            if (orcamento == null)
            {
                _orcamentoRepository.Salvar(new Orcamento()
                {
                    ClienteId = model.ClienteId,
                    VeiculoId = model.VeiculoId,
                    Descricao = model.Descricao,
                    ValorAdicional = model.ValorAdicional,
                    PercentualDesconto = model.PercentualDesconto,
                    ValorDesconto = model.ValorDesconto,
                    ValorTotal = model.ValorTotal,
                    StatusId = (int)OrcamentoStatusEnum.OrcamentoGerado,
                    Ativo = true,
                    DataCadastro = DateTime.Now
                });
            }
            else
            {
                _orcamentoRepository.Atualizar(new Orcamento()
                {
                    OrcamentoId = model.OrcamentoId,
                    Descricao = model.Descricao,
                    ValorAdicional = model.ValorAdicional,
                    PercentualDesconto = model.PercentualDesconto,
                    ValorDesconto = model.ValorDesconto,
                    ValorTotal = model.ValorTotal,
                    StatusId = model.StatusId,
                    Ativo = model.Ativo
                });
            }
        }

        public IEnumerable<ClienteOrcamentoListViewModel> GetByAllPaginado(int page)
        {
            return _mapper.Map<IEnumerable<ClienteOrcamentoListViewModel>>(_orcamentoRepository.GetByAllPaginado(page));
        }
    }
}
