﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Datos.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "personas",
                columns: table => new
                {
                    Identificacion = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Apellido = table.Column<string>(nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    Sexo = table.Column<string>(nullable: true),
                    EstadoCivil = table.Column<string>(nullable: true),
                    PaisDeProcedencia = table.Column<string>(nullable: true),
                    NivelEducativo = table.Column<string>(nullable: true),
                    Conocimiento1 = table.Column<string>(nullable: true),
                    Conocimiento2 = table.Column<string>(nullable: true),
                    Conocimiento3 = table.Column<string>(nullable: true),
                    Conocimiento4 = table.Column<string>(nullable: true),
                    Conocimiento5 = table.Column<string>(nullable: true),
                    ConocimientoExplicacion = table.Column<string>(nullable: true),
                    Actitud1 = table.Column<string>(nullable: true),
                    Actitud2 = table.Column<string>(nullable: true),
                    Actitud3 = table.Column<string>(nullable: true),
                    ActitudExplicacion = table.Column<string>(nullable: true),
                    Actitud5 = table.Column<string>(nullable: true),
                    Actitud6 = table.Column<string>(nullable: true),
                    Practica1 = table.Column<string>(nullable: true),
                    Practica2 = table.Column<string>(nullable: true),
                    Practica3 = table.Column<string>(nullable: true),
                    Practica4 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personas", x => x.Identificacion);
                });

            migrationBuilder.CreateTable(
                name: "restaurantes",
                columns: table => new
                {
                    Codigo = table.Column<string>(nullable: false),
                    Nombre = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_restaurantes", x => x.Codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personas");

            migrationBuilder.DropTable(
                name: "restaurantes");
        }
    }
}
