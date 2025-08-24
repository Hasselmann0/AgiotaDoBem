using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AgiotaDoBem.Infra.Migrations
{
    /// <inheritdoc />
    public partial class Primeira : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DividasDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDoEstabelecimento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorTotalDaCompra = table.Column<double>(type: "float", nullable: false),
                    DiaDaCompra = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DividasDb", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosDb",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDoDevedor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DividasParaPagarId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosDb", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuariosDb_DividasDb_DividasParaPagarId",
                        column: x => x.DividasParaPagarId,
                        principalTable: "DividasDb",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuariosDb_DividasParaPagarId",
                table: "UsuariosDb",
                column: "DividasParaPagarId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UsuariosDb");

            migrationBuilder.DropTable(
                name: "DividasDb");
        }
    }
}
