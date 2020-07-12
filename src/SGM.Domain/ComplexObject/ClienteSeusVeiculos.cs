using SGM.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGM.Domain.ComplexObject
{
    public class ClienteSeusVeiculos
    {
        public int ClienteVeiculoId { get; set; }
        public int ClienteId { get; set; }
        public int VeiculoId { get; set; }
        public string PlacaVeiculo { get; set; }
        public string CorVeiculo { get; set; }
        public int KmRodados { get; set; }
        public int AnoVeiculo { get; set; }

        [ForeignKey("ClienteId")]
        public virtual ClienteComplex Cliente { get; set; }

        [ForeignKey("VeiculoId")]
        public virtual Veiculo Veiculo { get; set; }

        public virtual IEnumerable<ClienteSeusOrcamentos> Orcamento { get; set; }
    }
}
