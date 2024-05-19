using Microsoft.EntityFrameworkCore;
using projeto.Models;

namespace projeto
{
    public class AppDataContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Orgao> Orgaos { get; set; }

        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Aqui você pode adicionar configurações adicionais para suas entidades, se necessário.
        }
    }
}
