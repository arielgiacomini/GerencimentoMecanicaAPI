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
                _clienteRepository.Salvar(
                    new Cliente
                        (
                            model.NomeCliente, 
                            model.Apelido, 
                            model.DocumentoCliente, 
                            model.Sexo, 
                            model.EstadoCivil, 
                            model.DataNascimento, 
                            model.Email, 
                            model.TelefoneFixo, 
                            model.TelefoneCelular, 
                            model.TelefoneOutros, 
                            model.LogradouroCEP, 
                            model.LogradouroNome, 
                            model.LogradouroNumero,
                            model.LogradouroComplemento, 
                            model.LogradouroMunicipio, 
                            model.LogradouroBairro, 
                            model.LogradouroUF,
                            model.RecebeNotificacoes,
                            model.ClienteAtivo,
                            DateTime.Now, 
                            null)
                {

                });
            }
            else
            {
                _clienteRepository.Atualizar(new Cliente
                        (
                            model.NomeCliente,
                            model.Apelido,
                            model.DocumentoCliente,
                            model.Sexo,
                            model.EstadoCivil,
                            model.DataNascimento,
                            model.Email,
                            model.TelefoneFixo,
                            model.TelefoneCelular,
                            model.TelefoneOutros,
                            model.LogradouroCEP,
                            model.LogradouroNome,
                            model.LogradouroNumero,
                            model.LogradouroComplemento,
                            model.LogradouroMunicipio,
                            model.LogradouroBairro,
                            model.LogradouroUF,
                            model.RecebeNotificacoes,
                            model.ClienteAtivo,
                            DateTime.Now,
                            DateTime.Now)
                {
                
                });
            }
        }

        public IEnumerable<ClienteViewModel> GetByAllPaginado(int page)
        {
            return _mapper.Map<IEnumerable<ClienteViewModel>>(_clienteRepository.GetByAllPaginado(page));
        }
    }
}