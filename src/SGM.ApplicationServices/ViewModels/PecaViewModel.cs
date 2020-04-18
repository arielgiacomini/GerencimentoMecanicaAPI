using System;

namespace SGM.ApplicationServices.ViewModels
{
    public class PecaViewModel
    {
        public int PecaId { get; set; }
        public string Descricao { get; set; }
        public string Fornecedor { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorFrete { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
