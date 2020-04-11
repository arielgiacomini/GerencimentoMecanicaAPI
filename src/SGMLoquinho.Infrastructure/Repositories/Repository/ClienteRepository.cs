using SGMLoquinho.Domain.Entities;
using SGMLoquinho.Infrastructure.Context;
using SGMLoquinho.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SGMLoquinho.Infrastructure.Repositories.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly SGMLoquinhoContext _sGMLoquinhoContext;

        public ClienteRepository(SGMLoquinhoContext context)
        {
            _sGMLoquinhoContext = context;
        }

        public IEnumerable<Cliente> GetByAll()
        {
            return _sGMLoquinhoContext.Cliente.ToList();
        }

        public Cliente GetById(int clienteId)
        {
            return _sGMLoquinhoContext.Cliente.Where(x => x.ClienteId == clienteId).FirstOrDefault();
        }

        public void Salvar(Cliente entidade)
        {
            _sGMLoquinhoContext.Cliente.Add(entidade);
            _sGMLoquinhoContext.SaveChanges();
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

            _sGMLoquinhoContext.Update(cliente);
            _sGMLoquinhoContext.SaveChanges();
        }
    }
}
