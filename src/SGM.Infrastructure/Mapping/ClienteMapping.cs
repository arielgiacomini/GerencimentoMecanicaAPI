using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SGM.Domain.Entities;

namespace SGM.Infrastructure.Mapping
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente");
            builder.HasKey(x => x.ClienteId);
            builder.Property(x => x.ClienteId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.NomeCliente);
            builder.Property(x => x.Apelido);
            builder.Property(x => x.DocumentoCliente);
            builder.Property(x => x.Sexo);
            builder.Property(x => x.EstadoCivil);
            builder.Property(x => x.DataNascimento);
            builder.Property(x => x.Email);
            builder.Property(x => x.TelefoneFixo);
            builder.Property(x => x.TelefoneCelular);
            builder.Property(x => x.TelefoneOutros);
            builder.Property(x => x.LogradouroCEP);
            builder.Property(x => x.LogradouroNome);
            builder.Property(x => x.LogradouroNumero);
            builder.Property(x => x.LogradouroComplemento);
            builder.Property(x => x.LogradouroMunicipio);
            builder.Property(x => x.LogradouroBairro);
            builder.Property(x => x.LogradouroUF);
            builder.Property(x => x.RecebeNotificacoes);
            builder.Property(x => x.DataCadastro);
            builder.Property(x => x.DataAlteracao);
        }
    }
}