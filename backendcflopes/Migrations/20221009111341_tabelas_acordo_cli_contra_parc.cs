using Microsoft.EntityFrameworkCore.Migrations;

namespace backendcflopes.Migrations
{
    public partial class tabelas_acordo_cli_contra_parc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Calculos",
                table: "Calculos");

            migrationBuilder.RenameTable(
                name: "Calculos",
                newName: "Calculo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calculo",
                table: "Calculo",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Calculo",
                table: "Calculo");

            migrationBuilder.RenameTable(
                name: "Calculo",
                newName: "Calculos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calculos",
                table: "Calculos",
                column: "id");
        }
    }
}
