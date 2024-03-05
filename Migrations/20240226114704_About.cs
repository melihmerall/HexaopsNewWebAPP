using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HexaopsNewWebAPP.Migrations
{
    /// <inheritdoc />
    public partial class About : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AboutQuestions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Questions = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descripton = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutService",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobil1Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobil1ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobil1SmallTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobil1Descripton = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requirement1Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requirement1ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requirement1SmallTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requirement1Descripton = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutService", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutService1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TextLGTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextLGTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutService1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutSlider",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TabBoxTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TabBoxDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TabBoxImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TabBoxSmallTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutSlider", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AboutQuestionsAssocs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Questions = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                name: "AboutServiceAssocs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobil1Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobil1ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobil1SmallTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobil1Descripton = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requirement1Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requirement1ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requirement1SmallTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Requirement1Descripton = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutServiceId = table.Column<int>(type: "int", nullable: false),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutServiceAssocs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutServiceAssocs_AboutService_AboutServiceId",
                        column: x => x.AboutServiceId,
                        principalTable: "AboutService",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AboutService1Assocs",
                columns: table => new
                {
                    AboutService1AssocId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TextLGTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TextLGTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutService1Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutService1Assocs", x => x.AboutService1AssocId);
                    table.ForeignKey(
                        name: "FK_AboutService1Assocs_AboutService1_AboutService1Id",
                        column: x => x.AboutService1Id,
                        principalTable: "AboutService1",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AboutSliderAssocs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TabBoxTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TabBoxDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TabBoxImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TabBoxSmallTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutSliderId = table.Column<int>(type: "int", nullable: false),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutSliderAssocs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AboutSliderAssocs_AboutSlider_AboutSliderId",
                        column: x => x.AboutSliderId,
                        principalTable: "AboutSlider",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AboutQuestionsAssocs_AboutQuestionsId",
                table: "AboutQuestionsAssocs",
                column: "AboutQuestionsId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutService1Assocs_AboutService1Id",
                table: "AboutService1Assocs",
                column: "AboutService1Id");

            migrationBuilder.CreateIndex(
                name: "IX_AboutServiceAssocs_AboutServiceId",
                table: "AboutServiceAssocs",
                column: "AboutServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_AboutSliderAssocs_AboutSliderId",
                table: "AboutSliderAssocs",
                column: "AboutSliderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutQuestionsAssocs");

            migrationBuilder.DropTable(
                name: "AboutService1Assocs");

            migrationBuilder.DropTable(
                name: "AboutServiceAssocs");

            migrationBuilder.DropTable(
                name: "AboutSliderAssocs");

            migrationBuilder.DropTable(
                name: "AboutQuestions");

            migrationBuilder.DropTable(
                name: "AboutService1");

            migrationBuilder.DropTable(
                name: "AboutService");

            migrationBuilder.DropTable(
                name: "AboutSlider");
        }
    }
}
