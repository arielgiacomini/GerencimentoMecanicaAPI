using SGM.Domain.Entities;
using System.Collections.Generic;

namespace SGM.Domain.ComplexObject
{
    public class ClienteSeusServicos
    {
        public Cliente Cliente { get; set; }
        public IList<Orcamento> Servicos { get; set; }
    }
}
