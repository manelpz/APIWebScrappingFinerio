using Microsoft.EntityFrameworkCore.Migrations;

namespace APIWebScrappingFinerio.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Artists_ArtistId1",
                table: "Albums");

            migrationBuilder.DropIndex(
                name: "IX_Albums_ArtistId1",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "ArtistId1",
                table: "Albums");

            migrationBuilder.AlterColumn<int>(
                name: "ArtistId",
                table: "Albums",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums",
                column: "ArtistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Artists_ArtistId",
                table: "Albums",
                column: "ArtistId",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Albums_Artists_ArtistId",
                table: "Albums");

            migrationBuilder.DropIndex(
                name: "IX_Albums_ArtistId",
                table: "Albums");

            migrationBuilder.AlterColumn<string>(
                name: "ArtistId",
                table: "Albums",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ArtistId1",
                table: "Albums",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistId1",
                table: "Albums",
                column: "ArtistId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Albums_Artists_ArtistId1",
                table: "Albums",
                column: "ArtistId1",
                principalTable: "Artists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
