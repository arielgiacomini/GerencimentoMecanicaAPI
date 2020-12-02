using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGM.Domain.Entities;

namespace SGM.Infrastructure.Mapping
{
    public class ServicoMapping : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.ToTable("Servico");
            builder.HasKey(x => x.ServicoId);
            builder.Property(x => x.ServicoId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.ClienteVeiculoId);
            builder.Property(x => x.Descricao);
            builder.Property(x => x.ValorAdicional);
            builder.Property(x => x.PercentualDesconto);
            builder.Property(x => x.ValorDesconto);
            builder.Property(x => x.ValorTotal);
            builder.Property(x => x.Status);
            builder.Property(x => x.Ativo);
            builder.Property(x => x.DataCadastro);
        }
    }
}