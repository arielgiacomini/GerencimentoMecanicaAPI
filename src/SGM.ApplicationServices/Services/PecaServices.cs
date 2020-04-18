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

        public IEnumerable<PecaViewModel> GetByAll()
        {
            return _mapper.Map<IEnumerable<PecaViewModel>>(_PecaRepository.GetByAll());
        }

        public IEnumerable<PecaViewModel> GetByAllPaginado(int page)
        {
            return _mapper.Map<IEnumerable<PecaViewModel>>(_PecaRepository.GetByAllPaginado(page));
        }

        public Count GetCount()
        {
            return _mapper.Map<Count>(_PecaRepository.GetCount());
        }

        public PecaViewModel GetById(int PecaId)
        {
            return _mapper.Map<PecaViewModel>(_PecaRepository.GetById(PecaId));
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
