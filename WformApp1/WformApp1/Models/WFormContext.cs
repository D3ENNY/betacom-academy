using Microsoft.EntityFrameworkCore;

namespace WformApp1.Models
{
    internal class WFormContext : DbContext
    {
        public DbSet<AnagraficaGenerale> AnagraficaGenerale { get; set; }
        public DbSet<AttivitaDipendenti> AttivitaDipendenti { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=DipendentiAzienda;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}
