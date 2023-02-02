using ApiMusica.Entidades;
using Microsoft.EntityFrameworkCore;

namespace ApiMusica
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genero>().HasKey(prop => prop.Identificador);
            modelBuilder.Entity<Genero>().Property(prop => prop.Nombre)
                .HasMaxLength(50);
        }


        public DbSet<Genero> Generos { get; set; }
    }
}
