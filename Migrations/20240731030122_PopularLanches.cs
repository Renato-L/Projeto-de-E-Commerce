using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PaginaLanches.Migrations
{
    public partial class PopularLanches : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO " +
                "Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, IsLanchePreferido, Nome, Preco)" +
                                 "VALUES " +
                "(1, 'Pao, hamburger, ovo, presunto, queijo e batata palha', 'Delicioso pao de hamburguer com ovo frito, presunto e queijo e batata palha', 1, " +
                "0, 'Cheese Egg Salada', 12.50)");

            migrationBuilder.Sql("INSERT INTO " +
                "Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, IsLanchePreferido, Nome, Preco)" +
                                 "VALUES " +
                "(1, 'Pao, presunto, queijo e tomate', 'Delicioso pao frances presunto, queijo e tomate', 1, " +
                "0, 'Misto Quente', 8.00)");

            migrationBuilder.Sql("INSERT INTO " +
                "Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, IsLanchePreferido, Nome, Preco)" +
                                 "VALUES " +
                "(1, 'Pao, hamburger, presunto, queijo e batata palha', 'Delicioso pao de hamburguer presunto, queijo e batata palha', 1, " +
                "0, 'Cheese Salada', 11.00)");

            migrationBuilder.Sql("INSERT INTO " +
                "Lanches(CategoriaId, DescricaoCurta, DescricaoDetalhada, EmEstoque, IsLanchePreferido, Nome, Preco)" +
                                 "VALUES " +
                "(2, 'Pao integral, queijo branco, peito de peru e cenoura', 'Delicioso pao de forma integral com queijo branco, peito de peru e cenoura', 1, " +
                "1, 'Lanche Natural Peito de Peru', 15.00)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
