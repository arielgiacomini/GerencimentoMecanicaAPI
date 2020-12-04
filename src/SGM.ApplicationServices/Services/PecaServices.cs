using AutoMapper;
using SGM.ApplicationServices.Interfaces;
using SGM.ApplicationServices.ViewModels;
using SGM.Domain.Utils;
using SGM.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace SGM.ApplicationServices.Services
{
    public class PecaServices : IPecaServices
    {
        private readonly IPecaRepository _PecaRepository;
        private readonly IMapper _mapper;

        public PecaServices(IPecaRepository PecaRepository, IMapper mapper)
        {
            _PecaRepository = PecaRepository;
            _mapper = mapper;
        }

        public IEnumerable<PecaViewModel> GetPecaByAll()
        {
            return _mapper.Map<IEnumerable<PecaViewModel>>(_PecaRepository.GetPecaByAll());
        }

        public IEnumerable<PecaViewModel> GetPecaByAllPaginado(int page)
        {
            return _mapper.Map<IEnumerable<PecaViewModel>>(_PecaRepository.GetPecaByAllPaginado(page));
        }

        public Count GetPecaCount()
        {
            return _mapper.Map<Count>(_PecaRepository.GetPecaCount());
        }

        public PecaViewModel GetPecaById(int PecaId)
        {
            return _mapper.Map<PecaViewModel>(_PecaRepository.GetById(PecaId));
        }

        public IList<PecaViewModel> GetPecaByDescricao(string descricao)
        {
            return _mapper.Map<IList<PecaViewModel>>(_PecaRepository.GetPecaByDescricao(descricao));
        }

        public void InativarPeca(int pecaId)
        {
            _PecaRepository.InativarPeca(pecaId);
        }

        public void AtualizarOrSalvar(PecaViewModel model)
        {
            var Peca = _PecaRepository.GetById(model.PecaId);

            if (Peca == null)
            {
                _PecaRepository.Salvar(new Domain.Entities.Peca()
                {
                    PecaId = model.PecaId,
                    Descricao = model.Descricao,
                    Fornecedor = model.Fornecedor,
                    Valor = model.Valor,
                    ValorFrete = model.ValorFrete,
                    DataCadastro = DateTime.Now,
                    Ativo = true
                });
            }
            else
            {
                _PecaRepository.Atualizar(new Domain.Entities.Peca()
                {
                    PecaId = model.PecaId,
                    Descricao = model.Descricao,
                    Fornecedor = model.Fornecedor,
                    Valor = model.Valor,
                    ValorFrete = model.ValorFrete,
                    Ativo = model.Ativo
                });
            }
        }
    }
}