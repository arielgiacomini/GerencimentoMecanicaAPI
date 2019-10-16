using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace SGMLoquinho.ApplicationServices.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome.")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres.")]
        [MinLength(2, ErrorMessage = "Minímo de {0} caracteres.")]
        public string NomeCliente { get; set; }
        public string Apelido { get; set; }
        public string DocumentoCliente { get; set; }
        public string Sexo { get; set; }
        public string EstadoCivil { get; set; }
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail.")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres.")]
        [EmailAddress(ErrorMessage = "Preencha um E-mail válido.")]
        [Display(Name = "E-mail")]
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
        //public virtual IEnumerable<ClienteVeiculoViewModel> ClienteVeiculo { get; set; }
    }
}
