using Microsoft.EntityFrameworkCore.Migrations;

namespace VolleyMVC.Migrations
{
    public partial class Quinta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partida_Time_CompeticaoId",
                table: "Partida");

            migrationBuilder.DropForeignKey(
                name: "FK_Partida_Competicao_CompeticaoId1",
                table: "Partida");

            migrationBuilder.DropIndex(
                name: "IX_Partida_CompeticaoId1",
                table: "Partida");

            migrationBuilder.DropColumn(
                name: "CompeticaoId1",
                table: "Partida");

            migrationBuilder.DropColumn(
                name: "Mandante",
                table: "Partida");

            migrationBuilder.DropColumn(
                name: "TimeId",
                table: "Partida");

            migrationBuilder.AddColumn<string>(
                name: "OpcaoLancamento",
                table: "Partida",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Mandante",
                table: "Acao",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateTable(
                name: "PartidaTime",
                columns: table => new
                {
                    PartidaId = table.Column<int>(nullable: false),
                    TimeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PartidaTime", x => new { x.PartidaId, x.TimeId });
                    table.ForeignKey(
                        name: "FK_PartidaTime_Partida_PartidaId",
                        column: x => x.PartidaId,
                        principalTable: "Partida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PartidaTime_Time_TimeId",
                        column: x => x.TimeId,
                        principalTable: "Time",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PartidaTime_TimeId",
                table: "PartidaTime",
                column: "TimeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Partida_Competicao_CompeticaoId",
                table: "Partida",
                column: "CompeticaoId",
                principalTable: "Competicao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Partida_Competicao_CompeticaoId",
                table: "Partida");

            migrationBuilder.DropTable(
                name: "PartidaTime");

            migrationBuilder.DropColumn(
                name: "OpcaoLancamento",
                table: "Partida");

            migrationBuilder.DropColumn(
                name: "Mandante",
                table: "Acao");

            migrationBuilder.AddColumn<int>(
                name: "CompeticaoId1",
                table: "Partida",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Mandante",
                table: "Partida",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "TimeId",
                table: "Partida",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Partida_CompeticaoId1",
                table: "Partida",
                column: "CompeticaoId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Partida_Time_CompeticaoId",
                table: "Partida",
                column: "CompeticaoId",
                principalTable: "Time",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Partida_Competicao_CompeticaoId1",
                table: "Partida",
                column: "CompeticaoId1",
                principalTable: "Competicao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
