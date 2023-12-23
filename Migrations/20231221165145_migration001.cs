using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exercicio_ef.Migrations
{
    /// <inheritdoc />
    public partial class migration001 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cadernos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cadernos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "registros",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    conteudo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cadernoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_registros", x => x.id);
                    table.ForeignKey(
                        name: "FK_registros_cadernos_cadernoId",
                        column: x => x.cadernoId,
                        principalTable: "cadernos",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_registros_cadernoId",
                table: "registros",
                column: "cadernoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "registros");

            migrationBuilder.DropTable(
                name: "cadernos");
        }
    }
}
