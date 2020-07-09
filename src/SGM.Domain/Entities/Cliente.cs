using System;
using System.Collections.Generic;

namespace SGM.Domain.Entities
{
    public class Cliente
    {

        public Cliente(
            string nomeCliente, string apelido, string documentoCliente, string sexo, string estadoCivil, DateTime dataNascimento, string email, string telefoneFixo, string telefoneCelular,
            string telefoneOutros, string logradouroCEP, string logradouroNome, string logradouroNumero, string logradouroComplemento, string logradouroMunicipio, string logradouroBairro,
            string logradouroUF, bool recebeNotificacao, bool clienteAtivo, DateTime dataCadastro, DateTime? dataAlteracao
            )
        {
            NomeCliente = nomeCliente;
            Apelido = apelido;
            DocumentoCliente = documentoCliente;
            Sexo = sexo;
            EstadoCivil = estadoCivil;
            DataNascimento = dataNascimento;
            Email = email;
            TelefoneFixo = telefoneFixo;
            TelefoneCelular = telefoneCelular;
            TelefoneOutros = telefoneOutros;
            LogradouroCEP = logradouroCEP;
            LogradouroNome = logradouroNome;
            LogradouroNumero = logradouroNumero;
            LogradouroComplemento = logradouroComplemento;
            LogradouroMunicipio = logradouroMunicipio;
            LogradouroBairro = logradouroBairro;
            LogradouroUF = logradouroUF;
            RecebeNotificacoes = recebeNotificacao;
            ClienteAtivo = clienteAtivo;
            DataCadastro = dataCadastro;
            DataAlteracao = dataAlteracao;
        }

        public int ClienteId { get; set; }
        public string NomeCliente { get; set; }
        public string Apelido { get; set; }
        public string DocumentoCliente { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }
        public string TelefoneFixo { get; set; }
        public string TelefoneCelular { get; set; }
        public string TelefoneOutros { get; set; }
        public string LogradouroCEP { get; set; }
        public string LogradouroNome { get; set; }
        public string LogradouroNumero { get; set; }
        public string LogradouroComplemento { get; set; }
        public string LogradouroMunicipio { get; set; }
        public string LogradouroBairro { get; set; }
        public string LogradouroUF { get; set; }
        public bool RecebeNotificacoes { get; set; }
        public bool ClienteAtivo { get; set; }
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public virtual IEnumerable<ClienteVeiculo> ClienteVeiculo { get; set; }
    }
}