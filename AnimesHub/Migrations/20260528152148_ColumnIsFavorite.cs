using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimesHub.Migrations
{
    /// <inheritdoc />
    public partial class ColumnIsFavorite : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "StatusAnime",
                table: "UsuariosAnimes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<bool>(
                name: "IsFavorite",
                table: "UsuariosAnimes",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFavorite",
                table: "UsuariosAnimes");

            migrationBuilder.AlterColumn<int>(
                name: "StatusAnime",
                table: "UsuariosAnimes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
