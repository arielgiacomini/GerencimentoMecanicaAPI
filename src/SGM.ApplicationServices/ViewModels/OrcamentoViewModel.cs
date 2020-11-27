using System;
using System.Collections.Generic;

namespace SGM.ApplicationServices.ViewModels
{
    public class OrcamentoViewModel
    {
        public int OrcamentoId { get; set; }
        public int ClienteVeiculoId { get; set; }
        public int ColaboradorId { get; set; }
        public string Descricao { get; set; }
        public decimal ValorMaodeObra { get; set; }
        public decimal ValorPeca { get; set; }
        public decimal ValorAdicional { get; set; }
        public decimal PercentualDesconto { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorTotal { get; set; }
        public int Status { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public virtual IList<OrcamentoMaodeObraViewModel> OrcamentoMaodeObra { get; set; }
        public virtual IList<OrcamentoPecaViewModel> OrcamentoPeca { get; set; }
    }
}