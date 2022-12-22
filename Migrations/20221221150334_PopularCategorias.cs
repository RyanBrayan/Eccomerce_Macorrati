using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteMVC.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descrição) " +
            "VALUES('Normal', 'Lanche feito com ingreditentes normais')");
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaNome, Descrição) " +
            "VALUES('Natural', 'Lanche feito com ingreditentes integrais e naturais') ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
