using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGM.Domain.Entities;

namespace SGM.Infrastructure.Mapping
{
    public class ClienteVeiculoMapping : IEntityTypeConfiguration<ClienteVeiculo>
    {
        public void Configure(EntityTypeBuilder<ClienteVeiculo> builder)
        {
            builder.ToTable("ClienteVeiculo");
            builder.HasKey(x => x.ClienteVeiculoId);
            builder.Property(x => x.ClienteVeiculoId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.ClienteId);
            builder.Property(x => x.VeiculoId);
            builder.Property(x => x.AnoVeiculo);
            builder.Property(x => x.PlacaVeiculo);
            builder.Property(x => x.CorVeiculo);
            builder.Property(x => x.KmRodados);
        }
    }
}