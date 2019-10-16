using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGMLoquinho.Domain.Entities;

namespace SGMLoquinho.Infrastructure.Mapping
{
    public class VeiculoMapping : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {
            builder.ToTable("Veiculo");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Marca);
            builder.Property(x => x.Modelo);
        }
    }
}
