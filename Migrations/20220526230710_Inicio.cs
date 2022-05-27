using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace SysPatrimonio.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "public");

            migrationBuilder.CreateTable(
                name: "Categoria",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    descricaocategoria = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categoria", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Departamento",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomedepartamento = table.Column<string>(type: "text", nullable: true),
                    descricacaodepartamento = table.Column<string>(type: "text", nullable: true),
                    idlocal = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamento", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "fornecedor",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomefornecedor = table.Column<string>(type: "text", nullable: true),
                    endereco = table.Column<string>(type: "text", nullable: true),
                    fone = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_fornecedor", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Local",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nomelocal = table.Column<string>(type: "text", nullable: true),
                    descicaolocal = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Local", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Patrimonio",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    numeroetiqueta = table.Column<string>(type: "text", nullable: true),
                    nomepatrimonio = table.Column<string>(type: "text", nullable: true),
                    descricaopatrimonio = table.Column<string>(type: "text", nullable: true),
                    valorpatrimonio = table.Column<string>(type: "text", nullable: true),
                    idcategoria = table.Column<int>(type: "integer", nullable: false),
                    idlocal = table.Column<int>(type: "integer", nullable: false),
                    iddepartamento = table.Column<int>(type: "integer", nullable: false),
                    marcamodelo = table.Column<string>(type: "text", nullable: true),
                    dataaquisicao = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    databaixa = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patrimonio", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                schema: "public",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    nome = table.Column<string>(type: "text", nullable: true),
                    login = table.Column<string>(type: "text", nullable: true),
                    senha = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categoria",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Departamento",
                schema: "public");

            migrationBuilder.DropTable(
                name: "fornecedor",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Local",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Patrimonio",
                schema: "public");

            migrationBuilder.DropTable(
                name: "Usuario",
                schema: "public");
        }
    }
}
