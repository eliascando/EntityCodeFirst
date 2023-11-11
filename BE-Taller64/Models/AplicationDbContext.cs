using Microsoft.EntityFrameworkCore;

namespace BE_Taller64.Models
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<CredencialesAcceso> CredencialesAccesos { get; set; }
        public DbSet<HistorialAcceso> HistorialAccesos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuario");
            modelBuilder.Entity<Departamento>().ToTable("Departamento");
            modelBuilder.Entity<CredencialesAcceso>().ToTable("CredencialesAcceso").HasNoKey();
            modelBuilder.Entity<HistorialAcceso>().ToTable("HistorialAcceso");
        }
    }

}
