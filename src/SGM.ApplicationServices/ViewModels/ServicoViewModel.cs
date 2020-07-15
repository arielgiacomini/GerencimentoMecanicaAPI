using System;

namespace SGM.ApplicationServices.ViewModels
{
    public class ServicoViewModel
    {
        public int ServicoId { get; set; }
        //public int ClienteId { get; set; }
        public int ClienteVeiculoId { get; set; }
        public string Descricao { get; set; }
        public decimal ValorAdicional { get; set; }
        public decimal PercentualDesconto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorTotal { get; set; }
        public int Status { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}