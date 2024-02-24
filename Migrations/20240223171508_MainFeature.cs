using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HexaopsNewWebAPP.Migrations
{
    /// <inheritdoc />
    public partial class MainFeature : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Bigtitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bigdescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainFeatures", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainFeatureAssocs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Smalltitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Smalldescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainFeatureAssocs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainFeatureAssocs_MainFeatures_MainFeaturesId",
                        column: x => x.MainFeaturesId,
                        principalTable: "MainFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MainFeatureAssocs_MainFeaturesId",
                table: "MainFeatureAssocs",
                column: "MainFeaturesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainFeatureAssocs");

            migrationBuilder.DropTable(
                name: "MainFeatures");
        }
    }
}
