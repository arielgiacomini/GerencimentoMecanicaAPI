using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGM.Domain.Entities;

namespace SGM.Infrastructure.Mapping
{
    public class PecaMapping : IEntityTypeConfiguration<Peca>
    {
        public void Configure(EntityTypeBuilder<Peca> builder)
        {
            builder.ToTable("Peca");
            builder.HasKey(x => x.PecaId);
            builder.Property(x => x.PecaId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Descricao);
            builder.Property(x => x.Fornecedor);
            builder.Property(x => x.Valor);
            builder.Property(x => x.ValorFrete);
            builder.Property(x => x.Ativo);
            builder.Property(x => x.DataCadastro);
        }
    }
}