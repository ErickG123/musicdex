using Microsoft.EntityFrameworkCore;
using musicdex.Models;

namespace musicdex.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt) : base(opt)
        {
        }

        public DbSet<Genero> Generos { get; set; }
        public DbSet<Musica> Musicas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genero>()
                .HasMany(g => g.Musicas)
                .WithOne(m => m.Genero)
                .HasForeignKey(m => m.GeneroId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
