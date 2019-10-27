using System;

namespace SGMLoquinho.Domain.Entities
{
    public class RhColaboradores
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Nome { get; set; }
        public string NomeCompleto { get; set; }
        public string CPF { get; set; }
        public DateTime DataNascimento { get; set; }
        public string EmailPessoal { get; set; }
        public string EmailProfissional { get; set; }
        public DateTime DataAdmissao { get; set; }
        public DateTime DataDemissao { get; set; }
        public bool Ativo { get; set; }
    }
}
