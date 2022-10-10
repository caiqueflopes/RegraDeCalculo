using Microsoft.EntityFrameworkCore.Migrations;

namespace backendcflopes.Migrations
{
    public partial class ajuste_contrato_err : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Parcela",
                table: "Parcela");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contrato",
                table: "Contrato");

            migrationBuilder.RenameTable(
                name: "Parcela",
                newName: "Parcelas");

            migrationBuilder.RenameTable(
                name: "Contrato",
                newName: "Contratos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parcelas",
                table: "Parcelas",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contratos",
                table: "Contratos",
                column: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Parcelas",
                table: "Parcelas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Contratos",
                table: "Contratos");

            migrationBuilder.RenameTable(
                name: "Parcelas",
                newName: "Parcela");

            migrationBuilder.RenameTable(
                name: "Contratos",
                newName: "Contrato");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parcela",
                table: "Parcela",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Contrato",
                table: "Contrato",
                column: "id");
        }
    }
}
