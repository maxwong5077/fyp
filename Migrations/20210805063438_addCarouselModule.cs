using Microsoft.EntityFrameworkCore.Migrations;

namespace EasyJobHunter.Migrations
{
    public partial class addCarouselModule : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "module",
                table: "tbl_carousel_image",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "module",
                table: "tbl_carousel_image");
        }
    }
}
