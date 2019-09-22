using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ADECULT.adecult
{
    public partial class addecultContext : DbContext
    {
        public addecultContext()
        {
        }

        public addecultContext(DbContextOptions<addecultContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Directorio> Directorio { get; set; }
        public virtual DbSet<DirectorioHasCategoria> DirectorioHasCategoria { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySQL("server=localhost;port=3306;user=root;password=genesis1991;database=addecult");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.ToTable("categoria", "addecult");

                entity.HasIndex(e => e.CategoriaIdCategoria)
                    .HasName("fk_categoria_categoria1_idx");

                entity.Property(e => e.IdCategoria)
                    .HasColumnName("idCategoria")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoriaIdCategoria)
                    .HasColumnName("categoria_idCategoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.NombreCaegoria)
                    .IsRequired()
                    .HasColumnName("nombreCaegoria")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.HasOne(d => d.CategoriaIdCategoriaNavigation)
                    .WithMany(p => p.InverseCategoriaIdCategoriaNavigation)
                    .HasForeignKey(d => d.CategoriaIdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_categoria_categoria1");
            });

            modelBuilder.Entity<Directorio>(entity =>
            {
                entity.HasKey(e => e.IdCedula);

                entity.ToTable("directorio", "addecult");

                entity.Property(e => e.IdCedula)
                    .HasColumnName("idCedula")
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Caserio)
                    .IsRequired()
                    .HasColumnName("caserio")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(45)
                    .IsUnicode(false);

                entity.Property(e => e.Espublico)
                    .HasColumnName("espublico")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Poblado)
                    .IsRequired()
                    .HasColumnName("poblado")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasColumnName("primerApellido")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoApellido)
                    .IsRequired()
                    .HasColumnName("segundoApellido")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Senas)
                    .IsRequired()
                    .HasColumnName("senas")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasColumnType("int(12)");
            });

            modelBuilder.Entity<DirectorioHasCategoria>(entity =>
            {
                entity.HasKey(e => new { e.DirectorioIdCedula, e.CategoriaIdCategoria });

                entity.ToTable("directorio_has_categoria", "addecult");

                entity.HasIndex(e => e.CategoriaIdCategoria)
                    .HasName("fk_Directorio_has_categoria_categoria1_idx");

                entity.HasIndex(e => e.DirectorioIdCedula)
                    .HasName("fk_Directorio_has_categoria_Directorio_idx");

                entity.Property(e => e.DirectorioIdCedula)
                    .HasColumnName("Directorio_idCedula")
                    .HasColumnType("int(11)");

                entity.Property(e => e.CategoriaIdCategoria)
                    .HasColumnName("categoria_idCategoria")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Individual)
                    .HasColumnName("individual")
                    .HasColumnType("tinyint(4)");

                entity.HasOne(d => d.CategoriaIdCategoriaNavigation)
                    .WithMany(p => p.DirectorioHasCategoria)
                    .HasForeignKey(d => d.CategoriaIdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Directorio_has_categoria_categoria1");

                entity.HasOne(d => d.DirectorioIdCedulaNavigation)
                    .WithMany(p => p.DirectorioHasCategoria)
                    .HasForeignKey(d => d.DirectorioIdCedula)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Directorio_has_categoria_Directorio");
            });
        }
    }
}
