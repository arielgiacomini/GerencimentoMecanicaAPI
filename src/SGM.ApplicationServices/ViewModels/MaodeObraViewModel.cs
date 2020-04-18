using System;

namespace SGM.ApplicationServices.ViewModels
{
    public class MaodeObraViewModel
    {
        public int MaodeObraId { get; set; }
        public string Descricao { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public DateTime VigenciaInicial { get; set; }
        public DateTime VigenciaFinal { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}
