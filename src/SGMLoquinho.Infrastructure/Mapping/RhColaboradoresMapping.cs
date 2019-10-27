using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGMLoquinho.Domain.Entities;

namespace SGMLoquinho.Infrastructure.Mapping
{
    public class RhColaboradoresMapping : IEntityTypeConfiguration<RhColaboradores>
    {
        public void Configure(EntityTypeBuilder<RhColaboradores> builder)
        {
            builder.ToTable("RhColaboradores");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Usuario);
            builder.Property(x => x.Nome);
            builder.Property(x => x.NomeCompleto);
            builder.Property(x => x.CPF);
            builder.Property(x => x.DataNascimento);
            builder.Property(x => x.EmailPessoal);
            builder.Property(x => x.EmailProfissional);
            builder.Property(x => x.DataAdmissao);
            builder.Property(x => x.DataDemissao);
            builder.Property(x => x.Ativo);
        }
    }
}