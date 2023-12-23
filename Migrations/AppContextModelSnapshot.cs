﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using exercicio_ef;

#nullable disable

namespace exercicio_ef.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("exercicio_ef.Models.Caderno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("cadernos");
                });

            modelBuilder.Entity("exercicio_ef.Models.Registro", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("cadernoId")
                        .HasColumnType("int");

                    b.Property<string>("conteudo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("data")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("cadernoId");

                    b.ToTable("registros");
                });

            modelBuilder.Entity("exercicio_ef.Models.Registro", b =>
                {
                    b.HasOne("exercicio_ef.Models.Caderno", "caderno")
                        .WithMany("registros")
                        .HasForeignKey("cadernoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("caderno");
                });

            modelBuilder.Entity("exercicio_ef.Models.Caderno", b =>
                {
                    b.Navigation("registros");
                });
#pragma warning restore 612, 618
        }
    }
}