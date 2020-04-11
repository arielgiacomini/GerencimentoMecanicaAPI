using System;

namespace SGM.Domain.Entities
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public bool VeiculoAtivo { get; set; }
        public DateTime DataCadastro { get; set; }
    }
}