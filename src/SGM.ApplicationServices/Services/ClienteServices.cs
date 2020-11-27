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
    public class ClienteServices : IClienteServices
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMapper _mapper;

        public ClienteServices(IClienteRepository clienteRepository, IMapper mapper)
        {
            _clienteRepository = clienteRepository;
            _mapper = mapper;
        }

        public IEnumerable<ClienteViewModel> GetByAll()
        {
            return _mapper.Map<IEnumerable<ClienteViewModel>>(_clienteRepository.GetByAll());
        }

        public ClienteViewModel GetById(int clienteId)
        {
            return _mapper.Map<ClienteViewModel>(_clienteRepository.GetById(clienteId));
        }

        public Count GetCount()
        {
            return _mapper.Map<Count>(_clienteRepository.GetCount());
        }

        public ClienteViewModel GetClienteByDocumentoCliente(string documentoCliente)
        {
            return _mapper.Map<ClienteViewModel>(_clienteRepository.GetClienteByDocumentoCliente(documentoCliente));
        }

        public ClienteViewModel GetClienteByPlacaVeiculo(string placaVeiculo)
        {
            return _mapper.Map<ClienteViewModel>(_clienteRepository.GetClienteByPlacaVeiculo(placaVeiculo));
        }

        public ClienteViewModel GetClienteByLikePlacaOrNomeOrApelido(string valor)
        {
            return _mapper.Map<ClienteViewModel>(_clienteRepository.GetClienteByLikePlacaOrNomeOrApelido(valor));
        }

        public int Salvar(ClienteViewModel model)
        {
            var entidade = _mapper.Map<Cliente>(model);
            entidade.DataAlteracao = null;
            return _clienteRepository.Salvar(entidade);
        }

        public void InativarCliente(int solicitacaoId)
        {
            _clienteRepository.InativarCliente(solicitacaoId);
        }

        public void Atualizar(ClienteViewModel model)
        {
            var cliente = _clienteRepository.GetById(model.ClienteId);

            if (cliente == null)
            {
                _clienteRepository.Salvar(new Cliente()
                {
                    NomeCliente = model.NomeCliente,
                    Apelido = model.Apelido,
                    DocumentoCliente = model.DocumentoCliente,
                    Sexo = model.Sexo,
                    EstadoCivil = model.EstadoCivil,
                    DataNascimento = model.DataNascimento,
                    Email = model.Email,
                    TelefoneFixo = model.TelefoneFixo,
                    TelefoneCelular = model.TelefoneCelular,
                    TelefoneOutros = model.TelefoneOutros,
                    LogradouroCEP = model.LogradouroCEP,
                    LogradouroNome = model.LogradouroNome,
                    LogradouroNumero = model.LogradouroNumero,
                    LogradouroComplemento = model.LogradouroComplemento,
                    LogradouroMunicipio = model.LogradouroMunicipio,
                    LogradouroBairro = model.LogradouroBairro,
                    LogradouroUF = model.LogradouroUF,
                    RecebeNotificacoes = model.RecebeNotificacoes,
                    ClienteAtivo = true,
                    DataCadastro = DateTime.Now,
                    DataAlteracao = null
                });
            }
            else
            {
                _clienteRepository.Atualizar(new Cliente()
                {
                    ClienteId = cliente.ClienteId,
                    NomeCliente = model.NomeCliente,
                    Apelido = model.Apelido,
                    DocumentoCliente = model.DocumentoCliente,
                    Sexo = model.Sexo,
                    EstadoCivil = model.EstadoCivil,
                    DataNascimento = model.DataNascimento,
                    Email = model.Email,
                    TelefoneFixo = model.TelefoneFixo,
                    TelefoneCelular = model.TelefoneCelular,
                    TelefoneOutros = model.TelefoneOutros,
                    LogradouroCEP = model.LogradouroCEP,
                    LogradouroNome = model.LogradouroNome,
                    LogradouroNumero = model.LogradouroNumero,
                    LogradouroComplemento = model.LogradouroComplemento,
                    LogradouroMunicipio = model.LogradouroMunicipio,
                    LogradouroBairro = model.LogradouroBairro,
                    LogradouroUF = model.LogradouroUF,
                    RecebeNotificacoes = model.RecebeNotificacoes,
                    ClienteAtivo = model.ClienteAtivo,
                    DataAlteracao = DateTime.Now
                });
            }
        }

        /*
         * COMENTADO, POIS PARA FUNCIONAR É PRECISO
         * 
        public IEnumerable<ClienteViewModel> GetByAllPaginado(int page)
        {
            return _mapper.Map<IEnumerable<ClienteViewModel>>(_clienteRepository.GetByAllPaginado(page));
        }
        */
    }
}