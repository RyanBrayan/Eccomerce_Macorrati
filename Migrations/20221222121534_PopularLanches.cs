using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteMVC.Migrations
{
    /// <inheritdoc />
    public partial class PopularLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome, DescriçãoCurta, DescriçãoDetalhada, Preco, IamgemUrl,  IamgemThumbnailUrl,  IsLanchePreferido, EmEstoque, CategoriaId) VALUES ('Cheese Salada', 'Delicoso pão de hambúrger', 'Pão, hambúrger, ovo, presunto, queijo e batata palha', 12.50, 'https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 'https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg',  0, 3, 1)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome, DescriçãoCurta, DescriçãoDetalhada, Preco, IamgemUrl,  IamgemThumbnailUrl,  IsLanchePreferido, EmEstoque, CategoriaId) VALUES('Cheese Salada',  'Delicoso pão de hambúrger', 'Pão, hambúrger, ovo, presunto, queijo e batata palha', 12.50, 'https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 'https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg',  0, 1, 1)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome, DescriçãoCurta, DescriçãoDetalhada, Preco, IamgemUrl,  IamgemThumbnailUrl,  IsLanchePreferido, EmEstoque, CategoriaId) VALUES('Cheese Salada',  'Delicoso pão de hambúrger', 'Pão, hambúrger, ovo, salada, queijo e batata palha', 12.50,   'https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg',  'https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 0, 2, 2)");
            migrationBuilder.Sql("INSERT INTO Lanches(LancheNome, DescriçãoCurta, DescriçãoDetalhada, Preco, IamgemUrl,  IamgemThumbnailUrl,  IsLanchePreferido, EmEstoque, CategoriaId) VALUES ('Cheese Salada', 'Delicoso pão de hambúrger', 'Pão, hambúrger, ovo, presunto, queijo e batata palha', 12.50, 'https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg', 'https://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg',  0, 1, 1)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FROM Lanches");
        }
    }
}
