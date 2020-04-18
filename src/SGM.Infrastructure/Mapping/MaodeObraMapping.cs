using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGM.Domain.Entities;

namespace SGM.Infrastructure.Mapping
{
    public class MaodeObraMapping : IEntityTypeConfiguration<MaodeObra>
    {
        public void Configure(EntityTypeBuilder<MaodeObra> builder)
        {
            builder.ToTable("MaodeObra");
            builder.HasKey(x => x.MaodeObraId);
            builder.Property(x => x.MaodeObraId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Descricao);
            builder.Property(x => x.Tipo);
            builder.Property(x => x.Valor);
            builder.Property(x => x.VigenciaInicial);
            builder.Property(x => x.VigenciaFinal);
            builder.Property(x => x.Ativo);
            builder.Property(x => x.DataCadastro);
        }
    }
}
