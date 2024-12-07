using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebReaders.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Arend",
                columns: table => new
                {
                    Id_HA = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArendStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArendEnd = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Id_Reader = table.Column<int>(type: "int", nullable: false),
                    Id_Book = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arend", x => x.Id_HA);
                    table.ForeignKey(
                        name: "FK_Arend_Readers_Id_Reader",
                        column: x => x.Id_Reader,
                        principalTable: "Readers",
                        principalColumn: "Id_Reader",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Arend_Id_Reader",
                table: "Arend",
                column: "Id_Reader");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Arend");
        }
    }
}
