using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmanId",
                table: "Personels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personels_DepartmanId",
                table: "Personels",
                column: "DepartmanId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personels_Departmen_DepartmanId",
                table: "Personels",
                column: "DepartmanId",
                principalTable: "Departmen",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personels_Departmen_DepartmanId",
                table: "Personels");

            migrationBuilder.DropIndex(
                name: "IX_Personels_DepartmanId",
                table: "Personels");

            migrationBuilder.DropColumn(
                name: "DepartmanId",
                table: "Personels");
        }
    }
}
