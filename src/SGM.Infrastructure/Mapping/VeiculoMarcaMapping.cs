using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGM.Domain.Entities;

namespace SGM.Infrastructure.Mapping
{
    public class VeiculoMarcaMapping : IEntityTypeConfiguration<VeiculoMarca>
    {
        public void Configure(EntityTypeBuilder<VeiculoMarca> builder)
        {
            builder.ToTable("VeiculoMarca");
            builder.HasKey(x => x.MarcaId);
            builder.Property(x => x.MarcaId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Marca);
            builder.Property(x => x.PesoOrdenacao);
        }
    }
}