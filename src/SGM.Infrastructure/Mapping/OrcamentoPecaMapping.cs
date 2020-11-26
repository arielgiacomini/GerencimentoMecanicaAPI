using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGM.Domain.Entities;

namespace SGM.Infrastructure.Mapping
{
    public class OrcamentoPecaMapping : IEntityTypeConfiguration<OrcamentoPeca>
    {
        public void Configure(EntityTypeBuilder<OrcamentoPeca> builder)
        {
            builder.ToTable("OrcamentoPeca");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.OrcamentoId);
            builder.Property(x => x.PecaId);
        }
    }
}