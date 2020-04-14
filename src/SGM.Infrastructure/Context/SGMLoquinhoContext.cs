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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMapping());
            modelBuilder.ApplyConfiguration(new ColaboradorMapping());
            modelBuilder.ApplyConfiguration(new OrcamentoMapping());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionKeys.SgmConnection);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
