using System;

namespace SGM.Domain.Entities
{
    public class ClienteVeiculo
    {
        public int ClienteVeiculoId { get; set; }
        public int ClienteId { get; set; }
        public int VeiculoId { get; set; }
        public string PlacaVeiculo { get; set; }
        public string CorVeiculo { get; set; }
        public int KmRodados { get; set; }
        public int AnoVeiculo { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }
        public DateTime? DataAlteracao { get; set; }
    }
}