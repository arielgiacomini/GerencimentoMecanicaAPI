using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGM.Domain.Entities;

namespace SGM.Infrastructure.Mapping
{
    public class OrcamentoMaodeObraMapping : IEntityTypeConfiguration<OrcamentoMaodeObra>
    {
        public void Configure(EntityTypeBuilder<OrcamentoMaodeObra> builder)
        {
            builder.ToTable("OrcamentoMaodeObra");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.OrcamentoId);
            builder.Property(x => x.MaodeObraId);
        }
    }
}