using Microsoft.EntityFrameworkCore.Migrations;

namespace VolleyMVC.Migrations
{
    public partial class _11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jogador_Time_TimeId",
                table: "Jogador");

            migrationBuilder.DropIndex(
                name: "IX_Jogador_TimeId",
                table: "Jogador");

            migrationBuilder.DropColumn(
                name: "TimeId",
                table: "Jogador");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TimeId",
                table: "Jogador",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Jogador_TimeId",
                table: "Jogador",
                column: "TimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jogador_Time_TimeId",
                table: "Jogador",
                column: "TimeId",
                principalTable: "Time",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
