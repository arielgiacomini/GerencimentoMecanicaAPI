using SGM.Domain.Entities;

namespace SGM.Domain.ComplexObject
{
    public class ClienteSeusVeiculosOrcamentos
    {
        public Cliente Cliente { get; set; }
        public ClienteVeiculo ClienteVeiculo { get; set; }
    }
}