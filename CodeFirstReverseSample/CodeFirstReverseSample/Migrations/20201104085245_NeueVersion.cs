using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirstReverseSample.Migrations
{
    public partial class NeueVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    Model = table.Column<string>(nullable: true),
                    ConstructYear = table.Column<string>(nullable: true),
                    Farbe = table.Column<string>(nullable: true),
                    IsCaprio = table.Column<bool>(nullable: false, defaultValueSql: "(CONVERT([bit],(0)))"),
                    MitRadio = table.Column<bool>(nullable: false, defaultValueSql: "(CONVERT([bit],(0)))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Train",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    WaggonAnzahl = table.Column<int>(nullable: false),
                    KMH = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Train", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Train");
        }
    }
}
