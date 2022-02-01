using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mine2Craft.Test.Persistance.Migrations
{
    public partial class Mine2CraftMigration03 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte>(
                name: "isCooked",
                table: "Items",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "isCooked",
                table: "Items");
        }
    }
}
