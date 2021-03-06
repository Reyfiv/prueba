﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tarea7.Models;

namespace Tarea7.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Tarea7.Models.Empleado", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AFP")
                        .IsRequired();

                    b.Property<string>("ARS")
                        .IsRequired();

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<string>("Cedula")
                        .IsRequired();

                    b.Property<string>("Departamento");

                    b.Property<string>("Direccion")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("EstadoCivil")
                        .IsRequired();

                    b.Property<DateTime>("FechaIngreso");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Nacionalidad")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("NombreContEmer")
                        .IsRequired();

                    b.Property<string>("Observaciones");

                    b.Property<string>("Religion");

                    b.Property<decimal>("SalrioMensual");

                    b.Property<string>("Sexo")
                        .IsRequired();

                    b.Property<string>("TeledfonoContEmer")
                        .IsRequired();

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.Property<string>("TipoSangre");

                    b.HasKey("Codigo");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("Tarea7.Models.Estudiantes", b =>
                {
                    b.Property<int>("IdEstudiantes")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<string>("Carrera");

                    b.Property<string>("Cedula")
                        .IsRequired();

                    b.Property<string>("Direccion")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("EstadoCivil")
                        .IsRequired();

                    b.Property<DateTime>("FechaIngreso");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("Matricula")
                        .IsRequired();

                    b.Property<string>("Nacionalidad")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("NombreMadre")
                        .IsRequired();

                    b.Property<string>("NombrePadre")
                        .IsRequired();

                    b.Property<string>("Observaciones");

                    b.Property<string>("Ocupacion");

                    b.Property<string>("Religion");

                    b.Property<string>("Sexo")
                        .IsRequired();

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.Property<string>("TipoColegio");

                    b.Property<string>("TipoSangre");

                    b.HasKey("IdEstudiantes");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("Tarea7.Models.Profesor", b =>
                {
                    b.Property<int>("Codigo")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .IsRequired();

                    b.Property<string>("Carrera");

                    b.Property<string>("CatProfesional");

                    b.Property<string>("Cedula")
                        .IsRequired();

                    b.Property<string>("Direccion")
                        .IsRequired();

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("EstadoCivil")
                        .IsRequired();

                    b.Property<string>("Facultad");

                    b.Property<DateTime>("FechaIngreso");

                    b.Property<DateTime>("FechaNacimiento");

                    b.Property<string>("MayorGrado");

                    b.Property<string>("Nacionalidad")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<string>("Ocupacion");

                    b.Property<string>("Religion");

                    b.Property<string>("Sexo")
                        .IsRequired();

                    b.Property<string>("Telefono")
                        .IsRequired();

                    b.Property<string>("TipoSangre");

                    b.Property<string>("TituloGrado")
                        .IsRequired();

                    b.HasKey("Codigo");

                    b.ToTable("Profesor");
                });
#pragma warning restore 612, 618
        }
    }
}
