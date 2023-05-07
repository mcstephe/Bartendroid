using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bartendroid.Migrations
{
    /// <inheritdoc />
    public partial class CocktailUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Instructions",
                table: "Cocktail",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Instructions",
                table: "Cocktail");
        }
    }
}
