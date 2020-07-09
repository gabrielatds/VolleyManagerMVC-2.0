using Microsoft.EntityFrameworkCore.Migrations;

namespace VolleyMVC.Migrations
{
    public partial class Terceira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competicao_Categoria_CategoriaId",
                table: "Competicao");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddForeignKey(
                name: "FK_Competicao_Categoria_CategoriaId",
                table: "Competicao",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
