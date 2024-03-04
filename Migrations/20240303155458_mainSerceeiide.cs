using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HexaopsNewWebAPP.Migrations
{
    /// <inheritdoc />
    public partial class mainSerceeiide : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainServiceAssocs_MainServices_MainServiceId",
                table: "MainServiceAssocs");

            migrationBuilder.RenameColumn(
                name: "MainServiceId",
                table: "MainServiceAssocs",
                newName: "MainServiceid");

            migrationBuilder.RenameIndex(
                name: "IX_MainServiceAssocs_MainServiceId",
                table: "MainServiceAssocs",
                newName: "IX_MainServiceAssocs_MainServiceid");

            migrationBuilder.AddForeignKey(
                name: "FK_MainServiceAssocs_MainServices_MainServiceid",
                table: "MainServiceAssocs",
                column: "MainServiceid",
                principalTable: "MainServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MainServiceAssocs_MainServices_MainServiceid",
                table: "MainServiceAssocs");

            migrationBuilder.RenameColumn(
                name: "MainServiceid",
                table: "MainServiceAssocs",
                newName: "MainServiceId");

            migrationBuilder.RenameIndex(
                name: "IX_MainServiceAssocs_MainServiceid",
                table: "MainServiceAssocs",
                newName: "IX_MainServiceAssocs_MainServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_MainServiceAssocs_MainServices_MainServiceId",
                table: "MainServiceAssocs",
                column: "MainServiceId",
                principalTable: "MainServices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
