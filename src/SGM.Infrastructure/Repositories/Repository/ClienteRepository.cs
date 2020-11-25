﻿using Microsoft.EntityFrameworkCore;
using SGM.Domain.Entities;
using SGM.Domain.Utils;
using SGM.Infrastructure.Context;
using SGM.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGM.Infrastructure.Repositories.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly SGMContext _SGMContext;

        public ClienteRepository(SGMContext context)
        {
            _SGMContext = context;
        }

        public IEnumerable<Cliente> GetByAll()
        {
            return _SGMContext.Cliente.AsNoTracking().Where(cliente => cliente.ClienteAtivo).ToList();
        }

        public Cliente GetById(int clienteId)
        {
            return _SGMContext.Cliente.AsNoTracking().Where(x => x.ClienteId == clienteId).FirstOrDefault();
        }

        public Count GetCount()
        {
            var contagem = GetByAll().Count();

            Count cont = new Count();
            {
                cont.Contagem = contagem;
            }

            return cont;
        }

        public int Salvar(Cliente entidade)
        {
            entidade.DataCadastro = DateTime.Now;
            entidade.ClienteAtivo = true;

            _SGMContext.Cliente.Add(entidade);
            _SGMContext.SaveChanges();

            return entidade.ClienteId;
        }

        public Cliente GetClienteByDocumentoCliente(string documentoCliente)
        {
            return _SGMContext.Cliente.AsNoTracking().Where(cliente => cliente.DocumentoCliente.Replace(".", "").Replace("-", "") == documentoCliente.Replace(".", "").Replace("-", "") && cliente.ClienteAtivo).FirstOrDefault();
        }

        public void InativarCliente(int clienteId)
        {
            var cliente = GetById(clienteId);

            cliente.DataAlteracao = DateTime.Now;
            cliente.ClienteAtivo = false;

            _SGMContext.Update(cliente);
            _SGMContext.SaveChanges();

        }

        public void Atualizar(Cliente entidade)
        {
            var cliente = GetById(entidade.ClienteId);
            cliente.NomeCliente = entidade.NomeCliente;
            cliente.Apelido = entidade.Apelido;
            cliente.DocumentoCliente = entidade.DocumentoCliente;
            cliente.Sexo = entidade.Sexo;
            cliente.EstadoCivil = entidade.EstadoCivil;
            cliente.DataNascimento = entidade.DataNascimento;
            cliente.Email = entidade.Email;
            cliente.TelefoneFixo = entidade.TelefoneFixo;
            cliente.TelefoneCelular = entidade.TelefoneCelular;
            cliente.TelefoneOutros = entidade.TelefoneOutros;
            cliente.LogradouroCEP = entidade.LogradouroCEP;
            cliente.LogradouroNome = entidade.LogradouroNome;
            cliente.LogradouroNumero = entidade.LogradouroNumero;
            cliente.LogradouroComplemento = entidade.LogradouroComplemento;
            cliente.LogradouroMunicipio = entidade.LogradouroMunicipio;
            cliente.LogradouroBairro = entidade.LogradouroBairro;
            cliente.LogradouroUF = entidade.LogradouroUF;
            cliente.RecebeNotificacoes = entidade.RecebeNotificacoes;
            cliente.ClienteAtivo = entidade.ClienteAtivo;
            cliente.DataAlteracao = DateTime.Now;

            _SGMContext.Update(cliente);
            _SGMContext.SaveChanges();
        }

        /*
         * COMENTADO, POIS PARA FUNCIONAR É PRECISO
         * 
        public IEnumerable<ClienteComplex> GetByAllPaginado(int page)
        {
            var clienteSeusVeiculos = _SGMContext
                                            .ClienteComplex
                                            .Include(x => x.ClienteVeiculo)
                                            .ThenInclude(g => g.Orcamento)
                                            .Include(x => x.ClienteVeiculo)
                                            .ThenInclude(c => c.Veiculo)
                                            .ToList();

            return clienteSeusVeiculos.Skip((page - 1) * 5).Take(5).ToList();
        }
        */
    }
}
