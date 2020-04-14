using System;

namespace SGM.ApplicationServices.ViewModels
{
    public class OrcamentoViewModel
    {
        public int OrcamentoId { get; set; }
        public int ClienteId { get; set; }
        public string Descricao { get; set; }
        public decimal ValorAdicional { get; set; }
        public decimal PercentualDesconto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorTotal { get; set; }
        public int StatusId { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
