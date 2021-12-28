﻿// <auto-generated />
using HW27122021.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HW27122021.Migrations
{
    [DbContext(typeof(DbContextHW))]
    [Migration("20211228000434_bmigration")]
    partial class bmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HW27122021.Models.Inventario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("cantidadAntigua")
                        .HasColumnType("int");

                    b.Property<int>("cantidadNueva")
                        .HasColumnType("int");

                    b.Property<byte>("estado")
                        .HasColumnType("tinyint");

                    b.Property<string>("producto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("usuario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("_inventario");
                });
#pragma warning restore 612, 618
        }
    }
}
