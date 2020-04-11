namespace SGM.ApplicationServices.ViewModels
{
    public class ClienteVeiculoViewModel
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public int VeiculoId { get; set; }
        public int AnoVeiculo { get; set; }
        public string PlacaVeiculo { get; set; }
        public string CorVeiculo { get; set; }
        public decimal KmRodados { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }
    }
}
