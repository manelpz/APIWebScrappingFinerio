using Microsoft.EntityFrameworkCore.Migrations;

namespace APIWebScrappingFinerio.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SubGenre",
                table: "Artists",
                newName: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "GenreId",
                table: "Artists",
                newName: "SubGenre");
        }
    }
}
