using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteMVC.Migrations
{
    /// <inheritdoc />
    public partial class AtualizandoNomeDatabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IamgemUrl",
                table: "Lanches",
                newName: "ImagemUrl");

            migrationBuilder.RenameColumn(
                name: "IamgemThumbnailUrl",
                table: "Lanches",
                newName: "ImagemThumbnailUrl");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagemUrl",
                table: "Lanches",
                newName: "IamgemUrl");

            migrationBuilder.RenameColumn(
                name: "ImagemThumbnailUrl",
                table: "Lanches",
                newName: "IamgemThumbnailUrl");
        }
    }
}
