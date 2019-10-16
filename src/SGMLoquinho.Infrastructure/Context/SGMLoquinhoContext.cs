using Microsoft.EntityFrameworkCore;
using SGMLoquinho.Domain.Entities;
using SGMLoquinho.Domain.ValueObjects;
using SGMLoquinho.Infrastructure.Mapping;

namespace SGMLoquinho.Infrastructure.Context
{
    public class SGMLoquinhoContext : DbContext
    {
        private readonly ConnectionStrings _connectionKeys;
        public SGMLoquinhoContext(ConnectionStrings keys)
        {
            _connectionKeys = keys;
        }
        public DbSet<Cliente> Clientes { get; set; }
        //public DbSet<Veiculo> Veiculos { get; set; }
        //public DbSet<ClienteVeiculo> ClienteVeiculos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().HasKey(x => x.Id);
            //modelBuilder.Entity<ClienteVeiculo>()
            //    .HasKey(x => new { x.ClienteId, x.Id });
            //
            //modelBuilder.Entity<Veiculo>().HasKey(x => x.Id);
            //modelBuilder.Entity<ClienteVeiculo>()
            //    .HasKey(x => new { x.VeiculoId, x.Id });

            modelBuilder.ApplyConfiguration(new ClienteMapping());
            //modelBuilder.ApplyConfiguration(new ClienteVeiculoMapping());
            //modelBuilder.ApplyConfiguration(new VeiculoMapping());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionKeys.SGMLoquinhoConnection);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
