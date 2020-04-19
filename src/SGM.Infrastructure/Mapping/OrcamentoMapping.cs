using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGM.Domain.Entities;

namespace SGM.Infrastructure.Mapping
{
    public class OrcamentoMapping : IEntityTypeConfiguration<Orcamento>
    {
        public void Configure(EntityTypeBuilder<Orcamento> builder)
        {
            builder.ToTable("Orcamento");
            builder.HasKey(x => x.OrcamentoId);
            builder.Property(x => x.OrcamentoId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.ClienteId);
            builder.Property(x => x.VeiculoId);
            builder.Property(x => x.Descricao);
            builder.Property(x => x.ValorAdicional);
            builder.Property(x => x.PercentualDesconto);
            builder.Property(x => x.ValorDesconto);
            builder.Property(x => x.ValorTotal);
            builder.Property(x => x.StatusId);
            builder.Property(x => x.Ativo);
            builder.Property(x => x.DataCadastro);
        }
    }
}