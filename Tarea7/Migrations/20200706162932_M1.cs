using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Tarea7.Migrations
{
    public partial class M1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleado",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cedula = table.Column<string>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    FechaIngreso = table.Column<DateTime>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Sexo = table.Column<string>(nullable: false),
                    EstadoCivil = table.Column<string>(nullable: false),
                    TipoSangre = table.Column<string>(nullable: true),
                    Nacionalidad = table.Column<string>(nullable: false),
                    Religion = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    SalrioMensual = table.Column<decimal>(nullable: false),
                    Departamento = table.Column<string>(nullable: true),
                    NombreContEmer = table.Column<string>(nullable: false),
                    TeledfonoContEmer = table.Column<string>(nullable: false),
                    AFP = table.Column<string>(nullable: false),
                    ARS = table.Column<string>(nullable: false),
                    Observaciones = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleado", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Estudiantes",
                columns: table => new
                {
                    IdEstudiantes = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Matricula = table.Column<string>(nullable: false),
                    Cedula = table.Column<string>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    FechaIngreso = table.Column<DateTime>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Sexo = table.Column<string>(nullable: false),
                    EstadoCivil = table.Column<string>(nullable: false),
                    Ocupacion = table.Column<string>(nullable: true),
                    TipoSangre = table.Column<string>(nullable: true),
                    Nacionalidad = table.Column<string>(nullable: false),
                    Religion = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    NombrePadre = table.Column<string>(nullable: false),
                    NombreMadre = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    TipoColegio = table.Column<string>(nullable: true),
                    Carrera = table.Column<string>(nullable: true),
                    Observaciones = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estudiantes", x => x.IdEstudiantes);
                });

            migrationBuilder.CreateTable(
                name: "Profesor",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cedula = table.Column<string>(nullable: false),
                    FechaNacimiento = table.Column<DateTime>(nullable: false),
                    FechaIngreso = table.Column<DateTime>(nullable: false),
                    Nombre = table.Column<string>(nullable: false),
                    Apellido = table.Column<string>(nullable: false),
                    Sexo = table.Column<string>(nullable: false),
                    EstadoCivil = table.Column<string>(nullable: false),
                    Ocupacion = table.Column<string>(nullable: true),
                    TipoSangre = table.Column<string>(nullable: true),
                    Nacionalidad = table.Column<string>(nullable: false),
                    Religion = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Direccion = table.Column<string>(nullable: false),
                    Carrera = table.Column<string>(nullable: true),
                    TituloGrado = table.Column<string>(nullable: false),
                    MayorGrado = table.Column<string>(nullable: true),
                    CatProfesional = table.Column<string>(nullable: true),
                    Facultad = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesor", x => x.Codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleado");

            migrationBuilder.DropTable(
                name: "Estudiantes");

            migrationBuilder.DropTable(
                name: "Profesor");
        }
    }
}
