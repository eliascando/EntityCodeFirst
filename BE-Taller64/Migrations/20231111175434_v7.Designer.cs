﻿// <auto-generated />
using System;
using BE_Taller64.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BE_Taller64.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20231111175434_v7")]
    partial class v7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BE_Taller64.Models.CredencialesAcceso", b =>
                {
                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("Cedula");

                    b.ToTable("CredencialesAcceso", (string)null);
                });

            modelBuilder.Entity("BE_Taller64.Models.Departamento", b =>
                {
                    b.Property<int>("DepartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartamentoId"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EstadoDepartamento")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombreDepartamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartamentoId");

                    b.ToTable("Departamento", (string)null);
                });

            modelBuilder.Entity("BE_Taller64.Models.HistorialAcceso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cedula")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("FechaHora")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("Cedula");

                    b.ToTable("HistorialAcceso", (string)null);
                });

            modelBuilder.Entity("BE_Taller64.Models.Usuario", b =>
                {
                    b.Property<string>("Cedula")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<bool>("EstadoUsuario")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Cedula");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("BE_Taller64.Models.CredencialesAcceso", b =>
                {
                    b.HasOne("BE_Taller64.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("Cedula")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("BE_Taller64.Models.HistorialAcceso", b =>
                {
                    b.HasOne("BE_Taller64.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("Cedula")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("BE_Taller64.Models.Usuario", b =>
                {
                    b.HasOne("BE_Taller64.Models.Departamento", "Departamento")
                        .WithMany("Usuarios")
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("BE_Taller64.Models.Departamento", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
