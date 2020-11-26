using Microsoft.EntityFrameworkCore;
using SGM.Domain.Entities;
using SGM.Domain.ValueObjects;
using SGM.Infrastructure.Mapping;

namespace SGM.Infrastructure.Context
{
    public class SGMContext : DbContext
    {
        private readonly ConnectionStrings _connectionKeys;

        public SGMContext(ConnectionStrings keys)
        {
            _connectionKeys = keys;
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Colaborador> Colaborador { get; set; }
        public DbSet<Orcamento> Orcamento { get; set; }
        public DbSet<MaodeObra> MaodeObra { get; set; }
        public DbSet<Peca> Peca { get; set; }
        public DbSet<Veiculo> Veiculo { get; set; }
        public DbSet<ClienteVeiculo> ClienteVeiculo { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<VeiculoMarca> VeiculoMarca { get; set; }
        public DbSet<OrcamentoMaodeObra> OrcamentoMaodeObra { get; set; }
        public DbSet<OrcamentoPeca> OrcamentoPeca { get; set; }
        public DbSet<ServicoMaodeObra> ServicoMaodeObra { get; set; }
        public DbSet<ServicoPeca> ServicoPeca { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMapping());
            modelBuilder.ApplyConfiguration(new ColaboradorMapping());
            modelBuilder.ApplyConfiguration(new PecaMapping());
            modelBuilder.ApplyConfiguration(new MaodeObraMapping());
            modelBuilder.ApplyConfiguration(new VeiculoMapping());
            modelBuilder.ApplyConfiguration(new ClienteVeiculoMapping());
            modelBuilder.ApplyConfiguration(new VeiculoMarcaMapping());
            modelBuilder.ApplyConfiguration(new OrcamentoMapping());
            modelBuilder.ApplyConfiguration(new OrcamentoMaodeObraMapping());
            modelBuilder.ApplyConfiguration(new OrcamentoPecaMapping());
            modelBuilder.ApplyConfiguration(new ServicoMapping());
            modelBuilder.ApplyConfiguration(new ServicoMaodeObraMapping());
            modelBuilder.ApplyConfiguration(new ServicoPecaMapping());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionKeys.SgmConnection);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
