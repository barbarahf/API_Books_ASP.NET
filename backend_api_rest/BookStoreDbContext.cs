using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ApiLibros.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
namespace ApiLibros.Models
{
    public partial class BookStoreDbContext : IdentityDbContext<ApplicationUser>
    {

        public BookStoreDbContext(DbContextOptions<BookStoreDbContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Editorial> Editorials { get; set; }
        public virtual DbSet<Genero> Generos { get; set; }
        public virtual DbSet<Libro> Libros { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 

            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Editorial>(entity =>
            {
                entity.ToTable("editorial");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NombreEditorial)
                    .IsRequired()
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("nombre_editorial")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Genero>(entity =>
            {
                entity.ToTable("genero");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Genero1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("genero")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Libro>(entity =>
            {
                entity.ToTable("libro");

                entity.HasIndex(e => e.Titulo, "UQ__libro__38FA640FE7AA7AE5")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Autor)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("autor")
                    .IsFixedLength(true);

                entity.Property(e => e.FechaPublicacion)
                    .HasColumnType("date")
                    .HasColumnName("fecha_publicacion");

                entity.Property(e => e.IdEditorial).HasColumnName("id_editorial");

                entity.Property(e => e.IdGenero).HasColumnName("id_genero");

                entity.Property(e => e.Img)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("img")
                    .IsFixedLength(true);

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.Property(e => e.Titulo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("titulo")
                    .IsFixedLength(true);

                entity.HasOne(d => d.IdEditorialNavigation)
                    .WithMany(p => p.Libros)
                    .HasForeignKey(d => d.IdEditorial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__libro__id_editor__29572725");

                entity.HasOne(d => d.IdGeneroNavigation)
                    .WithMany(p => p.Libros)
                    .HasForeignKey(d => d.IdGenero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__libro__id_genero__2A4B4B5E");
            });

            OnModelCreatingPartial(modelBuilder);
        }



        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
