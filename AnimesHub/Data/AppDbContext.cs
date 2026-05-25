using AnimesHub.Models;
using Microsoft.EntityFrameworkCore;


namespace AnimesHub.Data
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;
                Database=AnimeHubDb;
                Trusted_Connection=True;
                TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioAnime>()
                .HasKey(x => new { x.UsuarioId, x.AnimeId });

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Anime> Animes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioAnime> UsuariosAnimes { get; set; }
    }
}
