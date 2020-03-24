using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace materiel_et_medical.Models
{
    public partial class material_et_medical_bddContext : DbContext
    {
        public material_et_medical_bddContext()
        {
        }

        public material_et_medical_bddContext(DbContextOptions<material_et_medical_bddContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adresse> Adresse { get; set; }
        public virtual DbSet<Categorie> Categorie { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Materiel> Materiel { get; set; }
        public virtual DbSet<Type> Type { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("server=localhost;port=3306;user=root;password=root;database=material_et_medical_bdd", x => x.ServerVersion("8.0.19-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Adresse>(entity =>
            {
                entity.ToTable("adresse");

                entity.HasIndex(e => e.ClientId)
                    .HasName("fk_adresse_client1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.CodePostal).HasColumnName("code_postal");

                entity.Property(e => e.Nom)
                    .IsRequired()
                    .HasColumnName("nom")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Numero).HasColumnName("numero");

                entity.Property(e => e.Ville)
                    .IsRequired()
                    .HasColumnName("ville")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Adresse)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_adresse_client1");
            });

            modelBuilder.Entity<Categorie>(entity =>
            {
                entity.ToTable("categorie");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Libelle)
                    .IsRequired()
                    .HasColumnName("libelle")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("client");

                entity.HasIndex(e => e.TypeId)
                    .HasName("fk_client_type1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CodeClient)
                    .HasColumnName("code_client")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Nom)
                    .HasColumnName("nom")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.Telephone).HasColumnName("telephone");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_client_type1");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("location");

                entity.HasIndex(e => e.ClientId)
                    .HasName("fk_location_client1_idx");

                entity.HasIndex(e => e.MaterielId)
                    .HasName("fk_location_materiel1_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ClientId).HasColumnName("client_id");

                entity.Property(e => e.Duree).HasColumnName("duree");

                entity.Property(e => e.MaterielId).HasColumnName("materiel_id");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_location_client1");

                entity.HasOne(d => d.Materiel)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.MaterielId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_location_materiel1");
            });

            modelBuilder.Entity<Materiel>(entity =>
            {
                entity.ToTable("materiel");

                entity.HasIndex(e => e.Categorie)
                    .HasName("fk_materiel_categorie_idx");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Categorie).HasColumnName("categorie");

                entity.Property(e => e.DateAchat)
                    .HasColumnName("date_achat")
                    .HasColumnType("datetime");

                entity.Property(e => e.Designation)
                    .HasColumnName("designation")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.Property(e => e.PrixJour).HasColumnName("prix_jour");

                entity.Property(e => e.Reference)
                    .IsRequired()
                    .HasColumnName("reference")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");

                entity.HasOne(d => d.CategorieNavigation)
                    .WithMany(p => p.Materiel)
                    .HasForeignKey(d => d.Categorie)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_materiel_categorie");
            });

            modelBuilder.Entity<Type>(entity =>
            {
                entity.ToTable("type");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Type1)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasColumnType("varchar(45)")
                    .HasCharSet("utf8mb4")
                    .HasCollation("utf8mb4_0900_ai_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
