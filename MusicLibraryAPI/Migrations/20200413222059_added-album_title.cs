using Microsoft.EntityFrameworkCore.Migrations;

namespace MusicLibraryAPI.Migrations
{
    public partial class addedalbum_title : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AlbumTitle",
                table: "Albums",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AlbumTitle",
                table: "Albums");
        }
    }
}
