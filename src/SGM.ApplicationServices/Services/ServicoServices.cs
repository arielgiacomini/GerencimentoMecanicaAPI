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

        public IEnumerable<ServicoViewModel> GetServicoByAll()
        {
            return _mapper.Map<IEnumerable<ServicoViewModel>>(_servicoRepository.GetServicoByAll());
        }

        public IList<ServicoViewModel> GetUltimosServicos(int quantidade)
        {
            return _mapper.Map<IList<ServicoViewModel>>(_servicoRepository.GetUltimosServico(quantidade));
        }

        public Count GetServicoCount()
        {
            return _mapper.Map<Count>(_servicoRepository.GetServicoCount());
        }

        public ServicoViewModel GetServicoById(int servicoId)
        {
            return _mapper.Map<ServicoViewModel>(_servicoRepository.GetServicoById(servicoId));
        }

        public IList<ServicoViewModel> GetServicoByClienteVeiculoId(int clienteVeiculoId)
        {
            return _mapper.Map<IList<ServicoViewModel>>(_servicoRepository.GetServicoByClienteVeiculoId(clienteVeiculoId));
        }

        public int AtualizarOrSalvar(ServicoViewModel model)
        {
            var servico = _servicoRepository.GetServicoById(model.ServicoId);

            if (servico == null)
            {
                return _servicoRepository.SalvarServico(new Servico()
                {
                    ClienteVeiculoId = model.ClienteVeiculoId,
                    ColaboradorId = model.ColaboradorId,
                    Descricao = model.Descricao,
                    ValorMaodeObra = model.ValorMaodeObra,
                    ValorPeca = model.ValorPeca,
                    ValorAdicional = model.ValorAdicional,
                    PercentualDesconto = model.PercentualDesconto,
                    ValorDesconto = model.ValorDesconto,
                    ValorTotal = model.ValorTotal,
                    Status = (int)StatusEnum.IniciadoPendente,
                    Ativo = true,
                    DataCadastro = DateTime.Now,
                    DataAlteracao = null
                });
            }
            else
            {
                _servicoRepository.AtualizarServico(new Servico()
                {
                    ServicoId = model.ServicoId,
                    ClienteVeiculoId = model.ClienteVeiculoId,
                    ColaboradorId = model.ColaboradorId,
                    Descricao = model.Descricao,
                    ValorMaodeObra = model.ValorMaodeObra,
                    ValorPeca = model.ValorPeca,
                    ValorAdicional = model.ValorAdicional,
                    PercentualDesconto = model.PercentualDesconto,
                    ValorDesconto = model.ValorDesconto,
                    ValorTotal = model.ValorTotal,
                    Status = model.Status,
                    Ativo = model.Ativo,
                    DataCadastro = servico.DataCadastro,
                    DataAlteracao = DateTime.Now
                });

                return 0;
            }
        }

        public int SalvarServicoMaodeObra(ServicoMaodeObraViewModel servicoMaodeObraViewModel)
        {
            return _servicoRepository.SalvarServicoMaodeObra(_mapper.Map<ServicoMaodeObra>(servicoMaodeObraViewModel));
        }

        public int SalvarServicoPeca(ServicoPecaViewModel servicoPecaViewModel)
        {
            return _servicoRepository.SalvarServicoPeca(_mapper.Map<ServicoPeca>(servicoPecaViewModel));
        }

        public void DeletarServicoMaodeObra(ServicoMaodeObraViewModel servicoMaodeObraViewModel)
        {
            _servicoRepository.DeletarServicoMaodeObra(_mapper.Map<ServicoMaodeObra>(servicoMaodeObraViewModel));
        }

        public void DeletarServicoPeca(ServicoPecaViewModel servicoPecaViewModel)
        {
            _servicoRepository.DeletarServicoPeca(_mapper.Map<ServicoPeca>(servicoPecaViewModel));
        }

        public IList<ServicoMaodeObraViewModel> GetServicoMaodeObraByServicoId(int servicoId)
        {
            return _mapper.Map<IList<ServicoMaodeObraViewModel>>(_servicoRepository.GetServicoMaodeObraByServicoId(servicoId));
        }

        public IList<ServicoPecaViewModel> GetServicoPecaByServicoId(int servicoId)
        {
            return _mapper.Map<IList<ServicoPecaViewModel>>(_servicoRepository.GetServicoPecaByServicoId(servicoId));
        }
    }
}