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

        public DbSet<Cliente> Cliente { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMapping());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(_connectionKeys.SGMLoquinhoConnection);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
