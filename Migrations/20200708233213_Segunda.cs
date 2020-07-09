using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VolleyMVC.Migrations
{
    public partial class Segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Competicao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    Ano_Temporada = table.Column<int>(nullable: false),
                    CategoriaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competicao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Competicao_Categoria_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Partida",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TimeId = table.Column<int>(nullable: false),
                    Mandante = table.Column<bool>(nullable: false),
                    CompeticaoId1 = table.Column<int>(nullable: true),
                    CompeticaoId = table.Column<int>(nullable: false),
                    Num_Sets = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partida", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partida_Time_CompeticaoId",
                        column: x => x.CompeticaoId,
                        principalTable: "Time",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Partida_Competicao_CompeticaoId1",
                        column: x => x.CompeticaoId1,
                        principalTable: "Competicao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Competicao_CategoriaId",
                table: "Competicao",
                column: "CategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_Partida_CompeticaoId",
                table: "Partida",
                column: "CompeticaoId");

            migrationBuilder.CreateIndex(
                name: "IX_Partida_CompeticaoId1",
                table: "Partida",
                column: "CompeticaoId1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partida");

            migrationBuilder.DropTable(
                name: "Competicao");
        }
    }
}
