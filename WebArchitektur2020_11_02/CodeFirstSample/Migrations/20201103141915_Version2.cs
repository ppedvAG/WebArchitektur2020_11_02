using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstSample.Migrations
{
    public partial class Version2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCaprio",
                table: "Car",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "MitRadio",
                table: "Car",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCaprio",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "MitRadio",
                table: "Car");
        }
    }
}
