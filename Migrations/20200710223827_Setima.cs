using Microsoft.EntityFrameworkCore.Migrations;

namespace VolleyMVC.Migrations
{
    public partial class Setima : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MandanteId",
                table: "Partida",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VisitanteId",
                table: "Partida",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Partida_MandanteId",
                table: "Partida",
                column: "MandanteId");

            migrationBuilder.CreateIndex(
                name: "IX_Partida_VisitanteId",
                table: "Partida",
                column: "VisitanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Partida_Time_MandanteId",
                table: "Partida",
                column: "MandanteId",
                principalTable: "Time",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Partida_Time_VisitanteId",
                table: "Partida",
                column: "VisitanteId",
                principalTable: "Time",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partida_Time_MandanteId",
                table: "Partida");

            migrationBuilder.DropForeignKey(
                name: "FK_Partida_Time_VisitanteId",
                table: "Partida");

            migrationBuilder.DropIndex(
                name: "IX_Partida_MandanteId",
                table: "Partida");

            migrationBuilder.DropIndex(
                name: "IX_Partida_VisitanteId",
                table: "Partida");

            migrationBuilder.DropColumn(
                name: "MandanteId",
                table: "Partida");

            migrationBuilder.DropColumn(
                name: "VisitanteId",
                table: "Partida");
        }
    }
}
