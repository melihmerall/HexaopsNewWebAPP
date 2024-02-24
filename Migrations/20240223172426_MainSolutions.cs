using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HexaopsNewWebAPP.Migrations
{
    /// <inheritdoc />
    public partial class MainSolutions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainSolutions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolutionsImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolutionsTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolutionsDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SolutionsButtonUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainSolutions", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainSolutions");
        }
    }
}
