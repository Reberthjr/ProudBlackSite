using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProudBlack.Migrations
{
    /// <inheritdoc />
    public partial class PopularProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Produto(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,EmPromocao,Nome,Preco) VALUES(2,'Camisa Polo Lacoste','Camisa polo lacoste listrada; Tecido resistente e lindo',1, '/img/produtos/camisapolo.jpg','/img/produtos/camisapolo.jpg', 0 ,'Camisa Polo Listrada', 120.99)");
            migrationBuilder.Sql("INSERT INTO Produto(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,EmPromocao,Nome,Preco) VALUES(2,'Camisa Polo Lacoste','Camisa polo lacoste listrada; Tecido resistente e lindo',1, '/img/produtos/camisapolocolorida.jpg','/img/produtos/camisapolocolorida.jpg', 1 ,'Camisa Polo', 100.99)");
            migrationBuilder.Sql("INSERT INTO Produto(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,EmPromocao,Nome,Preco) VALUES(2,'Camisa Polo Lacoste','Camisa polo lacoste listrada; Tecido resistente e lindo',1, '/img/produtos/camisapoloazul.jpg','/img/produtos/camisapoloazul.jpg', 0 ,'Camisa Polo colorida', 140.99)");
            migrationBuilder.Sql("INSERT INTO Produto(CategoriaId,DescricaoCurta,DescricaoDetalhada,EmEstoque,ImagemThumbnailUrl,ImagemUrl,EmPromocao,Nome,Preco) VALUES(3,'Boné Nike','Boné Nike Bicolor; Material importado',1, '/img/produtos/boneNike.jpg','/img/produtos/boneNike.jpg', 1 ,'Boné Nike', 40.99)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Produto");
        }
    }
}
