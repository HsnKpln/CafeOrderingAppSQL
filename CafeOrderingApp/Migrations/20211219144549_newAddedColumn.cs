using Microsoft.EntityFrameworkCore.Migrations;

namespace CafeOrderingApp.Migrations
{
    public partial class newAddedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "AraToplam",
                table: "Siparisler",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AraToplam",
                table: "Siparisler");
        }
    }
}
