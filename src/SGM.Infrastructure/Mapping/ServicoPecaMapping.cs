using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGM.Domain.Entities;

namespace SGM.Infrastructure.Mapping
{
    public class ServicoPecaMapping : IEntityTypeConfiguration<ServicoPeca>
    {
        public void Configure(EntityTypeBuilder<ServicoPeca> builder)
        {
            builder.ToTable("ServicoPeca");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.ServicoId);
            builder.Property(x => x.PecaId);
        }
    }
}