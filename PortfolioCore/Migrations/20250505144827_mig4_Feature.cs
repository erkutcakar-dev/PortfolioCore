using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioCore.Migrations
{
    public partial class mig4_Feature : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Features",
                newName: "CardTitle3");

            migrationBuilder.AddColumn<string>(
                name: "CardTitle1",
                table: "Features",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CardTitle2",
                table: "Features",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CardTitle1",
                table: "Features");

            migrationBuilder.DropColumn(
                name: "CardTitle2",
                table: "Features");

            migrationBuilder.RenameColumn(
                name: "CardTitle3",
                table: "Features",
                newName: "Description");
        }
    }
}
