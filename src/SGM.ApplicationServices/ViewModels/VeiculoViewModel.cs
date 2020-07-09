using System;

namespace SGM.ApplicationServices.ViewModels
{
    public class VeiculoViewModel
    {
        public int VeiculoId { get; set; }
        public Int64 CodigoFipe { get; set; }
        public int MarcaId { get; set; }
        public string Modelo { get; set; }
        public bool VeiculoAtivo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}