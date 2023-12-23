using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace exercicio_ef.Migrations
{
    /// <inheritdoc />
    public partial class migration002 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "nome",
                table: "cadernos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "nome",
                table: "cadernos");
        }
    }
}
