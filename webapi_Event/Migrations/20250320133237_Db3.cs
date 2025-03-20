using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace webapi_Event.Migrations
{
    /// <inheritdoc />
    public partial class Db3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "TiposUsuarios");

            migrationBuilder.DropColumn(
                name: "Senha",
                table: "TiposUsuarios");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "TiposUsuarios",
                type: "VARCHAR(80)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Senha",
                table: "TiposUsuarios",
                type: "VARCHAR(60)",
                nullable: false,
                defaultValue: "");
        }
    }
}
