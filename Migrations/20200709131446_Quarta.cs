using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VolleyMVC.Migrations
{
    public partial class Quarta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competicao_Categoria_CategoriaId",
                table: "Competicao");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Competicao",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Set",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    PartidaId = table.Column<int>(nullable: false),
                    Num_Sets = table.Column<int>(nullable: false),
                    PontosMandante = table.Column<int>(nullable: false),
                    PontosVisitante = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Set", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Set_Partida_PartidaId",
                        column: x => x.PartidaId,
                        principalTable: "Partida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ponto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SetId = table.Column<int>(nullable: false),
                    PontoMandante = table.Column<int>(nullable: false),
                    PontoVisistante = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ponto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ponto_Set_SetId",
                        column: x => x.SetId,
                        principalTable: "Set",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Acao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    JogadorId = table.Column<int>(nullable: false),
                    PontoId = table.Column<int>(nullable: false),
                    Movimento = table.Column<string>(nullable: false),
                    Origem = table.Column<int>(nullable: false),
                    Destino = table.Column<int>(nullable: false),
                    Qualidade = table.Column<int>(nullable: false),
                    Tipo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Acao_Jogador_JogadorId",
                        column: x => x.JogadorId,
                        principalTable: "Jogador",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Acao_Ponto_PontoId",
                        column: x => x.PontoId,
                        principalTable: "Ponto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acao_JogadorId",
                table: "Acao",
                column: "JogadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Acao_PontoId",
                table: "Acao",
                column: "PontoId");

            migrationBuilder.CreateIndex(
                name: "IX_Ponto_SetId",
                table: "Ponto",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_Set_PartidaId",
                table: "Set",
                column: "PartidaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Competicao_Categoria_CategoriaId",
                table: "Competicao",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competicao_Categoria_CategoriaId",
                table: "Competicao");

            migrationBuilder.DropTable(
                name: "Acao");

            migrationBuilder.DropTable(
                name: "Ponto");

            migrationBuilder.DropTable(
                name: "Set");

            migrationBuilder.AlterColumn<int>(
                name: "CategoriaId",
                table: "Competicao",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Competicao_Categoria_CategoriaId",
                table: "Competicao",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
