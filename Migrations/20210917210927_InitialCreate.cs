using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    idProduto = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoProduto = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    nomeProduto = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    valorProduto = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.idProduto);
                });

            migrationBuilder.CreateTable(
                name: "Vendas",
                columns: table => new
                {
                    idVenda = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    produtosidProduto = table.Column<int>(type: "int", nullable: true),
                    produtoSelecionado = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendas", x => x.idVenda);
                    table.ForeignKey(
                        name: "FK_Vendas_Produtos_produtosidProduto",
                        column: x => x.produtosidProduto,
                        principalTable: "Produtos",
                        principalColumn: "idProduto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Funcionario",
                columns: table => new
                {
                    IdFuncionario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeFuncionario = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    vendasidVenda = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Funcionario", x => x.IdFuncionario);
                    table.ForeignKey(
                        name: "FK_Funcionario_Vendas_vendasidVenda",
                        column: x => x.vendasidVenda,
                        principalTable: "Vendas",
                        principalColumn: "idVenda",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Funcionario_vendasidVenda",
                table: "Funcionario",
                column: "vendasidVenda");

            migrationBuilder.CreateIndex(
                name: "IX_Vendas_produtosidProduto",
                table: "Vendas",
                column: "produtosidProduto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Funcionario");

            migrationBuilder.DropTable(
                name: "Vendas");

            migrationBuilder.DropTable(
                name: "Produtos");
        }
    }
}
