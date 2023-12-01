﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThrashShop.Data;

#nullable disable

namespace ThrashShop.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231201010508_AdicionarTabelaCategoria")]
    partial class AdicionarTabelaCategoria
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ThrashShop.Models.Categoria", b =>
                {
                    b.Property<int>("CategoriaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoriaId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoriaId");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("ThrashShop.Models.Marca", b =>
                {
                    b.Property<int>("MarcaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MarcaId"));

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MarcaId");

                    b.ToTable("Marcas");
                });

            modelBuilder.Entity("ThrashShop.Models.Skate", b =>
                {
                    b.Property<int>("SkateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SkateId"));

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<bool>("EntregaExpressa")
                        .HasColumnType("bit");

                    b.Property<string>("ImagemUri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MarcaId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Preco")
                        .HasColumnType("float");

                    b.HasKey("SkateId");

                    b.HasIndex("MarcaId");

                    b.ToTable("TB_SKATE");
                });

            modelBuilder.Entity("ThrashShop.Models.Skate", b =>
                {
                    b.HasOne("ThrashShop.Models.Marca", null)
                        .WithMany("Skates")
                        .HasForeignKey("MarcaId");
                });

            modelBuilder.Entity("ThrashShop.Models.Marca", b =>
                {
                    b.Navigation("Skates");
                });
#pragma warning restore 612, 618
        }
    }
}
