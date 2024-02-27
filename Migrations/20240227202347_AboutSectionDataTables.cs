using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HexaopsNewWebAPP.Migrations
{
    /// <inheritdoc />
    public partial class AboutSectionDataTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutHowWeWorks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeaderTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutHowWeWorks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripton = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutHowWeWorkAssocs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TitleAssoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutHowWeWorkId = table.Column<int>(type: "int", nullable: false),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutHowWeWorkAssocs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutHowWeWorkAssocs_AboutHowWeWorks_AboutHowWeWorkId",
                        column: x => x.AboutHowWeWorkId,
                        principalTable: "AboutHowWeWorks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AboutQuestionsAssocs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripton = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutQuestionsId = table.Column<int>(type: "int", nullable: false),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutQuestionsAssocs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutQuestionsAssocs_AboutQuestions_AboutQuestionsId",
                        column: x => x.AboutQuestionsId,
                        principalTable: "AboutQuestions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AboutHowWeWorkAssocItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutHowWeWorkAssocId = table.Column<int>(type: "int", nullable: false),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutHowWeWorkAssocItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutHowWeWorkAssocItems_AboutHowWeWorkAssocs_AboutHowWeWorkAssocId",
                        column: x => x.AboutHowWeWorkAssocId,
                        principalTable: "AboutHowWeWorkAssocs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutHowWeWorkAssocItems_AboutHowWeWorkAssocId",
                table: "AboutHowWeWorkAssocItems",
                column: "AboutHowWeWorkAssocId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutHowWeWorkAssocs_AboutHowWeWorkId",
                table: "AboutHowWeWorkAssocs",
                column: "AboutHowWeWorkId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutQuestionsAssocs_AboutQuestionsId",
                table: "AboutQuestionsAssocs",
                column: "AboutQuestionsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutHowWeWorkAssocItems");

            migrationBuilder.DropTable(
                name: "AboutQuestionsAssocs");

            migrationBuilder.DropTable(
                name: "AboutHowWeWorkAssocs");

            migrationBuilder.DropTable(
                name: "AboutQuestions");

            migrationBuilder.DropTable(
                name: "AboutHowWeWorks");
        }
    }
}
