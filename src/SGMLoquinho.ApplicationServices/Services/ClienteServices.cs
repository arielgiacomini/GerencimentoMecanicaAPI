﻿using AutoMapper;
using SGMLoquinho.ApplicationServices.Interfaces;
using SGMLoquinho.ApplicationServices.ViewModels;
using SGMLoquinho.Domain.Entities;
using SGMLoquinho.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;

namespace SGMLoquinho.ApplicationServices.Services
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

        public void Salvar(ClienteViewModel model)
        {
            var entidade = _mapper.Map<Cliente>(model);
            _clienteRepository.Salvar(entidade);
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
                    DataCadastro = DateTime.Now
                });
            }
            else
            {
                _clienteRepository.Atualizar(new Cliente()
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
                    DataAlteracao = DateTime.Now
                });
            }
        }
    }
}
