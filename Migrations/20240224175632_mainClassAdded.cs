using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HexaopsNewWebAPP.Migrations
{
    /// <inheritdoc />
    public partial class mainClassAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MainCarousels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Carousel1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Carousel2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCarousels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainFAQ",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainFAQ", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainFooters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ButtonUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Logo2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slogan1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slogan2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slogan3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slogan4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slogan5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyDescripiton1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyDescription3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyDescription4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyDescription5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HelpTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HelpSmallTitle1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HelpDescription1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HelpUrl1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HelpSmallTitle2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HelpDescription2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HelpUrl2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FooterCompanyLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TelifYazısı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnimationsLogo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainFooters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainPartners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Slogan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainPartners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainSliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainSliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SocialUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MainFAQAssocs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QuestionDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainFAQId = table.Column<int>(type: "int", nullable: false),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainFAQAssocs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainFAQAssocs_MainFAQ_MainFAQId",
                        column: x => x.MainFAQId,
                        principalTable: "MainFAQ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MainPartnerAssocs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartnerImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MainPartnerId = table.Column<int>(type: "int", nullable: false),
                    CreatedDated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainPartnerAssocs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MainPartnerAssocs_MainPartners_MainPartnerId",
                        column: x => x.MainPartnerId,
                        principalTable: "MainPartners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MainFAQAssocs_MainFAQId",
                table: "MainFAQAssocs",
                column: "MainFAQId");

            migrationBuilder.CreateIndex(
                name: "IX_MainPartnerAssocs_MainPartnerId",
                table: "MainPartnerAssocs",
                column: "MainPartnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MainCarousels");

            migrationBuilder.DropTable(
                name: "MainFAQAssocs");

            migrationBuilder.DropTable(
                name: "MainFooters");

            migrationBuilder.DropTable(
                name: "MainPartnerAssocs");

            migrationBuilder.DropTable(
                name: "MainSliders");

            migrationBuilder.DropTable(
                name: "SocialAccounts");

            migrationBuilder.DropTable(
                name: "MainFAQ");

            migrationBuilder.DropTable(
                name: "MainPartners");
        }
    }
}
