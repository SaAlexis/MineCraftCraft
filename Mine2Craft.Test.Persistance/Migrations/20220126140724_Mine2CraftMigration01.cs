using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mine2Craft.Test.Persistance.Migrations
{
    public partial class Mine2CraftMigration01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompleteItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Durability = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompleteItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    isCombustible = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Workbenchs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWID()"),
                    Position = table.Column<int>(type: "int", nullable: false),
                    CurrentItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CurrentCompleteItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workbenchs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workbenchs_CompleteItems_CurrentCompleteItemId",
                        column: x => x.CurrentCompleteItemId,
                        principalTable: "CompleteItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Workbenchs_Items_CurrentItemId",
                        column: x => x.CurrentItemId,
                        principalTable: "Items",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Workbenchs_CurrentCompleteItemId",
                table: "Workbenchs",
                column: "CurrentCompleteItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Workbenchs_CurrentItemId",
                table: "Workbenchs",
                column: "CurrentItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Workbenchs");

            migrationBuilder.DropTable(
                name: "CompleteItems");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
