using SGM.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SGM.Domain.ComplexObject
{
    public class ClienteSeusVeiculos
    {
        [ForeignKey("ClienteId")]
        public virtual ClienteComplex Cliente { get; set; }

        [ForeignKey("VeiculoId")]
        public virtual Veiculo Veiculo { get; set; }

        public virtual IEnumerable<ClienteSeusOrcamentos> Orcamento { get; set; }
    }
}
