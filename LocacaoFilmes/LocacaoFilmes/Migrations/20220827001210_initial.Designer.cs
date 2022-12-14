// <auto-generated />
using System;
using LocacaoFilmes.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LocacaoFilmes.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220827001210_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.6");

            modelBuilder.Entity("LocacaoFilmes.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("LocacaoFilmes.Models.Filme", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ClassificacaoIndicativa")
                        .HasColumnType("int");

                    b.Property<byte>("Lancamento")
                        .HasColumnType("tinyint unsigned");

                    b.Property<string>("Titulo")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Filme");
                });

            modelBuilder.Entity("LocacaoFilmes.Models.Locacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataDevolucao")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("DataLocacao")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("Id_Cliente")
                        .HasColumnType("int");

                    b.Property<int?>("Id_Filme")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Id_Cliente");

                    b.HasIndex("Id_Filme");

                    b.ToTable("Locacao");
                });

            modelBuilder.Entity("LocacaoFilmes.Models.Locacao", b =>
                {
                    b.HasOne("LocacaoFilmes.Models.Cliente", "IdCliente")
                        .WithMany();
                    // .HasForeignKey("FK_Cliente_idx");

                    b.HasOne("LocacaoFilmes.Models.Filme", "IdFilme")
                        .WithMany();
                      //  .HasForeignKey("FK_Filme_idx");

                    b.Navigation("IdCliente");

                    b.Navigation("IdFilme");
                });
#pragma warning restore 612, 618
        }
    }
}
