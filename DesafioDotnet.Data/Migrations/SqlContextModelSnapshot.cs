﻿// <auto-generated />
using System;
using DesafioDotnet.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DesafioDotnet.Data.Migrations
{
    [DbContext(typeof(SqlContext))]
    partial class SqlContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DesafioDotnet.Business.Models.ChaveModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.Property<int>("TipoChave")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Chaves");
                });

            modelBuilder.Entity("DesafioDotnet.Business.Models.Pagador", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ChaveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("ChaveId");

                    b.ToTable("Pagador");
                });

            modelBuilder.Entity("DesafioDotnet.Business.Models.Recebedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ChaveId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(1000)");

                    b.HasKey("Id");

                    b.HasIndex("ChaveId");

                    b.ToTable("Recebedor");
                });

            modelBuilder.Entity("DesafioDotnet.Business.Models.Transacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DataTransacao")
                        .HasColumnType("date");

                    b.Property<int>("PagadorId")
                        .HasColumnType("int");

                    b.Property<Guid>("PagadorId1")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RecebedorId")
                        .HasColumnType("int");

                    b.Property<Guid>("RecebedorId1")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PagadorId1");

                    b.HasIndex("RecebedorId1");

                    b.ToTable("Transacoes");
                });

            modelBuilder.Entity("DesafioDotnet.Business.Models.Pagador", b =>
                {
                    b.HasOne("DesafioDotnet.Business.Models.ChaveModel", "Chave")
                        .WithMany()
                        .HasForeignKey("ChaveId");
                });

            modelBuilder.Entity("DesafioDotnet.Business.Models.Recebedor", b =>
                {
                    b.HasOne("DesafioDotnet.Business.Models.ChaveModel", "Chave")
                        .WithMany()
                        .HasForeignKey("ChaveId");
                });

            modelBuilder.Entity("DesafioDotnet.Business.Models.Transacao", b =>
                {
                    b.HasOne("DesafioDotnet.Business.Models.Pagador", "Pagador")
                        .WithMany("Transacoes")
                        .HasForeignKey("PagadorId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DesafioDotnet.Business.Models.Recebedor", "Recebedor")
                        .WithMany("Transacoes")
                        .HasForeignKey("RecebedorId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
