using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProudBlack.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaName, Descricao) " +
                "VALUES('Blusa Polo','Camisa sem punho nas mangas e gola Polo')");

            migrationBuilder.Sql("INSERT INTO Categorias(CategoriaName,Descricao) " +
                "VALUES('Bonés','Acessório para cabeças, como proteção contra o sol')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
