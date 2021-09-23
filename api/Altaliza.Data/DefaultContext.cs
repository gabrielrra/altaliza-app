using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Altaliza.Data.Models;

#nullable disable

namespace Altaliza.Data
{
    public partial class DefaultContext : DbContext
    {
        public DefaultContext()
        {
        }

        public DefaultContext(DbContextOptions<DefaultContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<EfmigrationsHistory> EfmigrationsHistories { get; set; }
        public virtual DbSet<Personagem> Personagems { get; set; }
        public virtual DbSet<PersonagemVeiculo> PersonagemVeiculos { get; set; }
        public virtual DbSet<Veiculo> Veiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("Server=localhost; Database=altaliza; user=root; password=root ;  DefaultCommandTimeout=60; Allow User Variables=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("mediumint(9)");

                entity.Property(e => e.Descricao)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EfmigrationsHistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__EFMigrationsHistory");

                entity.Property(e => e.MigrationId).HasMaxLength(150);

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Personagem>(entity =>
            {
                entity.ToTable("Personagem");

                entity.Property(e => e.Id).HasColumnType("mediumint(9)");

                entity.Property(e => e.Carteira).HasColumnType("decimal(13,2)");

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PersonagemVeiculo>(entity =>
            {
                entity.ToTable("Personagem_Veiculo");

                entity.HasIndex(e => e.PersonagemId, "PersonagemId");

                entity.HasIndex(e => e.VeiculoId, "VeiculoId");

                entity.Property(e => e.Id).HasColumnType("mediumint(9)");

                entity.Property(e => e.PersonagemId).HasColumnType("mediumint(9)");

                entity.Property(e => e.VeiculoId).HasColumnType("mediumint(9)");

                entity.HasOne(d => d.Personagem)
                    .WithMany(p => p.PersonagemVeiculos)
                    .HasForeignKey(d => d.PersonagemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("personagem_veiculo_ibfk_1");

                entity.HasOne(d => d.Veiculo)
                    .WithMany(p => p.PersonagemVeiculos)
                    .HasForeignKey(d => d.VeiculoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("personagem_veiculo_ibfk_2");
            });

            modelBuilder.Entity<Veiculo>(entity =>
            {
                entity.ToTable("Veiculo");

                entity.HasIndex(e => e.CategoriaId, "CategoriaId");

                entity.Property(e => e.Id).HasColumnType("mediumint(9)");

                entity.Property(e => e.CategoriaId).HasColumnType("mediumint(9)");

                entity.Property(e => e.Estoque).HasColumnType("mediumint(9)");

                entity.Property(e => e.Imagem).HasMaxLength(255);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Preco15Dia).HasColumnType("decimal(13,2)");

                entity.Property(e => e.Preco1Dia).HasColumnType("decimal(13,2)");

                entity.Property(e => e.Preco7Dia).HasColumnType("decimal(13,2)");

                entity.HasOne(d => d.Categoria)
                    .WithMany(p => p.Veiculos)
                    .HasForeignKey(d => d.CategoriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("veiculo_ibfk_1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
