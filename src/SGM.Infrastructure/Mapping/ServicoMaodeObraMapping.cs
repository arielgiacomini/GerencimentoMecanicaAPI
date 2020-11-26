using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGM.Domain.Entities;

namespace SGM.Infrastructure.Mapping
{
    public class ServicoMaodeObraMapping : IEntityTypeConfiguration<ServicoMaodeObra>
    {
        public void Configure(EntityTypeBuilder<ServicoMaodeObra> builder)
        {
            builder.ToTable("ServicoMaodeObra");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.ServicoId);
            builder.Property(x => x.MaodeObraId);
        }
    }
}