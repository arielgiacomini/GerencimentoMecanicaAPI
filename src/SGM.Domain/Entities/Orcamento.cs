using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGM.Domain.Entities
{
    public class Orcamento
    {
        public int OrcamentoId { get; set; }
        public int ClienteId { get; set; }
        public int ClienteVeiculoId { get; set; }
        public string Descricao { get; set; }
        public decimal ValorAdicional { get; set; }
        public decimal PercentualDesconto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorTotal { get; set; }
        public int StatusId { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }
        [ForeignKey("ClienteVeiculoId")]
        public virtual ClienteVeiculo ClienteVeiculo { get; set; }
    }
}
