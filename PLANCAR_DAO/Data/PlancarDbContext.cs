using Microsoft.EntityFrameworkCore;
using PLANCAR_DAO.Models;

namespace PLANCAR_DAO.Data
{
    public class PlancarDbContext : DbContext
    {
        public DbSet<Departement> Departements { get; set; }
        public DbSet<Ville> Villes { get; set; }
        public DbSet<Institution> Institutions { get; set; }
        public DbSet<Constat> Constats { get; set; }
        public DbSet<DemandeUtilisation> DemandeUtilisations { get; set; }
        public DbSet<Dommage> Dommages { get; set; }
        public DbSet<Utilisateur> Utilisateurs { get; set; }
        public DbSet<Vehicule> Vehicules { get; set; }

        // Constructor to pass DbContextOptions to the base class
        public PlancarDbContext(DbContextOptions<PlancarDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseOracle("User Id=Test;Password=password;Data Source=localhost:1521/free");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Optional: Customize mappings, constraints, etc.
            base.OnModelCreating(modelBuilder);
        }
    }
}
