using Microsoft.EntityFrameworkCore.Migrations;

namespace backendcflopes.Migrations
{
    public partial class ajuste_contrato : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cep",
                table: "Contrato");

            migrationBuilder.DropColumn(
                name: "cidade",
                table: "Contrato");

            migrationBuilder.DropColumn(
                name: "telefone",
                table: "Contrato");

            migrationBuilder.DropColumn(
                name: "uf",
                table: "Contrato");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "cep",
                table: "Contrato",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "cidade",
                table: "Contrato",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "telefone",
                table: "Contrato",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "uf",
                table: "Contrato",
                type: "TEXT",
                nullable: true);
        }
    }
}
