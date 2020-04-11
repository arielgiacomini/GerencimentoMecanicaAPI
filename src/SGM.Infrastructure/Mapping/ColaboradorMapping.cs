using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGM.Domain.Entities;

namespace SGM.Infrastructure.Mapping
{
    public class ColaboradorMapping : IEntityTypeConfiguration<Colaborador>
    {
        public void Configure(EntityTypeBuilder<Colaborador> builder)
        {
            builder.ToTable("Colaborador");
            builder.HasKey(x => x.ColaboradorId);
            builder.Property(x => x.ColaboradorId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Usuario);
            builder.Property(x => x.Senha);
            builder.Property(x => x.Nome);
            builder.Property(x => x.NomeCompleto);
            builder.Property(x => x.Apelido);
            builder.Property(x => x.CPF);
            builder.Property(x => x.RG);
            builder.Property(x => x.DataAdmissao);
            builder.Property(x => x.DataDemissao);
            builder.Property(x => x.DataCadastro);
            builder.Property(x => x.DataAlteracao);
        }
    }
}