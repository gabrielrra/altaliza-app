﻿// <auto-generated />
using Altaliza.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Altaliza.Data.Migrations
{
    [DbContext(typeof(DefaultContext))]
    partial class DefaultContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("Altaliza.Data.Models.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("mediumint(9)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("Altaliza.Data.Models.Personagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("mediumint(9)");

                    b.Property<decimal>("Carteira")
                        .HasColumnType("decimal(13,2)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Personagem");
                });

            modelBuilder.Entity("Altaliza.Data.Models.PersonagemVeiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("mediumint(9)");

                    b.Property<int>("PersonagemId")
                        .HasColumnType("mediumint(9)");

                    b.Property<int>("VeiculoId")
                        .HasColumnType("mediumint(9)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "PersonagemId" }, "PersonagemId");

                    b.HasIndex(new[] { "VeiculoId" }, "VeiculoId");

                    b.ToTable("Personagem_Veiculo");
                });

            modelBuilder.Entity("Altaliza.Data.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("mediumint(9)");

                    b.Property<int>("CategoriaId")
                        .HasColumnType("mediumint(9)");

                    b.Property<int>("Estoque")
                        .HasColumnType("mediumint(9)");

                    b.Property<string>("Imagem")
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Preco15Dia")
                        .HasColumnType("decimal(13,2)");

                    b.Property<decimal>("Preco1Dia")
                        .HasColumnType("decimal(13,2)");

                    b.Property<decimal>("Preco7Dia")
                        .HasColumnType("decimal(13,2)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "CategoriaId" }, "CategoriaId");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("Altaliza.Data.Models.PersonagemVeiculo", b =>
                {
                    b.HasOne("Altaliza.Data.Models.Personagem", "Personagem")
                        .WithMany("PersonagemVeiculos")
                        .HasForeignKey("PersonagemId")
                        .HasConstraintName("personagem_veiculo_ibfk_1")
                        .IsRequired();

                    b.HasOne("Altaliza.Data.Models.Veiculo", "Veiculo")
                        .WithMany("PersonagemVeiculos")
                        .HasForeignKey("VeiculoId")
                        .HasConstraintName("personagem_veiculo_ibfk_2")
                        .IsRequired();

                    b.Navigation("Personagem");

                    b.Navigation("Veiculo");
                });

            modelBuilder.Entity("Altaliza.Data.Models.Veiculo", b =>
                {
                    b.HasOne("Altaliza.Data.Models.Categoria", "Categoria")
                        .WithMany("Veiculos")
                        .HasForeignKey("CategoriaId")
                        .HasConstraintName("veiculo_ibfk_1")
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("Altaliza.Data.Models.Categoria", b =>
                {
                    b.Navigation("Veiculos");
                });

            modelBuilder.Entity("Altaliza.Data.Models.Personagem", b =>
                {
                    b.Navigation("PersonagemVeiculos");
                });

            modelBuilder.Entity("Altaliza.Data.Models.Veiculo", b =>
                {
                    b.Navigation("PersonagemVeiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
