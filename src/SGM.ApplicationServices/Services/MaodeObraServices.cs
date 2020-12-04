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
    public class MaodeObraServices : IMaodeObraServices
    {
        private readonly IMaodeObraRepository _maoDeObraRepository;
        private readonly IMapper _mapper;

        public MaodeObraServices(IMaodeObraRepository maodeObraRepository, IMapper mapper)
        {
            _maoDeObraRepository = maodeObraRepository;
            _mapper = mapper;
        }

        public IEnumerable<MaodeObraViewModel> GetMaodeObraByAll()
        {
            return _mapper.Map<IEnumerable<MaodeObraViewModel>>(_maoDeObraRepository.GetMaodeObraByAll());
        }

        public IEnumerable<MaodeObraViewModel> GetMaodeObraByAllPaginado(int page)
        {
            return _mapper.Map<IEnumerable<MaodeObraViewModel>>(_maoDeObraRepository.GetMaodeObraByAllPaginado(page));
        }

        public Count GetMaodeObraCount()
        {
            return _mapper.Map<Count>(_maoDeObraRepository.GetMaodeObraCount());
        }

        public MaodeObraViewModel GetMaodeObraById(int maodeObraId)
        {
            return _mapper.Map<MaodeObraViewModel>(_maoDeObraRepository.GetMaodeObraById(maodeObraId));
        }

        public IList<MaodeObraViewModel> GetMaodeObraByDescricao(string descricao)
        {
            return _mapper.Map<IList<MaodeObraViewModel>>(_maoDeObraRepository.GetMaodeObraByDescricao(descricao));
        }

        public void InativarMaodeObra(int maoDeObraId)
        {
            var maoDeObra = _maoDeObraRepository.GetMaodeObraById(maoDeObraId);

            _maoDeObraRepository.InativarMaoDeObra(new MaodeObra()
            {
                MaodeObraId = maoDeObra.MaodeObraId,
                Descricao = maoDeObra.Descricao,
                Tipo = maoDeObra.Tipo,
                Valor = maoDeObra.Valor,
                VigenciaInicial = maoDeObra.VigenciaInicial,
                VigenciaFinal = DateTime.Now,
                Ativo = false,
                DataCadastro = maoDeObra.DataCadastro
            });
        }

        public void AtualizarOrSalvar(MaodeObraViewModel model)
        {
            var maoDeObra = _maoDeObraRepository.GetMaodeObraById(model.MaodeObraId);

            if (maoDeObra == null)
            {
                _maoDeObraRepository.Salvar(new MaodeObra()
                {
                    MaodeObraId = model.MaodeObraId,
                    Descricao = model.Descricao,
                    Tipo = model.Tipo,
                    Valor = model.Valor,
                    VigenciaInicial = model.VigenciaInicial,
                    VigenciaFinal = model.VigenciaFinal,
                    Ativo = true,
                    DataCadastro = DateTime.Now
                });
            }
            else
            {
                _maoDeObraRepository.Atualizar(new MaodeObra()
                {
                    MaodeObraId = model.MaodeObraId,
                    Descricao = model.Descricao,
                    Tipo = model.Tipo,
                    Valor = model.Valor,
                    VigenciaInicial = model.VigenciaInicial,
                    VigenciaFinal = model.VigenciaFinal,
                    Ativo = model.Ativo
                });
            }
        }
    }
}