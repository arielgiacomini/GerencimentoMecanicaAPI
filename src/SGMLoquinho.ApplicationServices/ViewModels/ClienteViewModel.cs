﻿using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace SGMLoquinho.ApplicationServices.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
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
        [JsonIgnore]
        public DateTime? DataCadastro { get; set; }
        [JsonIgnore]
        public DateTime? DataAlteracao { get; set; }
    }
}
