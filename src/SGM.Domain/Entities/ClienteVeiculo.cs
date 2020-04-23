using System.ComponentModel.DataAnnotations.Schema;

namespace SGM.Domain.Entities
{
    public class ClienteVeiculo
    {
        public int ClienteVeiculoId { get; set; }
        public int ClienteId { get; set; }
        public int VeiculoId { get; set; }
        public int AnoVeiculo { get; set; }
        public string PlacaVeiculo { get; set; }
        public string CorVeiculo { get; set; }
        public int KmRodados { get; set; }
        [ForeignKey("ClienteId")]
        public virtual Cliente Cliente { get; set; }
        [ForeignKey("VeiculoId")]
        public virtual Veiculo Veiculo { get; set; }
    }
}