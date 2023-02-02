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
            //Genero
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Genero>().HasKey(prop => prop.Identificador);
            modelBuilder.Entity<Genero>().Property(prop => prop.Nombre)
                .HasMaxLength(50)
                .IsRequired();

            //Artista
            modelBuilder.Entity<Artista>().Property(prop => prop.Nombre)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Artista>().Property(prop => prop.FechaNacimiento)
                .HasColumnType("Date");

            //Plataformas
            modelBuilder.Entity<Plataformas>().Property(prop => prop.Nombre)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Entity<Plataformas>().Property(prop => prop.Precio)
                .HasPrecision( 9, 2);

            //Cancion
            modelBuilder.Entity<Cancion>().Property(prop => prop.Titulo)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Cancion>().Property(prop => prop.FechaLanzamiento)
                .HasColumnType("Date");

            modelBuilder.Entity<Cancion>().Property(prop => prop.PosterURL)
                .HasMaxLength(500)
                .IsUnicode(false);
        }


        public DbSet<Genero> Generos { get; set; }
        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Plataformas> Plataformas { get; set; }
        public DbSet<Cancion> Canciones { get; set; }
    }
}
